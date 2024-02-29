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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void menubar_pic_Click(object sender, EventArgs e)
        {
            if(panel1.Height==614 & panel1.Width==270)
            {
                panel1.Height = 614;
                panel1.Width = 57;
                menubar_pic.Left = 3;
            }
            else
            {
                panel1.Height = 614;
                panel1.Width = 270;
                menubar_pic.Left = 212;
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
            Customer cust = new Customer();
            cust.Show();
            this.Hide();
        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Reservation_btn);
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_lbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addreserved_btn_Click(object sender, EventArgs e)
        {
            if(txt_tablenum.Text ==""|| txt_data.Text =="" || txt_location.Text =="" || txt_custname.Text == "")
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
                    SqlCommand cmd = new SqlCommand("sp_addreserve", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@table_num", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_tablenum.Text;
                    SqlParameter p2 = new SqlParameter("@date", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txt_data.Text;
                    SqlParameter p3 = new SqlParameter("@cust_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = txt_custname.Text;
                    SqlParameter p4 = new SqlParameter("@location", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = txt_location.Text;


                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Reservation Booked");
                    }
                   
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Reservation Failed");
                }
            }
           
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (txt_tablenum.Text == "" || txt_data.Text == "" || txt_location.Text == "" || txt_custname.Text == "")
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
                    SqlCommand cmd = new SqlCommand("sp_updatereserve", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@table_num", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_tablenum.Text;
                    SqlParameter p2 = new SqlParameter("@date", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txt_data.Text;
                    SqlParameter p3 = new SqlParameter("@cust_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = txt_custname.Text;
                    SqlParameter p4 = new SqlParameter("@location", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = txt_location.Text;


                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Reservation Updated");
                    }
                   
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Reservation not Updated");
                }
            }
           
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (txt_tablenum.Text == "" || txt_data.Text == "" || txt_location.Text == "" || txt_custname.Text == "")
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
                    SqlCommand cmd = new SqlCommand("sp_deletereserve", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@table_num", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_tablenum.Text;

                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Reservation  Deleted");
                    }
                    
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Reservation not deleted");
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
                SqlCommand cmd = new SqlCommand("sp_searchreserve", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@table_num", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txt_tablenum.Text;
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

        private void Showdata_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_fetchreservation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception)
            {
                MessageBox.Show("Please enter values");
            }
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
