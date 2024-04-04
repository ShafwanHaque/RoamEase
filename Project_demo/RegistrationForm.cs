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

namespace Project_demo
{
    public partial class RegistrationForm : Form
    {
        function fn = new function();
        
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        public bool checkMobile()
        {
            if (int.TryParse(this.mobileNumber.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkPostalCode() 
        {
            if (int.TryParse(this.postalCode.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Registration(object sender, EventArgs e)
        {
            string name, email, password, country, state, city, gender;
            string mobileNumber = null, postalCode = null;
            name = this.name.Text;
            email = this.email.Text;
            password = this.password.Text;
            string role = "Customer"; 
            
            /* if (Int32.TryParse(this.mobileNumber.Text, out mobileNumber)){            
                 this.mobileNumber.Text = mobileNumber.ToString();
             }
             if (Int32.TryParse(this.postalCode.Text, out postalCode)) {
                  this.postalCode.Text = postalCode.ToString();
             }*/

            country = this.country.Text;
            state = this.state.Text;
            city = this.city.Text;
            gender = this.gender.Text;

            if (this.mobileNumber.Text.Length != 0)
            {
                if (this.checkMobile())
                {
                    mobileNumber = this.mobileNumber.Text;
                }
                else
                {
                    MessageBox.Show("Mobile number only contains digit and digit must be 11!");
                    return;
                }
            }
            else
            {
                
            }
            if (this.postalCode.Text.Length != 0)
            {
                if (this.checkPostalCode())
                {
                    postalCode = this.postalCode.Text;
                }
                else
                {
                    MessageBox.Show("Postal Code number only contains digit!");
                    return;
                }
            }
            else
            {
                
            }


            try
            {
                string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlConnection con = new SqlConnection(constring);
               
                //string checkEmail = "select* from users where email != '" + email + "'";
               // SqlCommand cmdd = new SqlCommand(checkEmail, con);
                //SqlDataReader result = cmdd.ExecuteReader();
                


                if (this.name.Text.Length != 0 && this.email.Text.Length != 0 && this.password.Text.Length != 0  && !this.checkEmail(this.email.Text))
                {
                    
                   
                    con.Open();
                    string query = "insert into users (name, email, password, mobile_number, postal_code, country, state, city, gender,role) values('" + name + "','" + email + "','" + password + "','" + mobileNumber + "','" + postalCode + "','" + country + "','" + state + "','" + city + "','" + gender + "','"+role+"')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration completed!");
                    clearAll();                        
                }
                    
                    
                
                else
                {
                    MessageBox.Show("Your input is invalide. Please try again later!!");
                    return;
                }
                con.Close();

            }
            
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }  

        private void Login(object sender, EventArgs e)
        {
            
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

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
            catch(Exception ex) {
                return false;
            }
            
        
        }
        public void clearAll() 
        {
            name.Clear();
            email.Clear();
            password.Clear();
            mobileNumber.Clear();
            country.Clear();
            state.Clear();
            city.Clear();
            postalCode.Clear();
            gender.SelectedIndex = -1;
              
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
