using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AromaFood_Resort
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
          
        }

        

        private void StartPage_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(myprogress.Value < 100)
            {
                myprogress.Value += 1;
                timer_lbl.Text = myprogress.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
