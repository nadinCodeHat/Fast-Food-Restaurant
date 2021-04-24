using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        
        private void foodTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.foodTable.Rows[e.RowIndex];
                foodIdTextBox.Text = row.Cells["FoodID"].Value.ToString();
                foodNameTextBox.Text = row.Cells["FoodName"].Value.ToString();
                priceTextBox.Text = row.Cells["Price"].Value.ToString();
                descriptionTextBox.Text = row.Cells["Description"].Value.ToString();

                DataRow[] dr = food_dt.Select(string.Format("FoodID ='{0}' ", row.Cells["FoodID"].Value.ToString()));
                foreach (DataRow d1row in dr)
                {
                    int msize = d1row.Field<int>("MSize");
                    int cuisine = d1row.Field<int>("Cuisine");
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            string query = "SELECT MealSize.SizeName, Cuisine.CuisineName FROM MealSize,Cuisine,Food WHERE MealSize.SizeID = Food.MSize AND Cuisine.CuisineID = Food.Cuisine AND Food.MSize ='" + msize + "' AND Food.Cuisine = '" + cuisine + "'";
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
                    string insertquery = "INSERT INTO Food(Food.FoodID,Food.FoodName,Food.Price,Food.MSize,Food.Description,Food.Cuisine) VALUES(@foodid,@foodname,@price,(SELECT S.SizeID FROM MealSize S WHERE S.SizeName = @msize),@description,(SELECT C.CuisineID FROM Cuisine C WHERE C.CuisineName = @cuisine))";
                    using (SqlCommand cmd = new SqlCommand(insertquery, con))
                    {
                        count++;
                        cmd.Parameters.AddWithValue("@foodid", "F00"+count);
                        cmd.Parameters.AddWithValue("@foodname", foodNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                        cmd.Parameters.AddWithValue("@msize", sizecomboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                        cmd.Parameters.AddWithValue("@cuisine", cuisinecomboBox.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                    string message = "Data insert successful!";
                    string title = "Insert Successful";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        
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
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string insertquery = "UPDATE Food set Food.FoodName = @foodname,Food.Price,Food.MSize,Food.Description,Food.Cuisine) VALUES(@foodid,@foodname,@price,(SELECT S.SizeID FROM MealSize S WHERE S.SizeName = @msize),@description,(SELECT C.CuisineID FROM Cuisine C WHERE C.CuisineName = @cuisine))";
                    using (SqlCommand cmd = new SqlCommand(insertquery, con))
                    {
                        cmd.Parameters.AddWithValue("@foodname", foodNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                        cmd.Parameters.AddWithValue("@msize", sizecomboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                        cmd.Parameters.AddWithValue("@cuisine", cuisinecomboBox.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                    string message = "Data update successful!";
                    string title = "Update Successful";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {

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
    }
}
