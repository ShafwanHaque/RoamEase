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

namespace Project_demo.All_user_control
{
    public partial class UC_addRooms : UserControl
    {
        function fn = new function();
        string query;
        static string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
        SqlConnection con = new SqlConnection(constring);

        public UC_addRooms()
        {
            InitializeComponent();
        }

        private void UC_addRooms_Load(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT id AS 'Hotel ID', hotel_name AS 'Hotel Name', hotel_type AS'Hotel Type', hotel_location AS 'Hotel Location' FROM hotels";
                DataSet ds1 = fn.getData(query);
                viewHotel.DataSource = ds1.Tables[0];
                query = "SELECT id AS 'Room ID', room_number AS 'Room Number', room_type AS 'Room Type', bed AS Bed, quantity_people AS 'Maximum Person', price AS Price, hotel_id AS 'Hotel ID', booking_status AS 'Booking  Status' FROM hotel_rooms";
                DataSet dr = fn.getData(query);
                viewHotelRoom.DataSource = dr.Tables[0];


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                query = "SELECT hotel_name, id FROM hotels";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.hotel_list.DisplayMember = "id";
                this.hotel_list.ValueMember = "id";
                this.hotel_list.DataSource = ds.Tables["Fleet"];
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool Checkhotel_list()
        {
            if (int.TryParse(this.hotel_list.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            string roomNumber = this.roomNumber.Text;           
            string roomType = this.roomType.Text;
            string bedQuantity = this.bedQuantity.Text;
            string maxPerson = this.maxPerson.Text;
            string price = this.price.Text;
            string status = "No";
            string  hotel_list = null;
            if (this.hotel_list.Text.Length != 0)
            {
                if (this.Checkhotel_list())
                {
                    hotel_list = this.hotel_list.Text;
                }
                else
                {
                    MessageBox.Show("Hotel Id only contains digit!");
                    return;
                }
            }

            //codition check all the fileds are fill or not
            if (this.roomNumber.Text.Length != 0 && this.roomType.Text.Length != 0 && this.bedQuantity.Text.Length != 0 && this.maxPerson.Text.Length != 0 && this.price.Text.Length != 0)
            {
                query = "INSERT INTO hotel_rooms (room_number, room_type, bed, quantity_people, price, hotel_id, booking_status) VALUES ('" + roomNumber + "', '" + roomType + "', '" + bedQuantity + "', '"+maxPerson+"', '"+price+"', '"+hotel_list+"', '"+status+"')";
                fn.setData(query, "Room Added.");

                UC_addRooms_Load(this, null);
                clearAllText();
            }
            else
            {
                MessageBox.Show("Fill all the information.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAllText()
        {
            roomNumber.Clear();
            roomType.SelectedIndex = -1;
            bedQuantity.SelectedIndex = -1;//clearing combobox
            maxPerson.SelectedIndex = -1;//clearing combobox
            price.Clear();
            hotel_list.SelectedIndex = -1;

        }

        private void uodateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
            con.Open();

            if (this.hotel_list.Text.Length != 0 && this.roomNumber.Text.Length != 0 && this.roomType.Text.Length != 0 && this.bedQuantity.Text.Length != 0 && this.maxPerson.Text.Length != 0 && this.price.Text.Length != 0)
            {
                //int.TryParse(this.postalCode.Text, out _);
                //int.TryParse(this.mobileNumber.Text, out _);

                string query = "UPDATE hotel_rooms SET room_number = '" + roomNumber.Text + "', room_type = '" + roomType.Text + "', bed = '" + bedQuantity.Text + "', quantity_people = '" + maxPerson.Text + "', price = '" + price.Text + "' where id = '"+hotelRoomId.Text+"'";


                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                SqlDataReader MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                fn.setData(query, "Room Updated.");

                UC_addRooms_Load(this, null);
                clearAllText();
            }
            else
            {
                MessageBox.Show("Your have to fill all the fields. Please try again later!!");
                return;
            }
            con.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM hotel_rooms WHERE  id ='"+hotelRoomId.Text+"' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    //MessageBox.Show(result["email"].ToString());
                    int id = (int)result["id"];
                    string name = result["name"].ToString();
                    
                    // MessageBox.Show(id.ToString());
                    
                    fn.setData(query, "Record deleted");
                    UC_addRooms_Load(this, null);
                    break;
                }
            }

            else
            {
                //MessageBox.Show("Invalid!");
                //MessageBox.Show("Invalide Hotel room ID");

            }
            fn.setData(query, "Record deleted");
            UC_addRooms_Load(this, null);
            con.Close();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
