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
       
    public partial class Users : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        SqlCommand str = new SqlCommand("select * from users_biodata");
        int ID = 0;
       
        public Users()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("users_biodata");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel1usergrid.Visible = false;
        }

        private void txtuserno_MouseClick(object sender, MouseEventArgs e)
        {
            txtuserno.Clear();
        }

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            txtusername.Clear();
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtpassword.Clear();
        }

        private void txtemail_MouseClick(object sender, MouseEventArgs e)
        {
            txtemail.Clear();
        }

        private void txtcontact_MouseClick(object sender, MouseEventArgs e)
        {
            txtcontact.Clear();
        }

        private void bunifuTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuTextbox1.text = "";
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet13.users_biodata' table. You can move, or remove it, as needed.
            //this.users_biodataTableAdapter2.Fill(this.mypharmacyDataSet13.users_biodata);
            // TODO: This line of code loads data into the 'mypharmacyDataSet1.users_biodata' table. You can move, or remove it, as needed.
            //this.users_biodataTableAdapter1.Fill(this.mypharmacyDataSet1.users_biodata);
            //TODO: This line of code loads data into the 'mypharmacyDataSet.users_biodata' table. You can move, or remove it, as needed.
            //this.users_biodataTableAdapter.Fill(this.mypharmacyDataSet.users_biodata);

            //panel1usergrid.Visible = false;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from users_biodata", con);

            da.Fill(dt);
            dataGridViewuser.DataSource = dt;
            // dataGridView1.Visible = false;
            con.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            if (txtuserno.Text != "" && txtusername.Text != "" && txtpassword.Text != "" && txtemail.Text != "" && txtcontact.Text != "" && txtuserrole.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from users_biodata where username='" + txtusername.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    MessageBox.Show("Username already in use!!");
                    con.Close();
                }
                else
                {
                    dr.Close();
                    
                    SqlCommand cmdd = new SqlCommand("insert into users_biodata(userno, username, password, email, contact, userrole)values(@userno, @username, @password, @email, @contact, @userrole)", con);
                    cmdd.Parameters.AddWithValue("@userno", txtuserno.Text);
                    cmdd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmdd.Parameters.AddWithValue("@password", txtpassword.Text);
                    cmdd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmdd.Parameters.AddWithValue("@contact", txtcontact.Text);
                    cmdd.Parameters.AddWithValue("@userrole", txtuserrole.Text);
                   
                    cmdd.ExecuteNonQuery();
                    
                    MessageBox.Show("User Inserted Successfully");
                    con.Close();
                    display();
                    clear();
                    

                }

            }
            else
            {
                MessageBox.Show("Please fill the form and try gain!!!");
            }
        }
        private void clear()
        {
            txtuserno.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
            txtuserrole.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            panel1usergrid.Visible = true;
        }
        private void display()
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from users_biodata", con);
            sda.Fill(dt);
            dataGridViewuser.DataSource = dt;
            con.Close();
        }

        private void dataGridViewuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewuser.Rows[e.RowIndex];
                ID = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridViewuser.Rows[e.RowIndex];
            //    txtuserno.Text = row.Cells["userno"].Value.ToString();
            //    txtusername.Text = row.Cells["username"].Value.ToString();
            //    txtpassword.Text = row.Cells["password"].Value.ToString();
            //    txtemail.Text = row.Cells["email"].Value.ToString();
            //    txtcontact.Text = row.Cells["contact"].Value.ToString();
            //    txtuserrole.Text = row.Cells["userrole"].Value.ToString();

            //}

            if (e.RowIndex >= 0)
            {
                ID = Convert.ToInt32(dataGridViewuser.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtuserno.Text = dataGridViewuser.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtusername.Text = dataGridViewuser.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtpassword.Text = dataGridViewuser.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtemail.Text = dataGridViewuser.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtcontact.Text = dataGridViewuser.Rows[e.RowIndex].Cells[5].Value.ToString();
                //txtuserrole.SelectedValue = dataGridViewuser.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Select user First and continue");
            }
            


        }

        private void bunifuTextbox1_KeyPress(object sender, EventArgs e)
        {

            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("username like '%{0}%' or contact like '%{0}%' ", bunifuTextbox1.text);
            dataGridViewuser.DataSource = dv.ToTable();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
            if(txtuserno.Text!="" && txtusername.Text!="" && txtpassword.Text!="" && txtemail.Text!="" && txtcontact.Text!="" && txtuserrole.Text != "")
            {
                //if (ID != 0)
                //{
                    SqlCommand sqlc = new SqlCommand("update users_biodata set userno='" + txtuserno.Text + "', username='" + txtusername.Text + "', password = '" + txtpassword.Text + "', email = '" + txtemail.Text + "', contact = '" + txtcontact.Text + "', userrole = '" + txtuserrole.Text + "' where ID=@id ", con);
                    sqlc.Parameters.AddWithValue("@id", ID);
                    con.Open();
                    sqlc.ExecuteNonQuery();
                    MessageBox.Show("User Updated successfully...");
                    display();
                    con.Close();
                //}
                //else
                //{
                //    MessageBox.Show("No Item Selected!...");
                //}
                
            }
            else
            {
                MessageBox.Show("Your May have Unfilled Information...");
            }
        }
    }
}
