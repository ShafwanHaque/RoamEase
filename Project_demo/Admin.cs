using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_demo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void uC_addGuide1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            customerDetails.PerformClick();
        }

        private void customerDetails_Click(object sender, EventArgs e)
        {
            movingPanel.Left = customerDetails.Left;
            uC_customerDetails1.Visible = true;
            uC_customerDetails1.BringToFront();
        }

        private void addHotelRoom_Click(object sender, EventArgs e)
        {
            movingPanel.Left = addHotelRoom.Left;
            uC_addRooms1.Visible = true;
            uC_addRooms1.BringToFront();
        }

        private void addGuide_Click(object sender, EventArgs e)
        {
            movingPanel.Left = addGuide.Left;
            uC_addGuide1.Visible = true;
            uC_addGuide1.BringToFront();
        }

        private void addVehicle_Click(object sender, EventArgs e)
        {
            movingPanel.Left = addVehicle.Left;
            uC_addVehicle2.Visible = true;
            uC_addVehicle2.BringToFront();
        }

        private void addTent_Click(object sender, EventArgs e)
        {
            movingPanel.Left = addTent.Left;
            uC_addTent1.Visible = true;
            uC_addTent1.BringToFront();

        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            movingPanel.Left = minimizeButton.Left;
            uC_superAdminDashBoard1.Visible = true;
            uC_superAdminDashBoard1.BringToFront();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_verification pv = new Payment_verification();
            pv.Show();
           
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }
        string role = "Admin";
        public void setRole(string role) {
            role = this.role;
        }
        public string getRole() {
            return role;
        }
    }
}
