namespace ims_project
{
    partial class billinvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            purchaseInvoiceDetails1BindingSource = new BindingSource(components);
            imsdbDataSet1 = new imsdbDataSet1();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            purchaseInvoiceDetails1TableAdapter = new imsdbDataSet1TableAdapters.purchaseInvoiceDetails1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)purchaseInvoiceDetails1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imsdbDataSet1).BeginInit();
            SuspendLayout();
            // 
            // purchaseInvoiceDetails1BindingSource
            // 
            purchaseInvoiceDetails1BindingSource.DataMember = "purchaseInvoiceDetails1";
            purchaseInvoiceDetails1BindingSource.DataSource = imsdbDataSet1;
            // 
            // imsdbDataSet1
            // 
            imsdbDataSet1.DataSetName = "imsdbDataSet1";
            imsdbDataSet1.Namespace = "http://tempuri.org/imsdbDataSet1.xsd";
            imsdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = purchaseInvoiceDetails1BindingSource;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ims_project.purchaseinvoiceReport.rdlc";
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.ServerReport.ReportPath = "C:\\Users\\sakin\\source\\repos\\ims_project(working)\\ims_project\\purchaseinvoiceReport.rdlc";
            reportViewer1.Size = new Size(914, 450);
            reportViewer1.TabIndex = 0;
            // 
            // purchaseInvoiceDetails1TableAdapter
            // 
            purchaseInvoiceDetails1TableAdapter.ClearBeforeFill = true;
            // 
            // billinvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(reportViewer1);
            Name = "billinvoice";
            Text = "billinvoice";
            Load += billinvoice_Load;
            ((System.ComponentModel.ISupportInitialize)purchaseInvoiceDetails1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)imsdbDataSet1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private imsdbDataSet1 imsdbDataSet1;
        private BindingSource purchaseInvoiceDetails1BindingSource;
        private imsdbDataSet1TableAdapters.purchaseInvoiceDetails1TableAdapter purchaseInvoiceDetails1TableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}