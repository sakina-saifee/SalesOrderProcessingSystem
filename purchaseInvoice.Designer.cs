namespace ims_project
{
    partial class purchaseInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            supplierlbl = new Label();
            supplierComboBox = new ComboBox();
            barcode = new Label();
            barcodetxtbox = new TextBox();
            selectquantitylbl = new Label();
            selectquantitytxtbox = new TextBox();
            productlbl = new Label();
            producttxtbox = new TextBox();
            perunitpricelbl = new Label();
            perunitpricetxtbox = new TextBox();
            addtocartbtn = new Button();
            panel5 = new Panel();
            displaydgv = new DataGridView();
            purchaseiddgv = new DataGridViewTextBoxColumn();
            prodnamedgv = new DataGridViewTextBoxColumn();
            perunitpricedgv = new DataGridViewTextBoxColumn();
            quantitydgv = new DataGridViewTextBoxColumn();
            totalamountdgv = new DataGridViewTextBoxColumn();
            actiondgv = new DataGridViewButtonColumn();
            panel6 = new Panel();
            proceedtocheckoutbtn = new Button();
            grosstotalLabel = new Label();
            label6 = new Label();
            supplier_error = new Label();
            barcode_error = new Label();
            selectquantity_error = new Label();
            label1 = new Label();
            totalpricelbl = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displaydgv).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(totalpricelbl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(addtocartbtn);
            panel1.Controls.Add(perunitpricetxtbox);
            panel1.Controls.Add(perunitpricelbl);
            panel1.Controls.Add(selectquantitytxtbox);
            panel1.Controls.Add(selectquantitylbl);
            panel1.Controls.Add(producttxtbox);
            panel1.Controls.Add(productlbl);
            panel1.Controls.Add(barcodetxtbox);
            panel1.Controls.Add(barcode);
            panel1.Controls.Add(supplierComboBox);
            panel1.Controls.Add(supplierlbl);
            panel1.Controls.Add(barcode_error);
            panel1.Controls.Add(supplier_error);
            panel1.Controls.Add(selectquantity_error);
            panel1.Size = new Size(270, 554);
            panel1.TabIndex = 1;
            panel1.Controls.SetChildIndex(backbtn, 0);
            panel1.Controls.SetChildIndex(selectquantity_error, 0);
            panel1.Controls.SetChildIndex(supplier_error, 0);
            panel1.Controls.SetChildIndex(barcode_error, 0);
            panel1.Controls.SetChildIndex(panel4, 0);
            panel1.Controls.SetChildIndex(supplierlbl, 0);
            panel1.Controls.SetChildIndex(supplierComboBox, 0);
            panel1.Controls.SetChildIndex(barcode, 0);
            panel1.Controls.SetChildIndex(barcodetxtbox, 0);
            panel1.Controls.SetChildIndex(productlbl, 0);
            panel1.Controls.SetChildIndex(producttxtbox, 0);
            panel1.Controls.SetChildIndex(selectquantitylbl, 0);
            panel1.Controls.SetChildIndex(selectquantitytxtbox, 0);
            panel1.Controls.SetChildIndex(perunitpricelbl, 0);
            panel1.Controls.SetChildIndex(perunitpricetxtbox, 0);
            panel1.Controls.SetChildIndex(addtocartbtn, 0);
            panel1.Controls.SetChildIndex(label1, 0);
            panel1.Controls.SetChildIndex(totalpricelbl, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(270, 0);
            panel2.Size = new Size(1063, 554);
            panel2.Controls.SetChildIndex(panel3, 0);
            panel2.Controls.SetChildIndex(panel5, 0);
            // 
            // panel4
            // 
            panel4.Size = new Size(270, 46);
            // 
            // panel3
            // 
            panel3.Size = new Size(1063, 46);
            // 
            // supplierlbl
            // 
            supplierlbl.AutoSize = true;
            supplierlbl.Location = new Point(3, 90);
            supplierlbl.Name = "supplierlbl";
            supplierlbl.Size = new Size(64, 20);
            supplierlbl.TabIndex = 2;
            supplierlbl.Text = "Supplier";
            // 
            // supplierComboBox
            // 
            supplierComboBox.Cursor = Cursors.Hand;
            supplierComboBox.ForeColor = Color.Teal;
            supplierComboBox.Items.AddRange(new object[] { "select.." });
            supplierComboBox.Location = new Point(4, 113);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(239, 28);
            supplierComboBox.TabIndex = 0;
            supplierComboBox.SelectedIndexChanged += supplierComboBox_SelectedIndexChanged;
            supplierComboBox.SelectedValueChanged += supplierComboBox_SelectedValueChanged;
            supplierComboBox.Click += supplierComboBox_Click;
            // 
            // barcode
            // 
            barcode.AutoSize = true;
            barcode.Location = new Point(3, 144);
            barcode.Name = "barcode";
            barcode.Size = new Size(64, 20);
            barcode.TabIndex = 4;
            barcode.Text = "Barcode";
            barcode.Click += label1_Click;
            // 
            // barcodetxtbox
            // 
            barcodetxtbox.Location = new Point(5, 171);
            barcodetxtbox.Name = "barcodetxtbox";
            barcodetxtbox.Size = new Size(239, 27);
            barcodetxtbox.TabIndex = 1;
            barcodetxtbox.TextChanged += barcodetxtbox_TextChanged;
            // 
            // selectquantitylbl
            // 
            selectquantitylbl.AutoSize = true;
            selectquantitylbl.Location = new Point(4, 315);
            selectquantitylbl.Name = "selectquantitylbl";
            selectquantitylbl.Size = new Size(109, 20);
            selectquantitylbl.TabIndex = 6;
            selectquantitylbl.Text = "Select Quantity";
            // 
            // selectquantitytxtbox
            // 
            selectquantitytxtbox.Location = new Point(4, 338);
            selectquantitytxtbox.Name = "selectquantitytxtbox";
            selectquantitytxtbox.Size = new Size(240, 27);
            selectquantitytxtbox.TabIndex = 4;
            selectquantitytxtbox.TextChanged += selectquantitytxtbox_TextChanged;
            // 
            // productlbl
            // 
            productlbl.AutoSize = true;
            productlbl.Location = new Point(5, 201);
            productlbl.Name = "productlbl";
            productlbl.Size = new Size(60, 20);
            productlbl.TabIndex = 4;
            productlbl.Text = "Product";
            productlbl.Click += label1_Click;
            // 
            // producttxtbox
            // 
            producttxtbox.Enabled = false;
            producttxtbox.Location = new Point(4, 224);
            producttxtbox.Name = "producttxtbox";
            producttxtbox.Size = new Size(239, 27);
            producttxtbox.TabIndex = 2;
            producttxtbox.TextChanged += selectproducttxtbox_TextChanged;
            // 
            // perunitpricelbl
            // 
            perunitpricelbl.AutoSize = true;
            perunitpricelbl.Location = new Point(0, 261);
            perunitpricelbl.Name = "perunitpricelbl";
            perunitpricelbl.Size = new Size(94, 20);
            perunitpricelbl.TabIndex = 8;
            perunitpricelbl.Text = "Per unit Price";
            // 
            // perunitpricetxtbox
            // 
            perunitpricetxtbox.Enabled = false;
            perunitpricetxtbox.Location = new Point(0, 284);
            perunitpricetxtbox.Name = "perunitpricetxtbox";
            perunitpricetxtbox.Size = new Size(240, 27);
            perunitpricetxtbox.TabIndex = 3;
            // 
            // addtocartbtn
            // 
            addtocartbtn.BackgroundImageLayout = ImageLayout.None;
            addtocartbtn.Cursor = Cursors.Hand;
            addtocartbtn.FlatAppearance.BorderSize = 3;
            addtocartbtn.FlatStyle = FlatStyle.Flat;
            addtocartbtn.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addtocartbtn.ForeColor = Color.Honeydew;
            addtocartbtn.Location = new Point(21, 371);
            addtocartbtn.Name = "addtocartbtn";
            addtocartbtn.Size = new Size(187, 53);
            addtocartbtn.TabIndex = 10;
            addtocartbtn.Text = "ADD TO CART";
            addtocartbtn.UseVisualStyleBackColor = true;
            addtocartbtn.Click += addtocartbtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(displaydgv);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(1021, 428);
            panel5.TabIndex = 2;
            // 
            // displaydgv
            // 
            displaydgv.AllowUserToAddRows = false;
            displaydgv.AllowUserToOrderColumns = true;
            displaydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            displaydgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            displaydgv.BackgroundColor = SystemColors.ButtonHighlight;
            displaydgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            displaydgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            displaydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            displaydgv.Columns.AddRange(new DataGridViewColumn[] { purchaseiddgv, prodnamedgv, perunitpricedgv, quantitydgv, totalamountdgv, actiondgv });
            displaydgv.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            displaydgv.DefaultCellStyle = dataGridViewCellStyle3;
            displaydgv.EnableHeadersVisualStyles = false;
            displaydgv.Location = new Point(6, 7);
            displaydgv.Name = "displaydgv";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            displaydgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            displaydgv.RowHeadersVisible = false;
            displaydgv.RowHeadersWidth = 51;
            displaydgv.RowTemplate.Height = 29;
            displaydgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displaydgv.Size = new Size(1015, 292);
            displaydgv.TabIndex = 23;
            displaydgv.CellContentClick += displaydgv_CellContentClick_1;
            // 
            // purchaseiddgv
            // 
            purchaseiddgv.HeaderText = "Purchase ID";
            purchaseiddgv.MinimumWidth = 6;
            purchaseiddgv.Name = "purchaseiddgv";
            purchaseiddgv.ReadOnly = true;
            purchaseiddgv.Visible = false;
            // 
            // prodnamedgv
            // 
            prodnamedgv.HeaderText = "Product Name";
            prodnamedgv.MinimumWidth = 6;
            prodnamedgv.Name = "prodnamedgv";
            // 
            // perunitpricedgv
            // 
            perunitpricedgv.HeaderText = "Per Unit Price ";
            perunitpricedgv.MinimumWidth = 6;
            perunitpricedgv.Name = "perunitpricedgv";
            // 
            // quantitydgv
            // 
            quantitydgv.HeaderText = "Quantity";
            quantitydgv.MinimumWidth = 6;
            quantitydgv.Name = "quantitydgv";
            // 
            // totalamountdgv
            // 
            totalamountdgv.HeaderText = "Total Amount";
            totalamountdgv.MinimumWidth = 6;
            totalamountdgv.Name = "totalamountdgv";
            // 
            // actiondgv
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 192, 192);
            actiondgv.DefaultCellStyle = dataGridViewCellStyle2;
            actiondgv.HeaderText = "Action";
            actiondgv.MinimumWidth = 6;
            actiondgv.Name = "actiondgv";
            actiondgv.Text = "DELETE";
            actiondgv.ToolTipText = "DELETE";
            actiondgv.UseColumnTextForButtonValue = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(proceedtocheckoutbtn);
            panel6.Controls.Add(grosstotalLabel);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(-3, 305);
            panel6.Name = "panel6";
            panel6.Size = new Size(1032, 123);
            panel6.TabIndex = 2;
            // 
            // proceedtocheckoutbtn
            // 
            proceedtocheckoutbtn.BackColor = Color.Teal;
            proceedtocheckoutbtn.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            proceedtocheckoutbtn.FlatAppearance.BorderSize = 4;
            proceedtocheckoutbtn.ForeColor = Color.White;
            proceedtocheckoutbtn.Location = new Point(727, 14);
            proceedtocheckoutbtn.Name = "proceedtocheckoutbtn";
            proceedtocheckoutbtn.Size = new Size(278, 81);
            proceedtocheckoutbtn.TabIndex = 22;
            proceedtocheckoutbtn.Text = "PROCEED TO CHECKOUT";
            proceedtocheckoutbtn.UseVisualStyleBackColor = false;
            proceedtocheckoutbtn.Click += proceedtocheckoutbtn_Click;
            // 
            // grosstotalLabel
            // 
            grosstotalLabel.AutoSize = true;
            grosstotalLabel.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            grosstotalLabel.Location = new Point(516, 11);
            grosstotalLabel.Name = "grosstotalLabel";
            grosstotalLabel.Size = new Size(205, 106);
            grosstotalLabel.TabIndex = 21;
            grosstotalLabel.Text = "0.00";
            grosstotalLabel.Click += grosstotalLabel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(276, 28);
            label6.Name = "label6";
            label6.Size = new Size(205, 42);
            label6.TabIndex = 20;
            label6.Text = "Gross Total";
            // 
            // supplier_error
            // 
            supplier_error.AutoSize = true;
            supplier_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            supplier_error.ForeColor = Color.Red;
            supplier_error.Location = new Point(212, 83);
            supplier_error.Name = "supplier_error";
            supplier_error.Size = new Size(31, 41);
            supplier_error.TabIndex = 13;
            supplier_error.Text = "*";
            supplier_error.Visible = false;
            // 
            // barcode_error
            // 
            barcode_error.AutoSize = true;
            barcode_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            barcode_error.ForeColor = Color.Red;
            barcode_error.Location = new Point(212, 144);
            barcode_error.Name = "barcode_error";
            barcode_error.Size = new Size(31, 41);
            barcode_error.TabIndex = 14;
            barcode_error.Text = "*";
            barcode_error.Visible = false;
            // 
            // selectquantity_error
            // 
            selectquantity_error.AutoSize = true;
            selectquantity_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            selectquantity_error.ForeColor = Color.Red;
            selectquantity_error.Location = new Point(212, 314);
            selectquantity_error.Name = "selectquantity_error";
            selectquantity_error.Size = new Size(31, 41);
            selectquantity_error.TabIndex = 17;
            selectquantity_error.Text = "*";
            selectquantity_error.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 442);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 18;
            label1.Text = "Total Amount";
            // 
            // totalpricelbl
            // 
            totalpricelbl.AutoSize = true;
            totalpricelbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            totalpricelbl.Location = new Point(58, 477);
            totalpricelbl.Name = "totalpricelbl";
            totalpricelbl.Size = new Size(89, 46);
            totalpricelbl.TabIndex = 19;
            totalpricelbl.Text = "0.00";
            // 
            // purchaseInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 554);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "purchaseInvoice";
            Text = "purchaseInvoice";
            Load += purchaseInvoice_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)displaydgv).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label supplierlbl;
        private TextBox barcodetxtbox;
        private Label barcode;
        private TextBox selectquantitytxtbox;
        private Label selectquantitylbl;
        private TextBox producttxtbox;
        private Label productlbl;
        private TextBox perunitpricetxtbox;
        private Label perunitpricelbl;
        private Button addtocartbtn;
        private Panel panel5;
        private Label barcode_error;
        private Label supplier_error;
        private Label selectquantity_error;
        private Label label1;
        private Label totalpricelbl;
        private Panel panel6;
        private Label label6;
        public ComboBox supplierComboBox;
        private Button proceedtocheckoutbtn;
        public DataGridView displaydgv;
        private DataGridViewTextBoxColumn purchaseiddgv;
        private DataGridViewTextBoxColumn prodnamedgv;
        private DataGridViewTextBoxColumn perunitpricedgv;
        private DataGridViewTextBoxColumn quantitydgv;
        private DataGridViewTextBoxColumn totalamountdgv;
        private DataGridViewButtonColumn actiondgv;
        public Label grosstotalLabel;
    }
}