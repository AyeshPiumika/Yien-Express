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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Yien_ExpressDataSet5.tbl_NormalClients' table. You can move, or remove it, as needed.
            this.tbl_NormalClientsTableAdapter.Fill(this.db_Yien_ExpressDataSet5.tbl_NormalClients);

        }
    }
}
