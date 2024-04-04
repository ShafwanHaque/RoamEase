    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_demo.Customer_User_Control
{
    public partial class UC_searchingDestination : UserControl
    {
        public UC_searchingDestination()
        {
            InitializeComponent();
        }

        private void UC_searchingDestination_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Customer_Portal cp = new Customer_Portal();
            cp.Show();
        }
    }
}
