using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_demo.All_user_control
{
    public partial class UC_userDetails : UserControl
    {
        function fn = new function();
        string query, roleCustomer = "Customer" , roleAdmin = "Admin";
        public UC_userDetails()
        {
            InitializeComponent();
        }

        private void UC_userDetails_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM users WHERE email = '"+userEmail.Text+"' ";
            fn.setData(query, "Record deleted");
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            query = " SELECT name as Name,email as Email,mobile_number as 'Mobile Number',postal_code as 'Postal Code',country as Country,state as State,city as City,gender as Gender,role as Role FROM  users WHERE name like '" + searchBox.Text + "%' ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchBy.SelectedIndex == 0){
                query = "SELECT name as Name,email as Email,mobile_number as 'Mobile Number',postal_code as 'Postal Code',country as Country,state as State,city as City,gender as Gender,role as Role from users where role = '" + roleCustomer+"' or role = '"+roleAdmin+"'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (searchBy.SelectedIndex == 1){
                query = "SELECT name as Name,email as Email,mobile_number as 'Mobile Number',postal_code as 'Postal Code',country as Country,state as State,city as City,gender as Gender,role as Role from users where role = '" + roleCustomer + "' ";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else{
                query = "SELECT name as Name,email as Email,mobile_number as 'Mobile Number',postal_code as 'Postal Code',country as Country,state as State,city as City,gender as Gender,role as Role from users where role = '" + roleAdmin + "' ";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}