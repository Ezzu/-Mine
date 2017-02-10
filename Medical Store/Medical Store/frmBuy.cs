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
    public partial class frmBuy : Form
    {
        Module module = new Module();
        public frmBuy()
        {
            InitializeComponent();
        }

        private void frmBuy_Load(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {
            try { module.getAll().Fill(this.dsManager.dtManager); }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            btnFind.Enabled = true; btnRef.Enabled = true; btnBuy.Enabled = false;
            textBox1.Clear(); textBox1.Focus();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            module.getAll().Fill(this.dsManager.dtManager);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = module.search(textBox1.Text).dtManager;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind.PerformClick();
            }
        }

        private void frmBuy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                textBox1.Focus();
            }
        }
    }
}
