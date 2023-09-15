using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ims_project
{
    public partial class categories : sample2
    {
        public categories()
        {
            InitializeComponent();
        }



        int edit = 0; //0 indicates to save data, 1 indicates to edit the data
        int catid;
        short status;
        private void categories_Load(object sender, EventArgs e)
        {
            userlbl.Text = retrieval.user_login_name;
            main_class.disable(panel1);
        }
        public override void backbtn_Click(object sender, EventArgs e)
        {
            homescreen hs = new homescreen();
            main_class.show_window(hs, this, Form.ActiveForm);
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
                retrieval.showcategorydata(categoryDGV, CatidDGV, catnameDGV, IsActiveDGV, searchtxtbox.Text);
            }
            else
            {
                retrieval.showcategorydata(categoryDGV, CatidDGV, catnameDGV, IsActiveDGV);
            }

        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (categorytxtbox.Text == "") { categoryname_error.Visible = true; } else { categoryname_error.Visible = false; }
            if (isactive_comboBox.SelectedIndex == -1) { isactive_error.Visible = true; } else { isactive_error.Visible = false; }

            if (categoryname_error.Visible || isactive_error.Visible)
            {

                main_class.showmsg("PLease fill the * fields", "Missing data fields", "error");
            }
            else
            {
                if (isactive_comboBox.SelectedIndex == 0)
                {

                    status = 1;
                }
                else if (isactive_comboBox.SelectedIndex == 1)
                {
                    status = 0;
                }
                if (edit == 0) //save operation code
                {

                    insertion.insertcategories(categorytxtbox.Text, status);
                    retrieval.showcategorydata(categoryDGV, CatidDGV, catnameDGV, IsActiveDGV);
                    main_class.disable_reset(panel1);

                }
                else if (edit == 1)//edit operation code
                {


                    DialogResult dr = main_class.showmsg("Are you sure you want to edit the record?", "Question..", "question");
                    if (dr == DialogResult.Yes)
                    {
                        updation.updatecategories(catid, categorytxtbox.Text, status);
                        retrieval.showcategorydata(categoryDGV, CatidDGV, catnameDGV, IsActiveDGV);
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
                    deletion.delete(catid, "[delete_categories]", "@id");
                    retrieval.showcategorydata(categoryDGV, CatidDGV, catnameDGV, IsActiveDGV);
                }

            }
           

        }



        public override void viewbtn_Click(object sender, EventArgs e)
        {
            retrieval.showcategorydata(categoryDGV, CatidDGV, catnameDGV, IsActiveDGV);
        }

        private void categoryDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = new DataGridViewRow();
                row = categoryDGV.Rows[e.RowIndex];
                catid = Convert.ToInt32(row.Cells["CatidDGV"].Value.ToString());
                categorytxtbox.Text = row.Cells["catnameDGV"].Value.ToString();
                isactive_comboBox.SelectedItem = row.Cells["IsActiveDGV"].Value.ToString();

                main_class.disable(panel1);
            }
        }
    }
}
