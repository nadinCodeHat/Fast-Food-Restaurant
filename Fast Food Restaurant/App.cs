using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Restaurant
{
    public partial class App : Form
    {
        //Connection String 
        string connectionString = ConfigurationManager.ConnectionStrings["Fast_Food_Restaurant.Properties.Settings.FoodDBConnectionString"].ConnectionString;

        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            bindFoodData();
            bindSizeCombo();
            bindCuisineCombo();
        }

        DataTable food_dt = new DataTable();
        private void bindFoodData()
        {
            food_dt.Clear();
            foodTable.DataSource = null;
            foodTable.Update();
            foodTable.Refresh();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Food";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(food_dt);

                            foodTable.AutoGenerateColumns = false;
                            foodTable.ColumnCount = 4;

                            //Add Columns
                            foodTable.Columns[0].Name = "foodid";
                            foodTable.Columns[0].HeaderText = "FoodID";
                            foodTable.Columns[0].DataPropertyName = "FoodID";

                            foodTable.Columns[1].Name = "foodname";
                            foodTable.Columns[1].HeaderText = "FoodName";
                            foodTable.Columns[1].DataPropertyName = "FoodName";

                            foodTable.Columns[2].Name = "price";
                            foodTable.Columns[2].HeaderText = "Price";
                            foodTable.Columns[2].DataPropertyName = "Price";

                            foodTable.Columns[3].Name = "description";
                            foodTable.Columns[3].HeaderText = "Description";
                            foodTable.Columns[3].DataPropertyName = "Description";

                            foodTable.DataSource = food_dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }     
            }
            foodTable.ClearSelection();
        }

        private void bindSizeCombo()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT SizeName FROM MealSize";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                sizecomboBox.Items.Add(dr[0]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bindCuisineCombo()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT CuisineName FROM Cuisine";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cuisinecomboBox.Items.Add(dr[0]);
                                filterByCuisine.Items.Add(dr[0]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        
        string foodID;
        private void foodTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.foodTable.Rows[e.RowIndex];
                foodIdTextBox.Text = row.Cells["FoodID"].Value.ToString();
                foodNameTextBox.Text = row.Cells["FoodName"].Value.ToString();
                priceTextBox.Text = row.Cells["Price"].Value.ToString();
                descriptionTextBox.Text = row.Cells["Description"].Value.ToString();

                foodID = row.Cells["FoodID"].Value.ToString();
                DataRow[] dr = food_dt.Select(string.Format("FoodID ='{0}' ", foodID));
                foreach (DataRow d1row in dr)
                {
                    int msize = d1row.Field<int>("MSize");
                    int cuisine = d1row.Field<int>("Cuisine");

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            string query = "SELECT MealSize.SizeName, Cuisine.CuisineName, Food.Image FROM MealSize,Cuisine,Food WHERE MealSize.SizeID = Food.MSize AND Cuisine.CuisineID = Food.Cuisine AND Food.MSize ='" + msize + "' AND Food.Cuisine = '" + cuisine + "' AND Food.FoodID = '"+foodID+"'";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    DataTable dt = new DataTable();
                                    sda.Fill(dt);
                                    foreach (DataRow d2row in dt.Rows)
                                    {
                                        sizecomboBox.SelectedItem = d2row["SizeName"].ToString();
                                        cuisinecomboBox.SelectedItem = d2row["CuisineName"].ToString();
                                        
                                        Byte[] data = new Byte[0];
                                        data = (Byte[])(d2row["Image"]);
                                        MemoryStream mem = new MemoryStream(data);
                                        foodpictureBox.Image = Image.FromStream(mem);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

                }
            }      
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string countquery = "SELECT COUNT(*) FROM Food";
                    Int32 count;
                    using (SqlCommand cmd = new SqlCommand(countquery, con))
                    {
                        count = (Int32)cmd.ExecuteScalar();
                    }
                    string insertquery = "INSERT INTO Food(Food.FoodID,Food.FoodName,Food.Price,Food.MSize,Food.Description,Food.Cuisine,Food.Image) VALUES(@foodid,@foodname,@price,(SELECT S.SizeID FROM MealSize S WHERE S.SizeName = @msize),@description,(SELECT C.CuisineID FROM Cuisine C WHERE C.CuisineName = @cuisine),@image)";
                    using (SqlCommand cmd = new SqlCommand(insertquery, con))
                    {
                        count++;
                        cmd.Parameters.AddWithValue("@foodid", "F00"+count);
                        cmd.Parameters.AddWithValue("@foodname", foodNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                        cmd.Parameters.AddWithValue("@msize", sizecomboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                        cmd.Parameters.AddWithValue("@cuisine", cuisinecomboBox.SelectedItem.ToString());

                        Image img = foodpictureBox.Image;
                        ImageConverter converter = new ImageConverter();
                        byte[] arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                        cmd.Parameters.AddWithValue("@image", arr);
                        
                        cmd.ExecuteNonQuery();
                    }
                    string message = "Data insert successful!";
                    string title = "Insert Successful";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    bindFoodData();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (foodTable.SelectedRows.Count > 0)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        string updatequery = "UPDATE Food SET FoodName = @foodname, Price = @price, MSize = (SELECT SizeID FROM MealSize WHERE SizeName = @msize), Description = @description, Cuisine = (SELECT CuisineID FROM Cuisine WHERE CuisineName = @cuisine), Image = @image WHERE FoodID = '" + foodID + "'";
                        using (SqlCommand cmd = new SqlCommand(updatequery, con))
                        {
                            cmd.Parameters.AddWithValue("@foodname", foodNameTextBox.Text);
                            cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                            cmd.Parameters.AddWithValue("@msize", sizecomboBox.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                            cmd.Parameters.AddWithValue("@cuisine", cuisinecomboBox.SelectedItem.ToString());
                            
                            Image img = foodpictureBox.Image;
                            ImageConverter converter = new ImageConverter();
                            byte[] arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                            cmd.Parameters.AddWithValue("@image", arr);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        string message = "Record update successful!";
                        string title = "Update Successful";
                        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        bindFoodData();
                    }
                }
            }
            else
            {
                string message = "Please select record to update";
                string title = "Warning";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (foodTable.SelectedRows.Count > 0)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string deletequery = "DELETE Food WHERE FoodID = @foodid";
                        using (SqlCommand cmd = new SqlCommand(deletequery, con))
                        {
                            cmd.Parameters.AddWithValue("@foodid", foodID);
                            cmd.ExecuteNonQuery();
                        }
                        string message = "Record delete successful!";
                        string title = "Delete Successful";
                        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        bindFoodData();
                        foodIdTextBox.Text = null;
                        foodNameTextBox.Text = null;
                        priceTextBox.Text = null;
                        sizecomboBox.SelectedItem = null;
                        descriptionTextBox.Text = null;
                        cuisinecomboBox.SelectedItem = null;
                        foodpictureBox.Image = null;
                    }
                }
            }
            else
            {
                string message = "Please select record to delete";
                string title = "Warning";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (byId.Checked)
            {
                if (searchTextBox.Text == "")
                {
                    foodTable.DataSource = food_dt;
                }
                else
                {
                    DataView filterData = new DataView(food_dt);
                    filterData.RowFilter = "FoodID LIKE '%" + searchTextBox.Text + "%'";
                    foodTable.DataSource = filterData;
                }
            }
            else if(byName.Checked)
            {
                if (searchTextBox.Text == "")
                {
                    foodTable.DataSource = food_dt;
                }
                else
                {
                    DataView filterData = new DataView(food_dt);
                    filterData.RowFilter = "FoodName LIKE '%" + searchTextBox.Text + "%'";
                    foodTable.DataSource = filterData;
                }
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Browse Food Image";
            fdlg.InitialDirectory = "c:\\";
            fdlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                foodpictureBox.Image = new Bitmap(fdlg.FileName);
            }
        }

        DataTable food_items_dt = new DataTable();
        private void summaryBtn_Click(object sender, EventArgs e)
        {
            food_items_dt.Clear();
            foodItemsTable.DataSource = null;
            foodItemsTable.Update();
            foodItemsTable.Refresh();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT Food.FoodID, Food.FoodName, Cuisine.CuisineName FROM Food, Cuisine WHERE Cuisine.CuisineID = Food.Cuisine";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(food_items_dt);

                            foodItemsTable.AutoGenerateColumns = false;
                            foodItemsTable.ColumnCount = 3;

                            //Add Columns
                            foodItemsTable.Columns[0].Name = "foodid";
                            foodItemsTable.Columns[0].HeaderText = "FoodID";
                            foodItemsTable.Columns[0].DataPropertyName = "FoodID";

                            foodItemsTable.Columns[1].Name = "foodname";
                            foodItemsTable.Columns[1].HeaderText = "FoodName";
                            foodItemsTable.Columns[1].DataPropertyName = "FoodName";

                            foodItemsTable.Columns[2].Name = "cuisinename";
                            foodItemsTable.Columns[2].HeaderText = "CuisineName";
                            foodItemsTable.Columns[2].DataPropertyName = "CuisineName";

                            foodItemsTable.DataSource = food_items_dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            foodItemsTable.ClearSelection();
            itemCount.Text = foodItemsTable.Rows.Count.ToString();
        }

        private void filterByCuisine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
