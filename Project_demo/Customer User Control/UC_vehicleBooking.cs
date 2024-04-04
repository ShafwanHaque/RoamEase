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
    public partial class UC_vehicleBooking : UserControl
    {
        function fn = new function();
        string query;
        public UC_vehicleBooking()
        {
            InitializeComponent();
        }

        private void UC_vehicleBooking_Load(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            try
            {

                query = "SELECT '-- Select --' AS vehicle_from UNION ALL SELECT DISTINCT vehicle_from from vehicles";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.from.DisplayMember = "vehicle_from";
                this.from.ValueMember = "vehicle_from";
                this.from.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            try
            {                
                object b = from.SelectedItem;
                object be = from.GetItemText(b);

                //
                query = "select *  from vehicles where vehicle_from = '" + be + "'  ";

                DataSet ds1 = fn.getData(query);
                dataGridView1.DataSource = ds1.Tables[0];

                string q = "SELECT '-- Select --' AS vehicle_to UNION ALL SELECT DISTINCT vehicle_to from vehicles where vehicle_from = '" + be + "'";
               
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.to.DisplayMember = "vehicle_to";
                this.to.ValueMember = "vehicle_to";
                this.to.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void to_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            try
            {
                object b1 = from.SelectedItem;
                object be1 = from.GetItemText(b1);
                object b = to.SelectedItem;
                object be = to.GetItemText(b);
               

                //
                query = "select *  from vehicles where vehicle_to = '" + be + "' ";                

                DataSet ds1 = fn.getData(query);
                dataGridView1.DataSource = ds1.Tables[0];

                string q = "SELECT '-- Select --' AS vehicle_type UNION ALL SELECT DISTINCT vehicle_type from vehicles where vehicle_to = '" + be + "' and vehicle_from ='"+be1+"'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.type.DisplayMember = "vehicle_type";
                this.type.ValueMember = "vehicle_type";
                this.type.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            try
            {
                object b = type.SelectedItem;
                object be = type.GetItemText(b);


                //
                query = "select *  from vehicles where vehicle_type = '" + be + "' ";

                DataSet ds1 = fn.getData(query);
                dataGridView1.DataSource = ds1.Tables[0];

                string q = "SELECT 0 as id,'-- Select --' AS vehicle_name UNION ALL SELECT DISTINCT id,vehicle_name from vehicles where vehicle_type = '" + be + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                this.vehicleName.DisplayMember = "vehicle_name";
                this.vehicleName.ValueMember = "id";
                this.vehicleName.DataSource = ds.Tables["Fleet"];
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void vehicleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisplay.Text = "0";
            try
            {
                object b = vehicleName.SelectedValue;
                string be = Convert.ToString(b);
                string q = "select price from vehicles where id = '" + be + "'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                con.Open();
                SqlCommand query = new SqlCommand(q, con);
                SqlDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    priceDisplay.Text = dr["price"].ToString();
                    Price.setVehiclePrice((int)dr["price"]);
                    Price.setVehicleId((int)b);
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
