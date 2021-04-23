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
            foodTable.Columns.Clear();
            foodTable.DataSource = null;
            foodTable.Rows.Clear();
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

                            foodTable.Columns[1].HeaderText = "foodname";
                            foodTable.Columns[1].Name = "FoodName";
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
                    con.Close();
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
                    con.Close();
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

                DataRow[] dr = food_dt.Select(row.Cells["FoodID"].Value.ToString());
                foreach (DataRow d1row in dr)
                {
                    int msize = d1row.Field<int>("MSize");
                    int cuisine = d1row.Field<int>("Cuisine");
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            string query = "SELECT MealSize.SizeName, Cuisine.CuisineName FROM MealSize,Cuisine WHERE MealSize.SizeID = Food.MSize AND Cuisine.CuisineID = Food.Cuisine AND Food.MSize ='" + msize + "' AND Food.Cuisine = '" + cuisine + "'";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    DataTable dt = new DataTable();
                                    sda.Fill(dt);
                                    foreach (DataRow d2row in dt.Rows)
                                    {
                                       sizecomboBox.SelectedItem = d2row["SizeName"].ToString();
                                       cuisinecomboBox.SelectedItem =  d2row["Cuisine"].ToString();
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
    }
}
