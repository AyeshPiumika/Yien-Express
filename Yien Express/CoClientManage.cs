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
    public partial class CoClientManage : Form
    {
        localhost.YienExpressWebService ye = new localhost.YienExpressWebService();

        public CoClientManage()
        {
            InitializeComponent();
        }

        private void CoClientManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Yien_ExpressDataSet2.tbl_CorporateClientApprove' table. You can move, or remove it, as needed.
            this.tbl_CorporateClientApproveTableAdapter.Fill(this.db_Yien_ExpressDataSet2.tbl_CorporateClientApprove);

        }

        private void btnInsert_Click(object sender, EventArgs e)
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
            txtCCID.Clear();
            txtCompanyName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                dgvcc.DataSource = ye.searchAllCorporateClients().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ccid = Convert.ToInt32(txtCCID.Text);

            if (ye.deleteCorporateClients(ccid) > 0)
            {
                MessageBox.Show("Data Deleted!");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int ccid = Convert.ToInt32(txtCCID.Text);
                DataSet ds = ye.findCorporateClientsAfterApprove(ccid);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ccid = Convert.ToInt32(txtCCID.Text);
                string ccname = txtCompanyName.Text;
                int cccontact = Convert.ToInt32(txtContact.Text);
                string ccaddress = txtAddress.Text;
                string ccusername = txtUsername.Text;
                string ccpassword = txtPassword.Text;

                if (ye.updateCorporateClients(ccid, ccname, cccontact, ccaddress, ccusername, ccpassword) > 0)
                {
                    MessageBox.Show("Data Updated!");

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface lo = new AdminInterface();
            lo.Show();
        }
    }
}
