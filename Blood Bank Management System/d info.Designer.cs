
namespace Blood_Bank_Management_System
{
    partial class d_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(d_info));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDmobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDbgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btndelete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtDid,
            this.txtDname,
            this.txtDage,
            this.txtDmobile,
            this.txtDgender,
            this.txtDbgroup,
            this.txtDaddress,
            this.txtDcity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(21, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 332);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // txtDid
            // 
            this.txtDid.DataPropertyName = "Did";
            this.txtDid.HeaderText = "Did";
            this.txtDid.MinimumWidth = 6;
            this.txtDid.Name = "txtDid";
            this.txtDid.Width = 125;
            // 
            // txtDname
            // 
            this.txtDname.DataPropertyName = "Dname";
            this.txtDname.HeaderText = "Dname";
            this.txtDname.MinimumWidth = 6;
            this.txtDname.Name = "txtDname";
            this.txtDname.Width = 125;
            // 
            // txtDage
            // 
            this.txtDage.DataPropertyName = "Dage";
            this.txtDage.HeaderText = "Dage";
            this.txtDage.MinimumWidth = 6;
            this.txtDage.Name = "txtDage";
            this.txtDage.Width = 125;
            // 
            // txtDmobile
            // 
            this.txtDmobile.DataPropertyName = "Dmobile";
            this.txtDmobile.HeaderText = "Dmobile";
            this.txtDmobile.MinimumWidth = 6;
            this.txtDmobile.Name = "txtDmobile";
            this.txtDmobile.Width = 125;
            // 
            // txtDgender
            // 
            this.txtDgender.DataPropertyName = "Dgender";
            this.txtDgender.HeaderText = "Dgender";
            this.txtDgender.MinimumWidth = 6;
            this.txtDgender.Name = "txtDgender";
            this.txtDgender.Width = 125;
            // 
            // txtDbgroup
            // 
            this.txtDbgroup.DataPropertyName = "Dbgroup";
            this.txtDbgroup.HeaderText = "Dbgroup";
            this.txtDbgroup.MinimumWidth = 6;
            this.txtDbgroup.Name = "txtDbgroup";
            this.txtDbgroup.Width = 125;
            // 
            // txtDaddress
            // 
            this.txtDaddress.DataPropertyName = "Daddress";
            this.txtDaddress.HeaderText = "Daddress";
            this.txtDaddress.MinimumWidth = 6;
            this.txtDaddress.Name = "txtDaddress";
            this.txtDaddress.Width = 125;
            // 
            // txtDcity
            // 
            this.txtDcity.DataPropertyName = "Dcity";
            this.txtDcity.HeaderText = "Dcity";
            this.txtDcity.MinimumWidth = 6;
            this.txtDcity.Name = "txtDcity";
            this.txtDcity.Width = 125;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(352, 74);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(472, 95);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "Donors List";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtname.ForeColor = System.Drawing.Color.Maroon;
            this.txtname.HintForeColor = System.Drawing.Color.Empty;
            this.txtname.HintText = "";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(164)))), ((int)(((byte)(197)))));
            this.txtname.LineIdleColor = System.Drawing.Color.Red;
            this.txtname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtname.LineThickness = 2;
            this.txtname.Location = new System.Drawing.Point(188, 172);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(55, 33);
            this.txtname.TabIndex = 38;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtname.OnValueChanged += new System.EventHandler(this.txtname_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(15, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 43);
            this.label2.TabIndex = 37;
            this.label2.Text = "Donor ID :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.bloodTransferToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 56);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDonorToolStripMenuItem,
            this.donorsDetailsToolStripMenuItem,
            this.donateToolStripMenuItem});
            this.donorToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(127, 52);
            this.donorToolStripMenuItem.Text = "Donor";
            // 
            // addDonorToolStripMenuItem
            // 
            this.addDonorToolStripMenuItem.Name = "addDonorToolStripMenuItem";
            this.addDonorToolStripMenuItem.Size = new System.Drawing.Size(338, 52);
            this.addDonorToolStripMenuItem.Text = "Add Donor";
            this.addDonorToolStripMenuItem.Click += new System.EventHandler(this.addDonorToolStripMenuItem_Click);
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
            this.patientToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(142, 52);
            this.patientToolStripMenuItem.Text = "Patient";
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
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(135, 52);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // bloodTransferToolStripMenuItem
            // 
            this.bloodTransferToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodTransferToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.bloodTransferToolStripMenuItem.Name = "bloodTransferToolStripMenuItem";
            this.bloodTransferToolStripMenuItem.Size = new System.Drawing.Size(230, 52);
            this.bloodTransferToolStripMenuItem.Text = "Blood transfer";
            this.bloodTransferToolStripMenuItem.Click += new System.EventHandler(this.bloodTransferToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(177, 52);
            this.dashboardToolStripMenuItem.Text = "Statistics";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.LightCoral;
            this.bunifuImageButton1.ErrorImage = null;
            this.bunifuImageButton1.Image = global::Blood_Bank_Management_System.Properties.Resources.cross_small;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1056, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(96, 47);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 41;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // Btndelete
            // 
            this.Btndelete.ActiveBorderThickness = 1;
            this.Btndelete.ActiveCornerRadius = 30;
            this.Btndelete.ActiveFillColor = System.Drawing.Color.RosyBrown;
            this.Btndelete.ActiveForecolor = System.Drawing.Color.Black;
            this.Btndelete.ActiveLineColor = System.Drawing.Color.Maroon;
            this.Btndelete.BackColor = System.Drawing.Color.White;
            this.Btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btndelete.BackgroundImage")));
            this.Btndelete.ButtonText = "Delete";
            this.Btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndelete.ForeColor = System.Drawing.Color.Black;
            this.Btndelete.IdleBorderThickness = 1;
            this.Btndelete.IdleCornerRadius = 35;
            this.Btndelete.IdleFillColor = System.Drawing.Color.White;
            this.Btndelete.IdleForecolor = System.Drawing.Color.Maroon;
            this.Btndelete.IdleLineColor = System.Drawing.Color.Black;
            this.Btndelete.Location = new System.Drawing.Point(891, 146);
            this.Btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(231, 63);
            this.Btndelete.TabIndex = 84;
            this.Btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // d_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 575);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "d_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d_info";
            this.Load += new System.EventHandler(this.d_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodTransferToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDid;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDbgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDcity;
        private Bunifu.Framework.UI.BunifuThinButton2 Btndelete;
    }
}