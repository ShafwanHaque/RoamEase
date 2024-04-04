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
namespace Project_demo
{
    public partial class Payment_details : Form
    {
        static string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true; MultipleActiveResultSets=True;";
        SqlConnection con = new SqlConnection(constring);
        int o_id = 0;
        function fn = new function();
        public Payment_details()
        {
        }

        public Payment_details(int oid)
        {
            InitializeComponent();
            con.Open();
            int t_bill = 0;
            string query = "select o.id, o.date, u.name, od.vehicle_id, od.hotel_room_id, od.guide_id, od.tent_id from orders as o inner join users as u ON o.user_id = u.id left join order_details as od on o.id = od.order_id where o.id = '" + oid + "'";
            SqlDataAdapter db = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            db.Fill(dt);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader result = cmd.ExecuteReader();

            if (dt.Rows.Count == 1)
            {
                while (result.Read())
                {
                    string id = result["id"].ToString();
                    string name = result["name"].ToString();
                    string o_date = result["date"].ToString();

                    order_id.Text = id;
                    user_name.Text = name;
                    date.Text = o_date;

                    if (result["vehicle_id"] != null && result["vehicle_id"].ToString() != "")
                    {
                        int vehicle_id = (int)result["vehicle_id"];
                        string query2 = "select * from vehicles where id = '" + vehicle_id + "'";
                        SqlDataAdapter db2 = new SqlDataAdapter(query2, con);
                        DataTable dt2 = new DataTable();
                        db.Fill(dt2);
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        SqlDataReader result2 = cmd2.ExecuteReader();

                        if (dt2.Rows.Count == 1)
                        {
                            while (result2.Read())
                            {
                                string vehicle_name = result2["vehicle_name"].ToString();
                                string vehicle_type = result2["vehicle_type"].ToString();
                                int vehicle_price = (int)result2["price"];
                                t_bill += vehicle_price;

                                vehicle_info.Text = "Vehicle Name: "+vehicle_name+ ", Vehicle Type:"+ vehicle_type+", Price: "+ vehicle_price.ToString();
                            }
                        }

                    }

                    if (result["hotel_room_id"] != null && result["hotel_room_id"].ToString() != "")
                    {
                        int hotel_room_id = (int)result["hotel_room_id"];
                        string query3 = "select hr.room_number, hr.price, h.hotel_name from hotel_rooms as hr inner join hotels as h on h.id = hr.hotel_id where hr.id = '" + hotel_room_id + "'";
                        SqlDataAdapter db3 = new SqlDataAdapter(query3, con);
                        DataTable dt3 = new DataTable();
                        db.Fill(dt3);
                        SqlCommand cmd3 = new SqlCommand(query3, con);
                        SqlDataReader result3 = cmd3.ExecuteReader();

                        if (dt3.Rows.Count == 1)
                        {
                            while (result3.Read())
                            {
                                string hotel_name = result3["hotel_name"].ToString();
                                string room_number = result3["room_number"].ToString();
                                int room_price = (int)result3["price"];
                                t_bill += room_price;

                                hotel_room_info.Text = "Hotel Name: " + hotel_name + ", Room Number:" + room_number + ", Price: " + room_price.ToString();
                            }
                        }

                    }

                    if (result["guide_id"] != null && result["guide_id"].ToString() != "")
                    {
                        int guide_id = (int)result["guide_id"];
                        string query4 = "select * from guides where id = '" + guide_id + "'";
                        SqlDataAdapter db4 = new SqlDataAdapter(query4, con);
                        DataTable dt4 = new DataTable();
                        db.Fill(dt4);
                        SqlCommand cmd4 = new SqlCommand(query4, con);
                        SqlDataReader result4 = cmd4.ExecuteReader();

                        if (dt4.Rows.Count == 1)
                        {
                            while (result4.Read())
                            {
                                string guideid = result4["id"].ToString();
                                string guide_name = result4["name"].ToString();
                                int guide_price = (int)result4["price"];
                                t_bill += guide_price;

                                guide_info.Text = "Guide Name: " + guide_name + ", Guide ID:" + guideid + ", Price: " + guide_price.ToString();
                            }
                        }

                    }

                    if (result["tent_id"] != null && result["tent_id"].ToString() != "")
                    {
                        int tent_id = (int)result["tent_id"];
                        string query5 = "select * from tents where id = '" + tent_id + "'";
                        SqlDataAdapter db5 = new SqlDataAdapter(query5, con);
                        DataTable dt5 = new DataTable();
                        db.Fill(dt5);
                        SqlCommand cmd5 = new SqlCommand(query5, con);
                        SqlDataReader result5 = cmd5.ExecuteReader();

                        if (dt5.Rows.Count == 1)
                        {
                            while (result5.Read())
                            {
                                string tent_type = result5["type"].ToString();
                                string tent_name = result5["name"].ToString();
                                int tent_price = (int)result5["price"];
                                t_bill += tent_price;

                                tent_info.Text = "Tent Name: " + tent_name + ", Tent Type:" + tent_type + ", Price: " + tent_price.ToString();
                            }
                        }

                    }

                    total_bill.Text = t_bill.ToString();

                    this.o_id = (int)result["id"];
                }
            }
            con.Close();
        }
        public bool checkStatus(string role)
        {
            //string cPayment = "Payment Confirmed";

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                string query = "SELECT status FROM orders where status = '"+role+"' and id = '" + this.o_id + "'";
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                return false;
            }


        }
        private void Payment_details_Load(object sender, EventArgs e)
        {

            if (checkStatus("Payment Confirmed"))
            {
                confirm.Visible = false;
                showStatus.Visible = true;
            }
            else
            {
                confirm.Visible = true;
                showStatus.Visible = false;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update orders set status = 'Payment Confirmed' where id = '" + this.o_id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                fn.setData(query, "Status Updated.");
                con.Close();
                this.Hide();
                Payment_verification pv = new Payment_verification();
                pv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_verification pv = new Payment_verification();
            pv.Show();
        }
    }
}
