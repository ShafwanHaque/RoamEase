using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project_demo
{
    public partial class Reset_Password : Form
    {
        string email = sendCode.to;

        public Reset_Password()
        {
            InitializeComponent();
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (newPassword.Text == confirmPassword.Text)
            {
                string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlConnection con = new SqlConnection(constring);


                SqlCommand cmd = new SqlCommand("UPDATE users SET password = '" + confirmPassword.Text + "' where email = '" + email + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Password reset successfully.");
            }
            else {
                MessageBox.Show("The new password is not match to the enter password. Please try again!");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }
    }
}
