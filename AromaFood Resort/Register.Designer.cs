namespace AromaFood_Resort
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.register_lbl = new System.Windows.Forms.Label();
            this.goto_linklbl = new System.Windows.Forms.LinkLabel();
            this.txt_pwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_uname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_unameId = new Guna.UI2.WinForms.Guna2TextBox();
            this.pwd_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.uname_lbl = new System.Windows.Forms.Label();
            this.uid_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.submit_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.exit_lbl);
            this.panel1.Controls.Add(this.register_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 83);
            this.panel1.TabIndex = 0;
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.BackColor = System.Drawing.Color.Red;
            this.exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.ForeColor = System.Drawing.Color.White;
            this.exit_lbl.Location = new System.Drawing.Point(612, 9);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(39, 37);
            this.exit_lbl.TabIndex = 7;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.register_lbl.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.register_lbl.Location = new System.Drawing.Point(212, 25);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(270, 35);
            this.register_lbl.TabIndex = 1;
            this.register_lbl.Text = "Register Page";
            // 
            // goto_linklbl
            // 
            this.goto_linklbl.AutoSize = true;
            this.goto_linklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goto_linklbl.ForeColor = System.Drawing.Color.Black;
            this.goto_linklbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.goto_linklbl.LinkColor = System.Drawing.Color.Black;
            this.goto_linklbl.Location = new System.Drawing.Point(515, 503);
            this.goto_linklbl.Name = "goto_linklbl";
            this.goto_linklbl.Size = new System.Drawing.Size(98, 20);
            this.goto_linklbl.TabIndex = 15;
            this.goto_linklbl.TabStop = true;
            this.goto_linklbl.Text = "Goto Login";
            this.goto_linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goto_linklbl_LinkClicked);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Animated = true;
            this.txt_pwd.BorderColor = System.Drawing.Color.Gray;
            this.txt_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pwd.DefaultText = "";
            this.txt_pwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pwd.ForeColor = System.Drawing.Color.Black;
            this.txt_pwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pwd.Location = new System.Drawing.Point(452, 388);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '\0';
            this.txt_pwd.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_pwd.PlaceholderText = "Enter password";
            this.txt_pwd.SelectedText = "";
            this.txt_pwd.Size = new System.Drawing.Size(173, 29);
            this.txt_pwd.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Animated = true;
            this.txt_email.BorderColor = System.Drawing.Color.Gray;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(452, 305);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_email.PlaceholderText = "Enter your email";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(173, 31);
            this.txt_email.TabIndex = 10;
            // 
            // txt_uname
            // 
            this.txt_uname.Animated = true;
            this.txt_uname.BorderColor = System.Drawing.Color.Gray;
            this.txt_uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_uname.DefaultText = "";
            this.txt_uname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_uname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_uname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_uname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_uname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_uname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_uname.ForeColor = System.Drawing.Color.Black;
            this.txt_uname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_uname.Location = new System.Drawing.Point(452, 218);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.PasswordChar = '\0';
            this.txt_uname.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_uname.PlaceholderText = "Enter your name";
            this.txt_uname.SelectedText = "";
            this.txt_uname.Size = new System.Drawing.Size(173, 29);
            this.txt_uname.TabIndex = 11;
            // 
            // txt_unameId
            // 
            this.txt_unameId.Animated = true;
            this.txt_unameId.BorderColor = System.Drawing.Color.Gray;
            this.txt_unameId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_unameId.DefaultText = "";
            this.txt_unameId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_unameId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_unameId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_unameId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_unameId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_unameId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_unameId.ForeColor = System.Drawing.Color.Black;
            this.txt_unameId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_unameId.Location = new System.Drawing.Point(452, 135);
            this.txt_unameId.Name = "txt_unameId";
            this.txt_unameId.PasswordChar = '\0';
            this.txt_unameId.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_unameId.PlaceholderText = "Enter Id";
            this.txt_unameId.SelectedText = "";
            this.txt_unameId.Size = new System.Drawing.Size(173, 29);
            this.txt_unameId.TabIndex = 12;
            // 
            // pwd_lbl
            // 
            this.pwd_lbl.AutoSize = true;
            this.pwd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pwd_lbl.Location = new System.Drawing.Point(406, 351);
            this.pwd_lbl.Name = "pwd_lbl";
            this.pwd_lbl.Size = new System.Drawing.Size(106, 24);
            this.pwd_lbl.TabIndex = 5;
            this.pwd_lbl.Text = "Password:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.email_lbl.Location = new System.Drawing.Point(400, 260);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(91, 24);
            this.email_lbl.TabIndex = 6;
            this.email_lbl.Text = "Email Id:";
            // 
            // uname_lbl
            // 
            this.uname_lbl.AutoSize = true;
            this.uname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uname_lbl.Location = new System.Drawing.Point(400, 178);
            this.uname_lbl.Name = "uname_lbl";
            this.uname_lbl.Size = new System.Drawing.Size(120, 24);
            this.uname_lbl.TabIndex = 7;
            this.uname_lbl.Text = "User Name:";
            // 
            // uid_lbl
            // 
            this.uid_lbl.AutoSize = true;
            this.uid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uid_lbl.Location = new System.Drawing.Point(400, 99);
            this.uid_lbl.Name = "uid_lbl";
            this.uid_lbl.Size = new System.Drawing.Size(82, 24);
            this.uid_lbl.TabIndex = 8;
            this.uid_lbl.Text = "User Id:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 449);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AromaFood_Resort.Properties.Resources.foodreg;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.ActiveBorderThickness = 1;
            this.cancel_btn.ActiveCornerRadius = 20;
            this.cancel_btn.ActiveFillColor = System.Drawing.Color.Olive;
            this.cancel_btn.ActiveForecolor = System.Drawing.Color.White;
            this.cancel_btn.ActiveLineColor = System.Drawing.Color.Olive;
            this.cancel_btn.BackColor = System.Drawing.Color.Silver;
            this.cancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_btn.BackgroundImage")));
            this.cancel_btn.ButtonText = "Cancel";
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.IdleBorderThickness = 1;
            this.cancel_btn.IdleCornerRadius = 20;
            this.cancel_btn.IdleFillColor = System.Drawing.Color.Red;
            this.cancel_btn.IdleForecolor = System.Drawing.Color.White;
            this.cancel_btn.IdleLineColor = System.Drawing.Color.Silver;
            this.cancel_btn.Location = new System.Drawing.Point(533, 435);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(92, 49);
            this.cancel_btn.TabIndex = 13;
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.ActiveBorderThickness = 1;
            this.submit_btn.ActiveCornerRadius = 20;
            this.submit_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.submit_btn.ActiveForecolor = System.Drawing.Color.Black;
            this.submit_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.submit_btn.BackColor = System.Drawing.Color.Silver;
            this.submit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit_btn.BackgroundImage")));
            this.submit_btn.ButtonText = "Submit";
            this.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.Color.White;
            this.submit_btn.IdleBorderThickness = 1;
            this.submit_btn.IdleCornerRadius = 20;
            this.submit_btn.IdleFillColor = System.Drawing.Color.DarkGreen;
            this.submit_btn.IdleForecolor = System.Drawing.Color.White;
            this.submit_btn.IdleLineColor = System.Drawing.Color.Silver;
            this.submit_btn.Location = new System.Drawing.Point(420, 435);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(92, 49);
            this.submit_btn.TabIndex = 14;
            this.submit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(663, 532);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.goto_linklbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.uid_lbl);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.uname_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.pwd_lbl);
            this.Controls.Add(this.txt_unameId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label register_lbl;
        private System.Windows.Forms.LinkLabel goto_linklbl;
        private Bunifu.Framework.UI.BunifuThinButton2 cancel_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 submit_btn;
        private Guna.UI2.WinForms.Guna2TextBox txt_pwd;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_uname;
        private Guna.UI2.WinForms.Guna2TextBox txt_unameId;
        private System.Windows.Forms.Label pwd_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label uname_lbl;
        private System.Windows.Forms.Label uid_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit_lbl;
    }
}