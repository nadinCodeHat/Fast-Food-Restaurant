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
        }

        DataTable food_dt = new DataTable();
        private void bindFoodData()
        {
            foodTable.Columns.Clear();
            foodTable.DataSource = null;
            foodTable.Rows.Clear();
            foodTable.Refresh();
            // view_timetable_table.CellClick += view_timetable_table_CellClick;
            string query = "select * from Food";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
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

        private void foodTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.foodTable.Rows[e.RowIndex];
                foodIdTextBox.Text = row.Cells["FoodID"].Value.ToString();
                foodNameTextBox.Text = row.Cells["FoodName"].Value.ToString();
                priceTextBox.Text = row.Cells["Price"].Value.ToString();
                descriptionTextBox.Text = row.Cells["Description"].Value.ToString();
                

            }
            
        }
    }
}
