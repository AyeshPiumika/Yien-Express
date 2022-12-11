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
                string ncname = txtNCName.Text;
                int nccontact = Convert.ToInt32(txtNCContact.Text);
                int ncnic = Convert.ToInt32(txtNCNIC.Text);
                string ncaddress = txtNCAddress.Text;

                if (ye.UpdateNormalClients(ncname, nccontact, ncnic, ncaddress) > 0)
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
    }
}
