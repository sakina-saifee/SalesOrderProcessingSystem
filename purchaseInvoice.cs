using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ims_project
{
    public partial class purchaseInvoice : sample2
    {
        ProceedToCheckout ptc = new ProceedToCheckout();
        int edit = 0; //0 indicates to save data, 1 indicates to edit the data
        int purchase_invoice_id;
        //Regex regex = new Regex(" (/^[0-9]+$/)");
        float gross = Convert.ToSingle(0.0);
        public static string suppliercompanyname;
        public static float gross_amount = Convert.ToSingle(0.0);

        public purchaseInvoice()
        {
            InitializeComponent();
        }

        private void purchaseInvoice_Load(object sender, EventArgs e)
        {
            userlbl.Text = retrieval.user_login_name;
            main_class.disable(panel1);
            retrieval.getsupplierlist("view_supplier", supplierComboBox, "Company Name", "Supplier ID");

        }

        public override void addbtn_Click(object sender, EventArgs e)
        {
            edit = 0;// 0 represents to not do edit
            main_class.enable(panel1);
            retrieval.getsupplierlist("view_supplier", supplierComboBox, "Company Name", "Supplier ID");
        }

        private void supplierComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            retrieval.getsupplierlist("view_supplier", supplierComboBox, "Company Name", "Supplier ID");
            // suppliercompanyname = supplierComboBox.SelectedItem.ToString();
            // MessageBox.Show(suppliercompanyname);

        }

        private void supplierComboBox_Click(object sender, EventArgs e)
        {
            retrieval.getsupplierlist("view_supplier", supplierComboBox, "Company Name", "Supplier ID");
            //suppliercompanyname = supplierComboBox.SelectedText;
        }

        private void selectproducttxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string[] productArr = new string[10];
        int productID;

        private void barcodetxtbox_TextChanged(object sender, EventArgs e)
        {
            if (barcodetxtbox.Text != "")
            {

                productArr = retrieval.get_product_by_barcode(barcodetxtbox.Text);
                // retrieval.barcode_found_or_not();
                productID = Convert.ToInt32(productArr[0]);
                producttxtbox.Text = productArr[1];
                perunitpricetxtbox.Text = productArr[2];
                producttxtbox.Enabled = false;
                perunitpricetxtbox.Enabled = false;
                string barcodee = productArr[3];
                if (barcodee != null)
                {
                    selectquantitytxtbox.Focus();

                }

            }
            else
            {

                productID = 0;
                producttxtbox.Text = "";
                perunitpricetxtbox.Text = "";
                Array.Clear(productArr, 0, productArr.Length);

            }
        }

        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            if (supplierComboBox.SelectedIndex == -1) { supplier_error.Visible = true; } else { supplier_error.Visible = false; }
            if (barcodetxtbox.Text == "") { barcode_error.Visible = true; } else { barcode_error.Visible = false; }
            if (selectquantitytxtbox.Text == "") { selectquantity_error.Visible = true; } else { selectquantity_error.Visible = false; }


            if (supplier_error.Visible || barcode_error.Visible || selectquantity_error.Visible)
            {

                main_class.showmsg("PLease fill the * fields", "Missing data fields", "error");
            }
            else
            {

                //  insertion.insertPurchaseInvoiceDetails(producttxtbox.Text, Convert.ToSingle(perunitpricetxtbox.Text.ToString()), Convert.ToInt32(selectquantitytxtbox.Text.ToString()), Convert.ToSingle(totalpricelbl.Text.ToString()));

                displaydgv.Rows.Add(retrieval.purchase_invoice_id, producttxtbox.Text, perunitpricetxtbox.Text, selectquantitytxtbox.Text, totalpricelbl.Text);
                gross += Convert.ToSingle(totalpricelbl.Text.ToString());
                gross_amount = gross;

                //retrieval.show_purchaseInvoice(displaydgv, purchaseiddgv, prodnamedgv, perunitpricedgv, quantitydgv, totalamountdgv);


                productID = 0;
                producttxtbox.Text = "";
                perunitpricetxtbox.Text = "";
                selectquantitytxtbox.Text = "";
                totalpricelbl.Text = "0.00";
                barcodetxtbox.Text = "";
                Array.Clear(productArr, 0, productArr.Length);
                grosstotalLabel.Text = gross.ToString();

            }


        }

        private void selectquantitytxtbox_TextChanged(object sender, EventArgs e)
        {
            if (selectquantitytxtbox.Text != "")
            {
                float quantity, price, total;
                quantity = Convert.ToSingle(selectquantitytxtbox.Text);
                price = Convert.ToSingle(perunitpricetxtbox.Text);
                total = price * quantity;
                totalpricelbl.Text = total.ToString();



            }
            else
            {
                totalpricelbl.Text = "0.00";
            }
        }



        int count;
        public override void savebtn_Click(object sender, EventArgs e)
        {

            //ke gridview khali na ho

            // int purchaseInvoiceID;
            // purchaseInvoiceID=insertion.insertPurchaseInvoice(DateTime.Today,retrieval.user_login_id,Convert.ToInt16((supplierComboBox.SelectedValue)) );

            // using (TransactionScope sc = new TransactionScope()) //mtlb jitni b query hai sath mai chale wrna koi b na chale
            // {
            if (displaydgv.Rows.Count != 0)
            {
                // retrieval.show_purchaseInvoice(displaydgv, productdgv, perunitpricedgv, quantitydgv, totalamountdgv);
            }
            else
            {


            }

            if (count > 0)
            {
                main_class.showmsg("PurchaseInvoice details created!", "Success", "sucess");
            }
            else
            {
                main_class.showmsg("Unable to create PurchaseInvoice details!", "Error", "error");
            }
            // sc.Complete();




        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void proceedtocheckoutbtn_Click(object sender, EventArgs e)
        {

            if (supplierComboBox.SelectedIndex == -1) { supplier_error.Visible = true; } else { supplier_error.Visible = false; }
            if (barcodetxtbox.Text == "") { barcode_error.Visible = true; } else { barcode_error.Visible = false; }
            if (selectquantitytxtbox.Text == "") { selectquantity_error.Visible = true; } else { selectquantity_error.Visible = false; }



            if (displaydgv.Rows.Count != 0 & displaydgv.Rows != null)
            {
                foreach (DataGridViewRow rows in displaydgv.Rows)
                {
                    insertion.insertPurchaseInvoiceDetails(rows.Cells["prodnamedgv"].Value?.ToString(), Convert.ToSingle(rows.Cells["perunitpricedgv"].Value?.ToString()), Convert.ToInt32(rows.Cells["quantitydgv"].Value?.ToString()), Convert.ToSingle(rows.Cells["totalamountdgv"].Value?.ToString()));

                    //MessageBox.Show(rows.Cells["prodnamedgv"].Value?.ToString());
                }


                ptc.getset_grosstotal = Convert.ToSingle(grosstotalLabel.Text);
                main_class.show_window(ptc, this, MdiParent);




            }
            else
            {
                main_class.showmsg("No items in the cart!", "Empty Cart", "error");
            }


        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            // retrieval.show_purchaseInvoice(displaydgv, purchaseiddgv, prodnamedgv, perunitpricedgv, quantitydgv, totalamountdgv);

        }

        private void displaydgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {

                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = displaydgv.Rows[e.RowIndex];
                    gross -= Convert.ToSingle(row.Cells["totalamountdgv"].Value.ToString());
                    displaydgv.Rows.Remove(row);
                    grosstotalLabel.Text = gross.ToString();
                    gross_amount = gross;
                    ptc.getset_grosstotal = Convert.ToSingle(grosstotalLabel.Text);

                    // deletion.delete(retrieval.purchase_invoice_id, "delete_purchase_invoice_row", "@pid");
                }

            }
        }

        private void grosstotalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
