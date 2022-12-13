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
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientRequests lo = new ClientRequests();
            lo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoClientManage lo = new CoClientManage();
            lo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NormalClientManage lo = new NormalClientManage();
            lo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lo = new Form1();
            lo.Show();
        }
    }
}
