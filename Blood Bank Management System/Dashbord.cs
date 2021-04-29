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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }

 
        private void serchBloodDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
            this.Hide();
        }



        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

    

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void donorsDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            d_info D = new d_info();
            D.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void patientDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Patientdetails pd = new Patientdetails();
            pd.Show();
            this.Hide();
        }

        private void addDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_NEW_Donor g = new ADD_NEW_Donor();
            g.Show();
            this.Hide();
        }

        private void addPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addpatient ap = new Addpatient();
            ap.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donate dn = new Donate();
            dn.Show();
            this.Hide();
        }

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodtrans bt = new Bloodtrans();
            bt.Show();
            this.Hide();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats st = new stats();
            st.Show();
            this.Hide();
        }
    }
}
