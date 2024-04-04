
namespace Project_demo.All_user_control
{
    partial class UC_addVehicle
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
            this.addVechicle = new System.Windows.Forms.Button();
            this.vehicleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addHotelLabel = new System.Windows.Forms.Label();
            this.vehicleType = new System.Windows.Forms.ComboBox();
            this.hType = new System.Windows.Forms.Label();
            this.vehicleNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxSite = new System.Windows.Forms.TextBox();
            this.vehicleId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addVechicle
            // 
            this.addVechicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addVechicle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addVechicle.Location = new System.Drawing.Point(1131, 320);
            this.addVechicle.Name = "addVechicle";
            this.addVechicle.Size = new System.Drawing.Size(117, 44);
            this.addVechicle.TabIndex = 29;
            this.addVechicle.Text = "Add Vehicle";
            this.addVechicle.UseVisualStyleBackColor = false;
            this.addVechicle.Click += new System.EventHandler(this.addVechicle_Click);
            // 
            // vehicleName
            // 
            this.vehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.vehicleName.Location = new System.Drawing.Point(933, 52);
            this.vehicleName.Name = "vehicleName";
            this.vehicleName.Size = new System.Drawing.Size(157, 28);
            this.vehicleName.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(929, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Vehicle Location";
            // 
            // hname
            // 
            this.hname.AutoSize = true;
            this.hname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hname.Location = new System.Drawing.Point(929, 25);
            this.hname.Name = "hname";
            this.hname.Size = new System.Drawing.Size(130, 24);
            this.hname.TabIndex = 25;
            this.hname.Text = "Vehicle Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 404);
            this.dataGridView1.TabIndex = 24;
            // 
            // addHotelLabel
            // 
            this.addHotelLabel.AutoSize = true;
            this.addHotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.addHotelLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addHotelLabel.Location = new System.Drawing.Point(68, 13);
            this.addHotelLabel.Name = "addHotelLabel";
            this.addHotelLabel.Size = new System.Drawing.Size(158, 24);
            this.addHotelLabel.TabIndex = 23;
            this.addHotelLabel.Text = "Add New Vehicle";
            // 
            // vehicleType
            // 
            this.vehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.vehicleType.FormattingEnabled = true;
            this.vehicleType.Items.AddRange(new object[] {
            "Bus",
            "Mini bus",
            "Car",
            "Offroader Suv",
            "Auto rickshaw"});
            this.vehicleType.Location = new System.Drawing.Point(1100, 53);
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.Size = new System.Drawing.Size(148, 30);
            this.vehicleType.TabIndex = 33;
            // 
            // hType
            // 
            this.hType.AutoSize = true;
            this.hType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hType.Location = new System.Drawing.Point(1096, 22);
            this.hType.Name = "hType";
            this.hType.Size = new System.Drawing.Size(122, 24);
            this.hType.TabIndex = 32;
            this.hType.Text = "Vehicle Type";
            // 
            // vehicleNumber
            // 
            this.vehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.vehicleNumber.Location = new System.Drawing.Point(933, 121);
            this.vehicleNumber.Name = "vehicleNumber";
            this.vehicleNumber.Size = new System.Drawing.Size(315, 28);
            this.vehicleNumber.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(929, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Vehicle Number";
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.from.Location = new System.Drawing.Point(1036, 179);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(212, 28);
            this.from.TabIndex = 36;
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.to.Location = new System.Drawing.Point(1036, 224);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(212, 28);
            this.to.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(929, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(929, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(929, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Maximum Seats";
            // 
            // maxSite
            // 
            this.maxSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.maxSite.Location = new System.Drawing.Point(1079, 258);
            this.maxSite.Name = "maxSite";
            this.maxSite.Size = new System.Drawing.Size(169, 28);
            this.maxSite.TabIndex = 40;
            // 
            // vehicleId
            // 
            this.vehicleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.vehicleId.Location = new System.Drawing.Point(1070, 370);
            this.vehicleId.Name = "vehicleId";
            this.vehicleId.Size = new System.Drawing.Size(178, 28);
            this.vehicleId.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(929, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Vehicle ID";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.deleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteButton.Location = new System.Drawing.Point(1026, 404);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 44);
            this.deleteButton.TabIndex = 45;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.updateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.updateButton.Location = new System.Drawing.Point(1140, 404);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(108, 44);
            this.updateButton.TabIndex = 44;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(260, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(817, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "*You will accepted our terms and condition. When you add vehicle must fill all th" +
    "e filds and fill Vehicle ID when update and delete.";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.price.Location = new System.Drawing.Point(1079, 292);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(169, 28);
            this.price.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(931, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Price";
            // 
            // UC_addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vehicleId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxSite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.vehicleNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleType);
            this.Controls.Add(this.hType);
            this.Controls.Add(this.addVechicle);
            this.Controls.Add(this.vehicleName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addHotelLabel);
            this.Name = "UC_addVehicle";
            this.Size = new System.Drawing.Size(1285, 497);
            this.Load += new System.EventHandler(this.UC_addVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVechicle;
        private System.Windows.Forms.TextBox vehicleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label addHotelLabel;
        private System.Windows.Forms.ComboBox vehicleType;
        private System.Windows.Forms.Label hType;
        private System.Windows.Forms.TextBox vehicleNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxSite;
        private System.Windows.Forms.TextBox vehicleId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label8;
    }
}
