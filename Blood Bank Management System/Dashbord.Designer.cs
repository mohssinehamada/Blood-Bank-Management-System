
namespace Blood_Bank_Management_System
{
    partial class Dashbord
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
            this.components = new System.ComponentModel.Container();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.serchBloodDonorToolStripMenuItem,
            this.bloodTransferToolStripMenuItem,
            this.dASHBOARDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1217, 56);
            this.menuStrip1.TabIndex = 3;
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
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(150, 52);
            this.donorToolStripMenuItem.Text = "DONOR";
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
            this.donorsDetailsToolStripMenuItem.Click += new System.EventHandler(this.donorsDetailsToolStripMenuItem_Click_1);
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
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(171, 52);
            this.patientToolStripMenuItem.Text = "PATIENT";
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
            this.patientDetailsToolStripMenuItem.Click += new System.EventHandler(this.patientDetailsToolStripMenuItem_Click_1);
            // 
            // serchBloodDonorToolStripMenuItem
            // 
            this.serchBloodDonorToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serchBloodDonorToolStripMenuItem.Name = "serchBloodDonorToolStripMenuItem";
            this.serchBloodDonorToolStripMenuItem.Size = new System.Drawing.Size(162, 52);
            this.serchBloodDonorToolStripMenuItem.Text = "SEARCH";
            this.serchBloodDonorToolStripMenuItem.Click += new System.EventHandler(this.serchBloodDonorToolStripMenuItem_Click);
            // 
            // bloodTransferToolStripMenuItem
            // 
            this.bloodTransferToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodTransferToolStripMenuItem.Name = "bloodTransferToolStripMenuItem";
            this.bloodTransferToolStripMenuItem.Size = new System.Drawing.Size(322, 52);
            this.bloodTransferToolStripMenuItem.Text = "BLOOD TRANSFER";
            this.bloodTransferToolStripMenuItem.Click += new System.EventHandler(this.bloodTransferToolStripMenuItem_Click);
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(215, 52);
            this.dASHBOARDToolStripMenuItem.Text = "STATISTICS";
            this.dASHBOARDToolStripMenuItem.Click += new System.EventHandler(this.dASHBOARDToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::Blood_Bank_Management_System.Properties.Resources.shutdown_80px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1147, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(70, 56);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Blood_Bank_Management_System.Properties.Resources._6262;
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1217, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1217, 737);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchBloodDonorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDonorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientsToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
    }
}