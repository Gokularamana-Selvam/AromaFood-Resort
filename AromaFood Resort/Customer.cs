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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void menubar_pic_Click(object sender, EventArgs e)
        {
            if(panel1.Height==618 & panel1.Width == 270)
            {
                panel1.Height = 618;
                panel1.Width = 56;
                menubar_pic.Left = 3;
            }
            else
            {
                panel1.Height = 618;
                panel1.Width = 270;
                menubar_pic.Left = 216;
            }
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
            Food_Order fo = new Food_Order();
            fo.Show();
            this.Hide();
        }

        private void client_btn_Click(object sender, EventArgs e)
        {
            MovePanel(client_btn);
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

        private void minimize_lbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void addcustomer_btn_Click(object sender, EventArgs e)
        {
            if(txt_customername.Text =="" || txt_age.Text =="" || txt_address.Text =="" || txt_phone.Text == "")
            {
                MessageBox.Show("Must be enter values for each textbox");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_addcustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@cust_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_customername.Text;
                    SqlParameter p2 = new SqlParameter("@age", SqlDbType.Int);
                    cmd.Parameters.Add(p2).Value = txt_age.Text;
                    SqlParameter p3 = new SqlParameter("@ph_num", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = txt_phone.Text;
                    SqlParameter p4 = new SqlParameter("@address", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = txt_address.Text;


                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Customer added Successful");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (txt_customername.Text == "" || txt_age.Text == "" || txt_address.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show("Must be enter values for each textbox");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_updatecustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@cust_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_customername.Text;
                    SqlParameter p2 = new SqlParameter("@age", SqlDbType.Int);
                    cmd.Parameters.Add(p2).Value = txt_age.Text;
                    SqlParameter p3 = new SqlParameter("@ph_num", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = txt_phone.Text;
                    SqlParameter p4 = new SqlParameter("@address", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = txt_address.Text;

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Customer  updated Successful");
                    }
                    else
                    {
                        MessageBox.Show("Customer details no updated");
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
            if (txt_customername.Text == "" || txt_age.Text == "" || txt_address.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show("Must be enter values for each textbox");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_deletecustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@cust_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_customername.Text;

                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Customer details Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Customer details not deleted");
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
                SqlCommand cmd = new SqlCommand("sp_searchcustomers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@cust_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txt_customername.Text;
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
                SqlCommand cmd = new SqlCommand("sp_fetchcustomers", con);
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
    }
}
