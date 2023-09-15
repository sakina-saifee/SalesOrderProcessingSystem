using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims_project
{
    public partial class login : sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {


            if (login_passtxtbox.Text == "") { login_passerror.Visible = true; } else { login_passerror.Visible = false; }

        }

        private void PASSWORD_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {


            string username = login_usernametxtbox.Text;
            string password = login_passtxtbox.Text;
            if (login_usernametxtbox.Text == "") { login_usernameerror.Visible = true; } else { login_usernameerror.Visible = false; }
            if (login_passtxtbox.Text == "") { login_passerror.Visible = true; } else { login_passerror.Visible = false; }


            if (login_usernameerror.Visible || login_passerror.Visible)
            {

                main_class.showmsg("PLease fill the * fields", "Missing data fields", "error");

            }
            else
            {


                if (retrieval.getUserDetails(username, password))
                {

                    homescreen hs = new homescreen();
                    main_class.show_window(hs, this, MdiParent);

                }
                else
                {


                }

            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signup_lbl_Click(object sender, EventArgs e)
        {
            signup s = new signup();
            main_class.show_window(s, this, MdiParent);
        }

        private void login_usernametxtbox_TextChanged(object sender, EventArgs e)
        {

            if (login_usernametxtbox.Text == "") { login_usernameerror.Visible = true; } else { login_usernameerror.Visible = false; }


        }


        private void login_Load(object sender, EventArgs e)

        {
            main_class.enable_reset(panel1);
            mainwin m = new mainwin();
            m.logoutToolStripMenuItem.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
