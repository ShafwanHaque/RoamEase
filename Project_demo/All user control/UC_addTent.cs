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
    public partial class UC_addTent : UserControl
    {
        function fn = new function();
        string query;
        static string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
        SqlConnection con = new SqlConnection(constring);
        public UC_addTent()
        {
            InitializeComponent();
        }
        public bool CheckTent_ID()
        {
            if (int.TryParse(this.tentId.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void UC_addTent_Load(object sender, EventArgs e)
        {
            //
            query = "select * from tents";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void addGuideButton_Click(object sender, EventArgs e)
        {
            string tentName = this.tentName.Text;
            //if (this.hotelName.Text.Length != 0) {
            //    hotelName = hotelName.Insert(hotelName.IndexOf('\''), "'");//very important to insert a " ' and /" in string
            //}
            string tentType = this.tentType.Text;
            string tentLocation = this.tentLocation.Text;
            string tentPrice = this.price.Text;
            //if (this.hotelLocation.Text.Length != 0)
            //{
            //    hotelLocation = hotelLocation.Insert(hotelLocation.IndexOf('\''), "'");//very important to insert a " ' and /" in string
            //}

            //codition check all the fileds are fill or not
            if (this.tentName.Text.Length != 0 && this.tentType.Text.Length != 0 && this.tentLocation.Text.Length != 0 && this.price.Text.Length != 0)
            {
                query = "INSERT INTO tents (name, type, location, price) VALUES ('" + tentName + "', '" + tentType + "', '" + tentLocation + "', '" + tentPrice + "')";
                fn.setData(query, "Tent Added.");

                UC_addTent_Load(this, null);              
              
                clearAllText();
            }
            else
            {
                MessageBox.Show("Fill all the information.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAllText()
        {
            tentName.SelectedIndex = -1;
            tentType.SelectedIndex = -1;//clearing combobox
            tentLocation.Clear();
            tentId.Clear();
            price.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string tentId = null;
            if (this.tentId.Text.Length != 0)
            {
                if (this.CheckTent_ID())
                {
                    tentId = this.tentId.Text;
                }
                else
                {
                    MessageBox.Show("Tent Id only contains digit!");
                    return;
                }
            }
            try
            {
                string query2 = "select * from tents where id = '" + tentId + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataReader result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    query = "DELETE FROM tents WHERE  id ='" + tentId + "' ";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    fn.setData(query, "Tents Delete.");
                    UC_addTent_Load(this, null);
                    clearAllText();
                }
                else
                {
                    MessageBox.Show("Invalide Tent ID!");
                }
                con.Close();
            }
            catch (Exception ex) 
            { }
        }

        private void uodateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
            con.Open();
            string tentsID = null;
            if (this.tentId.Text.Length != 0)
            {
                if (this.CheckTent_ID())
                {
                    tentsID = this.tentId.Text;
                }
                else
                {
                    MessageBox.Show("Tent Id only contains digit!");
                    return;
                }
            }

            if (this.price.Text.Length != 0 && this.tentName.Text.Length != 0 && this.tentLocation.Text.Length != 0 && this.tentId.Text.Length != 0)
            {
                string query = "update tents set name = '" + tentName.Text + "', location = '" + tentLocation.Text + "', price = '" + price.Text + "' where id = '" + tentId.Text + "'";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                SqlDataReader MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                fn.setData(query, "Guide Updated.");

                UC_addTent_Load(this, null);
                clearAllText();
            }
            else
            {
                MessageBox.Show("Your have to fill all the fields. Please try again later!!");
                return;
            }
            con.Close();
        }

        private void tentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}