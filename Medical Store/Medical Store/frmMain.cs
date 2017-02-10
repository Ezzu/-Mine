using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Store
{
    public partial class frmMain : Form
    {
        Module module = new Module();
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBuy buy = new frmBuy();
            buy.MdiParent = this;
            buy.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.MdiParent = this;
            manager.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            sales.MdiParent = this;
            sales.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmStore store = new frmStore();
            store.MdiParent = this;
            store.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /*if (module.check() == 1)
            {
                this.Text = module.getName();
            }
            else
            {
                frmStart start = new frmStart();
                start.Show();
                this.Hide();
            }*/
        }
    }
}
