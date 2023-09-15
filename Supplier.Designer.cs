namespace ims_project
{
    partial class Supplier
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
            nic_error = new Label();
            niclbl = new Label();
            nictxtbox = new TextBox();
            suppnametxtbox = new TextBox();
            phonelbl = new Label();
            suppliernametxtbox = new Label();
            companynametxtbox = new TextBox();
            companynamelbl = new Label();
            supplierphone_error = new Label();
            suppliername_error = new Label();
            companyname_error = new Label();
            panel5 = new Panel();
            displaydgv = new DataGridView();
            companynamedgv = new DataGridViewTextBoxColumn();
            suppiddgv = new DataGridViewTextBoxColumn();
            suppnamedgv = new DataGridViewTextBoxColumn();
            nicdgv = new DataGridViewTextBoxColumn();
            phonedgv = new DataGridViewTextBoxColumn();
            phonetxtbox = new TextBox();
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
            panel1.Controls.Add(phonetxtbox);
            panel1.Controls.Add(nic_error);
            panel1.Controls.Add(niclbl);
            panel1.Controls.Add(nictxtbox);
            panel1.Controls.Add(suppnametxtbox);
            panel1.Controls.Add(phonelbl);
            panel1.Controls.Add(suppliernametxtbox);
            panel1.Controls.Add(companynametxtbox);
            panel1.Controls.Add(companynamelbl);
            panel1.Controls.Add(supplierphone_error);
            panel1.Controls.Add(suppliername_error);
            panel1.Controls.Add(companyname_error);
            panel1.Size = new Size(299, 667);
            panel1.Controls.SetChildIndex(companyname_error, 0);
            panel1.Controls.SetChildIndex(suppliername_error, 0);
            panel1.Controls.SetChildIndex(supplierphone_error, 0);
            panel1.Controls.SetChildIndex(companynamelbl, 0);
            panel1.Controls.SetChildIndex(companynametxtbox, 0);
            panel1.Controls.SetChildIndex(suppliernametxtbox, 0);
            panel1.Controls.SetChildIndex(phonelbl, 0);
            panel1.Controls.SetChildIndex(suppnametxtbox, 0);
            panel1.Controls.SetChildIndex(nictxtbox, 0);
            panel1.Controls.SetChildIndex(niclbl, 0);
            panel1.Controls.SetChildIndex(nic_error, 0);
            panel1.Controls.SetChildIndex(panel4, 0);
            panel1.Controls.SetChildIndex(phonetxtbox, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(299, 0);
            panel2.Size = new Size(990, 667);
            panel2.Controls.SetChildIndex(panel3, 0);
            panel2.Controls.SetChildIndex(panel5, 0);
            // 
            // panel4
            // 
            panel4.Size = new Size(299, 46);
            // 
            // panel3
            // 
            panel3.Size = new Size(990, 46);
            // 
            // nic_error
            // 
            nic_error.AutoSize = true;
            nic_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nic_error.ForeColor = Color.Red;
            nic_error.Location = new Point(198, 338);
            nic_error.Name = "nic_error";
            nic_error.Size = new Size(31, 41);
            nic_error.TabIndex = 28;
            nic_error.Text = "*";
            nic_error.Visible = false;
            // 
            // niclbl
            // 
            niclbl.AutoSize = true;
            niclbl.Location = new Point(9, 347);
            niclbl.Name = "niclbl";
            niclbl.Size = new Size(33, 20);
            niclbl.TabIndex = 24;
            niclbl.Text = "NIC";
            // 
            // nictxtbox
            // 
            nictxtbox.Location = new Point(12, 382);
            nictxtbox.MaxLength = 11;
            nictxtbox.Name = "nictxtbox";
            nictxtbox.Size = new Size(220, 27);
            nictxtbox.TabIndex = 23;
            // 
            // suppnametxtbox
            // 
            suppnametxtbox.Location = new Point(12, 238);
            suppnametxtbox.MaxLength = 35;
            suppnametxtbox.Name = "suppnametxtbox";
            suppnametxtbox.Size = new Size(220, 27);
            suppnametxtbox.TabIndex = 21;
            // 
            // phonelbl
            // 
            phonelbl.AutoSize = true;
            phonelbl.Location = new Point(12, 282);
            phonelbl.Name = "phonelbl";
            phonelbl.Size = new Size(71, 20);
            phonelbl.TabIndex = 20;
            phonelbl.Text = "PHONE #";
            // 
            // suppliernametxtbox
            // 
            suppliernametxtbox.AutoSize = true;
            suppliernametxtbox.Location = new Point(9, 203);
            suppliernametxtbox.Name = "suppliernametxtbox";
            suppliernametxtbox.Size = new Size(117, 20);
            suppliernametxtbox.TabIndex = 19;
            suppliernametxtbox.Text = "SUPPLIER NAME";
            // 
            // companynametxtbox
            // 
            companynametxtbox.Location = new Point(9, 163);
            companynametxtbox.MaxLength = 30;
            companynametxtbox.Name = "companynametxtbox";
            companynametxtbox.Size = new Size(220, 27);
            companynametxtbox.TabIndex = 18;
            // 
            // companynamelbl
            // 
            companynamelbl.AutoSize = true;
            companynamelbl.Location = new Point(12, 136);
            companynamelbl.Name = "companynamelbl";
            companynamelbl.Size = new Size(124, 20);
            companynamelbl.TabIndex = 17;
            companynamelbl.Text = "COMPANY NAME";
            // 
            // supplierphone_error
            // 
            supplierphone_error.AutoSize = true;
            supplierphone_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            supplierphone_error.ForeColor = Color.Red;
            supplierphone_error.Location = new Point(201, 268);
            supplierphone_error.Name = "supplierphone_error";
            supplierphone_error.Size = new Size(31, 41);
            supplierphone_error.TabIndex = 27;
            supplierphone_error.Text = "*";
            supplierphone_error.Visible = false;
            // 
            // suppliername_error
            // 
            suppliername_error.AutoSize = true;
            suppliername_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            suppliername_error.ForeColor = Color.Red;
            suppliername_error.Location = new Point(198, 203);
            suppliername_error.Name = "suppliername_error";
            suppliername_error.Size = new Size(31, 41);
            suppliername_error.TabIndex = 31;
            suppliername_error.Text = "*";
            suppliername_error.Visible = false;
            // 
            // companyname_error
            // 
            companyname_error.AutoSize = true;
            companyname_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            companyname_error.ForeColor = Color.Red;
            companyname_error.Location = new Point(201, 119);
            companyname_error.Name = "companyname_error";
            companyname_error.Size = new Size(31, 41);
            companyname_error.TabIndex = 30;
            companyname_error.Text = "*";
            companyname_error.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(displaydgv);
            panel5.Location = new Point(10, 126);
            panel5.Name = "panel5";
            panel5.Size = new Size(976, 539);
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
            displaydgv.Columns.AddRange(new DataGridViewColumn[] { companynamedgv, suppiddgv, suppnamedgv, nicdgv, phonedgv });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            displaydgv.DefaultCellStyle = dataGridViewCellStyle2;
            displaydgv.Dock = DockStyle.Fill;
            displaydgv.EnableHeadersVisualStyles = false;
            displaydgv.Location = new Point(0, 0);
            displaydgv.Name = "displaydgv";
            displaydgv.ReadOnly = true;
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
            displaydgv.Size = new Size(976, 539);
            displaydgv.TabIndex = 1;
            displaydgv.CellClick += displaydgv_CellClick_1;
            // 
            // companynamedgv
            // 
            companynamedgv.HeaderText = "Company Name";
            companynamedgv.MinimumWidth = 6;
            companynamedgv.Name = "companynamedgv";
            companynamedgv.ReadOnly = true;
            // 
            // suppiddgv
            // 
            suppiddgv.HeaderText = "Supplier ID";
            suppiddgv.MinimumWidth = 6;
            suppiddgv.Name = "suppiddgv";
            suppiddgv.ReadOnly = true;
            suppiddgv.Visible = false;
            // 
            // suppnamedgv
            // 
            suppnamedgv.HeaderText = "Supplier  Name";
            suppnamedgv.MinimumWidth = 6;
            suppnamedgv.Name = "suppnamedgv";
            suppnamedgv.ReadOnly = true;
            // 
            // nicdgv
            // 
            nicdgv.HeaderText = "NIC";
            nicdgv.MinimumWidth = 6;
            nicdgv.Name = "nicdgv";
            nicdgv.ReadOnly = true;
            // 
            // phonedgv
            // 
            phonedgv.HeaderText = "Phone";
            phonedgv.MinimumWidth = 6;
            phonedgv.Name = "phonedgv";
            phonedgv.ReadOnly = true;
            // 
            // phonetxtbox
            // 
            phonetxtbox.Location = new Point(9, 316);
            phonetxtbox.Name = "phonetxtbox";
            phonetxtbox.Size = new Size(223, 27);
            phonetxtbox.TabIndex = 32;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 667);
            Name = "Supplier";
            Text = "Supplier";
            Load += Supplier_Load;
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

        private Label nic_error;
        private Label niclbl;
        private TextBox nictxtbox;
        private TextBox suppnametxtbox;
        private Label phonelbl;
        private Label suppliernametxtbox;
        private TextBox companynametxtbox;
        private Label companynamelbl;
        private Label supplierphone_error;
        private Label suppliername_error;
        private Label companyname_error;
        private Panel panel5;
        public DataGridView displaydgv;
        private DataGridViewTextBoxColumn companynamedgv;
        private DataGridViewTextBoxColumn suppiddgv;
        private DataGridViewTextBoxColumn suppnamedgv;
        private DataGridViewTextBoxColumn nicdgv;
        private DataGridViewTextBoxColumn phonedgv;
        private TextBox phonetxtbox;
    }
}