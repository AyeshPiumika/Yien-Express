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
    public partial class Transfer : Form
    {
        localhost.YienExpressWebService ye = new localhost.YienExpressWebService();

        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Yien_ExpressDataSet3.tbl_Items' table. You can move, or remove it, as needed.
            this.tbl_ItemsTableAdapter.Fill(this.db_Yien_ExpressDataSet3.tbl_Items);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //int itemid = Convert.ToInt32(txtItemID.Text);
            //if (!txtItemID.L==0)
            try
            {
                try
                {
                    int itemid = Convert.ToInt32(txtItemID.Text);
                    DataSet ds = ye.findItem(itemid);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtItemID.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtStatus.Text = ds.Tables[0].Rows[0][5].ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show("Please provide relevant details");
            }

        }

        public void Clear()
        {
            txtItemID.Clear();
            txtStatus.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int itemid = Convert.ToInt32(txtItemID.Text);
                    string itemstatus = txtStatus.Text;

                    if (ye.updateItem(itemid, itemstatus) > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show("Please provide relevant details");
            }

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    dgvitem.DataSource = ye.viewAllItem().Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please provide relevant details");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lo = new Form1();
            lo.Show();
        }
    }
}
