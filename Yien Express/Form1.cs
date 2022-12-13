using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yien_Express
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("server = DESKTOP-C3CU2KB\\SQLEXPRESS; Database=db_Yien_Express; Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.TextLength == 0 || txtPassword.TextLength == 0)
                {
                    MessageBox.Show("Please enter your Username or Password");
                }
                else
                {
                    string UserName = txtUsername.Text;
                    string Password = txtPassword.Text;

                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM tbl_CorporateClientApprove WHERE ccusername='" + txtUsername.Text + "' AND ccpassword='" + txtPassword.Text + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        this.Hide();
                        Transfer MR = new Transfer();
                        MR.Show();
                    }
                    else if (UserName=="Admin" && Password=="1234")
                    {
                        this.Hide();
                        AdminInterface MR = new AdminInterface();
                        MR.Show();
                    }
                    else if (UserName=="Rec" && Password=="Rec123")
                    {
                        this.Hide();
                        Recieve MR = new Recieve();
                        MR.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login please check username and password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register MR = new Register();
            MR.Show();
        }
    }
}
