using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_demo.Customer_User_Control;

namespace Project_demo
{
    public partial class Customer_Portal : Form
    {
        public Customer_Portal()
        {
            InitializeComponent();
        }
        private void Customer_Portal_Load(object sender, EventArgs e)
        {
            vehicleBooking.PerformClick();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searching_Click(object sender, EventArgs e)
        {
            //movingPanel.Left = searching.Left;
            uC_searchingDestination1.Visible = true;
            uC_searchingDestination1.BringToFront();
        }

        private void vehicleBooking_Click(object sender, EventArgs e)
        {
            movingPanel.Left = vehicleBooking.Left;
            uC_vehicleBooking1.Visible = true;
            uC_vehicleBooking1.BringToFront();
        }

        private void hotelBooking_Click(object sender, EventArgs e)
        {
            movingPanel.Left = hotelBooking.Left;
            uC_hotelBooking1.Visible = true;
            uC_hotelBooking1.BringToFront();
        }

        private void guideBooking_Click(object sender, EventArgs e)
        {
            movingPanel.Left = guideBooking.Left;
            uC_guideBooking1.Visible = true;
            uC_guideBooking1.BringToFront();
        }

        private void tentBooking_Click(object sender, EventArgs e)
        {
            movingPanel.Left = tentBooking.Left;
            uC_tentBooking1.Visible = true;
            uC_tentBooking1.BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            movingPanel.Left = profileButton.Left;
            uC_customerProfileUpdate1.Visible = true;
            uC_customerProfileUpdate1.BringToFront();
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            //searching.PerformClick();
        }

        private void uC_tentBooking1_Load(object sender, EventArgs e)
        {

        }

        private void makePaymentButoon_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakePayment mp = new MakePayment();
            mp.Show();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }
    }
}
