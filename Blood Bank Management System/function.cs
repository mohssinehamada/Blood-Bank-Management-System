using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    class function
    {
        
        public SqlConnection getConnection()
        {
            return Con();
        }

        public static SqlConnection Con()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True";
            return con;
        }

        public DataSet getData(string query)// get the data 
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            SqlCommandBuilder builder = new SqlCommandBuilder();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setDate(string query)// inset delet update
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            SqlCommandBuilder builder = new SqlCommandBuilder();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       

    }
}
