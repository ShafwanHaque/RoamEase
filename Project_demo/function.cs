using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//using System.Windows.Forms;
using System.Windows;

namespace Project_demo
{
    class function
    {
        //method for database connection
        protected SqlConnection getConnection() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = SKIDOO-HOUSE\\SQLEXPRESS; Initial Catalog = csharp_porject;Integrated Security= true";
            return con;
        }
        //method for return  data form database
        public DataSet getData(string query) 
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;               
        }
        //method for insertion, deletion and updation
        public void setData(string query,string message = "") 
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            if(message != "")
            {
                MessageBox.Show("'" + message + "'", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
        public SqlDataReader getForCombo(string query) 
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();

            return sdr;
            con.Close();
        }
       
    }
}