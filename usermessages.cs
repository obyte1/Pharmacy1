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
    public partial class usermessages : Form
    {
        public usermessages()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        //DataTable dt = new DataTable("message_table");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usermessages_Load(object sender, EventArgs e)
        {        
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string obute = "onyeka";
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            SqlCommand cmd = new SqlCommand("insert into message_table(date, receiver, message, sender ) values (@date, @receiver, @message, @sender)", con);

            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@receiver", comboBox1.Text);
            cmd.Parameters.AddWithValue("@message", textBox1.Text);
            cmd.Parameters.AddWithValue("@sender", obute);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("Message sent");
            
        }
        private void display()
        {
            SqlDataAdapter dda = new SqlDataAdapter("select * from message_table where receiver='yemi'", con);
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
