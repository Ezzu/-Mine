using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medical_Store
{
    public partial class frmManager : Form
    {
        Module module = new Module();
        public frmManager()
        {
            InitializeComponent();
        }

        private void start()
        {
            dataGridView1.Visible = false;
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); maskedTextBox1.Clear(); maskedTextBox2.Clear(); maskedTextBox3.Clear(); maskedTextBox4.Clear();
            textBox1.ReadOnly = true; textBox2.ReadOnly = true; textBox3.ReadOnly = true; textBox4.ReadOnly = true; textBox5.ReadOnly = true;
            maskedTextBox1.ReadOnly = true; maskedTextBox2.ReadOnly = true; maskedTextBox3.ReadOnly = true; maskedTextBox4.ReadOnly = true;
            comboBox1.Enabled = false; dateTimePicker1.Enabled = false;
            btnSave.Enabled = false; btnNew.Enabled = true; btnUpdate.Enabled = false; btnCan.Enabled = false; btnSaveU.Enabled = false; btnDelete.Enabled = false; btnSel.Enabled = true; btnCloseL.Enabled = false; btnClose.Enabled = true;
            btnNew.BringToFront(); btnUpdate.BringToFront(); btnClose.BringToFront(); btnDelete.BringToFront();
        }

        private void selFunc()
        {
            try { module.getAll().Fill(this.dsManager.dtManager); }
            catch (SqlException e) { MessageBox.Show(e.ToString()); }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Visible = true;
            textBox1.ReadOnly = true; textBox2.ReadOnly = true; textBox3.ReadOnly = true; textBox4.ReadOnly = true; textBox5.ReadOnly = true;
            maskedTextBox1.ReadOnly = true; maskedTextBox2.ReadOnly = true; maskedTextBox3.ReadOnly = true; maskedTextBox4.ReadOnly = true;
            btnSave.Enabled = false; btnNew.Enabled = true; btnUpdate.Enabled = false; btnCan.Enabled = false; btnSaveU.Enabled = false; btnDelete.Enabled = false; btnSel.Enabled = false; btnCloseL.Enabled = true; btnClose.Enabled = false;
            btnNew.BringToFront(); btnUpdate.BringToFront(); btnCloseL.BringToFront(); btnDelete.BringToFront();
        }

        private void cListFunc()
        {
            dataGridView1.Visible = false;
            textBox1.ReadOnly = true; textBox2.ReadOnly = true; textBox3.ReadOnly = true; textBox4.ReadOnly = true; textBox5.ReadOnly = true;
            maskedTextBox1.ReadOnly = true; maskedTextBox2.ReadOnly = true; maskedTextBox3.ReadOnly = true; maskedTextBox4.ReadOnly = true;
            btnSave.Enabled = false; btnNew.Enabled = true; btnUpdate.Enabled = false; btnCan.Enabled = false; btnSaveU.Enabled = false; btnDelete.Enabled = false; btnSel.Enabled = true; btnCloseL.Enabled = false; btnClose.Enabled = true;
            btnNew.BringToFront(); btnUpdate.BringToFront(); btnClose.BringToFront(); btnDelete.BringToFront();
        }

        private void newFunc()
        {
            dataGridView1.Visible = false;
            textBox1.ReadOnly = true; textBox2.ReadOnly = false; textBox3.ReadOnly = false; textBox4.ReadOnly = false; textBox5.ReadOnly = false;
            maskedTextBox1.ReadOnly = false; maskedTextBox2.ReadOnly = false; maskedTextBox3.ReadOnly = false; maskedTextBox4.ReadOnly = false;
            comboBox1.Enabled = true; dateTimePicker1.Enabled = true;
            btnSave.Enabled = true; btnNew.Enabled = false; btnUpdate.Enabled = false; btnCan.Enabled = true; btnSaveU.Enabled = false; btnDelete.Enabled = false; btnSel.Enabled = true; btnCloseL.Enabled = false; btnClose.Enabled = true;
            btnSave.BringToFront(); btnUpdate.BringToFront(); btnClose.BringToFront(); btnCan.BringToFront();
        }

        private void selectFunc()
        {
            dataGridView1.Visible = false;
            textBox1.ReadOnly = true; textBox2.ReadOnly = true; textBox3.ReadOnly = true; textBox4.ReadOnly = true; textBox5.ReadOnly = true;
            maskedTextBox1.ReadOnly = true; maskedTextBox2.ReadOnly = true; maskedTextBox3.ReadOnly = true; maskedTextBox4.ReadOnly = true;
            comboBox1.Enabled = false; dateTimePicker1.Enabled = false;
            btnSave.Enabled = false; btnNew.Enabled = true; btnUpdate.Enabled = true; btnCan.Enabled = true; btnSaveU.Enabled = false; btnDelete.Enabled = false; btnSel.Enabled = true; btnCloseL.Enabled = false; btnClose.Enabled = true;
            btnNew.BringToFront(); btnUpdate.BringToFront(); btnClose.BringToFront(); btnCan.BringToFront();
        }

        private void saveFunc()
        {
            dataGridView1.Visible = false;
            textBox1.ReadOnly = true; textBox2.ReadOnly = true; textBox3.ReadOnly = true; textBox4.ReadOnly = true; textBox5.ReadOnly = true;
            maskedTextBox1.ReadOnly = true; maskedTextBox2.ReadOnly = true; maskedTextBox3.ReadOnly = true; maskedTextBox4.ReadOnly = true;
            comboBox1.Enabled = false; dateTimePicker1.Enabled = false;
            btnSave.Enabled = false; btnNew.Enabled = true; btnUpdate.Enabled = false; btnCan.Enabled = true; btnSaveU.Enabled = false; btnDelete.Enabled = false; btnSel.Enabled = true; btnCloseL.Enabled = false; btnClose.Enabled = true;
            btnNew.BringToFront(); btnUpdate.BringToFront(); btnClose.BringToFront(); btnDelete.BringToFront();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); maskedTextBox1.Clear(); maskedTextBox2.Clear(); maskedTextBox3.Clear(); maskedTextBox4.Clear();
        }

        private void updateFunc()
        {
            dataGridView1.Visible = false;
            textBox1.ReadOnly = true; textBox2.ReadOnly = false; textBox3.ReadOnly = false; textBox4.ReadOnly = false; textBox5.ReadOnly = false;
            maskedTextBox1.ReadOnly = false; maskedTextBox2.ReadOnly = false; maskedTextBox3.ReadOnly = false; maskedTextBox4.ReadOnly = false;
            comboBox1.Enabled = true; dateTimePicker1.Enabled = true;
            btnSave.Enabled = false; btnNew.Enabled = true; btnUpdate.Enabled = false; btnCan.Enabled = true; btnSaveU.Enabled = true; btnDelete.Enabled = false; btnSel.Enabled = false; btnCloseL.Enabled = false; btnClose.Enabled = true;
            btnNew.BringToFront(); btnSaveU.BringToFront(); btnClose.BringToFront(); btnCan.BringToFront();
        }

        public void setStatus(bool p,string s)
        {
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = s;
            if (p)
            {

            }
        }

        private void srDecide()
        {
            int sr = module.getSr() ;
            if (sr >= 0) { textBox1.Text = ""+(sr+1); }
            else { setStatus(false, "Can't Create New Entry At This Time !"); btnCan.PerformClick(); }
        }

        private bool saveDecision()
        {
            if (textBox2.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == ""|| maskedTextBox3.Text == "" || textBox4.Text == "")
                return false;
            return true;
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCloseL_Click(object sender, EventArgs e)
        {
            cListFunc();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            selFunc();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newFunc();
            srDecide();
            textBox2.Focus();
            setStatus(false, "Fill New Values And Save New Record.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveDecision())
            {
                module.setAll(this);
                setStatus(true, "Values Saved Successfully !");
                saveFunc();
            }
            else
            {
                setStatus(false, "Some Fields Are Necessary To Fill !");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateFunc();
            setStatus(false, "Edit Mode Enabled. Make Changes and Save Updates.");
        }

        private void btnSaveU_Click(object sender, EventArgs e)
        {

        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            start();
            textBox3.Focus();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            { 
                int sr = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value+"");
                frmManager m = module.select(sr);
                textBox1.Text = m.textBox1.Text;
                textBox2.Text = m.textBox2.Text;
                textBox3.Text = m.textBox3.Text;
                textBox4.Text = m.textBox4.Text;
                textBox5.Text = m.textBox5.Text;
                maskedTextBox1.Text = m.maskedTextBox1.Text;
                maskedTextBox2.Text = m.maskedTextBox2.Text;
                maskedTextBox3.Text = m.maskedTextBox3.Text;
                maskedTextBox4.Text = m.maskedTextBox4.Text;
                comboBox1.SelectedItem = m.comboBox1.SelectedItem;
                dateTimePicker1.Value = m.dateTimePicker1.Value;
                selectFunc();
                setStatus(true, textBox2.Text + " Is Selected !");
            }
        }

    }
}
