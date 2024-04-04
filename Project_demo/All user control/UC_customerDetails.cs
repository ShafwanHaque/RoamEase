using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_demo.All_user_control
{
    public partial class UC_customerDetails : UserControl
    {
        function fn = new function();
        string query, roleCustomer = "Customer";
        
        public UC_customerDetails()
        {
            InitializeComponent();
        }

       
        private void UC_customerDetails_Load(object sender, EventArgs e)
        {
            query = "SELECT name as Name,email as Email,mobile_number as 'Mobile Number',postal_code as 'Postal Code',country as Country,state as State,city as City,gender as Gender,role as Role from users where role = '" + roleCustomer + "' ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
            query = " SELECT name as Name,email as Email,mobile_number as 'Mobile Number',postal_code as 'Postal Code',country as Country,state as State,city as City,gender as Gender,role as Role FROM  users WHERE name like '" + searchBox.Text + "%' and role = '" + roleCustomer + "' ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            

        }

        //private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string value = searchBox.Text;
        //    foreach (GridViewRow row in dataGridView1.Rows)
        //    {
        //        for (int i = 0; i < dataGridView1.Columns.Count; i++)
        //        {
        //            string cellText = row.Cells[i].Text;
        //            if (cellText == value)
        //            {
        //                // Highlights the entire row
        //                row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
        //                break;
        //            }
        //        }
        //    }
        //}
    }
}
