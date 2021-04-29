using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Blood_Bank_Management_System
{

    public partial class ADD_NEW_Donor : Form
    {
        LINQDataContext lq = new LINQDataContext();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");
        function fn = new function();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nwidthEllipse,
            int n
            );

        public ADD_NEW_Donor()
        {
            InitializeComponent();
        }

        private void ADD_NEW_Donor_Load(object sender, EventArgs e)
        {
            string query = " select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            addnewDoner.Text = (count + 1).ToString();
        }

        private void populate()
        {
            string query = " select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            addnewDoner.Text = (count + 1).ToString();
        }
        private void addnewDoner_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }


        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset()
        {
            txtADDress.Text = "";
            txtAge.Text = "";
            txtBloodGroup.Text = "";
            txtcity.Text = "";
            txtGender.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
        }
        private void btnsae_Click_1(object sender, EventArgs e)
        {
            newDonor c = new newDonor();
            c.Dname = txtname.Text;
            c.Daddress = txtADDress.Text;
            c.Dmobile = Convert.ToInt32(txtphone.Text);
            c.Dbgroup = txtBloodGroup.Text;
            c.Dgender = txtGender.Text;
            c.Dage = Convert.ToInt32(txtAge.Text);
            c.Dcity = txtcity.Text;
            lq.newDonors.InsertOnSubmit(c);
            lq.SubmitChanges();
            MessageBox.Show("Ajouter avec succes", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();
            populate();
        }

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodtrans bt = new Bloodtrans();
            bt.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
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

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donate d = new Donate();
            d.Show();
            this.Hide();
        }

        private void donorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d_info di = new d_info();
            di.Show();
            this.Hide();
        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_NEW_Donor adn = new ADD_NEW_Donor();
            adn.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats st = new stats();
            st.Show();
            this.Hide();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
