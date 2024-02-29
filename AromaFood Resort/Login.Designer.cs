namespace AromaFood_Resort
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_to_reg_lbl = new System.Windows.Forms.LinkLabel();
            this.check_account_lbl = new System.Windows.Forms.Label();
            this.forgot_password_lbl = new System.Windows.Forms.LinkLabel();
            this.minimize_lbl = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.pwd_lbl = new System.Windows.Forms.Label();
            this.uname_lbl = new System.Windows.Forms.Label();
            this.Selectrole_combox = new System.Windows.Forms.ComboBox();
            this.loginpg_lbl = new System.Windows.Forms.Label();
            this.txt_pwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_uname = new Guna.UI2.WinForms.Guna2TextBox();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.clear_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.login_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pwd_pic_box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.uname_pic_box = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwd_pic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uname_pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // login_to_reg_lbl
            // 
            this.login_to_reg_lbl.AutoSize = true;
            this.login_to_reg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_to_reg_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.login_to_reg_lbl.LinkColor = System.Drawing.Color.Blue;
            this.login_to_reg_lbl.Location = new System.Drawing.Point(538, 456);
            this.login_to_reg_lbl.Name = "login_to_reg_lbl";
            this.login_to_reg_lbl.Size = new System.Drawing.Size(152, 25);
            this.login_to_reg_lbl.TabIndex = 28;
            this.login_to_reg_lbl.TabStop = true;
            this.login_to_reg_lbl.Text = "Register Now";
            this.login_to_reg_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_to_reg_lbl_LinkClicked);
            // 
            // check_account_lbl
            // 
            this.check_account_lbl.AutoSize = true;
            this.check_account_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_account_lbl.Location = new System.Drawing.Point(302, 456);
            this.check_account_lbl.Name = "check_account_lbl";
            this.check_account_lbl.Size = new System.Drawing.Size(246, 25);
            this.check_account_lbl.TabIndex = 27;
            this.check_account_lbl.Text = "Don\'t have an Account? ";
            // 
            // forgot_password_lbl
            // 
            this.forgot_password_lbl.AutoSize = true;
            this.forgot_password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.forgot_password_lbl.Location = new System.Drawing.Point(351, 350);
            this.forgot_password_lbl.Name = "forgot_password_lbl";
            this.forgot_password_lbl.Size = new System.Drawing.Size(203, 24);
            this.forgot_password_lbl.TabIndex = 26;
            this.forgot_password_lbl.TabStop = true;
            this.forgot_password_lbl.Text = "Forgot your password?";
            this.forgot_password_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_password_lbl_LinkClicked);
            // 
            // minimize_lbl
            // 
            this.minimize_lbl.AutoSize = true;
            this.minimize_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.minimize_lbl.Location = new System.Drawing.Point(681, -1);
            this.minimize_lbl.Name = "minimize_lbl";
            this.minimize_lbl.Size = new System.Drawing.Size(31, 42);
            this.minimize_lbl.TabIndex = 25;
            this.minimize_lbl.Text = "-";
            this.minimize_lbl.Click += new System.EventHandler(this.minimize_lbl_Click);
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.ForeColor = System.Drawing.Color.Red;
            this.exit_lbl.Location = new System.Drawing.Point(710, 2);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(41, 39);
            this.exit_lbl.TabIndex = 24;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            // 
            // pwd_lbl
            // 
            this.pwd_lbl.AutoSize = true;
            this.pwd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pwd_lbl.Location = new System.Drawing.Point(308, 245);
            this.pwd_lbl.Name = "pwd_lbl";
            this.pwd_lbl.Size = new System.Drawing.Size(160, 33);
            this.pwd_lbl.TabIndex = 20;
            this.pwd_lbl.Text = "Password:";
            // 
            // uname_lbl
            // 
            this.uname_lbl.AutoSize = true;
            this.uname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uname_lbl.Location = new System.Drawing.Point(301, 136);
            this.uname_lbl.Name = "uname_lbl";
            this.uname_lbl.Size = new System.Drawing.Size(167, 33);
            this.uname_lbl.TabIndex = 21;
            this.uname_lbl.Text = "Username:";
            // 
            // Selectrole_combox
            // 
            this.Selectrole_combox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectrole_combox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Selectrole_combox.FormattingEnabled = true;
            this.Selectrole_combox.Items.AddRange(new object[] {
            "Admin"});
            this.Selectrole_combox.Location = new System.Drawing.Point(337, 86);
            this.Selectrole_combox.Name = "Selectrole_combox";
            this.Selectrole_combox.Size = new System.Drawing.Size(222, 33);
            this.Selectrole_combox.TabIndex = 19;
            this.Selectrole_combox.Text = "Select Role";
            // 
            // loginpg_lbl
            // 
            this.loginpg_lbl.AutoSize = true;
            this.loginpg_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginpg_lbl.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpg_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginpg_lbl.Location = new System.Drawing.Point(330, 21);
            this.loginpg_lbl.Name = "loginpg_lbl";
            this.loginpg_lbl.Size = new System.Drawing.Size(224, 42);
            this.loginpg_lbl.TabIndex = 18;
            this.loginpg_lbl.Text = "Login Page";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Animated = true;
            this.txt_pwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_pwd.BorderRadius = 10;
            this.txt_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pwd.DefaultText = "";
            this.txt_pwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pwd.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.txt_pwd.ForeColor = System.Drawing.Color.Black;
            this.txt_pwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pwd.Location = new System.Drawing.Point(366, 294);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_pwd.PlaceholderText = "Enter your password";
            this.txt_pwd.SelectedText = "";
            this.txt_pwd.Size = new System.Drawing.Size(214, 42);
            this.txt_pwd.TabIndex = 14;
            // 
            // txt_uname
            // 
            this.txt_uname.Animated = true;
            this.txt_uname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_uname.BorderRadius = 10;
            this.txt_uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_uname.DefaultText = "";
            this.txt_uname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_uname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_uname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_uname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_uname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_uname.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.txt_uname.ForeColor = System.Drawing.Color.Black;
            this.txt_uname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_uname.Location = new System.Drawing.Point(366, 192);
            this.txt_uname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.PasswordChar = '\0';
            this.txt_uname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_uname.PlaceholderText = "Enter your name";
            this.txt_uname.SelectedText = "";
            this.txt_uname.Size = new System.Drawing.Size(214, 43);
            this.txt_uname.TabIndex = 15;
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.ForeColor = System.Drawing.Color.White;
            this.welcome_lbl.Location = new System.Drawing.Point(53, 207);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(168, 31);
            this.welcome_lbl.TabIndex = 30;
            this.welcome_lbl.Text = "WELCOME ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "WELCOME ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 35);
            this.label2.TabIndex = 33;
            this.label2.Text = "TO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "AROMA FOOD";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-80, -48);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(345, 624);
            this.guna2CirclePictureBox1.TabIndex = 31;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // clear_btn
            // 
            this.clear_btn.ActiveBorderThickness = 1;
            this.clear_btn.ActiveCornerRadius = 20;
            this.clear_btn.ActiveFillColor = System.Drawing.Color.OliveDrab;
            this.clear_btn.ActiveForecolor = System.Drawing.Color.White;
            this.clear_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clear_btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_btn.BackgroundImage")));
            this.clear_btn.ButtonText = "Clear";
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clear_btn.IdleBorderThickness = 1;
            this.clear_btn.IdleCornerRadius = 20;
            this.clear_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clear_btn.IdleForecolor = System.Drawing.Color.White;
            this.clear_btn.IdleLineColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(444, 389);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(136, 50);
            this.clear_btn.TabIndex = 22;
            this.clear_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.ActiveBorderThickness = 1;
            this.login_btn.ActiveCornerRadius = 20;
            this.login_btn.ActiveFillColor = System.Drawing.Color.OliveDrab;
            this.login_btn.ActiveForecolor = System.Drawing.Color.White;
            this.login_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login_btn.BackColor = System.Drawing.SystemColors.Control;
            this.login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_btn.BackgroundImage")));
            this.login_btn.ButtonText = "Login";
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login_btn.IdleBorderThickness = 1;
            this.login_btn.IdleCornerRadius = 20;
            this.login_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login_btn.IdleForecolor = System.Drawing.Color.White;
            this.login_btn.IdleLineColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(287, 389);
            this.login_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(136, 50);
            this.login_btn.TabIndex = 23;
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pwd_pic_box
            // 
            this.pwd_pic_box.BackColor = System.Drawing.Color.Transparent;
            this.pwd_pic_box.FillColor = System.Drawing.Color.Black;
            this.pwd_pic_box.Image = global::AromaFood_Resort.Properties.Resources.password;
            this.pwd_pic_box.ImageRotate = 0F;
            this.pwd_pic_box.Location = new System.Drawing.Point(317, 294);
            this.pwd_pic_box.Name = "pwd_pic_box";
            this.pwd_pic_box.Size = new System.Drawing.Size(43, 42);
            this.pwd_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pwd_pic_box.TabIndex = 16;
            this.pwd_pic_box.TabStop = false;
            this.pwd_pic_box.UseTransparentBackground = true;
            // 
            // uname_pic_box
            // 
            this.uname_pic_box.BackColor = System.Drawing.Color.Transparent;
            this.uname_pic_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uname_pic_box.Image = global::AromaFood_Resort.Properties.Resources.username;
            this.uname_pic_box.ImageRotate = 0F;
            this.uname_pic_box.Location = new System.Drawing.Point(317, 182);
            this.uname_pic_box.Name = "uname_pic_box";
            this.uname_pic_box.Size = new System.Drawing.Size(43, 53);
            this.uname_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uname_pic_box.TabIndex = 17;
            this.uname_pic_box.TabStop = false;
            this.uname_pic_box.UseTransparentBackground = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 520);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.login_to_reg_lbl);
            this.Controls.Add(this.check_account_lbl);
            this.Controls.Add(this.forgot_password_lbl);
            this.Controls.Add(this.minimize_lbl);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pwd_lbl);
            this.Controls.Add(this.uname_lbl);
            this.Controls.Add(this.Selectrole_combox);
            this.Controls.Add(this.loginpg_lbl);
            this.Controls.Add(this.pwd_pic_box);
            this.Controls.Add(this.uname_pic_box);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwd_pic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uname_pic_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel login_to_reg_lbl;
        private System.Windows.Forms.Label check_account_lbl;
        private System.Windows.Forms.LinkLabel forgot_password_lbl;
        private System.Windows.Forms.Label minimize_lbl;
        private System.Windows.Forms.Label exit_lbl;
        private Bunifu.Framework.UI.BunifuThinButton2 clear_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 login_btn;
        private System.Windows.Forms.Label pwd_lbl;
        private System.Windows.Forms.Label uname_lbl;
        private System.Windows.Forms.ComboBox Selectrole_combox;
        private System.Windows.Forms.Label loginpg_lbl;
        private Guna.UI2.WinForms.Guna2PictureBox pwd_pic_box;
        private Guna.UI2.WinForms.Guna2PictureBox uname_pic_box;
        private Guna.UI2.WinForms.Guna2TextBox txt_pwd;
        private Guna.UI2.WinForms.Guna2TextBox txt_uname;
        private System.Windows.Forms.Label welcome_lbl;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}