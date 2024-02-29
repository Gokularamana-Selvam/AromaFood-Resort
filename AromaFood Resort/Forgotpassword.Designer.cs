namespace AromaFood_Resort
{
    partial class Forgotpassword
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fguname = new Guna.UI2.WinForms.Guna2TextBox();
            this.getpwd_btn = new Guna.UI2.WinForms.Guna2Button();
            this.txt_fgpwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.goto_linklbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AromaFood_Resort.Properties.Resources.Forgotpassword2;
            this.pictureBox1.Location = new System.Drawing.Point(126, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txt_fguname
            // 
            this.txt_fguname.Animated = true;
            this.txt_fguname.BorderColor = System.Drawing.Color.Transparent;
            this.txt_fguname.BorderRadius = 5;
            this.txt_fguname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fguname.DefaultText = "";
            this.txt_fguname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fguname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fguname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fguname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fguname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fguname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_fguname.ForeColor = System.Drawing.Color.Black;
            this.txt_fguname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fguname.Location = new System.Drawing.Point(157, 225);
            this.txt_fguname.Margin = new System.Windows.Forms.Padding(5);
            this.txt_fguname.Name = "txt_fguname";
            this.txt_fguname.PasswordChar = '\0';
            this.txt_fguname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_fguname.PlaceholderText = "Enter your username";
            this.txt_fguname.SelectedText = "";
            this.txt_fguname.Size = new System.Drawing.Size(256, 41);
            this.txt_fguname.TabIndex = 2;
            // 
            // getpwd_btn
            // 
            this.getpwd_btn.BorderColor = System.Drawing.Color.Green;
            this.getpwd_btn.BorderRadius = 5;
            this.getpwd_btn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.getpwd_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.getpwd_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.getpwd_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.getpwd_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.getpwd_btn.FillColor = System.Drawing.Color.Green;
            this.getpwd_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getpwd_btn.ForeColor = System.Drawing.Color.White;
            this.getpwd_btn.Location = new System.Drawing.Point(196, 287);
            this.getpwd_btn.Name = "getpwd_btn";
            this.getpwd_btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.getpwd_btn.Size = new System.Drawing.Size(181, 37);
            this.getpwd_btn.TabIndex = 3;
            this.getpwd_btn.Text = "Get Password";
            this.getpwd_btn.Click += new System.EventHandler(this.getpwd_btn_Click);
            // 
            // txt_fgpwd
            // 
            this.txt_fgpwd.Animated = true;
            this.txt_fgpwd.BorderColor = System.Drawing.Color.Transparent;
            this.txt_fgpwd.BorderRadius = 5;
            this.txt_fgpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fgpwd.DefaultText = "";
            this.txt_fgpwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fgpwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fgpwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fgpwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fgpwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fgpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fgpwd.ForeColor = System.Drawing.Color.Black;
            this.txt_fgpwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fgpwd.Location = new System.Drawing.Point(157, 345);
            this.txt_fgpwd.Margin = new System.Windows.Forms.Padding(5);
            this.txt_fgpwd.Name = "txt_fgpwd";
            this.txt_fgpwd.PasswordChar = '\0';
            this.txt_fgpwd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_fgpwd.PlaceholderText = "Your password";
            this.txt_fgpwd.SelectedText = "";
            this.txt_fgpwd.Size = new System.Drawing.Size(256, 46);
            this.txt_fgpwd.TabIndex = 2;
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.BackColor = System.Drawing.Color.Red;
            this.exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.ForeColor = System.Drawing.Color.White;
            this.exit_lbl.Location = new System.Drawing.Point(565, 9);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(39, 37);
            this.exit_lbl.TabIndex = 4;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            // 
            // goto_linklbl
            // 
            this.goto_linklbl.AutoSize = true;
            this.goto_linklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goto_linklbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goto_linklbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.goto_linklbl.LinkColor = System.Drawing.Color.Black;
            this.goto_linklbl.Location = new System.Drawing.Point(350, 431);
            this.goto_linklbl.Name = "goto_linklbl";
            this.goto_linklbl.Size = new System.Drawing.Size(156, 31);
            this.goto_linklbl.TabIndex = 5;
            this.goto_linklbl.TabStop = true;
            this.goto_linklbl.Text = "Goto Login";
            this.goto_linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goto_linklbl_LinkClicked);
            // 
            // Forgotpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(618, 525);
            this.ControlBox = false;
            this.Controls.Add(this.goto_linklbl);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.getpwd_btn);
            this.Controls.Add(this.txt_fgpwd);
            this.Controls.Add(this.txt_fguname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Forgotpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_fguname;
        private Guna.UI2.WinForms.Guna2Button getpwd_btn;
        private Guna.UI2.WinForms.Guna2TextBox txt_fgpwd;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.LinkLabel goto_linklbl;
    }
}