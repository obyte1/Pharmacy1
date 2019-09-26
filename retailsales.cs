using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Diagnostics;
using DGVPrinterHelper;

namespace Pharmcacy1
{
    public partial class retailsales : Form
    {
        public retailsales()
        {
            InitializeComponent();
        }
        //DGVPrinter print = new DGVPrinter(DGVPrinterHelper.DGVPrinter);
         SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        
        DataTable dt = new DataTable("medicine_table");
        private void retailsales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet9.medicine_table' table. You can move, or remove it, as needed.
            //this.medicine_tableTableAdapter.Fill(this.mypharmacyDataSet9.medicine_table);

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from medicine_table", con);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnsearch_KeyPress(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("medicinename like '%{0}%' or manufacturer like '%{0}%' ", btnsearch.text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="" && textBox3.Text != "")
            {
                if (textBox4.Text != "")
                {
                    int price;
                    int a = Convert.ToInt32(textBox3.Text);
                    int b = Convert.ToInt32(textBox4.Text);
                    price = (a * b);
                    dataGridView2.Rows.Add(textBox4.Text, textBox2.Text, textBox3.Text, price);
                }
                else
                {
                    MessageBox.Show("Please type in the Quantity");
                }
            }
            else
            {
                MessageBox.Show("Please Select an item from the Tbale to Add");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                //txtbatno.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                //txtmanufacturer.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                //txtmanudate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                //txtexprdate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please Click to Select an Item");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("No Item to delete");
                
            }
            else
            {
                int rowIndex = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows.RemoveAt(rowIndex);
            }
            //if (dataGridView2.CurrentCell.RowIndex >= 0)
            //{
            //    MessageBox.Show("Pls Select Item to Remove");
            //}
            //else
            //{
            //    dataGridView2.Rows.RemoveAt(rowIndex);
            //}



        }
        private void addingitems()
        {
            decimal total = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView2.Rows[i].Cells["amount"].Value);
            }
            textBoxtotal.Text = total.ToString();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView2.Rows[i].Cells["amount"].Value);
            }
            

            string seller = "Onyeka";
            string date = DateTime.Now.ToString();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into sales_table(quantity, medicinename, rate, price, seller, date)Values('"+dataGridView2.Rows[i].Cells[0].Value+ "', '" + dataGridView2.Rows[i].Cells[1].Value + "', '" + dataGridView2.Rows[i].Cells[2].Value + "', '" + dataGridView2.Rows[i].Cells[3].Value + "', '"+seller+"', '"+date+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();              
            }
            addingitems();
            dataGridView2.Rows.Add("--------", "------", "---------", "----------");
            dataGridView2.Rows.Add("--------", "Total", "---------", total);
            //dataGridView2.Rows.Clear();
            MessageBox.Show("Inserted Successfully");
        }

        private void btnsearch_OnTextChange(object sender, EventArgs e)
        {

        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Kachi Pharm";
            printer.SubTitle = "No 24 Akute Road Ishaga";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Thanks for your Patronage";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView2);
        }
        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
