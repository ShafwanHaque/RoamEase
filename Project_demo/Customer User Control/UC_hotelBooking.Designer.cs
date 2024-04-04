
namespace Project_demo.Customer_User_Control
{
    partial class UC_hotelBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hotelLocation = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelName = new System.Windows.Forms.ComboBox();
            this.roomNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hotel Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hotelLocation
            // 
            this.hotelLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "Select Location"});
            this.hotelLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelLocation.FormattingEnabled = true;
            this.hotelLocation.Location = new System.Drawing.Point(162, 49);
            this.hotelLocation.Name = "hotelLocation";
            this.hotelLocation.Size = new System.Drawing.Size(179, 30);
            this.hotelLocation.TabIndex = 2;
            this.hotelLocation.SelectedIndexChanged += new System.EventHandler(this.hotelLocation_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 328);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hotelName
            // 
            this.hotelName.AutoCompleteCustomSource.AddRange(new string[] {
            "Select Hotel"});
            this.hotelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelName.FormattingEnabled = true;
            this.hotelName.Location = new System.Drawing.Point(832, 90);
            this.hotelName.Name = "hotelName";
            this.hotelName.Size = new System.Drawing.Size(147, 30);
            this.hotelName.TabIndex = 4;
            this.hotelName.SelectedIndexChanged += new System.EventHandler(this.hotelName_SelectedIndexChanged);
            // 
            // roomNumber
            // 
            this.roomNumber.AutoCompleteCustomSource.AddRange(new string[] {
            "Select Room"});
            this.roomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.FormattingEnabled = true;
            this.roomNumber.Location = new System.Drawing.Point(832, 158);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(147, 30);
            this.roomNumber.TabIndex = 6;
            this.roomNumber.SelectedIndexChanged += new System.EventHandler(this.roomNumber_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(636, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hotel Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(948, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tk";
            // 
            // priceDisplay
            // 
            this.priceDisplay.AutoSize = true;
            this.priceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDisplay.Location = new System.Drawing.Point(856, 333);
            this.priceDisplay.Name = "priceDisplay";
            this.priceDisplay.Size = new System.Drawing.Size(20, 24);
            this.priceDisplay.TabIndex = 16;
            this.priceDisplay.Text = "0";
            this.priceDisplay.Click += new System.EventHandler(this.priceDisplay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(767, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(441, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "*You will accepted our terms and condition.";
            // 
            // UC_hotelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hotelName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hotelLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_hotelBooking";
            this.Size = new System.Drawing.Size(1128, 506);
            this.Load += new System.EventHandler(this.UC_hotelBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hotelLocation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox hotelName;
        private System.Windows.Forms.ComboBox roomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label priceDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
    }
}
