using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Project_demo
{
    public partial class sendCode : Form
    {
        string randomCode;
        public static string to;
        public sendCode()
        {
            InitializeComponent();
        }

        private void sendCode_Load(object sender, EventArgs e)
        {

        }

        private void sentButton_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (sentEmail.Text).ToString();
            from = "shafwan44482@gmail.com";
            //pass = "csharp123";
            pass = "lhtkcmdeuwdsjwva";
            messageBody = "Your Reset Code is: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("code send successfully");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void verifyCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm ln = new LoginForm();
            ln.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verifyButton_Click_1(object sender, EventArgs e)
        {
            if (randomCode == (verifyCode.Text).ToString())
            {
                to = sentEmail.Text;

                this.Hide();
                Reset_Password rp = new Reset_Password();
                rp.Show();

            }
            else
            {
                MessageBox.Show("Wrong code!");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
