﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ICS
{
    public partial class particular_sales : Form
    {
        public particular_sales()
        {
            InitializeComponent();
        }

        private void particular_sales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from SALETABLE where VNO = '" + textBox1.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "a1");
                textBox1.Text = ds.Tables["a1"].Rows[0][0].ToString();
                textBox2.Text = ds.Tables["a1"].Rows[0][1].ToString();
                textBox3.Text = ds.Tables["a1"].Rows[0][2].ToString();
                textBox4.Text = ds.Tables["a1"].Rows[0][3].ToString();
                textBox5.Text = ds.Tables["a1"].Rows[0][4].ToString();
                textBox6.Text = ds.Tables["a1"].Rows[0][5].ToString();
                textBox7.Text = ds.Tables["a1"].Rows[0][6].ToString();
                textBox8.Text = ds.Tables["a1"].Rows[0][7].ToString();
                textBox9.Text = ds.Tables["a1"].Rows[0][8].ToString();
                textBox10.Text = ds.Tables["a1"].Rows[0][9].ToString();
                textBox11.Text = ds.Tables["a1"].Rows[0][10].ToString();
               
            }
            catch (Exception)
            {
                MessageBox.Show("        Sales Entry Not Found", "ALERT");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
