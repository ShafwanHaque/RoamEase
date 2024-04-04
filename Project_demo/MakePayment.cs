using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_demo.Customer_User_Control;
using System.Data.SqlClient;

namespace Project_demo
{
    public partial class MakePayment : Form
    {
        function fn = new function();
        public MakePayment()
        {
            InitializeComponent();
        }

        private void MakePayment_Load(object sender, EventArgs e)
        {
            vehiclePrice.Text = Price.getVehiclePrice().ToString();
            hotelPrice.Text = Price.getHotelPrice().ToString();
            guidePrice.Text = Price.getGuidePrice().ToString();
            tentPrice.Text = Price.getTentPrice().ToString();
            
            totalPrice.Text = Price.getTotal().ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Portal cp = new Customer_Portal();
            cp.Show();
        }

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            if (Price.getTotal() > 0)
            {
                //MessageBox.Show(Price.getUserId().ToString());
                int order_id = 0;
                DateTime today = DateTime.Today;
                string query1 = "INSERT INTO orders (date, user_id, status) VALUES ('" + today.ToString() + "', '" + Price.getUserId() + "', 'Ordered')";
                fn.setData(query1);
                string q = "select  max(id) AS id from orders where user_id = '" + Price.getUserId() + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                con.Open();
                SqlCommand query = new SqlCommand(q, con);
                SqlDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    order_id = (int)dr["id"];
                }
                //string query2 = "INSERT INTO order_details (order_id, hotel_room_id, vehicle_id, guide_id, tent_id) VALUES ('" + Price.getHotelId() + "', '" + Price.getVehicleId() + "', '" + Price.getGuideId() + "', '" + Price.getTentId() + "')";
                //fn.setData(query2);
                string query2 = "INSERT INTO order_details (order_id, hotel_room_id, vehicle_id, guide_id, tent_id) VALUES ('" + order_id + "','" + Price.getHotelId() + "', '" + Price.getVehicleId() + "', '" + Price.getGuideId() + "', '" + Price.getTentId() + "')";
                fn.setData(query2);
                this.Hide();
                Customer_Portal cp = new Customer_Portal();
                cp.Show();
            }
            else
            {
                MessageBox.Show("Nothing");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Portal cp = new Customer_Portal();
            cp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
