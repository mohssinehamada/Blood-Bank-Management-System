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
    public partial class Bloodtrans : Form
    {
        public Bloodtrans()
        {
            InitializeComponent();
                      
        }

        function fn = new function();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");

        int stock=0;
        private void GetStock(string Bgroup)
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
                stock = Convert.ToInt32(dr["Bstock"].ToString());
            }
            con.Close();
        }

        private void GetData()
        {
            string query = "select * from bloodtransfer";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
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
        private void GetData2()
        {
            string query = "select * from Transfer";
            DataSet ds = fn.getData(query);
            dataGridView2.DataSource = ds.Tables[0];
        }
            private void Bloodtrans_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from patient";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            Patientcb.Items.Clear();
            while (rd.Read())
            {
                Patientcb.Items.Add(rd[0]);
            }
            rd.Close();
            con.Close();
            GetData();
            GetData2();
            dgvskin();
            dgvskin2();
        }

        private void Patientcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
        private void reset()
        {
            txtpname.Text = "";
            txtpbgroupe.Text = "";
            
        }
        private void updatestock()
        {
            int newstock = stock - 1;
            try
            {
                string query = "update bloodtransfer set Bstock=" + newstock + "  where Bgroup='" + txtpbgroupe.Text + "'";
                con.Open();
                DataSet ds = fn.getData(query);
                GetData();
                con.Close();
            
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void transbtn_Click(object sender, EventArgs e)
        {
            if (txtpname.Text == "" ) 
            {
                MessageBox.Show("Missing information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {   
                    string query = "insert into Transfer values('" + txtpname.Text + "','"+txtpbgroupe.Text+ "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transfer completed", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    GetStock(txtpbgroupe.Text);
                    updatestock();
                    reset();
                    GetData2();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void addDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_NEW_Donor adn = new ADD_NEW_Donor();
            adn.Show();
            this.Hide();
        }


        private void Patientcb_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            con.Open();
            string query = "select * from patient where Pnum='" + Patientcb.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtpname.Text = rd["Pname"].ToString();
                txtpbgroupe.Text = rd["Pbgroupe"].ToString();
            }
            rd.Close();
            con.Close();
            GetStock(txtpbgroupe.Text);
            if (stock > 0)
            {
                transbtn.Visible = true;
                availablelb.Text = "Available in stock";
                availablelb.Visible = true;
            }
            else
            {
                availablelb.Text = "UnAvailable in stock";
                availablelb.Visible = true;
                transbtn.Visible = false;
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
        private void dgvskin2()
        {
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.Snow;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(184, 72, 39);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodtrans bt = new Bloodtrans();
            bt.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getstock(txtpbgroupe.Text);
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats st = new stats();
            st.Show();
            this.Hide();
        }

        private void serchBloodDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
            this.Hide();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
