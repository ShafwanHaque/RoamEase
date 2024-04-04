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
    public partial class UC_guideBooking : UserControl
    {
        function fn = new function();
        string query;
        public UC_guideBooking()
        {
            InitializeComponent();
        }

        private void UC_guideBooking_Load(object sender, EventArgs e)
        {
            try
            {
               
                query = "SELECT '-- Select --' AS location UNION ALL SELECT DISTINCT location from guides";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.guideLocation.DisplayMember = "location";
                this.guideLocation.ValueMember = "location";
                this.guideLocation.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void guideLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                guideId.SelectedIndex = -1;
                //guideName.SelectedIndex = -1;
                object b = guideLocation.SelectedItem;
                object be = guideLocation.GetItemText(b);

                //
                query = "select name, id, price  from guides where location = '" + be + "'  ";

                DataSet ds1 = fn.getData(query);
                dataGridView1.DataSource = ds1.Tables[0];

                //string q = "SELECT '-- Select --' AS id UNION ALL SELECT id from guides where location = '" + be + "'";
                string q = "SELECT  0 AS id UNION ALL SELECT id FROM guides where location = '" + be + "'";
                //string q2 = "select hotel_name, id from hotels where hotel_location = '" + be + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.guideId.DisplayMember = "id";
                this.guideId.ValueMember = "id";
                this.guideId.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void guideName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guideId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object b = guideId.SelectedValue;
                string be = Convert.ToString(b);
                //MessageBox.Show(be);
                string q = "select  price from guides where id = '" + be + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                con.Open();
                SqlCommand query = new SqlCommand(q, con);
                SqlDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    priceDisplay.Text = dr["price"].ToString();
                    Price.setGuidePrice((int)dr["price"]);
                    Price.setGuideId((int)b);
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
