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
    public partial class viewcustomers : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        public viewcustomers()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("customer_table");
        private void viewcustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet4.customer_table' table. You can move, or remove it, as needed.
            //this.customer_tableTableAdapter.Fill(this.mypharmacyDataSet4.customer_table);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from customer_table", con);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void bunifuTextbox1_KeyPress(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("name like '%{0}%' or phoneno like '%{0}%' ", bunifuTextbox1.text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
