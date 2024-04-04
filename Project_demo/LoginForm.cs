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
using Project_demo.Customer_User_Control;

namespace Project_demo
{
    public partial class LoginForm : Form
    {
        //string role;
        static string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
        SqlConnection con = new SqlConnection(constring);
        
        public LoginForm()
        {
            InitializeComponent();
            errorMessage.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton(object sender, EventArgs e) 
        {
            string email, password;
            email = this.email.Text;
            password = this.password.Text;

            try
            {
                con.Open();
                
                string query = "select * from users where email = '"+email+"' and password = '"+password+"'";
                SqlDataAdapter db = new SqlDataAdapter(query,con);
                DataTable dt = new DataTable();
                db.Fill(dt);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader result = cmd.ExecuteReader();
                
                if (dt.Rows.Count == 1 )
                {
                    while (result.Read())
                    {
                    //    //MessageBox.Show(result["email"].ToString());
                    int id = (int)result["id"];
                    string name = result["name"].ToString();
                    Price.setUserId(id);
                    
                  
                        if (this.checkRole("Customer"))
                        {
                            this.Hide();
                            Customer_Portal booking = new Customer_Portal();
                            booking.Show();

                        }
                    
                        
                        else if (this.checkRole("Super Admin") )
                        {
                            this.Hide();
                            SuperAdmin booking = new SuperAdmin();
                            booking.Show();
                        }
                        else {
                            
                                this.Hide();
                                Admin booking = new Admin();
                                booking.Show();
                            
                        }
                        errorMessage.Visible = false;
                        break;
                    }
                    con.Close();
                }
                
                else
                {
                    //MessageBox.Show("Invalid!");
                    errorMessage.Visible = true;

                }
                
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }


        private void RegistrationButton(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        private void forgetButton_Click(object sender, EventArgs e)
        {
            try {                
                sendCode s1 = new sendCode();
                this.Hide();
                s1.Show();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login.PerformClick();
            }
        }

        private void email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        public bool checkRole(string role)
        {
            
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                string query = "SELECT role FROM users where role = '" +role+"' and email = '"+email.Text+"'";
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    return true;
                    con.Close();
                }
                return false;
                

            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public bool checkEmail(string email)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                string query = "SELECT * FROM users where email = '" + email + "'";
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                return false;
            }


        }

        private void errorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
