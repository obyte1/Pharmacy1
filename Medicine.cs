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

namespace Pharmcacy1
{
    public partial class Medicine : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        int ID = 0;
        public Medicine()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("medicine_table");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet10.medicine_table' table. You can move, or remove it, as needed.
            //this.medicine_tableTableAdapter1.Fill(this.mypharmacyDataSet10.medicine_table);

            // TODO: This line of code loads data into the 'mypharmacyDataSet3.medicine_table' table. You can move, or remove it, as needed.
            //this.medicine_tableTableAdapter.Fill(this.mypharmacyDataSet3.medicine_table);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from medicine_table", con);
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           // dataGridView1.Visible = false;
            con.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtprice.Text!="" && txtquantity.Text!="" && txtmedicine.Text!="" && txtbatno.Text!="" && txtmanufacturer.Text!= "")
            {
                
                SqlCommand cmdd = new SqlCommand("Select * from medicine_table where batch='" + txtbatno.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmdd.ExecuteReader();
                
                if (dr.Read())
                {
                    MessageBox.Show("Medicine with the same batch No already in Exist!!");
                    con.Close();
                }
                else
                {
                    dr.Close();
                    SqlCommand cmd = new SqlCommand("insert into medicine_table(medicinename, batch, manufacturer,quantity,manudate, expirydate,sellingprice )values(@medicinename, @batch, @manufacturer, @quantity, @manudate, @expirydate, @sellingprice)", con);
                    cmd.Parameters.AddWithValue("@medicinename", txtmedicine.Text);
                    cmd.Parameters.AddWithValue("@batch", txtbatno.Text);
                    cmd.Parameters.AddWithValue("@manufacturer", txtmanufacturer.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                    cmd.Parameters.AddWithValue("@manudate", txtmanudate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@expirydate", txtexprdate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@sellingprice", txtprice.Text);
                    cmd.ExecuteNonQuery();
                   // MessageBox.Show("Medicine Inserted Successfully");
                    con.Close();
                    display();
                    
                }
            }
            else
            {
                lblmsg.Text="You can't Submit Emply form";
            }

            con.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtbatno.Text = "";
            txtmanufacturer.Text = "";
            txtmedicine.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
        }
        private void display()
        {
           
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_table", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ID = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }
        
        private void btndelete_Click(object sender, EventArgs e)
        {
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);
           if (ID != 0)
            {
                SqlCommand cmdn = new SqlCommand("delete medicine_table where ID=@id", con);
                con.Open();
                cmdn.Parameters.AddWithValue("@id", ID);
                cmdn.ExecuteNonQuery();           
                MessageBox.Show("Meddicine Successfully Deleted ");
                display();
            }
            else
            {
                MessageBox.Show("Please select Medicine to Delete!!!");
                con.Close();
            }
        }

        private void txtsearch_KeyPress(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("medicinename like '%{0}%' or manufacturer like '%{0}%' ", txtsearch.text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 )
            {
                txtmedicine.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtbatno.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtmanufacturer.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtquantity.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                //txtmanudate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                //txtexprdate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtprice.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();              
            }
            else
            {
                MessageBox.Show("Please Click to Select an Item");
            }
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmedicine.Text != "" && txtbatno.Text != "" && txtmanufacturer.Text!="" && txtprice.Text!="" && txtquantity.Text!="")
            {
                SqlCommand cmdp = new SqlCommand("update medicine_table set medicinename=@medicinename, batch=@batch, manufacturer=@manufacturer, quantity=@quantity, manudate=@manudate, expirydate=@expirydate, sellingprice=@sellingprice where ID=@id", con);
                con.Open();
                cmdp.Parameters.AddWithValue("@id", ID);
                cmdp.Parameters.AddWithValue("@medicinename", txtmedicine.Text);
                cmdp.Parameters.AddWithValue("@batch", txtbatno.Text);
                cmdp.Parameters.AddWithValue("@manufacturer", txtmanufacturer.Text);
                cmdp.Parameters.AddWithValue("@quantity", txtquantity.Text);
                cmdp.Parameters.AddWithValue("@manudate", txtmanudate.Value.ToShortDateString());
                cmdp.Parameters.AddWithValue("@expirydate", txtexprdate.Value.ToShortDateString());
                cmdp.Parameters.AddWithValue("@sellingprice", txtprice.Text);
                cmdp.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                display();               
                con.Close();             
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void txtsearch_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
