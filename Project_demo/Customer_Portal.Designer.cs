
namespace Project_demo
{
    partial class Customer_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Portal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileButton = new System.Windows.Forms.Button();
            this.movingPanel = new System.Windows.Forms.Panel();
            this.makePaymentButoon = new System.Windows.Forms.Button();
            this.tentBooking = new System.Windows.Forms.Button();
            this.guideBooking = new System.Windows.Forms.Button();
            this.vehicleBooking = new System.Windows.Forms.Button();
            this.hotelBooking = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_vehicleBooking1 = new Project_demo.Customer_User_Control.UC_vehicleBooking();
            this.uC_tentBooking1 = new Project_demo.Customer_User_Control.UC_tentBooking();
            this.uC_guideBooking1 = new Project_demo.Customer_User_Control.UC_guideBooking();
            this.uC_hotelBooking1 = new Project_demo.Customer_User_Control.UC_hotelBooking();
            this.homeButton = new System.Windows.Forms.Button();
            this.uC_searchingDestination1 = new Project_demo.Customer_User_Control.UC_searchingDestination();
            this.signOutButton = new System.Windows.Forms.Button();
            this.uC_customerProfileUpdate1 = new Project_demo.Customer_User_Control.UC_customerProfileUpdate();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Controls.Add(this.movingPanel);
            this.panel1.Controls.Add(this.makePaymentButoon);
            this.panel1.Controls.Add(this.tentBooking);
            this.panel1.Controls.Add(this.guideBooking);
            this.panel1.Controls.Add(this.vehicleBooking);
            this.panel1.Controls.Add(this.hotelBooking);
            this.panel1.Location = new System.Drawing.Point(306, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 132);
            this.panel1.TabIndex = 20;
            // 
            // profileButton
            // 
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileButton.Location = new System.Drawing.Point(1045, 17);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(162, 90);
            this.profileButton.TabIndex = 20;
            this.profileButton.Text = "Update Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.movingPanel.Location = new System.Drawing.Point(29, 108);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(162, 10);
            this.movingPanel.TabIndex = 6;
            // 
            // makePaymentButoon
            // 
            this.makePaymentButoon.Location = new System.Drawing.Point(841, 17);
            this.makePaymentButoon.Name = "makePaymentButoon";
            this.makePaymentButoon.Size = new System.Drawing.Size(162, 101);
            this.makePaymentButoon.TabIndex = 5;
            this.makePaymentButoon.Text = "Make Payment";
            this.makePaymentButoon.UseVisualStyleBackColor = true;
            this.makePaymentButoon.Click += new System.EventHandler(this.makePaymentButoon_Click);
            // 
            // tentBooking
            // 
            this.tentBooking.Location = new System.Drawing.Point(637, 17);
            this.tentBooking.Name = "tentBooking";
            this.tentBooking.Size = new System.Drawing.Size(162, 101);
            this.tentBooking.TabIndex = 4;
            this.tentBooking.Text = "Tent";
            this.tentBooking.UseVisualStyleBackColor = true;
            this.tentBooking.Click += new System.EventHandler(this.tentBooking_Click);
            // 
            // guideBooking
            // 
            this.guideBooking.Location = new System.Drawing.Point(431, 17);
            this.guideBooking.Name = "guideBooking";
            this.guideBooking.Size = new System.Drawing.Size(162, 101);
            this.guideBooking.TabIndex = 3;
            this.guideBooking.Text = "Guide";
            this.guideBooking.UseVisualStyleBackColor = true;
            this.guideBooking.Click += new System.EventHandler(this.guideBooking_Click);
            // 
            // vehicleBooking
            // 
            this.vehicleBooking.Location = new System.Drawing.Point(29, 17);
            this.vehicleBooking.Name = "vehicleBooking";
            this.vehicleBooking.Size = new System.Drawing.Size(162, 101);
            this.vehicleBooking.TabIndex = 2;
            this.vehicleBooking.Text = "Vehicle";
            this.vehicleBooking.UseVisualStyleBackColor = true;
            this.vehicleBooking.Click += new System.EventHandler(this.vehicleBooking_Click);
            // 
            // hotelBooking
            // 
            this.hotelBooking.Location = new System.Drawing.Point(231, 15);
            this.hotelBooking.Name = "hotelBooking";
            this.hotelBooking.Size = new System.Drawing.Size(162, 101);
            this.hotelBooking.TabIndex = 0;
            this.hotelBooking.Text = "Hotel";
            this.hotelBooking.UseVisualStyleBackColor = true;
            this.hotelBooking.Click += new System.EventHandler(this.hotelBooking_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(1552, 168);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 41);
            this.exitButton.TabIndex = 19;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.uC_customerProfileUpdate1);
            this.panel2.Controls.Add(this.uC_vehicleBooking1);
            this.panel2.Controls.Add(this.uC_tentBooking1);
            this.panel2.Controls.Add(this.uC_guideBooking1);
            this.panel2.Controls.Add(this.uC_hotelBooking1);
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.uC_searchingDestination1);
            this.panel2.Location = new System.Drawing.Point(306, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 506);
            this.panel2.TabIndex = 21;
            // 
            // uC_vehicleBooking1
            // 
            this.uC_vehicleBooking1.BackColor = System.Drawing.Color.White;
            this.uC_vehicleBooking1.Location = new System.Drawing.Point(10, 3);
            this.uC_vehicleBooking1.Name = "uC_vehicleBooking1";
            this.uC_vehicleBooking1.Size = new System.Drawing.Size(1128, 506);
            this.uC_vehicleBooking1.TabIndex = 13;
            // 
            // uC_tentBooking1
            // 
            this.uC_tentBooking1.BackColor = System.Drawing.Color.White;
            this.uC_tentBooking1.Location = new System.Drawing.Point(10, 3);
            this.uC_tentBooking1.Name = "uC_tentBooking1";
            this.uC_tentBooking1.Size = new System.Drawing.Size(1128, 500);
            this.uC_tentBooking1.TabIndex = 12;
            this.uC_tentBooking1.Load += new System.EventHandler(this.uC_tentBooking1_Load);
            // 
            // uC_guideBooking1
            // 
            this.uC_guideBooking1.BackColor = System.Drawing.Color.White;
            this.uC_guideBooking1.Location = new System.Drawing.Point(10, 3);
            this.uC_guideBooking1.Name = "uC_guideBooking1";
            this.uC_guideBooking1.Size = new System.Drawing.Size(1128, 506);
            this.uC_guideBooking1.TabIndex = 11;
            // 
            // uC_hotelBooking1
            // 
            this.uC_hotelBooking1.BackColor = System.Drawing.Color.White;
            this.uC_hotelBooking1.Location = new System.Drawing.Point(10, 3);
            this.uC_hotelBooking1.Name = "uC_hotelBooking1";
            this.uC_hotelBooking1.Size = new System.Drawing.Size(1128, 506);
            this.uC_hotelBooking1.TabIndex = 10;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(1196, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(98, 46);
            this.homeButton.TabIndex = 9;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click_1);
            // 
            // uC_searchingDestination1
            // 
            this.uC_searchingDestination1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.uC_searchingDestination1.Location = new System.Drawing.Point(10, 1);
            this.uC_searchingDestination1.Name = "uC_searchingDestination1";
            this.uC_searchingDestination1.Size = new System.Drawing.Size(1126, 497);
            this.uC_searchingDestination1.TabIndex = 0;
            // 
            // signOutButton
            // 
            this.signOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signOutButton.BackgroundImage")));
            this.signOutButton.Location = new System.Drawing.Point(1548, 234);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(55, 51);
            this.signOutButton.TabIndex = 22;
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // uC_customerProfileUpdate1
            // 
            this.uC_customerProfileUpdate1.BackColor = System.Drawing.Color.White;
            this.uC_customerProfileUpdate1.Location = new System.Drawing.Point(10, 3);
            this.uC_customerProfileUpdate1.Name = "uC_customerProfileUpdate1";
            this.uC_customerProfileUpdate1.Size = new System.Drawing.Size(1128, 506);
            this.uC_customerProfileUpdate1.TabIndex = 14;
            // 
            // Customer_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1622, 807);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Portal";
            this.Text = "Customer_Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Portal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Panel movingPanel;
        private System.Windows.Forms.Button makePaymentButoon;
        private System.Windows.Forms.Button tentBooking;
        private System.Windows.Forms.Button guideBooking;
        private System.Windows.Forms.Button vehicleBooking;
        private System.Windows.Forms.Button hotelBooking;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel2;
        private Customer_User_Control.UC_searchingDestination uC_searchingDestination1;
        private System.Windows.Forms.Button homeButton;
        private Customer_User_Control.UC_hotelBooking uC_hotelBooking1;
        private Customer_User_Control.UC_guideBooking uC_guideBooking1;
        private Customer_User_Control.UC_tentBooking uC_tentBooking1;
        private Customer_User_Control.UC_vehicleBooking uC_vehicleBooking1;
        private System.Windows.Forms.Button signOutButton;
        private Customer_User_Control.UC_customerProfileUpdate uC_customerProfileUpdate1;
    }
}