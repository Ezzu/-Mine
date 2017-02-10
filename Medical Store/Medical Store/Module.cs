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
    class Module
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        string con;
        string com;

        public bool openConn()
        {
            try
            {
                con = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Mine\Practical\Medical Store\Medical Store\Data.mdf;Integrated Security=True;User Instance=True";
                connection = new SqlConnection(con);
                connection.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Access Denied ! Try Again Later.");
                return false;
            }
        }

        public void closeConn()
        {
            connection.Close();
        }

        public SqlConnection get()
        {
            return connection;
        }

        public SqlDataAdapter getAll()
        {
            if (openConn())
            {
                try
                {
                    //com = "SELECT Medicine As Medicine,Intensity As Intensity,Quantity As Quantity,Customer As Price FROM Entries";
                    com = "SELECT Sr,Medicine,Intensity,Quantity,Customer,Expiry FROM Entries";
                    adapter = new SqlDataAdapter(com,get());
                    closeConn();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else
            {
                closeConn();
            }
            return adapter;
        }

        public void setAll(frmManager m)
        {
            if (openConn())
            {
                try
                {
                    com = "INSERT INTO Entries Values('" + m.textBox1.Text + "','" + m.textBox2.Text + "','" + m.textBox3.Text + "','" + m.dateTimePicker1.Value + "','" + m.maskedTextBox1.Text + "','" + m.maskedTextBox2.Text + "','" + m.maskedTextBox3.Text + "','" + m.textBox4.Text + "','" + m.textBox5.Text + "','" + m.maskedTextBox4.Text + "','" + m.comboBox1.SelectedItem + "')";
                    command = new SqlCommand(com, get());
                    command.ExecuteNonQuery();
                    closeConn();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else
            {
                closeConn();
            }
        }

        public void setStore(frmStart start)
        {
            try
            {
                openConn();
                com = "INSERT INTO Store Values('1','" + start.textBox1.Text + "','" + start.textBox2.Text + "','" + start.textBox3.Text + "','" + start.textBox4.Text + "','" + start.maskedTextBox1.Text + "','" + start.textBox5.Text + "')";
                command = new SqlCommand(com, get());
                command.ExecuteNonQuery();
                closeConn();
                Application.Restart();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public int getSr()
        {
            int sr = 0;
            if (openConn())
            {
                try
                {
                    com = "SELECT Sr From Entries";
                    command = new SqlCommand(com, get());
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        sr = int.Parse(dr["Sr"] + "");
                    }
                    dr.Dispose();
                    closeConn();
                    return sr;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                    return -1;
                }
            }
            else
            {
                closeConn();
            }
            return sr;
        }

        public dsManager search(string n)
        {
            dsManager ds = new dsManager();
            try
            {
                openConn();
                com = "SELECT Sr,Medicine,Intensity,Quantity,Customer,Expiry FROM Entries WHERE Medicine = '" + n + "'";
                command = new SqlCommand(com, get());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    ds.dtManager.AdddtManagerRow(dr["Sr"] + "", dr["Medicine"] + "", dr["Intensity"] + "", dr["Quantity"] + "", dr["Customer"] + "", dr["Expiry"] + "");
                }
                dr.Close();
                closeConn();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return ds;
        }

        public frmManager select(int s)
        {
            frmManager manager = new frmManager();
            try
            {
                openConn();
                com = "SELECT Sr,Medicine,Expiry,Intensity,Quantity,Consumer,Customer,Description,Manufacturer,Contact,Country FROM Entries WHERE Sr = '"+ s +"'";
                command = new SqlCommand(com,get());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    manager.textBox1.Text = dr["Sr"] + "";
                    manager.textBox2.Text = dr["Medicine"] + "";
                    manager.dateTimePicker1.Value = DateTime.Parse(dr["Expiry"] + "");
                    manager.textBox3.Text = dr["Intensity"] + "";
                    manager.maskedTextBox1.Text = dr["Quantity"] + "";
                    manager.maskedTextBox2.Text = dr["Consumer"] + "";
                    manager.maskedTextBox3.Text = dr["Customer"] + "";
                    manager.textBox4.Text = dr["Description"] + "";
                    manager.textBox5.Text = dr["Manufacturer"] + "";
                    manager.maskedTextBox4.Text = dr["Contact"] + "";
                    manager.comboBox1.SelectedItem = dr["Country"] + "";
                }
                dr.Dispose();
                closeConn();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return manager;
        }

        public string getName()
        {
            string name = " ";
            try
            {
                openConn();
                com = "SELECT Name FROM Store";
                command = new SqlCommand(com, get());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    name = dr["Name"] + "";
                }
                dr.Close();
                closeConn();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return name;
        }

        public int check()
        {
            int count = 0;
            try
            {
                openConn();
                com = "SELECT Sign FROM Store";
                command = new SqlCommand(com, get());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    count = int.Parse(dr["Sign"]+"");
                }
                dr.Close();
                closeConn();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return count;
        }

    }

}