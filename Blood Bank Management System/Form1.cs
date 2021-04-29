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
using System.Runtime.InteropServices;


namespace Blood_Bank_Management_System
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nwidthEllipse,
            int n
            );

        public Form1()
        {
            InitializeComponent();
        }

        LINQDataContext lq = new LINQDataContext();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O107CL\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True");
        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(btnHideShow.Text == "Show Password")
            {
                btnHideShow.Text = "Hide Password";
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show Password";
                TxtPassword.PasswordChar = '*';
            }

        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
           
            label3.Text = "Welcome";
            panel1.Visible = false;
            button6.Visible = false;
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 30, 30));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from signin where Username='" + txtUsername.Text + "' and  SPassword='" + TxtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0].ToString() == "1")
            {
                Dashbord ds = new Dashbord();
                ds.Show();
                this.Hide();
                
            }
            else
            {
                label9.Visible = true;
            }
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            signin s = new signin ();
            lq.signins.InsertOnSubmit(s);
            lq.SubmitChanges();
            MessageBox.Show("Your Account has been succesfully created", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void panel4_Click(object sender, EventArgs e)
        {
            label10.Text = "Abdelkrim_Tair/Mohssine_Hmada";
            label10.Visible = true;
            label12.Visible = false;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            label10.Text = "Abdelkrim Tair/Mohssine Hmada";
            label10.Visible = true;
            label12.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label12.Text = "0617586113/0690954313";
            label12.Visible = true;            
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void bunifuButton1_Click_3(object sender, EventArgs e)
        {
            var don = (from s in lq.signins where s.Username == txtUsername.Text && s.SPassword == TxtPassword.Text select s);
            if (don.Any())

            {
                this.Hide();
                Dashbord ds = new Dashbord();
                ds.Show();
            }
            else
            {
                label9.Visible = true;
            }
        }

    

        private void button2_Click_2(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "Login";
            panel1.Visible = true;
            button3.Visible = false;
            button2.Visible = false;
            panel1.Size = new Size(500, 300);
            label9.Visible = false;
            button6.Visible = true;
            label10.Visible = false;
            label11.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            label12.Visible = false;
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            adminlog am = new adminlog();
            am.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            label3.Text = "Welcome";
            button6.Visible = false;
            label10.Visible = true;
            label11.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            txtUsername.Clear();
            TxtPassword.Clear();
            label10.Visible = false;
            label12.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Enter(object sender, EventArgs e)
        {
          
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            var don = (from s in lq.signins where s.Username == txtUsername.Text && s.SPassword == TxtPassword.Text select s);
            if (don.Any())

            {
                this.Hide();
                Dashbord ds = new Dashbord();
                ds.Show();
            }
            else
            {
                label9.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
