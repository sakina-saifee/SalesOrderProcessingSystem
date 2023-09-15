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
    public partial class Products : sample2
    {
        int edit = 0; //0 indicates to save data, 1 indicates to edit the data
        int prodid;
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            userlbl.Text = retrieval.user_login_name;
            main_class.disable(panel1);
            retrieval.getcategorieslist("get_categories_list", cat_prodComboBox, "Category", "ID");
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
            main_class.enable_reset(panel1);


        }

        public override void searchtxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (producttxtbox.Text == "") { productname_error.Visible = true; } else { productname_error.Visible = false; }
            if (barcodetxtbox.Text == "") { barcode_error.Visible = true; } else { barcode_error.Visible = false; }
            if (pricetxtbox.Text == "") { price_error.Visible = true; } else { price_error.Visible = false; }

            if (expirydateTimePicker.Value < DateTime.Now)
            {
                expirydate_validationerror.Visible = true;
                MessageBox.Show("Invalid Date!", "Error..", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else { expirydate_validationerror.Visible = false; }

            if (cat_prodComboBox.SelectedIndex == -1)
            {
                prodcategory_error.Visible = true;
                MessageBox.Show("Select an item!", "Error..", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else { prodcategory_error.Visible = false; }

            if (productname_error.Visible || barcode_error.Visible || price_error.Visible || expirydate_validationerror.Visible || prodcategory_error.Visible)
            {

                main_class.showmsg("PLease fill the * fields", "Missing data fields", "error");
            }
            else
            {
                if (edit == 0) //save operation code
                {

                    insertion.insertProduct(producttxtbox.Text, barcodetxtbox.Text, Convert.ToDateTime(expirydateTimePicker.Value), Convert.ToSingle(pricetxtbox.Text), Convert.ToInt32(cat_prodComboBox.SelectedValue));
                    retrieval.showProducts(displaydgv, prodiddgv, prodnamedgv, barcodedgv, pricedgv, catIDdgv, expirydgv, CategoryNamedgv);
                    //  retrieval.showProducts(displaydgv, prodiddgv, prodnamedgv, barcodedgv, pricedgv, catIDdgv, expirydgv, CategoryNamedgv);
                    main_class.disable_reset(panel1);

                }
                else if (edit == 1)//edit operation code
                {

                    DialogResult dr = main_class.showmsg("Are you sure you want to edit the record?", "Question..", "question");
                    if (dr == DialogResult.Yes)
                    {
                        updation.updateProduct(prodid, producttxtbox.Text, barcodetxtbox.Text, Convert.ToDateTime(expirydateTimePicker.Value), Convert.ToSingle(pricetxtbox.Text), Convert.ToInt32(cat_prodComboBox.SelectedValue));
                        retrieval.showProducts(displaydgv, prodiddgv, prodnamedgv, barcodedgv, pricedgv, catIDdgv, expirydgv, CategoryNamedgv);
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
                    deletion.delete(prodid, "[st_deleteProducts]", "@p_id");
                    retrieval.showProducts(displaydgv, prodiddgv, prodnamedgv, barcodedgv, pricedgv, catIDdgv, expirydgv, CategoryNamedgv);
                }

            }
        }



        public override void viewbtn_Click(object sender, EventArgs e)
            
        {
            edit = 0;
            retrieval.showProducts(displaydgv, prodiddgv, prodnamedgv, barcodedgv, pricedgv, catIDdgv, expirydgv, CategoryNamedgv);
        }

        public void cat_prodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            retrieval.getcategorieslist("get_categories_list", cat_prodComboBox, "Category", "ID");
            main_class.enable(panel1);
        }

        public void cat_prodComboBox_MouseClick(object sender, MouseEventArgs e)
        { 
            retrieval.getcategorieslist("get_categories_list", cat_prodComboBox, "Category", "ID");
        }

        private void displaydgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 )
            {
                edit = 1;
                DataGridViewRow row = displaydgv.Rows[e.RowIndex];
               // row = displaydgv.Rows[e.RowIndex];
                prodid = Convert.ToInt32(row.Cells["prodiddgv"].Value.ToString());
                producttxtbox.Text = row.Cells["prodnamedgv"].Value.ToString();
                barcodetxtbox.Text = row.Cells["barcodedgv"].Value.ToString();
                pricetxtbox.Text = row.Cells["pricedgv"].Value.ToString();

                if (row.Cells["expirydgv"].FormattedValue == "")
                {

                    expirydateTimePicker.Value=DateTime.Now;
                }
                else
                {
                    expirydateTimePicker.Value = Convert.ToDateTime(row.Cells["expirydgv"].Value.ToString());
                }
               
                cat_prodComboBox.SelectedValue = row.Cells["catIDdgv"].Value.ToString();
                main_class.disable(panel1);
            }
        }

        private void cat_prodComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
