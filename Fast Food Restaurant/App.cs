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
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                   // string query = "SELECT "
                    //SqlCommand command = new SqlCommand()
                }
            }
            
        }
    }
}
