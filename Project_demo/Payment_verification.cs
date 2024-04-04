using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_demo
{
    public partial class Payment_verification : Form
    {
        function fn = new function();
        public Payment_verification()
        {
            InitializeComponent();
        }

        private void Payment_verification_Load(object sender, EventArgs e)
        {
            var editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Text = "See";
            editButtonColumn.UseColumnTextForButtonValue = true;

            string query = "SELECT  o.id as Order_ID, u.name as 'Customer Name', o.date as 'Order Date', o.status as 'Order status' FROM orders AS o INNER JOIN users as u ON o.user_id = u.id";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns.Add(editButtonColumn);

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // exclude header
            {
                if (e.ColumnIndex == 4)
                {
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells["Order_Id"].Value;
                    //MessageBox.Show(id);
                    Payment_details pd = new Payment_details(id);
                    this.Hide();
                    pd.Show();
                }
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
