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
    public partial class billinvoice : Form
    {
        public billinvoice()
        {
            InitializeComponent();
        }

        private void billinvoice_Load(object sender, EventArgs e)
        {
            this.imsdbDataSet1.EnforceConstraints = false;
            this.purchaseInvoiceDetails1TableAdapter.Fill(this.imsdbDataSet1.purchaseInvoiceDetails1);
            this.reportViewer1.RefreshReport();
        }
    }
}
