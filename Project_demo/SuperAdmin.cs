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
    public partial class SuperAdmin : Form
    {
        function fn = new function();
        public SuperAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            movingPanel.Left = adminRegistration.Left;
            uC_adminRegistration1.Visible = true;
            uC_adminRegistration1.BringToFront();
            
        }

        private void adminDetails_Click(object sender, EventArgs e)
        {
            movingPanel.Left = adminDetails.Left;
            uC_userDetails1.Visible = true;
            uC_userDetails1.BringToFront();
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
            uC_addVehicle1.Visible = true;
            uC_addVehicle1.BringToFront();
        }

        private void addTent_Click(object sender, EventArgs e)
        {
            movingPanel.Left = addTent.Left;
            uC_addTent1.Visible = true;
            uC_addTent1.BringToFront();
        }

        private void addHotel_Click(object sender, EventArgs e)
        {
            //move the exra color panel for identifing the position
            movingPanel.Left = addHotel.Left;
            //show the UC_addHote.cs 
            uC_addHotel1.Visible = true;
            uC_addHotel1.BringToFront();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            movingPanel.Left = editProfile.Left;
            uC_superAdminDashBoard1.Visible = true;
            uC_superAdminDashBoard1.BringToFront();
        }
        private void SuperAdmin_Load(object sender, EventArgs e)
        {
            uC_addHotel1.Visible = false;
            uC_adminRegistration1.Visible = false;

            adminRegistration.PerformClick();//to show the UC_addHotel visible
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }
        string role = "Super admin";
        public void setRole(string role)
        {
            role = this.role;
        }
        public string getRole()
        {
            return role;
        }

        private void uC_addVehicle1_Load(object sender, EventArgs e)
        {

        }
    }
}
