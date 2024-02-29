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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_lbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void forgot_password_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpassword fp = new Forgotpassword();
            fp.Show();
            Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(txt_uname.Text =="" || txt_pwd.Text =="")
            {
                MessageBox.Show("Must be full all the textbox");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["aromafood"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_userlogin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_uname.Text;
                    SqlParameter p2 = new SqlParameter("@pwd", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txt_pwd.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int i = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

                    if (i > 0)
                    {
                        MessageBox.Show("Successful Login");
                        HomePage hp = new HomePage();
                        hp.Show();
                        this.Hide();
                    }
                  
                    con.Close();


                }
                catch (Exception)
                {
                    MessageBox.Show("Failed");
                }

            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            txt_pwd.Clear();
            txt_uname.Clear();
        }

        private void login_to_reg_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
    }

}
