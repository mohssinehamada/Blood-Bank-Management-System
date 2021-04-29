using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Addpatient : Form
    {
        LINQDataContext lq = new LINQDataContext();
        function fn = new function();
        public Addpatient()
        {
            InitializeComponent();
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
        private void Addpatient_Load(object sender, EventArgs e)
        {
            string query = " select max(Pnum) from patient";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            addnewpatient.Text = (count + 1).ToString();
        }
        private void pop()
        {
            string query = " select max(Pnum) from patient";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            addnewpatient.Text = (count + 1).ToString();
        }
        private void addDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_NEW_Donor a = new ADD_NEW_Donor();
            a.Show();
            this.Hide();
        }

        private void donorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d_info d = new d_info();
            d.Show();
            this.Hide();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donate don = new Donate();
            don.Show();
            this.Hide();
        }

        private void addAPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addpatient ap = new Addpatient();
            ap.Show();
            this.Hide();
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patientdetails dp = new Patientdetails();
            dp.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodtrans bs = new Bloodtrans();
            bs.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsae_Click_1(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Pname = txtname.Text;
            p.Padress = txtADDress.Text;
            p.Pphone = Convert.ToInt32(txtphone.Text);
            p.Pbgroupe = txtBloodGroup.Text;
            p.Pgender = txtGender.Text;
            p.PAge = Convert.ToInt32(txtAge.Text);
            p.Pcity = txtcity.Text;
            lq.patients.InsertOnSubmit(p);
            lq.SubmitChanges();
            MessageBox.Show("Ajouter avec succes", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();
            pop();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats st = new stats();
            st.Show();
            this.Hide();
        }

        private void txtphone_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcity_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void serchBloodDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
            this.Hide();
        }

        private void addnewpatient_Click(object sender, EventArgs e)
        {

        }
    }
}
