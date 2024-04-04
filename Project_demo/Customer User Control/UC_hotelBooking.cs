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

namespace Project_demo.Customer_User_Control
{

    public partial class UC_hotelBooking : UserControl
    {
        function fn = new function();
        string query;
        public UC_hotelBooking()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void setComboBox(string query, ComboBox combo) {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read()) {
                for (int i = 0; i < sdr.FieldCount; i++) {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void UC_hotelBooking_Load(object sender, EventArgs e)
        {
            hotelLocation.SelectedIndex = -1;
            priceDisplay.Text = "0";
            try
            {
                query = "SELECT '-- Select --' AS hotel_location UNION ALL SELECT DISTINCT hotel_location FROM hotels";
              
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.hotelLocation.DisplayMember = "hotel_location";
                this.hotelLocation.ValueMember = "hotel_location";
                this.hotelLocation.DataSource = ds.Tables["Fleet"];
                con.Close();
            } catch(Exception ex)
            {

            }
        }

        private void hotelLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotelName.SelectedIndex = -1;
            roomNumber.SelectedIndex = -1;
            priceDisplay.Text = "0";
            try
            {

                object b = hotelLocation.SelectedValue;
                string be = Convert.ToString(b);
                string q1 = "select h.hotel_name, hr.room_number, hr.price from hotels as h, hotel_rooms as hr where h.hotel_location = '" + be + "' and h.id = hr.hotel_id ";
                
                DataSet ds1 = fn.getData(q1);
                dataGridView1.DataSource = ds1.Tables[0];

                string q2 = "SELECT 0 AS id, '-- Select --' AS hotel_name UNION ALL SELECT id, hotel_name FROM hotels where hotel_location = '" + be + "'";
                //string q2 = "select hotel_name, id from hotels where hotel_location = '" + be + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(q2, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.hotelName.DisplayMember = "hotel_name";
                this.hotelName.ValueMember = "id";
                this.hotelName.DataSource = ds.Tables["Fleet"];
                con.Close();
            }catch(Exception ex)
            {

            }
        }

        private void hotelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomNumber.SelectedIndex = -1;
            priceDisplay.Text = "0";
            try
            {
                object b = hotelName.SelectedValue;
                string be = Convert.ToString(b);
                string q = "SELECT 0 AS id, '-- Select --' AS room_number UNION ALL SELECT id, room_number FROM hotel_rooms where hotel_id = " + be + "";
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.roomNumber.DisplayMember = "room_number";
                this.roomNumber.ValueMember = "id";
                this.roomNumber.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void roomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            try
            {
                object b = roomNumber.SelectedValue;
                string be = Convert.ToString(b);
                string q = "select  price from hotel_rooms where id = '" + be + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                con.Open();
                SqlCommand query = new SqlCommand(q, con);
                SqlDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    priceDisplay.Text = dr["price"].ToString();
                    Price.setHotelPrice((int)dr["price"]);
                    Price.setHotelId((int)b);
                }
                con.Close();
            } catch(Exception ex)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void priceDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
