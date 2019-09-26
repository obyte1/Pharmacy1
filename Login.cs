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
    public partial class Login : Form
    {

        // SqlConnection con = new SqlConnection(@"Data Source=SIDSYS-LAP-22\SQLEXPRESS;Initial Catalog=mypharmacy;Integrated Security=True");
        //SqlConnection con = new SqlConnection("Data Source=SIDSYS-LAP-22 SQLEXPRESS;Initial Catalog=mypharmacy;Integrated Security=True");
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        

      // newcon = new SqlConnection();
       
        
        
        
        public Login()
        {
            InitializeComponent();
        }
        public class UserDisplayName
        {
            public static string displayName;
        }
        internal class UserInformation
        {
            public static string CurrentLoggedInUser
            {
                get;
                set;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            label5.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //label8.Text = UserDisplayName.displayName;
            txtpass.PasswordChar = '*';
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtadminusername.Text!="" && txtadminemail.Text!="" && txtadminpassword.Text != "")
            {
                SqlCommand cmm = new SqlCommand("select * from admin_table where username='" + txtadminusername.Text + "'", con);
                con.Open();
                SqlDataReader sda = cmm.ExecuteReader();              
                if (sda.Read())
                {
                    MessageBox.Show("Admin with Username " + txtadminusername.Text + " already Exist");
                    con.Close();
                }
                else
                {
                    sda.Close();
                    SqlCommand cmd = new SqlCommand("insert into admin_table(username, email, password)values(@username, @email, @password)", con);
                    cmd.Parameters.AddWithValue("@username", txtadminusername.Text);
                    cmd.Parameters.AddWithValue("@email", txtadminemail.Text);
                    cmd.Parameters.AddWithValue("@password", txtadminpassword.Text);
                   
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Admin " + txtadminusername.Text + " has been added successfully");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Fill out the Form..");
                con.Close();
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
               
            //Admin Login here
            if (txtusename.Text != "" && txtpass.Text != "")
            {
                SqlCommand cmm = new SqlCommand("select * from admin_table where username='" + txtusename.Text + "' and password='" + txtpass.Text + "'", con);
                con.Open();
                SqlDataReader sda = cmm.ExecuteReader();

                if (sda.Read())
                {
                    sda.Close();
                   
                    
                    Form1 ff = new Form1(txtusename.Text);
                    UserInformation.CurrentLoggedInUser = (string)txtusename.Text;
                   
                    this.Hide();
                    ff.Show();
                    con.Close();

                }
                else
                {
                    lblmsg.Text = "This Admin Does not Exist";
                    con.Close();
                }

            }
            else
            {
                lblmsg.Text = "Please fill Your details";
                con.Close();
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //user Login here
            if (txtusename.Text != "" && txtpass.Text != "")
            {
                SqlCommand cmmd = new SqlCommand("select * from users_biodata where username='" + txtusename.Text + "' and password='" + txtpass.Text + "'", con);
                con.Open();
                SqlDataReader sdaa = cmmd.ExecuteReader();

                if (sdaa.Read())
                {                   
                    UserDashboard us = new UserDashboard(txtusename.Text);
                    UserInformation.CurrentLoggedInUser = (string)txtusename.Text;
                    //UserDisplayName.displayName = txtusename.Text;
                    this.Hide();
                    us.Show();
                    
                    con.Close();

                }
                else
                {
                    sdaa.Close();
                    lblmsg.Text = "Not Registered User";
                    con.Close();
                    
                }


            }
            else
            {
                lblmsg.Text = "Please Insert your details";
                con.Close();
            }          
          }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
