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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtcompany.Text!="" && txtname.Text!="" && txtphone.Text!="" && txtproduct.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select phoneno from suppliers_table where phoneno='" + txtphone.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Supplier with the same Phone Number Exist!!!");
                }
                else
                {
                    dr.Close();
                    SqlCommand cmdd = new SqlCommand("insert into suppliers_table(name, company, product, phoneno)values(@name, @company, @product, @phoneno)", con);
                    cmdd.Parameters.AddWithValue("@name", txtname.Text);
                    cmdd.Parameters.AddWithValue("@phoneno", txtphone.Text);
                    cmdd.Parameters.AddWithValue("@product", txtproduct.Text);
                    cmdd.Parameters.AddWithValue("@company", txtcompany.Text);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Saved");
                    display();
                    clear();
                }

            }
            else
            {
                lblmsg.Text = "Pls Make Sure All fields are filled";
            }
        }
        private void clear()
        {
            txtcompany.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
            txtproduct.Text = "";
        }
        private void display()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from suppliers_table", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet5.suppliers_table' table. You can move, or remove it, as needed.
            //this.suppliers_tableTableAdapter.Fill(this.mypharmacyDataSet5.suppliers_table);
            display();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
