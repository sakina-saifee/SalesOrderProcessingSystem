using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ims_project
{
    public partial class ProceedToCheckout : sample
    {
        public float getset_grosstotal { get; set; }
        public ProceedToCheckout()
        {
            InitializeComponent();
        }

        float standardshipping = Convert.ToSingle(0.0);
        float expressshipping = Convert.ToSingle(0.0);
        float grosstotal = Convert.ToSingle(0.0);
        float change = Convert.ToSingle(0.0);

        
        private void ProceedToCheckout_Load(object sender, EventArgs e)
        {
            userlbl.Text = retrieval.user_login_name.ToString();
            grosstotal = getset_grosstotal;
        


        }

        private void generatebtn_Click(object sender, EventArgs e)
        {



            purchaseInvoice pi = new purchaseInvoice();

            if (shippingComboBox.SelectedIndex == -1) { shippingcharges_error.Visible = true; } else { shippingcharges_error.Visible = false; }
            if (taxtxtbox.Text == "") { tax_error.Visible = true; } else { tax_error.Visible = false; }
            if (amountpaidtxtbox.Text == "") { amountpaid_error.Visible = true; } else { amountpaid_error.Visible = false; }



            if (shippingcharges_error.Visible || tax_error.Visible || amountpaid_error.Visible)
            {

                main_class.showmsg("PLease fill the * fields", "Missing data fields", "error");
            }
            else
            {
                if (shippingComboBox.SelectedIndex != null)
                {
                    if (shippingComboBox.SelectedIndex==1)
                    {
                        
                        grosstotal += 50;

                    }
                    else if (shippingComboBox.SelectedIndex==2)
                    {
                       
                        grosstotal += 100;

                    }
                }

                else
                {

                }

                grosstotal += Convert.ToSingle(taxtxtbox.Text);
                if (grosstotal != 0 && amountpaidtxtbox.Text != "")
                {

                    change = grosstotal - Convert.ToSingle(amountpaidtxtbox.Text);
                    MessageBox.Show(grosstotal.ToString());
                }
                else
                {
                    main_class.showmsg("Gross Total is 0.0", "Empty Cart", "error");
                }

                billinvoice b = new billinvoice();

                ReportParameterCollection rpc = new ReportParameterCollection();

                rpc.Add(new ReportParameter("pID1", retrieval.get_Purchase_invoice_Id().ToString()));
                //   rpc.Add(new ReportParameter("suppliercompanynameparameter1", purchaseInvoice.suppliercompanyname));
                rpc.Add(new ReportParameter("usernameParameter", retrieval.user_login_name));
                rpc.Add(new ReportParameter("shippingchargesparameter", shippingComboBox.SelectedItem.ToString()));
                rpc.Add(new ReportParameter("taxParameter", taxtxtbox.Text));
                rpc.Add(new ReportParameter("amountpaidParameter", amountpaidtxtbox.Text));
                rpc.Add(new ReportParameter("changeParameter", change.ToString()));
                rpc.Add(new ReportParameter("grosstotalParameter", getset_grosstotal.ToString()));


                b.reportViewer1.LocalReport.SetParameters(rpc);
                b.reportViewer1.RefreshReport();
                //main_class.show_window(b, this, MdiParent);
                b.Show();
                this.Hide();
                deletion.truncate();
                MdiParent.Hide();
            }


            //  deletion.truncate();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            purchaseInvoice p = new purchaseInvoice();
            main_class.show_window(p, this, MdiParent);
        }

        
    }
}
