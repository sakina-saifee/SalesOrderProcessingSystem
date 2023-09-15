using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims_project
{
    public partial class signup : sample
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            main_class.enable_reset(panel1);
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string theDate = dob_signdatetimepicker.Value.ToString("dd-MMM-yyyy");
            if (name_signtxtbox.Text == "") { signup_nameerror.Visible = true; } else { signup_nameerror.Visible = false; }
            if (username_signtxtbox.Text == "") { signup_usernameerror.Visible = true; } else { signup_usernameerror.Visible = false; }
            if (pass_signtxtbox.Text == "") { signup_passerror.Visible = true; } else { signup_passerror.Visible = false; }
            if (phone_signtxtbox.Text == "") { signup_phoneerror.Visible = true; } else { signup_phoneerror.Visible = false; }
            if (gender_signcombobox.SelectedIndex == -1) { signup_gendererror.Visible = true; } else { signup_gendererror.Visible = false; }
            if (dob_signdatetimepicker.Text == "") { signup_doberror.Visible = true; } else { signup_doberror.Visible = false; }

            if(signup_nameerror.Visible || signup_usernameerror.Visible || signup_passerror.Visible || signup_phoneerror.Visible || signup_gendererror.Visible || signup_doberror.Visible)
            {
                DialogResult result=  MessageBox.Show("Please fill in the * fields!","Empty Fields",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    signup_nameerror.Visible = false;
                    signup_usernameerror.Visible = false;
                    signup_passerror.Visible = false;
                    signup_phoneerror.Visible = false;
                    signup_gendererror.Visible = false;
                    signup_doberror.Visible = false;
                }
            }
            else
            {
                insertion.insert_signup_user(name_signtxtbox.Text, username_signtxtbox.Text, pass_signtxtbox.Text, gender_signcombobox.Text, phone_signtxtbox.Text, theDate);
            }

            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            login l = new login();
            main_class.show_window(l, this, MdiParent);
        }
    }
}
