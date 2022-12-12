using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yien_Express
{
    public partial class Register : Form
    {
        localhost.YienExpressWebService ye = new localhost.YienExpressWebService();

        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ccname = txtCompanyName.Text;
                int cccontact = Convert.ToInt32(txtContact.Text);
                string ccaddress = txtAddress.Text;
                string ccusername = txtUsername.Text;
                string ccpassword = txtPassword.Text;

                if (ye.insertCorporateClients(ccname, cccontact, ccaddress, ccusername, ccpassword) > 0)
                {
                    MessageBox.Show("Data Added!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                Clear();
            }
        }

        public void Clear()
        {
            //txtNCID.Clear();
            txtCompanyName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
