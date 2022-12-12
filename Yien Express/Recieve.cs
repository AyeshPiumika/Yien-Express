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

    
    public partial class Recieve : Form
    {
        localhost.YienExpressWebService ye = new localhost.YienExpressWebService();
        public Recieve()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Recieve_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ncname = txtNCName.Text;
                int nccontact = Convert.ToInt32(txtNCContact.Text);
                int ncnic = Convert.ToInt32(txtNCNIC.Text);
                string ncaddress = txtNCAddress.Text;

                if (ye.insertNormalClients(ncname, nccontact, ncnic, ncaddress) > 0)
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
                ClearNC();
            }
        }

        public void ClearNC()
        {
            //txtNCID.Clear();
            txtNCName.Clear();
            txtNCContact.Clear();
            txtNCNIC.Clear();
            txtNCAddress.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int itemid = Convert.ToInt32(txtItemID.Text);
                string details = txtContent.Text;
                int ncid = Convert.ToInt32(txtNCID.Text);
                int rcontact = Convert.ToInt32(txtContact.Text);
                string raddress = txtAddress.Text;
                string itemstatus = txtStatus.Text;

                if (ye.insertItems(itemid, details, ncid, rcontact, raddress, itemstatus) > 0)
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
            txtItemID.Clear();
            txtContent.Clear();
            txtNCID.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtStatus.Clear();
        }
    }
}
