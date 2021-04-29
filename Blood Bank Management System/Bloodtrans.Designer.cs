
namespace Blood_Bank_Management_System
{
    partial class Bloodtrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloodtrans));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Patientcb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpbgroupe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtpname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.availablelb = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchBloodDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.transbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(477, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 4);
            this.panel2.TabIndex = 78;
            // 
            // Patientcb
            // 
            this.Patientcb.BackColor = System.Drawing.Color.White;
            this.Patientcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patientcb.Font = new System.Drawing.Font("Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Patientcb.FormattingEnabled = true;
            this.Patientcb.Items.AddRange(new object[] {
            "Male",
            "Female ",
            "Attack Helicopter"});
            this.Patientcb.Location = new System.Drawing.Point(477, 32);
            this.Patientcb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Patientcb.Name = "Patientcb";
            this.Patientcb.Size = new System.Drawing.Size(98, 36);
            this.Patientcb.TabIndex = 77;
            this.Patientcb.SelectedIndexChanged += new System.EventHandler(this.Patientcb_SelectedIndexChanged_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(269, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 48);
            this.label6.TabIndex = 76;
            this.label6.Text = "Patient Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(665, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 48);
            this.label1.TabIndex = 82;
            this.label1.Text = "Blood Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 48);
            this.label2.TabIndex = 81;
            this.label2.Text = "Full Name :";
            // 
            // txtpbgroupe
            // 
            this.txtpbgroupe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpbgroupe.Enabled = false;
            this.txtpbgroupe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpbgroupe.ForeColor = System.Drawing.Color.Black;
            this.txtpbgroupe.HintForeColor = System.Drawing.Color.Empty;
            this.txtpbgroupe.HintText = "";
            this.txtpbgroupe.isPassword = false;
            this.txtpbgroupe.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(164)))), ((int)(((byte)(197)))));
            this.txtpbgroupe.LineIdleColor = System.Drawing.Color.Black;
            this.txtpbgroupe.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtpbgroupe.LineThickness = 3;
            this.txtpbgroupe.Location = new System.Drawing.Point(885, 135);
            this.txtpbgroupe.Margin = new System.Windows.Forms.Padding(4);
            this.txtpbgroupe.Name = "txtpbgroupe";
            this.txtpbgroupe.Size = new System.Drawing.Size(51, 35);
            this.txtpbgroupe.TabIndex = 80;
            this.txtpbgroupe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpname
            // 
            this.txtpname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpname.Enabled = false;
            this.txtpname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.ForeColor = System.Drawing.Color.Black;
            this.txtpname.HintForeColor = System.Drawing.Color.Empty;
            this.txtpname.HintText = "";
            this.txtpname.isPassword = false;
            this.txtpname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(164)))), ((int)(((byte)(197)))));
            this.txtpname.LineIdleColor = System.Drawing.Color.Black;
            this.txtpname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtpname.LineThickness = 2;
            this.txtpname.Location = new System.Drawing.Point(239, 135);
            this.txtpname.Margin = new System.Windows.Forms.Padding(4);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(246, 35);
            this.txtpname.TabIndex = 79;
            this.txtpname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // availablelb
            // 
            this.availablelb.AutoSize = true;
            this.availablelb.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablelb.Location = new System.Drawing.Point(145, 243);
            this.availablelb.Name = "availablelb";
            this.availablelb.Size = new System.Drawing.Size(324, 41);
            this.availablelb.TabIndex = 84;
            this.availablelb.Text = "bunifuCustomLabel1";
            this.availablelb.Visible = false;
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
            this.dASHBOARDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 56);
            this.menuStrip1.TabIndex = 85;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientsToolStripMenuItem,
            this.patientDetailsToolStripMenuItem});
            this.patientToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(142, 52);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // addPatientsToolStripMenuItem
            // 
            this.addPatientsToolStripMenuItem.Name = "addPatientsToolStripMenuItem";
            this.addPatientsToolStripMenuItem.Size = new System.Drawing.Size(349, 52);
            this.addPatientsToolStripMenuItem.Text = "Add Patients";
            this.addPatientsToolStripMenuItem.Click += new System.EventHandler(this.addPatientsToolStripMenuItem_Click);
            // 
            // patientDetailsToolStripMenuItem
            // 
            this.patientDetailsToolStripMenuItem.Name = "patientDetailsToolStripMenuItem";
            this.patientDetailsToolStripMenuItem.Size = new System.Drawing.Size(349, 52);
            this.patientDetailsToolStripMenuItem.Text = "Patients details";
            this.patientDetailsToolStripMenuItem.Click += new System.EventHandler(this.patientDetailsToolStripMenuItem_Click);
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
            this.bloodTransferToolStripMenuItem.Size = new System.Drawing.Size(253, 52);
            this.bloodTransferToolStripMenuItem.Text = "Blood transfer";
            this.bloodTransferToolStripMenuItem.Click += new System.EventHandler(this.bloodTransferToolStripMenuItem_Click);
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(177, 52);
            this.dASHBOARDToolStripMenuItem.Text = "Statistics";
            this.dASHBOARDToolStripMenuItem.Click += new System.EventHandler(this.dASHBOARDToolStripMenuItem_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Brown;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(337, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(399, 95);
            this.bunifuCustomLabel1.TabIndex = 87;
            this.bunifuCustomLabel1.Text = "Transfers";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::Blood_Bank_Management_System.Properties.Resources.icons8_don_de_sang_100;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(749, 66);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(114, 89);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 88;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // transbtn
            // 
            this.transbtn.ActiveBorderThickness = 1;
            this.transbtn.ActiveCornerRadius = 30;
            this.transbtn.ActiveFillColor = System.Drawing.Color.RosyBrown;
            this.transbtn.ActiveForecolor = System.Drawing.Color.Black;
            this.transbtn.ActiveLineColor = System.Drawing.Color.Maroon;
            this.transbtn.BackColor = System.Drawing.Color.White;
            this.transbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transbtn.BackgroundImage")));
            this.transbtn.ButtonText = "Transfer";
            this.transbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transbtn.ForeColor = System.Drawing.Color.Black;
            this.transbtn.IdleBorderThickness = 1;
            this.transbtn.IdleCornerRadius = 35;
            this.transbtn.IdleFillColor = System.Drawing.Color.White;
            this.transbtn.IdleForecolor = System.Drawing.Color.Maroon;
            this.transbtn.IdleLineColor = System.Drawing.Color.Black;
            this.transbtn.Location = new System.Drawing.Point(633, 243);
            this.transbtn.Margin = new System.Windows.Forms.Padding(5);
            this.transbtn.Name = "transbtn";
            this.transbtn.Size = new System.Drawing.Size(243, 69);
            this.transbtn.TabIndex = 83;
            this.transbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transbtn.Visible = false;
            this.transbtn.Click += new System.EventHandler(this.transbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(365, 290);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(441, 278);
            this.dataGridView2.TabIndex = 90;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.LightCoral;
            this.bunifuImageButton2.Image = global::Blood_Bank_Management_System.Properties.Resources.shutdown_80px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1032, -1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(70, 56);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 91;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(584, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 353);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood transfered";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(126, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 356);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blood Stock";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Patientcb);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.txtpname);
            this.groupBox3.Controls.Add(this.txtpbgroupe);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.transbtn);
            this.groupBox3.Controls.Add(this.availablelb);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(76, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(992, 336);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Blood Transfer";
            // 
            // Bloodtrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 868);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bloodtrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloodtrans";
            this.Load += new System.EventHandler(this.Bloodtrans_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Patientcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpbgroupe;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpname;
        private Bunifu.Framework.UI.BunifuThinButton2 transbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel availablelb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDonorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchBloodDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}