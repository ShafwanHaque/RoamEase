
namespace Project_demo
{
    partial class SuperAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin));
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editProfile = new System.Windows.Forms.Button();
            this.movingPanel = new System.Windows.Forms.Panel();
            this.addTent = new System.Windows.Forms.Button();
            this.addVehicle = new System.Windows.Forms.Button();
            this.addGuide = new System.Windows.Forms.Button();
            this.adminDetails = new System.Windows.Forms.Button();
            this.adminRegistration = new System.Windows.Forms.Button();
            this.addHotel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signOutButton = new System.Windows.Forms.Button();
            this.uC_addVehicle1 = new Project_demo.All_user_control.UC_addVehicle();
            this.uC_addTent1 = new Project_demo.All_user_control.UC_addTent();
            this.uC_addGuide1 = new Project_demo.All_user_control.UC_addGuide();
            this.uC_superAdminDashBoard1 = new Project_demo.All_user_control.UC_superAdminDashBoard();
            this.uC_userDetails1 = new Project_demo.All_user_control.UC_userDetails();
            this.uC_adminRegistration1 = new Project_demo.All_user_control.UC_adminRegistration();
            this.uC_addHotel1 = new Project_demo.All_user_control.UC_addHotel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(1683, 173);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 41);
            this.exitButton.TabIndex = 17;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editProfile);
            this.panel1.Controls.Add(this.movingPanel);
            this.panel1.Controls.Add(this.addTent);
            this.panel1.Controls.Add(this.addVehicle);
            this.panel1.Controls.Add(this.addGuide);
            this.panel1.Controls.Add(this.adminDetails);
            this.panel1.Controls.Add(this.adminRegistration);
            this.panel1.Controls.Add(this.addHotel);
            this.panel1.Location = new System.Drawing.Point(434, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 132);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // editProfile
            // 
            this.editProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.Location = new System.Drawing.Point(1054, 17);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(151, 90);
            this.editProfile.TabIndex = 20;
            this.editProfile.Text = "Update Profile";
            this.editProfile.UseVisualStyleBackColor = true;
            this.editProfile.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.movingPanel.Location = new System.Drawing.Point(8, 107);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(151, 10);
            this.movingPanel.TabIndex = 6;
            // 
            // addTent
            // 
            this.addTent.Location = new System.Drawing.Point(883, 17);
            this.addTent.Name = "addTent";
            this.addTent.Size = new System.Drawing.Size(151, 101);
            this.addTent.TabIndex = 5;
            this.addTent.Text = "Tent";
            this.addTent.UseVisualStyleBackColor = true;
            this.addTent.Click += new System.EventHandler(this.addTent_Click);
            // 
            // addVehicle
            // 
            this.addVehicle.Location = new System.Drawing.Point(702, 17);
            this.addVehicle.Name = "addVehicle";
            this.addVehicle.Size = new System.Drawing.Size(151, 101);
            this.addVehicle.TabIndex = 4;
            this.addVehicle.Text = "Vehicle";
            this.addVehicle.UseVisualStyleBackColor = true;
            this.addVehicle.Click += new System.EventHandler(this.addVehicle_Click);
            // 
            // addGuide
            // 
            this.addGuide.Location = new System.Drawing.Point(529, 17);
            this.addGuide.Name = "addGuide";
            this.addGuide.Size = new System.Drawing.Size(151, 101);
            this.addGuide.TabIndex = 3;
            this.addGuide.Text = "Guide";
            this.addGuide.UseVisualStyleBackColor = true;
            this.addGuide.Click += new System.EventHandler(this.addGuide_Click);
            // 
            // adminDetails
            // 
            this.adminDetails.Location = new System.Drawing.Point(189, 17);
            this.adminDetails.Name = "adminDetails";
            this.adminDetails.Size = new System.Drawing.Size(151, 101);
            this.adminDetails.TabIndex = 2;
            this.adminDetails.Text = "User Details";
            this.adminDetails.UseVisualStyleBackColor = true;
            this.adminDetails.Click += new System.EventHandler(this.adminDetails_Click);
            // 
            // adminRegistration
            // 
            this.adminRegistration.Location = new System.Drawing.Point(8, 15);
            this.adminRegistration.Name = "adminRegistration";
            this.adminRegistration.Size = new System.Drawing.Size(151, 101);
            this.adminRegistration.TabIndex = 1;
            this.adminRegistration.Text = "Admin Registration";
            this.adminRegistration.UseVisualStyleBackColor = true;
            this.adminRegistration.Click += new System.EventHandler(this.button4_Click);
            // 
            // addHotel
            // 
            this.addHotel.Location = new System.Drawing.Point(360, 17);
            this.addHotel.Name = "addHotel";
            this.addHotel.Size = new System.Drawing.Size(151, 101);
            this.addHotel.TabIndex = 0;
            this.addHotel.Text = "Hotel";
            this.addHotel.UseVisualStyleBackColor = true;
            this.addHotel.Click += new System.EventHandler(this.addHotel_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_addVehicle1);
            this.panel2.Controls.Add(this.uC_addTent1);
            this.panel2.Controls.Add(this.uC_addGuide1);
            this.panel2.Controls.Add(this.uC_superAdminDashBoard1);
            this.panel2.Controls.Add(this.uC_userDetails1);
            this.panel2.Controls.Add(this.uC_adminRegistration1);
            this.panel2.Controls.Add(this.uC_addHotel1);
            this.panel2.Location = new System.Drawing.Point(434, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 506);
            this.panel2.TabIndex = 19;
            // 
            // signOutButton
            // 
            this.signOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signOutButton.BackgroundImage")));
            this.signOutButton.Location = new System.Drawing.Point(1680, 236);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(55, 51);
            this.signOutButton.TabIndex = 21;
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // uC_addVehicle1
            // 
            this.uC_addVehicle1.BackColor = System.Drawing.Color.White;
            this.uC_addVehicle1.Location = new System.Drawing.Point(9, -1);
            this.uC_addVehicle1.Name = "uC_addVehicle1";
            this.uC_addVehicle1.Size = new System.Drawing.Size(1285, 497);
            this.uC_addVehicle1.TabIndex = 6;
            this.uC_addVehicle1.Load += new System.EventHandler(this.uC_addVehicle1_Load);
            // 
            // uC_addTent1
            // 
            this.uC_addTent1.BackColor = System.Drawing.Color.White;
            this.uC_addTent1.Location = new System.Drawing.Point(6, -1);
            this.uC_addTent1.Name = "uC_addTent1";
            this.uC_addTent1.Size = new System.Drawing.Size(1285, 497);
            this.uC_addTent1.TabIndex = 5;
            // 
            // uC_addGuide1
            // 
            this.uC_addGuide1.BackColor = System.Drawing.Color.White;
            this.uC_addGuide1.Location = new System.Drawing.Point(7, -1);
            this.uC_addGuide1.Name = "uC_addGuide1";
            this.uC_addGuide1.Size = new System.Drawing.Size(1285, 497);
            this.uC_addGuide1.TabIndex = 4;
            // 
            // uC_superAdminDashBoard1
            // 
            this.uC_superAdminDashBoard1.BackColor = System.Drawing.Color.White;
            this.uC_superAdminDashBoard1.Location = new System.Drawing.Point(7, 0);
            this.uC_superAdminDashBoard1.Name = "uC_superAdminDashBoard1";
            this.uC_superAdminDashBoard1.Size = new System.Drawing.Size(1285, 497);
            this.uC_superAdminDashBoard1.TabIndex = 3;
            // 
            // uC_userDetails1
            // 
            this.uC_userDetails1.BackColor = System.Drawing.Color.White;
            this.uC_userDetails1.Location = new System.Drawing.Point(6, 0);
            this.uC_userDetails1.Name = "uC_userDetails1";
            this.uC_userDetails1.Size = new System.Drawing.Size(1285, 497);
            this.uC_userDetails1.TabIndex = 2;
            // 
            // uC_adminRegistration1
            // 
            this.uC_adminRegistration1.BackColor = System.Drawing.Color.White;
            this.uC_adminRegistration1.Location = new System.Drawing.Point(7, -1);
            this.uC_adminRegistration1.Name = "uC_adminRegistration1";
            this.uC_adminRegistration1.Size = new System.Drawing.Size(1285, 497);
            this.uC_adminRegistration1.TabIndex = 1;
            // 
            // uC_addHotel1
            // 
            this.uC_addHotel1.BackColor = System.Drawing.Color.White;
            this.uC_addHotel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_addHotel1.Location = new System.Drawing.Point(5, -1);
            this.uC_addHotel1.Name = "uC_addHotel1";
            this.uC_addHotel1.Size = new System.Drawing.Size(1287, 499);
            this.uC_addHotel1.TabIndex = 0;
            // 
            // SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1746, 811);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuperAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuperAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addHotel;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.Button addTent;
        private System.Windows.Forms.Button addVehicle;
        private System.Windows.Forms.Button addGuide;
        private System.Windows.Forms.Button adminDetails;
        private System.Windows.Forms.Button adminRegistration;
        private System.Windows.Forms.Panel movingPanel;
        private System.Windows.Forms.Panel panel2;
        private All_user_control.UC_addHotel uC_addHotel1;
        private All_user_control.UC_adminRegistration uC_adminRegistration1;
        private All_user_control.UC_userDetails uC_userDetails1;
        private All_user_control.UC_superAdminDashBoard uC_superAdminDashBoard1;
        private All_user_control.UC_addGuide uC_addGuide1;
        private All_user_control.UC_addTent uC_addTent1;
        private All_user_control.UC_addVehicle uC_addVehicle1;
        private System.Windows.Forms.Button signOutButton;
    }
}