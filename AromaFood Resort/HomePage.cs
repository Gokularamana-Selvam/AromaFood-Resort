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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void minimize_lbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MovePanel (Control btn)
        {
            sidepanel.Top = btn.Top;
            sidepanel.Height = btn.Height;
        }

        private void dashbrd_btn_Click(object sender, EventArgs e)
        {
            MovePanel(dashbrd_btn);
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            MovePanel(room_btn);
            Food_Order fo = new Food_Order();
            fo.Show();
            this.Hide();
        }

       

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Reservation_btn);
            Reservation reserve = new Reservation();
            reserve.Show();
            this.Hide();
        }

        private void client_btn_Click_1(object sender, EventArgs e)
        {
            MovePanel(client_btn);
            Customer cust = new Customer();
            cust.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            MovePanel(logout_btn);
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
