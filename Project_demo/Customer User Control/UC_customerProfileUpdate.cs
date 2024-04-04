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

namespace Project_demo.Customer_User_Control
{
    public partial class UC_customerProfileUpdate : UserControl
    {
        public UC_customerProfileUpdate()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int mobileNumber, postalCode;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
            con.Open();
            if (Int32.TryParse(this.mobileNumber.Text, out mobileNumber))
            {
                this.mobileNumber.Text = mobileNumber.ToString();
            }
            if (Int32.TryParse(this.postalCode.Text, out postalCode))
            {
                this.postalCode.Text = postalCode.ToString();
            }
            if (this.name.Text.Length != 0 && this.email.Text.Length != 0 && this.password.Text.Length != 0 && this.mobileNumber.Text.Length != 0 && this.country.Text.Length != 0 && this.state.Text.Length != 0 && this.city.Text.Length != 0 && this.postalCode.Text.Length != 0 && this.gender.Text.Length != 0 /*&& this.dateOfBirth.Text.Length != 0*/)
            {
                //int.TryParse(this.postalCode.Text, out _);
                //int.TryParse(this.mobileNumber.Text, out _);

                string query = "update users set name = '" + name.Text + "', password = '" + password.Text + "', mobile_number = '" + mobileNumber + "', country = '" + country.Text + "', state = '" + state.Text + "', city = '" + city.Text + "', postal_code = '" + postalCode + "', gender ='" + gender.Text + "'  where email='" + email.Text + "';";


                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                // MySqlCommand cmd = this.connectionBDD.CreateCommand();
                SqlDataReader MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MessageBox.Show("Data Updated");
            }
            else
            {
                MessageBox.Show("Your have to fill all the fields. Please try again later!!");
                return;
            }
            con.Close();
        }
    }
}
