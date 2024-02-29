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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if(txt_unameId.Text =="" || txt_uname.Text =="" || txt_pwd.Text =="" || txt_email.Text == "")
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
                    SqlCommand cmd = new SqlCommand("sp_newregisters", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@uname_id", SqlDbType.Int);
                    cmd.Parameters.Add(param1).Value = txt_unameId.Text;
                    SqlParameter param2 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = txt_uname.Text;
                    SqlParameter param3 = new SqlParameter("email_id", SqlDbType.VarChar);
                    cmd.Parameters.Add(param3).Value = txt_email.Text;
                    SqlParameter param4 = new SqlParameter("pwd", SqlDbType.VarChar);
                    cmd.Parameters.Add(param4).Value = txt_pwd.Text;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Successful Registered");

                    }
                    else
                    {
                        MessageBox.Show("Oh NO!");
                    }
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter valid datatype");
                }
            }
           

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            txt_uname.Clear();
            txt_pwd.Clear();
            txt_uname.Clear();
            txt_email.Clear();
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goto_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
