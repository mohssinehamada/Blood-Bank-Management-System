
namespace Blood_Bank_Management_System
{
    partial class Patientdetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patientdetails));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtADDress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtnum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchBloodDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.patientsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtcity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 542);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 159);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txtADDress
            // 
            this.txtADDress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtADDress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtADDress.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADDress.ForeColor = System.Drawing.Color.Black;
            this.txtADDress.HintForeColor = System.Drawing.Color.Empty;
            this.txtADDress.HintText = "";
            this.txtADDress.isPassword = false;
            this.txtADDress.LineFocusedColor = System.Drawing.Color.Pink;
            this.txtADDress.LineIdleColor = System.Drawing.Color.Black;
            this.txtADDress.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtADDress.LineThickness = 2;
            this.txtADDress.Location = new System.Drawing.Point(913, 293);
            this.txtADDress.Margin = new System.Windows.Forms.Padding(4);
            this.txtADDress.Name = "txtADDress";
            this.txtADDress.Size = new System.Drawing.Size(228, 73);
            this.txtADDress.TabIndex = 69;
            this.txtADDress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtphone
            // 
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.Font = new System.Drawing.Font("Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtphone.ForeColor = System.Drawing.Color.Black;
            this.txtphone.HintForeColor = System.Drawing.Color.Empty;
            this.txtphone.HintText = "";
            this.txtphone.isPassword = false;
            this.txtphone.LineFocusedColor = System.Drawing.Color.Pink;
            this.txtphone.LineIdleColor = System.Drawing.Color.Black;
            this.txtphone.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtphone.LineThickness = 2;
            this.txtphone.Location = new System.Drawing.Point(927, 213);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(228, 33);
            this.txtphone.TabIndex = 68;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HintForeColor = System.Drawing.Color.Empty;
            this.txtname.HintText = "";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.LightPink;
            this.txtname.LineIdleColor = System.Drawing.Color.Black;
            this.txtname.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtname.LineThickness = 2;
            this.txtname.Location = new System.Drawing.Point(311, 213);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(233, 33);
            this.txtname.TabIndex = 67;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtname.OnValueChanged += new System.EventHandler(this.txtname_OnValueChanged);
            // 
            // txtAge
            // 
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.Font = new System.Drawing.Font("Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.HintForeColor = System.Drawing.Color.Empty;
            this.txtAge.HintText = "";
            this.txtAge.isPassword = false;
            this.txtAge.LineFocusedColor = System.Drawing.Color.Pink;
            this.txtAge.LineIdleColor = System.Drawing.Color.Black;
            this.txtAge.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtAge.LineThickness = 2;
            this.txtAge.Location = new System.Drawing.Point(311, 310);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(53, 33);
            this.txtAge.TabIndex = 66;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.White;
            this.txtGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGender.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female "});
            this.txtGender.Location = new System.Drawing.Point(311, 405);
            this.txtGender.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(186, 30);
            this.txtGender.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(107, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 48);
            this.label2.TabIndex = 58;
            this.label2.Text = "Full Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(751, 293);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 48);
            this.label10.TabIndex = 62;
            this.label10.Text = "Adress :";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.BackColor = System.Drawing.Color.White;
            this.txtBloodGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBloodGroup.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodGroup.FormattingEnabled = true;
            this.txtBloodGroup.Items.AddRange(new object[] {
            "O-",
            "O+",
            "B-",
            "B+",
            "A-",
            "A+",
            "AB-",
            "AB+"});
            this.txtBloodGroup.Location = new System.Drawing.Point(927, 406);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(106, 30);
            this.txtBloodGroup.TabIndex = 64;
            // 
            // txtnum
            // 
            this.txtnum.AutoSize = true;
            this.txtnum.BackColor = System.Drawing.Color.Transparent;
            this.txtnum.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtnum.Location = new System.Drawing.Point(645, 198);
            this.txtnum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(263, 48);
            this.txtnum.TabIndex = 65;
            this.txtnum.Text = "Phone Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(679, 385);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 48);
            this.label8.TabIndex = 61;
            this.label8.Text = "Blood Group :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(194, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 48);
            this.label5.TabIndex = 59;
            this.label5.Text = "Age :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(141, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 48);
            this.label6.TabIndex = 60;
            this.label6.Text = "Gender :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(362, 74);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(518, 95);
            this.bunifuCustomLabel1.TabIndex = 72;
            this.bunifuCustomLabel1.Text = "Patients List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(927, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 2);
            this.panel1.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(311, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 2);
            this.panel2.TabIndex = 75;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.serchBloodDonorToolStripMenuItem,
            this.bloodTransferToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 56);
            this.menuStrip1.TabIndex = 76;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDonorsToolStripMenuItem,
            this.donorsDetailsToolStripMenuItem,
            this.donateToolStripMenuItem});
            this.donorToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(127, 52);
            this.donorToolStripMenuItem.Text = "Donor";
            // 
            // addDonorsToolStripMenuItem
            // 
            this.addDonorsToolStripMenuItem.Name = "addDonorsToolStripMenuItem";
            this.addDonorsToolStripMenuItem.Size = new System.Drawing.Size(338, 52);
            this.addDonorsToolStripMenuItem.Text = "Add Donors";
            this.addDonorsToolStripMenuItem.Click += new System.EventHandler(this.addDonorsToolStripMenuItem_Click);
            // 
            // donorsDetailsToolStripMenuItem
            // 
            this.donorsDetailsToolStripMenuItem.Name = "donorsDetailsToolStripMenuItem";
            this.donorsDetailsToolStripMenuItem.Size = new System.Drawing.Size(338, 52);
            this.donorsDetailsToolStripMenuItem.Text = "Donors Details";
            this.donorsDetailsToolStripMenuItem.Click += new System.EventHandler(this.donorsDetailsToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(338, 52);
            this.donateToolStripMenuItem.Text = "Donate";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientsToolStripMenuItem,
            this.patientsDetailsToolStripMenuItem});
            this.patientToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(142, 52);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // addPatientsToolStripMenuItem
            // 
            this.addPatientsToolStripMenuItem.Name = "addPatientsToolStripMenuItem";
            this.addPatientsToolStripMenuItem.Size = new System.Drawing.Size(353, 52);
            this.addPatientsToolStripMenuItem.Text = "Add Patients";
            this.addPatientsToolStripMenuItem.Click += new System.EventHandler(this.addPatientsToolStripMenuItem_Click);
            // 
            // serchBloodDonorToolStripMenuItem
            // 
            this.serchBloodDonorToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serchBloodDonorToolStripMenuItem.Name = "serchBloodDonorToolStripMenuItem";
            this.serchBloodDonorToolStripMenuItem.Size = new System.Drawing.Size(144, 52);
            this.serchBloodDonorToolStripMenuItem.Text = "Search ";
            this.serchBloodDonorToolStripMenuItem.Click += new System.EventHandler(this.serchBloodDonorToolStripMenuItem_Click);
            // 
            // bloodTransferToolStripMenuItem
            // 
            this.bloodTransferToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodTransferToolStripMenuItem.Name = "bloodTransferToolStripMenuItem";
            this.bloodTransferToolStripMenuItem.Size = new System.Drawing.Size(261, 52);
            this.bloodTransferToolStripMenuItem.Text = "Blood Transfer";
            this.bloodTransferToolStripMenuItem.Click += new System.EventHandler(this.bloodTransferToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(177, 52);
            this.dashboardToolStripMenuItem.Text = "Statistics";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.LightCoral;
            this.bunifuImageButton2.Image = global::Blood_Bank_Management_System.Properties.Resources.cross_small;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1165, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(76, 43);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 77;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 30;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.RosyBrown;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Update";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 35;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.Location = new System.Drawing.Point(993, 464);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(234, 64);
            this.bunifuThinButton22.TabIndex = 73;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 30;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.RosyBrown;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Delete";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 35;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(748, 464);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(222, 64);
            this.bunifuThinButton21.TabIndex = 70;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // patientsDetailsToolStripMenuItem
            // 
            this.patientsDetailsToolStripMenuItem.Name = "patientsDetailsToolStripMenuItem";
            this.patientsDetailsToolStripMenuItem.Size = new System.Drawing.Size(353, 52);
            this.patientsDetailsToolStripMenuItem.Text = "Patients Details";
            this.patientsDetailsToolStripMenuItem.Click += new System.EventHandler(this.patientsDetailsToolStripMenuItem_Click);
            // 
            // txtcity
            // 
            this.txtcity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcity.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.ForeColor = System.Drawing.Color.Black;
            this.txtcity.HintForeColor = System.Drawing.Color.Empty;
            this.txtcity.HintText = "";
            this.txtcity.isPassword = false;
            this.txtcity.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(164)))), ((int)(((byte)(197)))));
            this.txtcity.LineIdleColor = System.Drawing.Color.Black;
            this.txtcity.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtcity.LineThickness = 2;
            this.txtcity.Location = new System.Drawing.Point(281, 482);
            this.txtcity.Margin = new System.Windows.Forms.Padding(4);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(260, 33);
            this.txtcity.TabIndex = 91;
            this.txtcity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(170, 476);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 48);
            this.label3.TabIndex = 90;
            this.label3.Text = "City :";
            // 
            // Patientdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 713);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.txtADDress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patientdetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patientdetails";
            this.Load += new System.EventHandler(this.Patientdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtADDress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtphone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAge;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtBloodGroup;
        private System.Windows.Forms.Label txtnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDonorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchBloodDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodTransferToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsDetailsToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcity;
        private System.Windows.Forms.Label label3;
    }
}