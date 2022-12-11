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
    public partial class NormalClientManage : Form
    {

        localhost.YienExpressWebService ye = new localhost.YienExpressWebService();

        public NormalClientManage()
        {
            InitializeComponent();
        }

        private void btnNCUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ncid = Convert.ToInt32(txtNCID.Text);
                string ncname = txtNCName.Text;
                int nccontact = Convert.ToInt32(txtNCContact.Text);
                int ncnic = Convert.ToInt32(txtNCNIC.Text);
                string ncaddress = txtNCAddress.Text;

                if (ye.UpdateNormalClients(ncid, ncname, nccontact, ncnic, ncaddress) > 0)
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

        public void Clear()
        {
            txtNCID.Clear();
            txtNCName.Clear();
            txtNCContact.Clear();
            txtNCNIC.Clear();
            txtNCAddress.Clear();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                dgvnc.DataSource = ye.searchAllNormalClients().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnNCDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int ncid = Convert.ToInt32(txtNCID.Text);

                if (ye.deleteNormalClients(ncid) > 0)
                {
                    MessageBox.Show("Data Deleted!");
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

        private void NormalClientManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Yien_ExpressDataSet.tbl_NormalClients' table. You can move, or remove it, as needed.
            this.tbl_NormalClientsTableAdapter.Fill(this.db_Yien_ExpressDataSet.tbl_NormalClients);

        }

        private void btnNCFind_Click(object sender, EventArgs e)
        {
            try
            {
                int ncid = Convert.ToInt32(txtNCID.Text);
                DataSet ds = ye.findNormalClients(ncid);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtNCID.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtNCName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtNCContact.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtNCNIC.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtNCAddress.Text = ds.Tables[0].Rows[0][4].ToString();
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
    }
}
