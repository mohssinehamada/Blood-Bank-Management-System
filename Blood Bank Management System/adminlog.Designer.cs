
namespace Blood_Bank_Management_System
{
    partial class adminlog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminlog));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlog = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.button6)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Javanese Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(180, -11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(230, 136);
            this.bunifuCustomLabel1.TabIndex = 79;
            this.bunifuCustomLabel1.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 84;
            this.label1.Text = "Password :";
            // 
            // btnlog
            // 
            this.btnlog.ActiveBorderThickness = 1;
            this.btnlog.ActiveCornerRadius = 30;
            this.btnlog.ActiveFillColor = System.Drawing.Color.RosyBrown;
            this.btnlog.ActiveForecolor = System.Drawing.Color.Black;
            this.btnlog.ActiveLineColor = System.Drawing.Color.Maroon;
            this.btnlog.BackColor = System.Drawing.Color.White;
            this.btnlog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlog.BackgroundImage")));
            this.btnlog.ButtonText = "LOGIN";
            this.btnlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.Black;
            this.btnlog.IdleBorderThickness = 1;
            this.btnlog.IdleCornerRadius = 35;
            this.btnlog.IdleFillColor = System.Drawing.Color.White;
            this.btnlog.IdleForecolor = System.Drawing.Color.Maroon;
            this.btnlog.IdleLineColor = System.Drawing.Color.Black;
            this.btnlog.Location = new System.Drawing.Point(187, 227);
            this.btnlog.Margin = new System.Windows.Forms.Padding(5);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(223, 65);
            this.btnlog.TabIndex = 86;
            this.btnlog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Image = global::Blood_Bank_Management_System.Properties.Resources._50;
            this.button6.ImageActive = null;
            this.button6.Location = new System.Drawing.Point(460, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 63);
            this.button6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button6.TabIndex = 87;
            this.button6.TabStop = false;
            this.button6.Zoom = 10;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Maroon;
            this.txtpassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtpassword.HintText = "";
            this.txtpassword.isPassword = true;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtpassword.LineIdleColor = System.Drawing.Color.Salmon;
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtpassword.LineThickness = 2;
            this.txtpassword.Location = new System.Drawing.Point(214, 159);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(223, 35);
            this.txtpassword.TabIndex = 88;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adminlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 328);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminlog";
            this.Load += new System.EventHandler(this.adminlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnlog;
        private Bunifu.Framework.UI.BunifuImageButton button6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpassword;
    }
}