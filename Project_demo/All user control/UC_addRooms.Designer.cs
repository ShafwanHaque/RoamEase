
namespace Project_demo.All_user_control
{
    partial class UC_addRooms
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
            this.addRoom = new System.Windows.Forms.Button();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.hType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hname = new System.Windows.Forms.Label();
            this.viewHotelRoom = new System.Windows.Forms.DataGridView();
            this.addHotelLabel = new System.Windows.Forms.Label();
            this.bedQuantity = new System.Windows.Forms.ComboBox();
            this.maxPerson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hj = new System.Windows.Forms.Label();
            this.viewHotel = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.hotel_list = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.uodateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hotelRoomId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewHotelRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // addRoom
            // 
            this.addRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addRoom.Location = new System.Drawing.Point(1154, 299);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(117, 44);
            this.addRoom.TabIndex = 22;
            this.addRoom.Text = "Add Room";
            this.addRoom.UseVisualStyleBackColor = false;
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
            // 
            // roomType
            // 
            this.roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.roomType.FormattingEnabled = true;
            this.roomType.Items.AddRange(new object[] {
            "Room-only",
            "Standard ",
            "Minimalist",
            "Deluxe",
            "Studio",
            "Connecting",
            "Suites"});
            this.roomType.Location = new System.Drawing.Point(1029, 120);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(242, 30);
            this.roomType.TabIndex = 20;
            // 
            // roomNumber
            // 
            this.roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.roomNumber.Location = new System.Drawing.Point(1029, 86);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(242, 28);
            this.roomNumber.TabIndex = 19;
            // 
            // hType
            // 
            this.hType.AutoSize = true;
            this.hType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hType.Location = new System.Drawing.Point(880, 126);
            this.hType.Name = "hType";
            this.hType.Size = new System.Drawing.Size(109, 24);
            this.hType.TabIndex = 18;
            this.hType.Text = "Room Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(880, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantity Of Bed";
            // 
            // hname
            // 
            this.hname.AutoSize = true;
            this.hname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hname.Location = new System.Drawing.Point(880, 89);
            this.hname.Name = "hname";
            this.hname.Size = new System.Drawing.Size(135, 24);
            this.hname.TabIndex = 16;
            this.hname.Text = "Room Number";
            // 
            // viewHotelRoom
            // 
            this.viewHotelRoom.BackgroundColor = System.Drawing.Color.White;
            this.viewHotelRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewHotelRoom.Location = new System.Drawing.Point(55, 39);
            this.viewHotelRoom.Name = "viewHotelRoom";
            this.viewHotelRoom.RowHeadersWidth = 51;
            this.viewHotelRoom.RowTemplate.Height = 24;
            this.viewHotelRoom.Size = new System.Drawing.Size(817, 180);
            this.viewHotelRoom.TabIndex = 15;
            // 
            // addHotelLabel
            // 
            this.addHotelLabel.AutoSize = true;
            this.addHotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.addHotelLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addHotelLabel.Location = new System.Drawing.Point(51, 12);
            this.addHotelLabel.Name = "addHotelLabel";
            this.addHotelLabel.Size = new System.Drawing.Size(274, 24);
            this.addHotelLabel.TabIndex = 14;
            this.addHotelLabel.Text = "Add new room in exitsting hotel";
            // 
            // bedQuantity
            // 
            this.bedQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.bedQuantity.FormattingEnabled = true;
            this.bedQuantity.Items.AddRange(new object[] {
            "One Single",
            "One Semi Master",
            "One Master",
            "One Single and One Master",
            "Two Single",
            "Two Master",
            "Two Master and One Single"});
            this.bedQuantity.Location = new System.Drawing.Point(1029, 156);
            this.bedQuantity.Name = "bedQuantity";
            this.bedQuantity.Size = new System.Drawing.Size(242, 30);
            this.bedQuantity.TabIndex = 23;
            // 
            // maxPerson
            // 
            this.maxPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.maxPerson.FormattingEnabled = true;
            this.maxPerson.Items.AddRange(new object[] {
            "2",
            "4",
            "5",
            "6"});
            this.maxPerson.Location = new System.Drawing.Point(1154, 210);
            this.maxPerson.Name = "maxPerson";
            this.maxPerson.Size = new System.Drawing.Size(117, 30);
            this.maxPerson.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(880, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Maximum Quantity Of Person";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.price.Location = new System.Drawing.Point(1029, 265);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(242, 28);
            this.price.TabIndex = 27;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(914, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Price";
            // 
            // hj
            // 
            this.hj.AutoSize = true;
            this.hj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hj.Location = new System.Drawing.Point(880, 45);
            this.hj.Name = "hj";
            this.hj.Size = new System.Drawing.Size(76, 24);
            this.hj.TabIndex = 28;
            this.hj.Text = "Hotel ID";
            // 
            // viewHotel
            // 
            this.viewHotel.BackgroundColor = System.Drawing.Color.White;
            this.viewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewHotel.Location = new System.Drawing.Point(55, 264);
            this.viewHotel.Name = "viewHotel";
            this.viewHotel.RowHeadersWidth = 51;
            this.viewHotel.RowTemplate.Height = 24;
            this.viewHotel.Size = new System.Drawing.Size(817, 195);
            this.viewHotel.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(51, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Add new room in exitsting hotel";
            // 
            // hotel_list
            // 
            this.hotel_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotel_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hotel_list.FormattingEnabled = true;
            this.hotel_list.Location = new System.Drawing.Point(1029, 39);
            this.hotel_list.Name = "hotel_list";
            this.hotel_list.Size = new System.Drawing.Size(242, 30);
            this.hotel_list.TabIndex = 32;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.deleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteButton.Location = new System.Drawing.Point(1040, 406);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 44);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // uodateButton
            // 
            this.uodateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uodateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.uodateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uodateButton.Location = new System.Drawing.Point(1165, 401);
            this.uodateButton.Name = "uodateButton";
            this.uodateButton.Size = new System.Drawing.Size(108, 44);
            this.uodateButton.TabIndex = 33;
            this.uodateButton.Text = "Update";
            this.uodateButton.UseVisualStyleBackColor = false;
            this.uodateButton.Click += new System.EventHandler(this.uodateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(882, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hotel Room ID";
            // 
            // hotelRoomId
            // 
            this.hotelRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hotelRoomId.Location = new System.Drawing.Point(1029, 359);
            this.hotelRoomId.Name = "hotelRoomId";
            this.hotelRoomId.Size = new System.Drawing.Size(242, 28);
            this.hotelRoomId.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(248, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(833, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "*You will accepted our terms and condition. When you add room must fill all the f" +
    "ileds and give Hotel Room ID to update and delete.";
            // 
            // UC_addRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hotelRoomId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.uodateButton);
            this.Controls.Add(this.hotel_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewHotel);
            this.Controls.Add(this.hj);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bedQuantity);
            this.Controls.Add(this.addRoom);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.hType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hname);
            this.Controls.Add(this.viewHotelRoom);
            this.Controls.Add(this.addHotelLabel);
            this.Name = "UC_addRooms";
            this.Size = new System.Drawing.Size(1285, 497);
            this.Load += new System.EventHandler(this.UC_addRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewHotelRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRoom;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.Label hType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hname;
        private System.Windows.Forms.DataGridView viewHotelRoom;
        private System.Windows.Forms.Label addHotelLabel;
        private System.Windows.Forms.ComboBox bedQuantity;
        private System.Windows.Forms.ComboBox maxPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hj;
        private System.Windows.Forms.DataGridView viewHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hotel_list;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button uodateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hotelRoomId;
        private System.Windows.Forms.Label label7;
    }
}
