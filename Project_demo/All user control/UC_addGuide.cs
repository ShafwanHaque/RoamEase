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
    public partial class UC_addGuide : UserControl
    {
        function fn = new function();
        string query;
        static string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
        SqlConnection con = new SqlConnection(constring);
        public UC_addGuide()
        {
            InitializeComponent();
        }
        public bool CheckGuide_ID()
        {
            if (int.TryParse(this.guideId.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckPrice()
        {
            if (int.TryParse(this.price.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void UC_addGuide_Load(object sender, EventArgs e)
        {
            query = "select * from guides";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void addGuideButton_Click(object sender, EventArgs e)
        {
            string guideName = this.guideName.Text;
           // guideName = guideName.Insert(guideName.IndexOf('\''), "'");
            string guideLocation = this.guideLocation.Text;
            //if (this.guideName.Text.Length != 0 && this.guideLocation.Text.Length != 0)
            //{
            //    guideName = guideName.Insert(guideName.IndexOf('\''), "'");//very important to insert a " ' and /" in string
            //    guideLocation = guideLocation.Insert(guideLocation.IndexOf('\''), "'");
            //}
            //else
            string price = null;
            if (this.price.Text.Length != 0)
            {
                if (this.CheckPrice())
                {
                    price = this.price.Text;
                }
                else
                {
                    MessageBox.Show("Price only contains digit!");
                    return;
                }
            }

            //codition check all the fileds are fill or not
            if (this.guideName.Text.Length != 0 && this.guideLocation.Text.Length !=0)
            {
                query = "INSERT INTO guides (name, location, price) VALUES ('" + guideName + "', '" + guideLocation + "', '"+price+"')";
                fn.setData(query, "Guide Added.");

                UC_addGuide_Load(this, null);
                clearAllText();
            }
            else
            {
                MessageBox.Show("Fill all the information.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAllText()
        {
            guideName.Clear();
           // hoteltype.SelectedIndex = -1;//clearing combobox
            guideLocation.Clear();
            guideId.Clear();
            price.Clear();


        }

        private void guideName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            }
        }

        private void guideLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addGuideButton.PerformClick();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string guideId = null;
            if (this.guideId.Text.Length != 0)
            {
                if (this.CheckGuide_ID())
                {
                    guideId = this.guideId.Text;
                }
                else
                {
                    MessageBox.Show("Guide Id only contains digit!");
                    return;
                }
            }
            try
            {
                string query2 = "select * from guides where id = '" + guideId + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataReader result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    query = "DELETE FROM guides WHERE  id ='" + guideId + "' ";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    fn.setData(query, "Guide Delete.");
                    UC_addGuide_Load(this, null);
                    clearAllText();
                }
                else
                {
                    MessageBox.Show("Invalide Guide ID!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uodateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
            con.Open(); 
            string guideId = null;
            if (this.guideId.Text.Length != 0)
            {
                if (this.CheckGuide_ID())
                {
                    guideId = this.guideId.Text;
                }
                else
                {
                    MessageBox.Show("Guide Id only contains digit!");
                    return;
                }
            }
            string price = null;
            if (this.price.Text.Length != 0)
            {
                if (this.CheckPrice())
                {
                    price = this.price.Text;
                }
                else
                {
                    MessageBox.Show("Price only contains digit!");
                    return;
                }
            }

            if (this.price.Text.Length != 0 && this.guideName.Text.Length != 0 && this.guideLocation.Text.Length != 0 && this.guideId.Text.Length != 0)
            {
                string query = "update guides set name = '" + guideName.Text + "', location = '" + guideLocation.Text + "', price = '" + price + "' where id = '" + guideId + "'";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                SqlDataReader MyReader2 = cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                fn.setData(query, "Guide Updated.");

                UC_addGuide_Load(this, null);
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
