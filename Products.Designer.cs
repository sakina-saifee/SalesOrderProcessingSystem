namespace ims_project
{
    partial class Products
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Productlbl = new Label();
            barcodelbl = new Label();
            producttxtbox = new TextBox();
            barcodetxtbox = new TextBox();
            productname_error = new Label();
            barcode_error = new Label();
            expirylbl = new Label();
            expirydateTimePicker = new DateTimePicker();
            expirydate_validationerror = new Label();
            pricetxtbox = new TextBox();
            pricelbl = new Label();
            price_error = new Label();
            categorylbl = new Label();
            cat_prodComboBox = new ComboBox();
            prodcategory_error = new Label();
            panel5 = new Panel();
            displaydgv = new DataGridView();
            prodnamedgv = new DataGridViewTextBoxColumn();
            prodiddgv = new DataGridViewTextBoxColumn();
            barcodedgv = new DataGridViewTextBoxColumn();
            pricedgv = new DataGridViewTextBoxColumn();
            expirydgv = new DataGridViewTextBoxColumn();
            catIDdgv = new DataGridViewTextBoxColumn();
            CategoryNamedgv = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displaydgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cat_prodComboBox);
            panel1.Controls.Add(categorylbl);
            panel1.Controls.Add(pricetxtbox);
            panel1.Controls.Add(pricelbl);
            panel1.Controls.Add(price_error);
            panel1.Controls.Add(expirydateTimePicker);
            panel1.Controls.Add(expirylbl);
            panel1.Controls.Add(barcodetxtbox);
            panel1.Controls.Add(producttxtbox);
            panel1.Controls.Add(barcodelbl);
            panel1.Controls.Add(Productlbl);
            panel1.Controls.Add(barcode_error);
            panel1.Controls.Add(productname_error);
            panel1.Controls.Add(expirydate_validationerror);
            panel1.Controls.Add(prodcategory_error);
            panel1.Size = new Size(250, 681);
            panel1.Controls.SetChildIndex(prodcategory_error, 0);
            panel1.Controls.SetChildIndex(expirydate_validationerror, 0);
            panel1.Controls.SetChildIndex(productname_error, 0);
            panel1.Controls.SetChildIndex(barcode_error, 0);
            panel1.Controls.SetChildIndex(panel4, 0);
            panel1.Controls.SetChildIndex(Productlbl, 0);
            panel1.Controls.SetChildIndex(barcodelbl, 0);
            panel1.Controls.SetChildIndex(producttxtbox, 0);
            panel1.Controls.SetChildIndex(barcodetxtbox, 0);
            panel1.Controls.SetChildIndex(expirylbl, 0);
            panel1.Controls.SetChildIndex(expirydateTimePicker, 0);
            panel1.Controls.SetChildIndex(price_error, 0);
            panel1.Controls.SetChildIndex(pricelbl, 0);
            panel1.Controls.SetChildIndex(pricetxtbox, 0);
            panel1.Controls.SetChildIndex(categorylbl, 0);
            panel1.Controls.SetChildIndex(cat_prodComboBox, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Size = new Size(1064, 681);
            panel2.Controls.SetChildIndex(panel3, 0);
            panel2.Controls.SetChildIndex(panel5, 0);
            // 
            // panel3
            // 
            panel3.Size = new Size(1064, 46);
            // 
            // Productlbl
            // 
            Productlbl.AutoSize = true;
            Productlbl.Location = new Point(12, 132);
            Productlbl.Name = "Productlbl";
            Productlbl.Size = new Size(104, 20);
            Productlbl.TabIndex = 2;
            Productlbl.Text = "Product Name";
            // 
            // barcodelbl
            // 
            barcodelbl.AutoSize = true;
            barcodelbl.Location = new Point(12, 208);
            barcodelbl.Name = "barcodelbl";
            barcodelbl.Size = new Size(64, 20);
            barcodelbl.TabIndex = 3;
            barcodelbl.Text = "Barcode";
            // 
            // producttxtbox
            // 
            producttxtbox.Location = new Point(12, 159);
            producttxtbox.Name = "producttxtbox";
            producttxtbox.Size = new Size(206, 27);
            producttxtbox.TabIndex = 4;
            // 
            // barcodetxtbox
            // 
            barcodetxtbox.Location = new Point(12, 231);
            barcodetxtbox.Name = "barcodetxtbox";
            barcodetxtbox.Size = new Size(214, 27);
            barcodetxtbox.TabIndex = 5;
            // 
            // productname_error
            // 
            productname_error.AutoSize = true;
            productname_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            productname_error.ForeColor = Color.Red;
            productname_error.Location = new Point(122, 132);
            productname_error.Name = "productname_error";
            productname_error.Size = new Size(31, 41);
            productname_error.TabIndex = 13;
            productname_error.Text = "*";
            productname_error.Visible = false;
            // 
            // barcode_error
            // 
            barcode_error.AutoSize = true;
            barcode_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            barcode_error.ForeColor = Color.Red;
            barcode_error.Location = new Point(122, 208);
            barcode_error.Name = "barcode_error";
            barcode_error.Size = new Size(31, 41);
            barcode_error.TabIndex = 14;
            barcode_error.Text = "*";
            barcode_error.Visible = false;
            // 
            // expirylbl
            // 
            expirylbl.AutoSize = true;
            expirylbl.Location = new Point(12, 286);
            expirylbl.Name = "expirylbl";
            expirylbl.Size = new Size(85, 20);
            expirylbl.TabIndex = 15;
            expirylbl.Text = "Expiry Date";
            // 
            // expirydateTimePicker
            // 
            expirydateTimePicker.CustomFormat = "dd-MMM-yyyy";
            expirydateTimePicker.Format = DateTimePickerFormat.Custom;
            expirydateTimePicker.Location = new Point(12, 320);
            expirydateTimePicker.Name = "expirydateTimePicker";
            expirydateTimePicker.Size = new Size(232, 27);
            expirydateTimePicker.TabIndex = 16;
            // 
            // expirydate_validationerror
            // 
            expirydate_validationerror.AutoSize = true;
            expirydate_validationerror.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            expirydate_validationerror.ForeColor = Color.Red;
            expirydate_validationerror.Location = new Point(122, 286);
            expirydate_validationerror.Name = "expirydate_validationerror";
            expirydate_validationerror.Size = new Size(31, 41);
            expirydate_validationerror.TabIndex = 17;
            expirydate_validationerror.Text = "*";
            expirydate_validationerror.Visible = false;
            // 
            // pricetxtbox
            // 
            pricetxtbox.Location = new Point(12, 392);
            pricetxtbox.Name = "pricetxtbox";
            pricetxtbox.Size = new Size(214, 27);
            pricetxtbox.TabIndex = 19;
            // 
            // pricelbl
            // 
            pricelbl.AutoSize = true;
            pricelbl.Location = new Point(12, 369);
            pricelbl.Name = "pricelbl";
            pricelbl.Size = new Size(41, 20);
            pricelbl.TabIndex = 18;
            pricelbl.Text = "Price";
            // 
            // price_error
            // 
            price_error.AutoSize = true;
            price_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            price_error.ForeColor = Color.Red;
            price_error.Location = new Point(122, 352);
            price_error.Name = "price_error";
            price_error.Size = new Size(31, 41);
            price_error.TabIndex = 20;
            price_error.Text = "*";
            price_error.Visible = false;
            // 
            // categorylbl
            // 
            categorylbl.AutoSize = true;
            categorylbl.Location = new Point(12, 439);
            categorylbl.Name = "categorylbl";
            categorylbl.Size = new Size(69, 20);
            categorylbl.TabIndex = 21;
            categorylbl.Text = "Category";
            // 
            // cat_prodComboBox
            // 
            cat_prodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cat_prodComboBox.FormattingEnabled = true;
            cat_prodComboBox.Location = new Point(12, 472);
            cat_prodComboBox.Name = "cat_prodComboBox";
            cat_prodComboBox.Size = new Size(214, 28);
            cat_prodComboBox.TabIndex = 22;
            cat_prodComboBox.SelectedIndexChanged += cat_prodComboBox_SelectedIndexChanged_1;
            cat_prodComboBox.MouseClick += cat_prodComboBox_MouseClick;
            // 
            // prodcategory_error
            // 
            prodcategory_error.AutoSize = true;
            prodcategory_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            prodcategory_error.ForeColor = Color.Red;
            prodcategory_error.Location = new Point(122, 439);
            prodcategory_error.Name = "prodcategory_error";
            prodcategory_error.Size = new Size(31, 41);
            prodcategory_error.TabIndex = 23;
            prodcategory_error.Text = "*";
            prodcategory_error.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(displaydgv);
            panel5.Location = new Point(0, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(1033, 552);
            panel5.TabIndex = 2;
            // 
            // displaydgv
            // 
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
            displaydgv.Columns.AddRange(new DataGridViewColumn[] { prodnamedgv, prodiddgv, barcodedgv, pricedgv, expirydgv, catIDdgv, CategoryNamedgv });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            displaydgv.DefaultCellStyle = dataGridViewCellStyle2;
            displaydgv.Dock = DockStyle.Fill;
            displaydgv.Location = new Point(0, 0);
            displaydgv.Name = "displaydgv";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            displaydgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            displaydgv.RowHeadersVisible = false;
            displaydgv.RowHeadersWidth = 51;
            displaydgv.RowTemplate.Height = 29;
            displaydgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displaydgv.Size = new Size(1033, 552);
            displaydgv.TabIndex = 1;
            displaydgv.CellClick += displaydgv_CellClick;
            // 
            // prodnamedgv
            // 
            prodnamedgv.HeaderText = "Product Name";
            prodnamedgv.MinimumWidth = 6;
            prodnamedgv.Name = "prodnamedgv";
            // 
            // prodiddgv
            // 
            prodiddgv.HeaderText = "Product ID";
            prodiddgv.MinimumWidth = 6;
            prodiddgv.Name = "prodiddgv";
            prodiddgv.ReadOnly = true;
            prodiddgv.Visible = false;
            // 
            // barcodedgv
            // 
            barcodedgv.HeaderText = "Barcode";
            barcodedgv.MinimumWidth = 6;
            barcodedgv.Name = "barcodedgv";
            // 
            // pricedgv
            // 
            pricedgv.HeaderText = "Price";
            pricedgv.MinimumWidth = 6;
            pricedgv.Name = "pricedgv";
            // 
            // expirydgv
            // 
            expirydgv.HeaderText = "Expiry Date";
            expirydgv.MinimumWidth = 6;
            expirydgv.Name = "expirydgv";
            // 
            // catIDdgv
            // 
            catIDdgv.HeaderText = "Category ID";
            catIDdgv.MinimumWidth = 6;
            catIDdgv.Name = "catIDdgv";
            catIDdgv.ReadOnly = true;
            catIDdgv.Visible = false;
            // 
            // CategoryNamedgv
            // 
            CategoryNamedgv.HeaderText = "Category";
            CategoryNamedgv.MinimumWidth = 6;
            CategoryNamedgv.Name = "CategoryNamedgv";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 681);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)displaydgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox barcodetxtbox;
        private TextBox producttxtbox;
        private Label barcodelbl;
        private Label Productlbl;
        private Label barcode_error;
        private Label productname_error;
        private ComboBox cat_prodComboBox;
        private Label categorylbl;
        private TextBox pricetxtbox;
        private Label pricelbl;
        private Label price_error;
        private DateTimePicker expirydateTimePicker;
        private Label expirylbl;
        private Label expirydate_validationerror;
        private Label prodcategory_error;
        private Panel panel5;
        public DataGridView displaydgv;
        private DataGridViewTextBoxColumn prodnamedgv;
        private DataGridViewTextBoxColumn prodiddgv;
        private DataGridViewTextBoxColumn barcodedgv;
        private DataGridViewTextBoxColumn pricedgv;
        private DataGridViewTextBoxColumn expirydgv;
        private DataGridViewTextBoxColumn catIDdgv;
        private DataGridViewTextBoxColumn CategoryNamedgv;
    }
}