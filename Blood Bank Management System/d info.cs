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
   
    public partial class d_info : Form
    { 
        function fn = new function();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");
        SqlDataAdapter adapt;
        DataTable dt;
        public int index = 0;
        SqlCommand cmd = new SqlCommand();
        public d_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvskin2()
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
        private void populate()
        {
            string query = "select * from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void d_info_Load(object sender, EventArgs e)
        {
            string query = "select * from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dgvskin2();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           

        }

        private void txtname_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from newDonor where Did like '" + txtname.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void donorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d_info di = new d_info();
            di.Show();
            this.Hide();
        }

        private void addDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_NEW_Donor adn = new ADD_NEW_Donor();
            adn.Show();
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
            Addpatient ad = new Addpatient();
            ad.Show();
            this.Hide();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patientdetails pd = new Patientdetails();
            pd.Show();
            this.Hide();
        }

    
        

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodtrans bt = new Bloodtrans();
            bt.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats st = new stats();
            st.Show();
            this.Hide();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                con.Open();
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                SqlCommand cmd = new SqlCommand("DONOR", con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (dgvRow.Cells["txtDid"].Value == DBNull.Value) //INSERT
                    cmd.Parameters.AddWithValue("@Did", 0);
                else //UPDATE 
                    cmd.Parameters.AddWithValue("@Did", Convert.ToInt32(dgvRow.Cells["txtDid"].Value));
                cmd.Parameters.AddWithValue("@Dname", dgvRow.Cells["txtDname"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDname"].Value.ToString());
                cmd.Parameters.AddWithValue("@Dage", Convert.ToInt32(dgvRow.Cells["txtDage"].Value == DBNull.Value ?"0" : dgvRow.Cells["txtDage"].Value.ToString()));
                cmd.Parameters.AddWithValue("@Dmobile", Convert.ToInt32(dgvRow.Cells["txtDmobile"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtDmobile"].Value.ToString()));
                cmd.Parameters.AddWithValue("@Dgender", dgvRow.Cells["txtDgender"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDgender"].Value.ToString());
                cmd.Parameters.AddWithValue("@Dbgroup", dgvRow.Cells["txtDbgroup"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDbgroup"].Value.ToString());
                cmd.Parameters.AddWithValue("@Daddress", dgvRow.Cells["txtDaddress"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDaddress"].Value.ToString());
                cmd.Parameters.AddWithValue("@Dcity", dgvRow.Cells["txtDcity"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDcity"].Value.ToString());
                cmd.ExecuteNonQuery();
                populate();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
         
        }

        private void AllowNumersOnly(Object sender , KeyEventArgs e)
        {
           
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["txtDid"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure you want to delete this donor?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETEDONOR", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Did", Convert.ToInt32(dataGridView1.CurrentRow.Cells["txtDid"].Value != DBNull.Value));
                    cmd.ExecuteNonQuery();
                }
            }
     
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            index = e.RowIndex;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[index];
            DialogResult result = MessageBox.Show("Are you sure you want to delete this donor?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("delete newDonor where Did='" + row.Cells["txtDid"].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Donor Has been deleted!","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                populate();
            }

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
 }

