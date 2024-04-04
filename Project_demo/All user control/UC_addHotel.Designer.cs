
namespace Project_demo.All_user_control
{
    partial class UC_addHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_addHotel));
            this.addHotelLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hType = new System.Windows.Forms.Label();
            this.hotelName = new System.Windows.Forms.TextBox();
            this.hoteltype = new System.Windows.Forms.ComboBox();
            this.hotelLocation = new System.Windows.Forms.TextBox();
            this.addHotel = new System.Windows.Forms.Button();
            this.uodateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hotelId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addHotelLabel
            // 
            resources.ApplyResources(this.addHotelLabel, "addHotelLabel");
            this.addHotelLabel.Name = "addHotelLabel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // hname
            // 
            resources.ApplyResources(this.hname, "hname");
            this.hname.Name = "hname";
            this.hname.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // hType
            // 
            resources.ApplyResources(this.hType, "hType");
            this.hType.Name = "hType";
            // 
            // hotelName
            // 
            resources.ApplyResources(this.hotelName, "hotelName");
            this.hotelName.Name = "hotelName";
            // 
            // hoteltype
            // 
            this.hoteltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.hoteltype, "hoteltype");
            this.hoteltype.FormattingEnabled = true;
            this.hoteltype.Items.AddRange(new object[] {
            resources.GetString("hoteltype.Items"),
            resources.GetString("hoteltype.Items1"),
            resources.GetString("hoteltype.Items2"),
            resources.GetString("hoteltype.Items3"),
            resources.GetString("hoteltype.Items4")});
            this.hoteltype.Name = "hoteltype";
            // 
            // hotelLocation
            // 
            resources.ApplyResources(this.hotelLocation, "hotelLocation");
            this.hotelLocation.Name = "hotelLocation";
            // 
            // addHotel
            // 
            this.addHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.addHotel, "addHotel");
            this.addHotel.Name = "addHotel";
            this.addHotel.UseVisualStyleBackColor = false;
            this.addHotel.Click += new System.EventHandler(this.addHotel_Click);
            // 
            // uodateButton
            // 
            this.uodateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.uodateButton, "uodateButton");
            this.uodateButton.Name = "uodateButton";
            this.uodateButton.UseVisualStyleBackColor = false;
            this.uodateButton.Click += new System.EventHandler(this.uodateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // hotelId
            // 
            resources.ApplyResources(this.hotelId, "hotelId");
            this.hotelId.Name = "hotelId";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Name = "label7";
            // 
            // UC_addHotel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hotelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.uodateButton);
            this.Controls.Add(this.addHotel);
            this.Controls.Add(this.hotelLocation);
            this.Controls.Add(this.hoteltype);
            this.Controls.Add(this.hotelName);
            this.Controls.Add(this.hType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addHotelLabel);
            this.Name = "UC_addHotel";
            this.Load += new System.EventHandler(this.UC_addHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addHotelLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label hname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hType;
        private System.Windows.Forms.TextBox hotelName;
        private System.Windows.Forms.ComboBox hoteltype;
        private System.Windows.Forms.TextBox hotelLocation;
        private System.Windows.Forms.Button addHotel;
        private System.Windows.Forms.Button uodateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hotelId;
        private System.Windows.Forms.Label label7;
    }
}
