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
    public partial class ClientRequests : Form
    {
        localhost.YienExpressWebService ye = new localhost.YienExpressWebService();

        public ClientRequests()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ClientRequests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Yien_ExpressDataSet1.tbl_CorporateClientRequest' table. You can move, or remove it, as needed.
            this.tbl_CorporateClientRequestTableAdapter.Fill(this.db_Yien_ExpressDataSet1.tbl_CorporateClientRequest);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int ccid = Convert.ToInt32(txtCCID.Text);
                DataSet ds = ye.findCorporateClients(ccid);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtCCID.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtCompanyName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtUsername.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    MessageBox.Show("Record not Found!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public void Clear()
        {
            txtCCID.Clear();
            txtCompanyName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                string ccname = txtCompanyName.Text;
                int cccontact = Convert.ToInt32(txtContact.Text);
                string ccaddress = txtAddress.Text;
                string ccusername = txtUsername.Text;
                string ccpassword = txtPassword.Text;

                if (ye.insertCorporateClientsAfterApprove(ccname, cccontact, ccaddress, ccusername, ccpassword) > 0)
                {
                    MessageBox.Show("Corporate Client is Approved!");

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface lo = new AdminInterface();
            lo.Show();
        }
    }
}
