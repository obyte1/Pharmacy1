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
    public partial class viewstocks : Form
    {
        public viewstocks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        DataTable dt = new DataTable("medicine_table");
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void viewstocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet10.medicine_table' table. You can move, or remove it, as needed.
            //this.medicine_tableTableAdapter.Fill(this.mypharmacyDataSet10.medicine_table);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from medicine_table", con);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void bunifuTextbox1_KeyPress(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("medicinename like '%{0}%' or manufacturer like '%{0}%' ", bunifuTextbox1.text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
