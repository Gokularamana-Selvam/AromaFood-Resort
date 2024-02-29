using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AromaFood_Resort
{
    public partial class Food_Order : Form
    {
        public Food_Order()
        {
            InitializeComponent();
        }
        private void MovePanel(Control btn)
        {
            sidepanel.Top = btn.Top;
            sidepanel.Height = btn.Height;
        }

        private void dashbrd_btn_Click(object sender, EventArgs e)
        {
            MovePanel(dashbrd_btn);
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            MovePanel(room_btn);
        }

        private void client_btn_Click(object sender, EventArgs e)
        {
            MovePanel(client_btn);
            Customer cust = new Customer();
            cust.Show();
            this.Hide();
        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Reservation_btn);
            Reservation reserve = new Reservation();
            reserve.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            MovePanel(logout_btn);
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void menubar_pic_Click(object sender, EventArgs e)
        {
            if(panel1.Height==618 & panel1.Width == 270)
            {
                panel1.Height = 618;
                panel1.Width = 55;
                menubar_pic.Left =3;

            }
            else
            {
                panel1.Height = 618;
                panel1.Width =270;
                menubar_pic.Left =216;
            }
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_lbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addfood_btn_Click(object sender, EventArgs e)
        {
            if(txt_foodname.Text =="" || txt_price.Text =="" || txt_tips.Text == "")
            {
                MessageBox.Show("Must be enter all the textbox");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_addfood", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@food_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_foodname.Text;
                    SqlParameter p2 = new SqlParameter("@price", SqlDbType.Int);
                    cmd.Parameters.Add(p2).Value = txt_price.Text;
                    SqlParameter p3 = new SqlParameter("@tips", SqlDbType.Int);
                    cmd.Parameters.Add(p3).Value = txt_tips.Text;

                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Food Ordered Successful");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter values");
                }
            }
           
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (txt_foodname.Text == "" || txt_price.Text == "" || txt_tips.Text == "")
            {
                MessageBox.Show("Must be enter all the textbox");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_updatefood", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@food_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_foodname.Text;
                    SqlParameter p2 = new SqlParameter("@price", SqlDbType.Int);
                    cmd.Parameters.Add(p2).Value = txt_price.Text;
                    SqlParameter p3 = new SqlParameter("@tips", SqlDbType.Int);
                    cmd.Parameters.Add(p3).Value = txt_tips.Text;

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Food Order updated");
                    }
                    else
                    {
                        MessageBox.Show("Food Order no updated");
                    }
                    con.Close();


                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter values");
                }
            }
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (txt_foodname.Text == "" || txt_price.Text == "" || txt_tips.Text == "")
            {
                MessageBox.Show("Must be enter all the textbox");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_deletefood", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@food_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_foodname.Text;

                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Food Order Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter values");
                }
            }
           
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@food_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txt_foodname.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                guna2DataGridView1.DataSource = ds.Tables[0];
              

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter values");
            }
        }

        private void fetch_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_fetchfood", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                guna2DataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
