﻿
namespace Project_demo.Customer_User_Control
{
    partial class UC_tentBooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.priceDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tentName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tentLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(943, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tk";
            // 
            // priceDisplay
            // 
            this.priceDisplay.AutoSize = true;
            this.priceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDisplay.Location = new System.Drawing.Point(906, 343);
            this.priceDisplay.Name = "priceDisplay";
            this.priceDisplay.Size = new System.Drawing.Size(20, 24);
            this.priceDisplay.TabIndex = 32;
            this.priceDisplay.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(753, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Price";
            // 
            // tentType
            // 
            this.tentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Select Room"});
            this.tentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentType.FormattingEnabled = true;
            this.tentType.Location = new System.Drawing.Point(827, 162);
            this.tentType.Name = "tentType";
            this.tentType.Size = new System.Drawing.Size(147, 30);
            this.tentType.TabIndex = 30;
            this.tentType.SelectedIndexChanged += new System.EventHandler(this.tentType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tent Type";
            // 
            // tentName
            // 
            this.tentName.AutoCompleteCustomSource.AddRange(new string[] {
            "Select Hotel"});
            this.tentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentName.FormattingEnabled = true;
            this.tentName.Location = new System.Drawing.Point(827, 93);
            this.tentName.Name = "tentName";
            this.tentName.Size = new System.Drawing.Size(147, 30);
            this.tentName.TabIndex = 28;
            this.tentName.SelectedIndexChanged += new System.EventHandler(this.tentName_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 328);
            this.dataGridView1.TabIndex = 27;
            // 
            // tentLocation
            // 
            this.tentLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "Select Location"});
            this.tentLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tentLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentLocation.FormattingEnabled = true;
            this.tentLocation.Location = new System.Drawing.Point(157, 50);
            this.tentLocation.Name = "tentLocation";
            this.tentLocation.Size = new System.Drawing.Size(179, 30);
            this.tentLocation.TabIndex = 26;
            this.tentLocation.SelectedIndexChanged += new System.EventHandler(this.tentLocation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tent Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Location";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(457, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "*You will accepted our terms and condition.";
            // 
            // UC_tentBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tentType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tentName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tentLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_tentBooking";
            this.Size = new System.Drawing.Size(1128, 506);
            this.Load += new System.EventHandler(this.UC_tentBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label priceDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tentName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox tentLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
    }
}
