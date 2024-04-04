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
    public partial class UC_adminRegistration : UserControl
    {
        function fn = new function();
        string query;
        int i;
        public UC_adminRegistration()
        {
            InitializeComponent();
        }
        public void setComboBox(string query, ComboBox combo) 
        {
            SqlDataReader sdr = fn.getForCombo(query);

            while (sdr.Read()) {
                for (i = 0; i < sdr.FieldCount; i++) {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //query = "SELECT gemder FROM users where name = '" + name.Text + "'";
            //setComboBox(query, gender);
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
        private void registration_Click(object sender, EventArgs e)
        {
            string name, email, password, country, state, city, gender;
            string mobileNumber = null, postalCode = null;
            name = this.name.Text;
            email = this.email.Text;
            password = this.password.Text;
            string role = "Admin";

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
                    MessageBox.Show("Mobile number only contains digit!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Your have to fill all the fields. Please try again later!!");
                return;

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
                MessageBox.Show("Your have to fill all the fields. Please try again later!!");
                return;
            }

            try
            {
                string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlConnection con = new SqlConnection(constring);

                //string checkEmail = "select* from users where email != '" + email + "'";
                // SqlCommand cmdd = new SqlCommand(checkEmail, con);
                //SqlDataReader result = cmdd.ExecuteReader();



                if (this.name.Text.Length != 0 && this.email.Text.Length != 0 && this.password.Text.Length != 0 && this.mobileNumber.Text.Length!=0 && this.country.Text.Length !=0 && this.state.Text.Length != 0 && this.city.Text.Length !=0 && this.postalCode.Text.Length !=0 && this.gender.Text.Length !=0 && this.dateOfBirth.Text.Length != 0)
                {


                    con.Open();
                    string query = "insert into users (name, email, password, mobile_number, postal_code, country, state, city, gender,role) values('" + name + "','" + email + "','" + password + "','" + mobileNumber + "','" + postalCode + "','" + country + "','" + state + "','" + city + "','" + gender + "','" + role + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration completed!");

                }



                else
                {
                    MessageBox.Show("Your have to fill all the fields. Please try again later!!");
                    return;
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void UC_adminRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
