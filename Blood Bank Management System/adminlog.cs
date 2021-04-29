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
    public partial class adminlog : Form
    {
        public adminlog()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");
        private void btnlog_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Please select a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtpassword.Text == "sabri")
            {
                Admin ad = new Admin();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void adminlog_Load(object sender, EventArgs e)
        {

        }
    }
}
