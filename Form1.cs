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
    public partial class Form1 : Form
    {
        //Login.UserDisplayName s;
        SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        
        public Form1(string user)
        {
            InitializeComponent();
            panel3.Visible = false;
            panel7.Visible = false;
            label8.Text = user;
            


        }
        
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuImageButton4.Visible != true)
            {
                Users ss = new Users();               
                ss.MdiParent = this;
                ss.Show();
            }
            else
            {
                Users ss = new Users();
                ss.MdiParent = this;
                ss.Show();
                panel9.Visible = true;
            }            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Medicine sv = new Medicine();
            sv.MdiParent = this;
            sv.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Suppliers ss = new Suppliers();
            ss.MdiParent = this;
            ss.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Customers ss = new Customers();
            ss.MdiParent = this;
            ss.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Sales ss = new Sales();
            ss.MdiParent = this;
            ss.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do you want to close this App?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel7.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void bunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            //panel7.Visible = false;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.Blue;
            panel7.Visible = true;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.BackColor = Color.Blue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
            panel7.Visible = Visible;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel7.Visible = false;
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void bunifuImageButton2_MouseDown(object sender, MouseEventArgs e)
        {
            panel7.Visible = true;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mypharmacyDataSet14.medicine_table' table. You can move, or remove it, as needed.
            ///this.medicine_tableTableAdapter1.Fill(this.mypharmacyDataSet14.medicine_table);
            // TODO: This line of code loads data into the 'mypharmacyDataSet10.medicine_table' table. You can move, or remove it, as needed.
            //this.medicine_tableTableAdapter.Fill(this.mypharmacyDataSet10.medicine_table);
            bunifuImageButton4.Visible = false;
            panel9.Visible = false;
            lbldate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //label8.Text = UserInformation.CurrentLoggedInUser;
            string user;
            

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            bunifuTransition1.ShowSync(panel9);
            bunifuImageButton4.Visible = true;
            if (panel2.Width== 268)
            {
                panel2.Visible = false;
                panel2.Width = 67;
                bunifuImageButton3.Visible = false;
                bunifuTransition1.ShowSync(panel2);
                bunifuImageButton5.Visible = false;
            }
            else
            {
                panel2.Visible = false;
                panel2.Width = 268;
                bunifuImageButton3.Visible = true;
                bunifuTransition1.ShowSync(panel2);
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            bunifuImageButton4.Visible = false;
            bunifuImageButton5.Visible = true;
            if (panel2.Width == 67)
            {
                panel2.Visible = false;
                panel2.Width = 268;
                bunifuImageButton3.Visible = true;
                bunifuTransition1.ShowSync(panel2);
            }
            else
            {
                panel2.Visible = false;
                panel2.Width = 67;
                bunifuTransition1.ShowSync(panel2);
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Messages ss = new Messages();
            ss.MdiParent = this;
            ss.Show();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    UserDashboard uu = new UserDashboard(string user);
        //    uu.Show();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            Login nn = new Login();
            nn.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login ll = new Login();
            this.Close();
            ll.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            bunifuTransition1.ShowSync(panel9);
            bunifuImageButton4.Visible = true;
            if (panel2.Width == 268)
            {
                panel2.Visible = false;
                panel2.Width = 67;
                bunifuImageButton3.Visible = false;
                bunifuTransition1.ShowSync(panel2);
                bunifuImageButton5.Visible = false;
            }
            else
            {
                panel2.Visible = false;
                panel2.Width = 268;
                bunifuImageButton3.Visible = true;
                bunifuTransition1.ShowSync(panel2);
            }
            btnabout.Hide();
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            //label19.Text = user;
        }
    }
}
