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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        //DataTable dt = new DataTable("message_table");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Messages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet12.message_table' table. You can move, or remove it, as needed.
            //this.message_tableTableAdapter1.Fill(this.mypharmacyDataSet12.message_table);
            // TODO: This line of code loads data into the 'mypharmacyDataSet11.message_table' table. You can move, or remove it, as needed.
            //this.message_tableTableAdapter.Fill(this.mypharmacyDataSet11.message_table);
            // TODO: This line of code loads data into the 'mypharmacyDataSet.users_biodata' table. You can move, or remove it, as needed.
            //this.users_biodataTableAdapter.Fill(this.mypharmacyDataSet.users_biodata);
            // TODO: This line of code loads data into the 'mypharmacyDataSet2.admin_table' table. You can move, or remove it, as needed.
            //this.admin_tableTableAdapter.Fill(this.mypharmacyDataSet2.admin_table);
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select * from message_table where receiver='AdminObyte'", con);

            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string obute = "onyeka";
            string date = DateTime.Now.ToString("dd/mm/yyyy");
            SqlCommand cmd = new SqlCommand("insert into message_table(date, receiver, message, sender ) values (@date, @receiver, @message, @sender)", con);

            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@receiver", comboBox1.Text);
            cmd.Parameters.AddWithValue("@message", textBox1.Text);
            cmd.Parameters.AddWithValue("@sender", obute);
            con.Open();
            cmd.ExecuteNonQuery();
            display();
            MessageBox.Show("Message sent");
            
        }
        private void display()
        {
            SqlDataAdapter dda = new SqlDataAdapter("select * from message_table where receiver='AdminObyte'", con);
            DataTable ddt = new DataTable();
            dda.Fill(ddt);
            dataGridView1.DataSource = ddt;
            con.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
