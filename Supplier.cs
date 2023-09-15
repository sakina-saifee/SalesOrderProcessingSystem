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
    public partial class Supplier : sample2
    {
        int edit = 0; //0 indicates to save data, 1 indicates to edit the data
        int suppid;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
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
                retrieval.show_suppliers(displaydgv, suppiddgv, companynamedgv, suppnamedgv, nicdgv, phonedgv, searchtxtbox.Text);
            }
            else
            {
                retrieval.show_suppliers(displaydgv, suppiddgv, companynamedgv, suppnamedgv, nicdgv, phonedgv);
            }
        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (companynametxtbox.Text == "") { companyname_error.Visible = true; } else { companyname_error.Visible = false; }
            if (suppnametxtbox.Text == "") { suppliername_error.Visible = true; } else { suppliername_error.Visible = false; }
            if (phonetxtbox.Text == "") { supplierphone_error.Visible = true; } else { supplierphone_error.Visible = false; }
            if (nictxtbox.Text == "") { nic_error.Visible = true; } else { nic_error.Visible = false; }


            if (companyname_error.Visible || suppliername_error.Visible || supplierphone_error.Visible || nic_error.Visible)
            {

                main_class.showmsg("PLease fill the * fields", "Missing data fields", "error");
            }
            else
            {
                if (edit == 0) //save operation code
                {

                    insertion.insertsupplier(companynametxtbox.Text, suppnametxtbox.Text, phonetxtbox.Text, nictxtbox.Text);
                    retrieval.show_suppliers(displaydgv, suppiddgv, companynamedgv, suppnamedgv, nicdgv, phonedgv);
                    main_class.disable_reset(panel1);

                }
                else if (edit == 1)//edit operation code
                {

                    DialogResult dr = main_class.showmsg("Are you sure you want to edit the record?", "Question..", "question");
                    if (dr == DialogResult.Yes)
                    {
                        updation.updatesupplier(suppid, companynametxtbox.Text, suppnametxtbox.Text, phonetxtbox.Text, nictxtbox.Text);
                        retrieval.show_suppliers(displaydgv, suppiddgv, companynamedgv, suppnamedgv, nicdgv, phonedgv);
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
                    deletion.delete(suppid, "[delete_supplier]", "@id");
                    retrieval.show_suppliers(displaydgv, suppiddgv, companynamedgv, suppnamedgv, nicdgv, phonedgv);
                }

            }

        }
        public override void viewbtn_Click(object sender, EventArgs e)
        {
            retrieval.show_suppliers(displaydgv, suppiddgv, companynamedgv, suppnamedgv, nicdgv, phonedgv);

        }
        

        private void displaydgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = new DataGridViewRow();
                row = displaydgv.Rows[e.RowIndex];
                suppid = Convert.ToInt32(row.Cells["suppiddgv"].Value.ToString());
                companynametxtbox.Text = row.Cells["companynamedgv"].Value.ToString();
                suppnametxtbox.Text = row.Cells["suppnamedgv"].Value.ToString();
                phonetxtbox.Text = row.Cells["phonedgv"].Value.ToString();
                nictxtbox.Text = row.Cells["nicdgv"].Value.ToString();

                main_class.disable(panel1);
            }
        }
    }
}
