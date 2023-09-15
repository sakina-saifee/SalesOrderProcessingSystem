using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims_project
{
    public partial class users : sample2
    {
        int edit = 0; //0 indicates to save data, 1 indicates to edit the data
        int userid;
        public users()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void users_Load(object sender, EventArgs e)

        {
            userlbl.Text = retrieval.user_login_name;
            main_class.disable(panel1);
        }

        public override void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1; // 1 represents to do edit\
            main_class.enable(panel1);
        }

        public override void addbtn_Click(object sender, EventArgs e)
        {
            edit = 0;// 0 represents to not do edit
            main_class.enable(panel1);
        }

        public override void searchtxtbox_TextChanged_1(object sender, EventArgs e)
        {
            if (searchtxtbox.Text != " ")
            {
                retrieval.showusers(displaydgv, useriddgv, namedgv, usernamedgv, passdgv, phonedgv, emaildgv, statusdgv, searchtxtbox.Text);
            }
            else
            {
                retrieval.showusers(displaydgv, useriddgv, namedgv, usernamedgv, passdgv, phonedgv, emaildgv, statusdgv);
            }
        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (nametxtbox.Text == "") { name_error.Visible = true; } else { name_error.Visible = false; }
            if (usertxtbox.Text == "") { username_error.Visible = true; } else { username_error.Visible = false; }
            if (passtxtbox.Text == "") { pass_error.Visible = true; } else { pass_error.Visible = false; }
            if (phonetxtbox.Text == "") { phone_error.Visible = true; } else { phone_error.Visible = false; }
            if (emailtxtbox.Text == "") { mail_error.Visible = true; } else { mail_error.Visible = false; }

            if (name_error.Visible || username_error.Visible || pass_error.Visible || phone_error.Visible || mail_error.Visible)
            {

                main_class.showmsg("PLease fill the * fields", "Missing data fields", "error");
            }
            else
            {
                if (edit == 0) //save operation code
                {

                    insertion.insertuser(nametxtbox.Text, usertxtbox.Text, passtxtbox.Text, phonetxtbox.Text, emailtxtbox.Text);
                    retrieval.showusers(displaydgv, useriddgv, namedgv, usernamedgv, passdgv, phonedgv, emaildgv, statusdgv);
                    main_class.disable_reset(panel1);

                }
                else if (edit == 1)//edit operation code
                {

                    DialogResult dr = main_class.showmsg("Are you sure you want to edit the record?", "Question..", "question");
                    if (dr == DialogResult.Yes)
                    {
                        updation.updateuser(userid, nametxtbox.Text, usertxtbox.Text, passtxtbox.Text, phonetxtbox.Text, emailtxtbox.Text);
                        retrieval.showusers(displaydgv, useriddgv, namedgv, usernamedgv, passdgv, phonedgv, emaildgv, statusdgv);
                        main_class.disable_reset(panel1);
                    }


                }


            }
        }

        public override void delbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult warning = main_class.showmsg("Are you sure you want to delete the data?", "Warning!!!!", "warning");
                if (warning == DialogResult.Yes)
                {
                    deletion.delete(userid, "[st_deleteUsers]", "@id");
                    retrieval.showusers(displaydgv, useriddgv, namedgv, usernamedgv, passdgv, phonedgv, emaildgv, statusdgv);
                }

            }

        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            retrieval.showusers(displaydgv, useriddgv, namedgv, usernamedgv, passdgv, phonedgv, emaildgv, statusdgv);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void displaydgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = new DataGridViewRow();
                row = displaydgv.Rows[e.RowIndex];
                userid = Convert.ToInt32(row.Cells["useriddgv"].Value.ToString());
                nametxtbox.Text = row.Cells["namedgv"].Value.ToString();
                usertxtbox.Text = row.Cells["usernamedgv"].Value.ToString();
                passtxtbox.Text = row.Cells["passdgv"].Value.ToString();
                phonetxtbox.Text = row.Cells["phonedgv"].Value.ToString();
                emailtxtbox.Text = row.Cells["emaildgv"].Value.ToString();
                main_class.disable(panel1);
            }
        }
    }
}
