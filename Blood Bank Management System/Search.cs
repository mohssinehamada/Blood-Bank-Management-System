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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        function fn = new function();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");
        SqlDataAdapter adapt;
        DataTable dt;
        private void Search_Load(object sender, EventArgs e)
        {
            string query = "select * from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            string query1 = "select * from patient";
            DataSet ds1 = fn.getData(query1);
            dataGridView2.DataSource = ds1.Tables[0];
            dgvskin();
            dgvskin2();
        }
    

        private void txtcity_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from newDonor where Dcity like '" + txtcity.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void patient()
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from patient where Pbgroupe like '" + txtbgroup2.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void txtbgroupe_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from newDonor where Dbgroup like '" + txtbgroupe.Text +  "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();        
        }

        private void txtcity2_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from patient where Pcity like '" + txtcity2.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void txtbgroup2_OnValueChanged(object sender, EventArgs e)
        {
            patient();
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
            Donate don = new Donate();
            don.Show();
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

        private void serchBloodDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
            this.Hide();
        }

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodtrans btr = new Bloodtrans();
            btr.Show();
            this.Hide();
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats st = new stats();
            st.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
