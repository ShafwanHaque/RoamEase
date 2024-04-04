
namespace Project_demo.All_user_control
{
    partial class UC_addGuide
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
            this.guideLocation = new System.Windows.Forms.TextBox();
            this.guideName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addHotelLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guideId = new System.Windows.Forms.TextBox();
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
            this.addGuideButton.Location = new System.Drawing.Point(1085, 271);
            this.addGuideButton.Name = "addGuideButton";
            this.addGuideButton.Size = new System.Drawing.Size(117, 44);
            this.addGuideButton.TabIndex = 22;
            this.addGuideButton.Text = "Add Guide";
            this.addGuideButton.UseVisualStyleBackColor = false;
            this.addGuideButton.Click += new System.EventHandler(this.addGuideButton_Click);
            // 
            // guideLocation
            // 
            this.guideLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.guideLocation.Location = new System.Drawing.Point(960, 157);
            this.guideLocation.Name = "guideLocation";
            this.guideLocation.Size = new System.Drawing.Size(242, 28);
            this.guideLocation.TabIndex = 21;
            this.guideLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guideLocation_KeyDown);
            // 
            // guideName
            // 
            this.guideName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.guideName.Location = new System.Drawing.Point(960, 71);
            this.guideName.Name = "guideName";
            this.guideName.Size = new System.Drawing.Size(242, 28);
            this.guideName.TabIndex = 19;
            this.guideName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guideName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(956, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Guide Location";
            // 
            // hname
            // 
            this.hname.AutoSize = true;
            this.hname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hname.Location = new System.Drawing.Point(956, 36);
            this.hname.Name = "hname";
            this.hname.Size = new System.Drawing.Size(117, 24);
            this.hname.TabIndex = 16;
            this.hname.Text = "Guide Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 404);
            this.dataGridView1.TabIndex = 15;
            // 
            // addHotelLabel
            // 
            this.addHotelLabel.AutoSize = true;
            this.addHotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.addHotelLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addHotelLabel.Location = new System.Drawing.Point(59, 9);
            this.addHotelLabel.Name = "addHotelLabel";
            this.addHotelLabel.Size = new System.Drawing.Size(145, 24);
            this.addHotelLabel.TabIndex = 14;
            this.addHotelLabel.Text = "Add New Guide";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.price.Location = new System.Drawing.Point(960, 237);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(242, 28);
            this.price.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(956, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Price";
            // 
            // guideId
            // 
            this.guideId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.guideId.Location = new System.Drawing.Point(993, 336);
            this.guideId.Name = "guideId";
            this.guideId.Size = new System.Drawing.Size(209, 28);
            this.guideId.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(883, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Guide ID";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.deleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteButton.Location = new System.Drawing.Point(985, 381);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 44);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // uodateButton
            // 
            this.uodateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uodateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.uodateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uodateButton.Location = new System.Drawing.Point(1099, 381);
            this.uodateButton.Name = "uodateButton";
            this.uodateButton.Size = new System.Drawing.Size(108, 44);
            this.uodateButton.TabIndex = 25;
            this.uodateButton.Text = "Update";
            this.uodateButton.UseVisualStyleBackColor = false;
            this.uodateButton.Click += new System.EventHandler(this.uodateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(304, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(730, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "*You will accepted our terms and condition. When you add guide fill the the filed" +
    "s and update, delete give Guide id.";
            // 
            // UC_addGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guideId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.uodateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.addGuideButton);
            this.Controls.Add(this.guideLocation);
            this.Controls.Add(this.guideName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addHotelLabel);
            this.Name = "UC_addGuide";
            this.Size = new System.Drawing.Size(1285, 497);
            this.Load += new System.EventHandler(this.UC_addGuide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGuideButton;
        private System.Windows.Forms.TextBox guideLocation;
        private System.Windows.Forms.TextBox guideName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label addHotelLabel;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guideId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button uodateButton;
        private System.Windows.Forms.Label label7;
    }
}
