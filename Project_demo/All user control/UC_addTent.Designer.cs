
namespace Project_demo.All_user_control
{
    partial class UC_addTent
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
            this.addGuideButton = new System.Windows.Forms.Button();
            this.tentLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.Label();
            this.tentType = new System.Windows.Forms.ComboBox();
            this.hType = new System.Windows.Forms.Label();
            this.tentName = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.uodateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addGuideButton
            // 
            this.addGuideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addGuideButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addGuideButton.Location = new System.Drawing.Point(1092, 320);
            this.addGuideButton.Name = "addGuideButton";
            this.addGuideButton.Size = new System.Drawing.Size(117, 44);
            this.addGuideButton.TabIndex = 29;
            this.addGuideButton.Text = "Add Tent";
            this.addGuideButton.UseVisualStyleBackColor = false;
            this.addGuideButton.Click += new System.EventHandler(this.addGuideButton_Click);
            // 
            // tentLocation
            // 
            this.tentLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tentLocation.Location = new System.Drawing.Point(965, 205);
            this.tentLocation.Name = "tentLocation";
            this.tentLocation.Size = new System.Drawing.Size(242, 28);
            this.tentLocation.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(961, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tent Location";
            // 
            // hname
            // 
            this.hname.AutoSize = true;
            this.hname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hname.Location = new System.Drawing.Point(961, 21);
            this.hname.Name = "hname";
            this.hname.Size = new System.Drawing.Size(104, 24);
            this.hname.TabIndex = 25;
            this.hname.Text = "Tent Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 404);
            this.dataGridView1.TabIndex = 24;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label.Location = new System.Drawing.Point(63, 21);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(132, 24);
            this.Label.TabIndex = 23;
            this.Label.Text = "Add New Tent";
            // 
            // tentType
            // 
            this.tentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tentType.FormattingEnabled = true;
            this.tentType.Items.AddRange(new object[] {
            "One is to one",
            "One is to two",
            "One is to three",
            "One is to four",
            "One is to six",
            "One is to ten"});
            this.tentType.Location = new System.Drawing.Point(967, 133);
            this.tentType.Name = "tentType";
            this.tentType.Size = new System.Drawing.Size(242, 30);
            this.tentType.TabIndex = 31;
            // 
            // hType
            // 
            this.hType.AutoSize = true;
            this.hType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hType.Location = new System.Drawing.Point(963, 100);
            this.hType.Name = "hType";
            this.hType.Size = new System.Drawing.Size(96, 24);
            this.hType.TabIndex = 30;
            this.hType.Text = "Tent Type";
            // 
            // tentName
            // 
            this.tentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tentName.FormattingEnabled = true;
            this.tentName.Items.AddRange(new object[] {
            "Frame tent",
            "Pyramid tent",
            "Hoop tent",
            "Dome tent"});
            this.tentName.Location = new System.Drawing.Point(965, 48);
            this.tentName.Name = "tentName";
            this.tentName.Size = new System.Drawing.Size(242, 30);
            this.tentName.TabIndex = 32;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.price.Location = new System.Drawing.Point(967, 273);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(242, 28);
            this.price.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(963, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Price";
            // 
            // tentId
            // 
            this.tentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tentId.Location = new System.Drawing.Point(975, 370);
            this.tentId.Name = "tentId";
            this.tentId.Size = new System.Drawing.Size(232, 28);
            this.tentId.TabIndex = 38;
            this.tentId.TextChanged += new System.EventHandler(this.tentId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(899, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tent ID";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.deleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteButton.Location = new System.Drawing.Point(987, 408);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 44);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // uodateButton
            // 
            this.uodateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uodateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.uodateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uodateButton.Location = new System.Drawing.Point(1101, 408);
            this.uodateButton.Name = "uodateButton";
            this.uodateButton.Size = new System.Drawing.Size(108, 44);
            this.uodateButton.TabIndex = 35;
            this.uodateButton.Text = "Update";
            this.uodateButton.UseVisualStyleBackColor = false;
            this.uodateButton.Click += new System.EventHandler(this.uodateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(261, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(780, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "*You will accepted our terms and condition. When you add tent must fill all the f" +
    "ilds and fill Tent ID when update and delete.";
            // 
            // UC_addTent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.uodateButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tentName);
            this.Controls.Add(this.tentType);
            this.Controls.Add(this.hType);
            this.Controls.Add(this.addGuideButton);
            this.Controls.Add(this.tentLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label);
            this.Name = "UC_addTent";
            this.Size = new System.Drawing.Size(1285, 497);
            this.Load += new System.EventHandler(this.UC_addTent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGuideButton;
        private System.Windows.Forms.TextBox tentLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ComboBox tentType;
        private System.Windows.Forms.Label hType;
        private System.Windows.Forms.ComboBox tentName;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button uodateButton;
        private System.Windows.Forms.Label label7;
    }
}
