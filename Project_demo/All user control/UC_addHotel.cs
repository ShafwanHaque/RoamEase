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
    public partial class UC_addHotel : UserControl
    {
        static string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
        SqlConnection con = new SqlConnection(constring);
        function fn = new function();
        string query;
        public UC_addHotel()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        public bool Checkhotel_ID()
        {
            if (int.TryParse(this.hotelId.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void UC_addHotel_Load(object sender, EventArgs e)
        {   //
            query = "SELECT id AS 'Hotel ID', hotel_name AS 'Hotel Name', hotel_type AS'Hotel Type', hotel_location AS 'Hotel Location' from hotels";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void addHotel_Click(object sender, EventArgs e)
        {
            string hotelName = this.hotelName.Text;       
            string hotelType = this.hoteltype.Text;
            string hotelLocation = this.hotelLocation.Text;
            string hotelId = null;
            if (this.hotelId.Text.Length != 0)
            {
                if (this.Checkhotel_ID())
                {
                    hotelId = this.hotelId.Text;
                }
                else
                {
                    MessageBox.Show("Hotel Id only contains digit!");
                    return;
                }
            }
            //if (this.hotelLocation.Text.Length != 0)
            //{
            //    hotelLocation = hotelLocation.Insert(hotelLocation.IndexOf('\''), "'");//very important to insert a " ' and /" in string
            //}

            //codition check all the fileds are fill or not
            if (this.hotelName.Text.Length != 0 && this.hoteltype.Text.Length != 0 && this.hotelLocation.Text.Length != 0){
                query = "INSERT INTO hotels (hotel_name, hotel_type, hotel_location) VALUES ('"+hotelName+"', '"+hotelType+"', '"+hotelLocation+"')";
                fn.setData(query,"Hotel Added.");

                UC_addHotel_Load(this, null);
                clearAllText();
            }
            else {
                MessageBox.Show("Fill all the information.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //to clear the exiting data in the textbox
        public void clearAllText() 
        {   
            hotelName.Clear();
            hoteltype.SelectedIndex = -1;//clearing combobox
            hotelLocation.Clear();
            hotelId.Clear();
        }

        private void uodateButton_Click(object sender, EventArgs e)
        {            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
            con.Open(); string hotelId = null;
            if (this.hotelId.Text.Length != 0)
            {
                if (this.Checkhotel_ID())
                {
                    hotelId = this.hotelId.Text;
                }
                else
                {
                    MessageBox.Show("Hotel Id only contains digit!");
                    return;
                }
            }

            if (this.hotelName.Text.Length != 0 && this.hoteltype.Text.Length != 0 && this.hotelLocation.Text.Length != 0 && this.hotelId.Text.Length !=0)
            {    
                string query = "update hotels set hotel_name = '" + hotelName.Text + "', hotel_type = '" + hoteltype.Text + "', hotel_location = '" + hotelLocation.Text + "' where id = '"+hotelId+"'";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                
                SqlDataReader MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                fn.setData(query, "Hotel Updated.");

                UC_addHotel_Load(this, null);
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
            string hotelId = null;
            if (this.hotelId.Text.Length != 0)
            {
                if (this.Checkhotel_ID())
                {
                    hotelId = this.hotelId.Text;
                }
                else
                {
                    MessageBox.Show("Hotel Id only contains digit!");
                    return;
                }
            }
            try
            {                
                string query2 ="select * from hotels where id = '" +hotelId+ "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query2, con);                
                SqlDataReader result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    query = "DELETE FROM hotels WHERE  id ='" + hotelId + "' ";
                    SqlCommand cmd2 = new SqlCommand(query, con);                    
                    fn.setData(query, "Hotel Delete.");
                    UC_addHotel_Load(this, null);
                    clearAllText();                    
                }                
                else
                {
                    MessageBox.Show("Invalide Hotel ID!");
                }                
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}