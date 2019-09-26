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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtname.Text!="" && txtaddress.Text!="" && txtaddress.Text != "")
            {
                SqlCommand cmdd = new SqlCommand("Select phoneno from customer_table where phoneno='" + txtphoneno.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmdd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Customer with the same Phone No already in Exist!!");
                    con.Close();
                }
                else
                {
                    dr.Close();
                    string date;
                    date = DateTime.Now.ToString("dd/MM/yyyy");
                    SqlCommand cmd = new SqlCommand("insert into customer_table(name, phoneno, address, date)values(@name, @phoneno, @address, @date)", con);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@phoneno", txtphoneno.Text);
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Saved");
                    con.Close();
                    display();
                    clear();

                }
            }
            else
            {
                lblmsg.Text = "Please Fill customers Form";
            }
           
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet4.customer_table' table. You can move, or remove it, as needed.
            //this.customer_tableTableAdapter.Fill(this.mypharmacyDataSet4.customer_table);
            display();
        }
        private void display()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from customer_table", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void clear()
        {
            txtaddress.Text = "";
            txtname.Text = "";
            txtphoneno.Text="";

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
