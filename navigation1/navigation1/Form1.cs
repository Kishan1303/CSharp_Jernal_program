using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace navigation1
{
    public partial class Form1 : Form
    {
        DataTable dtg = new DataTable();
        int cr = 0;
        int tr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp();
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string ins = "insert into table1  values('" + textBox1.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(ins, Class1.cn);
                DataTable dt = new DataTable();
               int a = sda.Fill(dt);
                clear();
                MessageBox.Show("Recored Insert Succsessfuly.....");
                dataGridView1.DataSource = dt;
                disp();
            }
            else
            {
                MessageBox.Show("Enter Your Name .....");
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bfirst_Click(object sender, EventArgs e)
        {
            cr = 0;
            navigate();
        }
        public void disp()
        {
            string sel = "select * from table1";
            SqlDataAdapter da = new SqlDataAdapter(sel, Class1.cn);
            da.Fill(dtg);
            dataGridView1.DataSource = dtg;
            tr = dtg.Rows.Count;
        }
        private void navigate()
        {
            textBox1.Text = dtg.Rows[cr]["Name"].ToString();
        }

        private void bnext_Click(object sender, EventArgs e)
        {
            if (cr < tr - 1)
            {
                cr++;
                navigate();
            }
            else
            {
                MessageBox.Show("Not Show Next..");
            }


        }

        private void bpreview_Click(object sender, EventArgs e)
        {
            if (cr > 0)
            {
                cr--;
                navigate();
            }
            else
            {
                MessageBox.Show("Not Work Preview Button..");
            }
        }

        private void blast_Click(object sender, EventArgs e)
        {
            cr = tr - 1;
            navigate();

        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            string del = "Delete from table1 where Name = '" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(del, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.AcceptChanges();
            dt.Reset();
            disp();
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp();
        }

    }
}
