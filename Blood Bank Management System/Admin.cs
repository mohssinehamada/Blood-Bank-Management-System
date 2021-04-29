using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blood_Bank_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }    
        function fn = new function();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");

        private void Admin_Load(object sender, EventArgs e)
        {
            string query = "select * from signin";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dgvskin();
            blood();
        }
        private void blood()
        {
            con.Open();
            string query = "select * from signin";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void reset()
        {
            txtuname.Text = "";
            txtpassword.Text = "";
            key = 0;
        }
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Missing Informations","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "insert into signin values('" + txtuname.Text + "','" + txtpassword.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully saved", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    reset();
                    blood();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            } 
        }
        private void dgvskin()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Snow;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(184, 72, 39);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtuname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtpassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (txtuname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
        }
                
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "" || txtuname.Text == "" )
            {
                MessageBox.Show("Missing information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "update signin set Username='" + txtuname.Text + "',SPassword='" + txtpassword.Text + "' where UserID='" + key + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User has been Updated","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    reset();
                    blood();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Btndelete_Click_1(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the user you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "delete from signin where UserID=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User has been deleted", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    reset();
                    blood();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnsae_Click_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Dashbord ds = new Dashbord();
            ds.Show();           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbord ds = new Dashbord();
            ds.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTNSAV_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Missing Informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "insert into signin values('" + txtuname.Text + "','" + txtpassword.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully saved", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    reset();
                    blood();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
