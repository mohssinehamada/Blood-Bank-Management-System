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
    public partial class Patientdetails : Form
    {
        
        public Patientdetails()
        {
            InitializeComponent();
        }

        function fn = new function();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");
        
        private void Reset()
        {
            txtname.Text = "";
            txtAge.Text = "";
            txtADDress.Text = "";
            txtBloodGroup.Text = "";
            txtGender.Text = "";
            txtphone.Text = "";
            txtcity.Text = "";
            key = 0;
        }
        private void populate()
        {
            string query = "select * from patient";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Patientdetails_Load(object sender, EventArgs e)
        {
            string query = "select * from patient";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Snow;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(184, 72, 39);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }
        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAge.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtphone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGender.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBloodGroup.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtADDress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtcity.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (txtname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the patient you want to delete","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "delete from patient where Pnum=" + key + ";";
                    con.Open();
                    DataSet ds = fn.getData(query);
                    MessageBox.Show("Patient has been deleted","succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    con.Close();
                    Reset();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtAge.Text == "" || txtBloodGroup.SelectedIndex == -1 || txtGender.SelectedIndex == -1 || txtphone.Text == "" || txtADDress.Text == ""||txtcity.Text=="")
            {
                MessageBox.Show("Missing information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "update patient set Pname='" + txtname.Text + "',PAge='" + txtAge.Text + "',Pbgroupe='" + txtBloodGroup.SelectedItem.ToString() + "',Pphone='" + txtphone.Text + "',Pgender='" + txtGender.SelectedItem.ToString() + "',Padress='" + txtADDress.Text +"',Pcity='"+txtcity.Text+ "' where Pnum='" + key + "'";                  
                    con.Open();                    
                    DataSet ds = fn.getData(query);
                    MessageBox.Show("Patient has been Updated","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
    }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats st = new stats();
            st.Show();
            this.Hide();
        }

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodtrans bt = new Bloodtrans();
            bt.Hide();
            this.Hide();
        }

        private void serchBloodDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search sea = new Search();
            sea.Show();
            this.Hide();
        }

        private void addPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addpatient ap = new Addpatient();
            ap.Show();
            this.Hide();
        }

        private void patientsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patientdetails pd = new Patientdetails();
            pd.Show();
            this.Hide();
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
    }
}
