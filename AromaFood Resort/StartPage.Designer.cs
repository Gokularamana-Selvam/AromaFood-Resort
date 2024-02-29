namespace AromaFood_Resort
{
    partial class StartPage
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
            this.exit_lbl = new System.Windows.Forms.Label();
            this.city_lbl = new System.Windows.Forms.Label();
            this.food_lbl = new System.Windows.Forms.Label();
            this.loading_lbl = new System.Windows.Forms.Label();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.myprogress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.BackColor = System.Drawing.Color.Red;
            this.exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.ForeColor = System.Drawing.Color.White;
            this.exit_lbl.Location = new System.Drawing.Point(679, 9);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(33, 31);
            this.exit_lbl.TabIndex = 6;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_lbl.ForeColor = System.Drawing.Color.White;
            this.city_lbl.Location = new System.Drawing.Point(329, 65);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(125, 46);
            this.city_lbl.TabIndex = 4;
            this.city_lbl.Text = "Chennai";
            // 
            // food_lbl
            // 
            this.food_lbl.AutoSize = true;
            this.food_lbl.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_lbl.ForeColor = System.Drawing.Color.White;
            this.food_lbl.Location = new System.Drawing.Point(194, 24);
            this.food_lbl.Name = "food_lbl";
            this.food_lbl.Size = new System.Drawing.Size(407, 41);
            this.food_lbl.TabIndex = 5;
            this.food_lbl.Text = "AROMA FOOD RESORT";
            // 
            // loading_lbl
            // 
            this.loading_lbl.AutoSize = true;
            this.loading_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_lbl.ForeColor = System.Drawing.Color.White;
            this.loading_lbl.Location = new System.Drawing.Point(304, 346);
            this.loading_lbl.Name = "loading_lbl";
            this.loading_lbl.Size = new System.Drawing.Size(169, 37);
            this.loading_lbl.TabIndex = 8;
            this.loading_lbl.Text = "Loading...";
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.timer_lbl.Location = new System.Drawing.Point(358, 397);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(30, 31);
            this.timer_lbl.TabIndex = 10;
            this.timer_lbl.Text = "0";
            // 
            // myprogress
            // 
            this.myprogress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myprogress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.myprogress.Location = new System.Drawing.Point(0, 447);
            this.myprogress.Name = "myprogress";
            this.myprogress.ProgressColor = System.Drawing.Color.White;
            this.myprogress.ProgressColor2 = System.Drawing.Color.White;
            this.myprogress.Size = new System.Drawing.Size(724, 18);
            this.myprogress.TabIndex = 11;
            this.myprogress.Text = "guna2ProgressBar1";
            this.myprogress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AromaFood_Resort.Properties.Resources.foodimages;
            this.pictureBox1.Location = new System.Drawing.Point(234, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(724, 465);
            this.ControlBox = false;
            this.Controls.Add(this.myprogress);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.loading_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.city_lbl);
            this.Controls.Add(this.food_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label city_lbl;
        private System.Windows.Forms.Label food_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loading_lbl;
        private System.Windows.Forms.Label timer_lbl;
        private Guna.UI2.WinForms.Guna2ProgressBar myprogress;
        private System.Windows.Forms.Timer timer1;
    }
}

