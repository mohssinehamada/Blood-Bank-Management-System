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
    public partial class stats : Form
    {
        public stats()
        {
            InitializeComponent();
            GetData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");

        private void GetData()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from newDonor", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label4.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from patient", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            label5.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from signin", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            label6.Text = dt2.Rows[0][0].ToString();
             SqlDataAdapter sda4 = new SqlDataAdapter("select Sum(Bstock) from bloodtransfer", con);
             DataTable dt4 = new DataTable();
             sda4.Fill(dt4);
            int Bstock = Convert.ToInt32(dt4.Rows[0][0].ToString());
            //totlb.Text = "" + Bstock;
            //O+
            SqlDataAdapter sda5 = new SqlDataAdapter("select Bstock from bloodtransfer where Bgroup='"+"O+"+"'", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            //label9.Text = dt5.Rows[0][0].ToString();
            double OplusPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / Bstock) * 100;
            bunifuCircleProgressbar1.Value = Convert.ToInt32(OplusPercentage);
            //O-
            SqlDataAdapter sda6 = new SqlDataAdapter("select Bstock from bloodtransfer where Bgroup='" + "O-" + "'", con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            //label10.Text = dt6.Rows[0][0].ToString();
            double OminusPercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / Bstock) * 100;
            bunifuCircleProgressbar2.Value = Convert.ToInt32(OminusPercentage);
            //A+
            SqlDataAdapter sda7 = new SqlDataAdapter("select Bstock from bloodtransfer where Bgroup='" + "A+" + "'", con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            //label11.Text = dt7.Rows[0][0].ToString();
            double AplusPercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / Bstock) * 100;
            bunifuCircleProgressbar3.Value = Convert.ToInt32(AplusPercentage);
            //A-
            SqlDataAdapter sda8 = new SqlDataAdapter("select Bstock from bloodtransfer where Bgroup='" + "A-" + "'", con);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
           // label12.Text = dt8.Rows[0][0].ToString();
            double AminusPercentage = (Convert.ToDouble(dt8.Rows[0][0].ToString()) / Bstock) * 100;
            bunifuCircleProgressbar4.Value = Convert.ToInt32(AminusPercentage);
            //B+
            SqlDataAdapter sda9 = new SqlDataAdapter("select Bstock from bloodtransfer where Bgroup='" + "B+" + "'", con);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
           // label13.Text = dt9.Rows[0][0].ToString();
            double BplusPercentage = (Convert.ToDouble(dt9.Rows[0][0].ToString()) / Bstock) * 100;
            bunifuCircleProgressbar5 .Value = Convert.ToInt32(BplusPercentage);
            //B-
            SqlDataAdapter sda10 = new SqlDataAdapter("select Bstock from bloodtransfer where Bgroup='" + "B-" + "'", con);
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
           // label14.Text = dt10.Rows[0][0].ToString();
            double BminusPercentage = (Convert.ToDouble(dt10.Rows[0][0].ToString()) / Bstock) * 100;
            bunifuCircleProgressbar6.Value = Convert.ToInt32(BminusPercentage);
            //AB+
            SqlDataAdapter sda11 = new SqlDataAdapter("select Bstock from bloodtransfer where Bgroup='" + "AB+" + "'", con);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
           // label15.Text = dt11.Rows[0][0].ToString();
            double ABplusPercentage = (Convert.ToDouble(dt11.Rows[0][0].ToString()) / Bstock) * 100;
            bunifuCircleProgressbar7.Value = Convert.ToInt32(ABplusPercentage);
            //AB-
            SqlDataAdapter sda12 = new SqlDataAdapter("select Bstock from bloodtransfer where Bgroup='" + "AB-" + "'", con);
            DataTable dt12 = new DataTable();
            sda12.Fill(dt12);
           // label16.Text = dt12.Rows[0][0].ToString();
            double ABminusPercentage = (Convert.ToDouble(dt12.Rows[0][0].ToString()) / Bstock) * 100;
            bunifuCircleProgressbar8.Value = Convert.ToInt32(ABminusPercentage);
            con.Close();
        }
        private void stats_Load(object sender, EventArgs e)
        {
            
            
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            Dashbord ds = new Dashbord();
            ds.Show();
            this.Hide();
        }
    }
}
