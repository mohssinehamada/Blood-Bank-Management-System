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

namespace Blood_Bank_Management_System
{
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        function fn = new function();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");
        private void Donate_Load(object sender, EventArgs e)
        {
            string query = "select * from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            blood();
            dgvskin();
            dgvskin2();
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
        private void dgvskin2()
        {
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.Snow;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(184, 72, 39);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void blood()
        {
            string query = "select * from bloodtransfer";
            DataSet ds = fn.getData(query);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbgroupe.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            getstock(txtbgroupe.Text);
        }
        int oldstock;
        private void getstock(string Bgroup)
        {
            // Get the actual stock of blood based on particular blood groups
            con.Open();
            string query = "select * from bloodtransfer where Bgroup='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["Bstock"].ToString());    
            }
            con.Close();
        }
        private void Reset()
        {
            txtname.Text = "";
            txtbgroupe.Text = "";
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Select a Donor","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
            else
            {
                try
                {
                    int stock = oldstock + 1;
                    string query = "update bloodtransfer set Bstock='" + stock + "' where Bgroup='" + txtbgroupe.Text+ "'";
                    con.Open();
                    DataSet ds = fn.getData(query);
                    MessageBox.Show("Donation Complete","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    con.Close();
                    Reset();
                    blood();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_NEW_Donor adn = new ADD_NEW_Donor();
            adn.Show();
            this.Hide();
        }

        private void donorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d_info di = new d_info();
            di.Show();
            this.Hide();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donate d = new Donate();
            d.Show();
            this.Hide();
        }

        private void addPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addpatient ap = new Addpatient();
            ap.Show();
            this.Hide();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patientdetails pd = new Patientdetails(); 
            pd.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
            this.Hide();
        }

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodtrans bt = new Bloodtrans();
            bt.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           stats ds = new stats();
            ds.Show();
            this.Hide();
        }
    }
}
