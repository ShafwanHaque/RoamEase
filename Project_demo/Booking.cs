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
    public partial class BookinPage : Form
    {
        private int id;
        private string name = "";
        public BookinPage()
        {
            InitializeComponent();
        }
        public BookinPage(int id, string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            Booking_type.Text = this.name;
            // MessageBox.Show(name);

            try
            {
                string constring = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
                SqlConnection con = new SqlConnection(constring);

                /* con.Open();
                 string query = "select s.*, u.name as teacher_name from students as s join users as u on s.teacher_id = u.id where teacher_id = " + this.id;

                 SqlDataAdapter sq = new SqlDataAdapter(query, con);

                 DataTable dt = new DataTable();

                 sq.Fill(dt);

                 student_list_table.DataSource = dt;

                 DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                 Editlink.UseColumnTextForLinkValue = true;
                 Editlink.HeaderText = "Edit";
                 Editlink.DataPropertyName = "lnkColumn";
                 Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                 Editlink.Text = "Edit";
                 student_list_table.Columns.Add(Editlink);                             

                 con.Close();*/
            }
            catch (Exception ex)
            {

            }
        }

        private void BookinPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox1.Items.Add("");
        }

      
    }            
}


