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
    public partial class UC_addVehicle : UserControl
    {
        static string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
        SqlConnection con = new SqlConnection(constring);
        function fn = new function();
        string query;
        public UC_addVehicle()
        {
            InitializeComponent();
        }

        private void UC_addVehicle_Load(object sender, EventArgs e)
        {
            query = "select * from vehicles";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void addVechicle_Click(object sender, EventArgs e)
        {
            string vehicleName = this.vehicleName.Text;
            //if (this.hotelName.Text.Length != 0) {
            //    hotelName = hotelName.Insert(hotelName.IndexOf('\''), "'");//very important to insert a " ' and /" in string
            //}
            string vehicleType = this.vehicleType.Text;
            string vehicleNumber = this.vehicleNumber.Text;
            string vehicleLocation = this.from.Text;
            //if (this.hotelLocation.Text.Length != 0)
            //{
            //    hotelLocation = hotelLocation.Insert(hotelLocation.IndexOf('\''), "'");//very important to insert a " ' and /" in string
            //}

            //codition check all the fileds are fill or not
            if (this.price.Text.Length != 0 && this.vehicleName.Text.Length != 0 && this.vehicleNumber.Text.Length != 0 && this.vehicleType.Text.Length != 0 && this.to.Text.Length != 0 && this.from.Text.Length != 0  && this.maxSite.Text.Length != 0)
            {
                query = "INSERT INTO vehicles (vehicle_name, vehicle_type, vehicle_number, vehicle_from, vehicle_to, person_quantity, price) VALUES ('" + vehicleName + "', '" + vehicleType + "', '" + vehicleNumber + "', '"+vehicleLocation+"', '"+to.Text+"', '"+maxSite.Text+"', '"+price.Text+"')";
                fn.setData(query, "Vehicle Added.");
                

                UC_addVehicle_Load(this, null);
                
                clearAllText();
                
            }
            else
            {
                MessageBox.Show("Fill all the information.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAllText()
        {
            vehicleName.Clear();
            vehicleType.SelectedIndex = -1;//clearing combobox
            vehicleNumber.Clear();
            vehicleId.Clear();
            maxSite.Clear();
            price.Clear();
           // from.Clear();
        }
        public bool checkVehicle_ID()
        {
            if (int.TryParse(this.vehicleId.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string vehicleId = null;
            if (this.vehicleId.Text.Length != 0)
            {
                if (this.checkVehicle_ID())
                {
                    vehicleId = this.vehicleId.Text;
                }
                else
                {
                    MessageBox.Show("Vehicle Id only contains digit!");
                    return;
                }
            }
            try
            {
                string query2 = "select * from vehicles where id = '" + vehicleId + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataReader result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    query = "DELETE FROM vehicles WHERE  id ='" + vehicleId + "' ";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    fn.setData(query, "Vehicle Delete.");
                    UC_addVehicle_Load(this, null);
                    clearAllText();
                }
                else
                {
                    MessageBox.Show("Invalide Vehicle ID!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           
            con.Open();
            string vehicleId = null;
            if (this.vehicleId.Text.Length != 0)
            {
                if (this.checkVehicle_ID())
                {
                    vehicleId = this.vehicleId.Text;
                }
                else
                {
                    MessageBox.Show("Vehicle Id only contains digit!");
                    return;
                }
            }

            if (this.price.Text.Length != 0 && this.vehicleName.Text.Length != 0 && this.vehicleNumber.Text.Length != 0 && this.vehicleType.Text.Length != 0 && this.to.Text.Length !=0 && this.from.Text.Length !=0 && this.vehicleId.Text.Length != 0 && this.maxSite.Text.Length !=0)
            {
                string query = "update vehicles set vehicle_name = '" + vehicleName.Text + "', vehicle_type = '" + vehicleType.Text + "', price = '" + price.Text + "', person_quantity ='"+maxSite.Text+"', vehicle_number = '"+vehicleNumber.Text+"', vehicle_to = '"+to.Text+"', vehicle_from = '"+from.Text+"' where id = '" + vehicleId + "'";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                SqlDataReader MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                fn.setData(query, "Vehicle Updated.");

                UC_addVehicle_Load(this, null);
                clearAllText();
            }
            else
            {
                MessageBox.Show("Your have to fill all the fields. Please try again later!!");
                return;
            }
            con.Close();
        }
    }
}
