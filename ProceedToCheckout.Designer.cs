namespace ims_project
{
    partial class ProceedToCheckout
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
            amountpaidtxtbox = new TextBox();
            amountpaidlbl = new Label();
            taxtxtbox = new TextBox();
            taxlbl = new Label();
            shippingComboBox = new ComboBox();
            shippingchargeslbl = new Label();
            tax_error = new Label();
            shippingcharges_error = new Label();
            amountpaid_error = new Label();
            generatebtn = new Button();
            backbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(generatebtn);
            panel1.Controls.Add(amountpaidtxtbox);
            panel1.Controls.Add(amountpaidlbl);
            panel1.Controls.Add(taxtxtbox);
            panel1.Controls.Add(taxlbl);
            panel1.Controls.Add(shippingComboBox);
            panel1.Controls.Add(shippingchargeslbl);
            panel1.Controls.Add(tax_error);
            panel1.Controls.Add(shippingcharges_error);
            panel1.Controls.Add(amountpaid_error);
            panel1.Size = new Size(250, 447);
            panel1.Controls.SetChildIndex(amountpaid_error, 0);
            panel1.Controls.SetChildIndex(panel4, 0);
            panel1.Controls.SetChildIndex(shippingcharges_error, 0);
            panel1.Controls.SetChildIndex(tax_error, 0);
            panel1.Controls.SetChildIndex(shippingchargeslbl, 0);
            panel1.Controls.SetChildIndex(shippingComboBox, 0);
            panel1.Controls.SetChildIndex(taxlbl, 0);
            panel1.Controls.SetChildIndex(taxtxtbox, 0);
            panel1.Controls.SetChildIndex(amountpaidlbl, 0);
            panel1.Controls.SetChildIndex(amountpaidtxtbox, 0);
            panel1.Controls.SetChildIndex(generatebtn, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(732, 447);
            // 
            // panel4
            // 
            panel4.Controls.Add(backbtn);
            panel4.Controls.SetChildIndex(welcomelbl, 0);
            panel4.Controls.SetChildIndex(backbtn, 0);
            // 
            // panel3
            // 
            panel3.Size = new Size(732, 46);
            // 
            // amountpaidtxtbox
            // 
            amountpaidtxtbox.Location = new Point(3, 232);
            amountpaidtxtbox.Name = "amountpaidtxtbox";
            amountpaidtxtbox.Size = new Size(239, 27);
            amountpaidtxtbox.TabIndex = 20;
            // 
            // amountpaidlbl
            // 
            amountpaidlbl.AutoSize = true;
            amountpaidlbl.Location = new Point(3, 202);
            amountpaidlbl.Name = "amountpaidlbl";
            amountpaidlbl.Size = new Size(94, 20);
            amountpaidlbl.TabIndex = 24;
            amountpaidlbl.Text = "Amount Paid";
            // 
            // taxtxtbox
            // 
            taxtxtbox.Location = new Point(3, 172);
            taxtxtbox.Name = "taxtxtbox";
            taxtxtbox.Size = new Size(239, 27);
            taxtxtbox.TabIndex = 19;
            // 
            // taxlbl
            // 
            taxlbl.AutoSize = true;
            taxlbl.Location = new Point(6, 145);
            taxlbl.Name = "taxlbl";
            taxlbl.Size = new Size(30, 20);
            taxlbl.TabIndex = 25;
            taxlbl.Text = "Tax";
            // 
            // shippingComboBox
            // 
            shippingComboBox.Cursor = Cursors.Hand;
            shippingComboBox.ForeColor = Color.Teal;
            shippingComboBox.Items.AddRange(new object[] { "select..", "Standard Shipping", "Express Shipping" });
            shippingComboBox.Location = new Point(0, 114);
            shippingComboBox.Name = "shippingComboBox";
            shippingComboBox.Size = new Size(239, 28);
            shippingComboBox.TabIndex = 18;
            // 
            // shippingchargeslbl
            // 
            shippingchargeslbl.AutoSize = true;
            shippingchargeslbl.Location = new Point(6, 91);
            shippingchargeslbl.Name = "shippingchargeslbl";
            shippingchargeslbl.Size = new Size(125, 20);
            shippingchargeslbl.TabIndex = 21;
            shippingchargeslbl.Text = "Shipping Charges";
            // 
            // tax_error
            // 
            tax_error.AutoSize = true;
            tax_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tax_error.ForeColor = Color.Red;
            tax_error.Location = new Point(215, 145);
            tax_error.Name = "tax_error";
            tax_error.Size = new Size(31, 41);
            tax_error.TabIndex = 29;
            tax_error.Text = "*";
            tax_error.Visible = false;
            // 
            // shippingcharges_error
            // 
            shippingcharges_error.AutoSize = true;
            shippingcharges_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shippingcharges_error.ForeColor = Color.Red;
            shippingcharges_error.Location = new Point(215, 84);
            shippingcharges_error.Name = "shippingcharges_error";
            shippingcharges_error.Size = new Size(31, 41);
            shippingcharges_error.TabIndex = 28;
            shippingcharges_error.Text = "*";
            shippingcharges_error.Visible = false;
            // 
            // amountpaid_error
            // 
            amountpaid_error.AutoSize = true;
            amountpaid_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            amountpaid_error.ForeColor = Color.Red;
            amountpaid_error.Location = new Point(212, 202);
            amountpaid_error.Name = "amountpaid_error";
            amountpaid_error.Size = new Size(31, 41);
            amountpaid_error.TabIndex = 31;
            amountpaid_error.Text = "*";
            amountpaid_error.Visible = false;
            // 
            // generatebtn
            // 
            generatebtn.Dock = DockStyle.Bottom;
            generatebtn.FlatAppearance.BorderColor = Color.Navy;
            generatebtn.FlatAppearance.BorderSize = 4;
            generatebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            generatebtn.ForeColor = Color.Teal;
            generatebtn.Location = new Point(0, 395);
            generatebtn.Name = "generatebtn";
            generatebtn.Size = new Size(250, 52);
            generatebtn.TabIndex = 33;
            generatebtn.Text = "Generate Bill";
            generatebtn.UseVisualStyleBackColor = true;
            generatebtn.Click += generatebtn_Click;
            // 
            // backbtn
            // 
            backbtn.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            backbtn.ForeColor = Color.FromArgb(0, 192, 192);
            backbtn.Location = new Point(3, 18);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(38, 25);
            backbtn.TabIndex = 3;
            backbtn.Text = "<";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // ProceedToCheckout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 447);
            Name = "ProceedToCheckout";
            Text = "ProceedToCheckout";
            Load += ProceedToCheckout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox amountpaidtxtbox;
        private Label amountpaidlbl;
        private TextBox taxtxtbox;
        private Label taxlbl;
        public ComboBox shippingComboBox;
        private Label shippingchargeslbl;
        private Label tax_error;
        private Label shippingcharges_error;
        private Label amountpaid_error;
        private Button generatebtn;
        public Button backbtn;
    }
}