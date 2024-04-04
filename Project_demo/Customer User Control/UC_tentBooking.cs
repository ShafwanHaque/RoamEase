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
    public partial class UC_tentBooking : UserControl
    {
        function fn = new function();
        string query;
        public UC_tentBooking()
        {
            InitializeComponent();
        }

        private void UC_tentBooking_Load(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            //"SELECT '-- Select --' AS hotel_location UNION ALL SELECT DISTINCT hotel_location FROM hotels";
            query = "SELECT '-- Select --' AS location UNION ALL SELECT DISTINCT location from tents";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Fleet");
            this.tentLocation.DisplayMember = "location";
            this.tentLocation.ValueMember = "location";
            this.tentLocation.DataSource = ds.Tables["Fleet"];
            con.Close();
        }

        private void tentLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            tentName.SelectedIndex = -1;
            tentType.SelectedIndex = -1;
            try
            {
                
                object b = tentLocation.SelectedItem;
                object be = tentLocation.GetItemText(b);

                
                query = "select name, id  from tents where location = '" + be + "'  ";

                DataSet ds1 = fn.getData(query);
                dataGridView1.DataSource = ds1.Tables[0];
                string q = "SELECT 0 AS id, '-- Select --' AS name UNION ALL SELECT id,name FROM tents where location = '" + be + "'";
               // string q = "select  name, id from tents where location = '" + be + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.tentName.DisplayMember = "name";
                this.tentName.ValueMember = "name";
                this.tentName.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void tentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            tentType.SelectedIndex = -1;
            try
            {
                object b = tentName.SelectedValue;
                object be = tentName.GetItemText(b);

                query = "select *  from tents where name = '" + be + "'  ";

                DataSet ds1 = fn.getData(query);
                dataGridView1.DataSource = ds1.Tables[0];

                string q = "SELECT 0 as id, '-- Select --' AS type UNION ALL select id, type FROM tents WHERE name = '" + be + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.tentType.DisplayMember = "type";
                this.tentType.ValueMember = "id";
                this.tentType.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void tentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            try
            {
                object b = tentType.SelectedValue;
                string be = Convert.ToString(b);
                string q = "select price from tents where id = '" + be + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                con.Open();
                SqlCommand query = new SqlCommand(q, con);
                SqlDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    priceDisplay.Text = dr["price"].ToString();
                    Price.setTentPrice((int)dr["price"]);
                    Price.setTentId((int)b);
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
