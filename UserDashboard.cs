using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmcacy1
{
    public partial class UserDashboard : Form
    {
        public UserDashboard(string user)
        {
            InitializeComponent();
            label2.Text = user;
            panel3.Visible = false;
            panel7.Visible = false;


        }
        string user;
        viewstocks vv;
        viewcustomers vc;
        retailsales rr;
        vieworder vm;
        usermessages vg;

        //SqlConnection con = new SqlConnection(ConnectionString.CONNECTIONSTRING);
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            vv = new viewstocks();
            vv.MdiParent = this;
            vv.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            vc = new viewcustomers();
            vc.MdiParent = this;
            vc.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;


            rr = new retailsales();
            rr.MdiParent = this;
            rr.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            vm = new vieworder();
            vm.MdiParent = this;
            vm.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            vg = new usermessages();
            vg.MdiParent = this;
            vg.Show();

        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            panel9.Visible = false;


        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {          
            lbltime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            //if(vv.Visible!=true && vc.Visible!=true && rr.Visible!=true && vg.Visible!=true && vm.Visible != true)
            //{
            //    vv.Close();
            //    vc.Close();
            //    rr.Close();
            //    vg.Close();
            //    vm.Close();
            //}
            //else
            //{
                
            //}           
            panel9.Visible = true;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            panel9.Hide();
        }

        private void bunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            //panel7.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ll = new Login();
            ll.Show();
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void label20_MouseHover(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }
    }
}
