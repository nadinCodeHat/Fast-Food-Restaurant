using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Restaurant
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodDBDataSet.Food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.foodDBDataSet.Food);

        }
    }
}
