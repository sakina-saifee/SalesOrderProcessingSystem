namespace ims_project
{
    partial class homescreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homescreen));
            tableLayoutPanel1 = new TableLayoutPanel();
            purchasebtn = new Button();
            productbtn = new Button();
            USERSBTN = new Button();
            supplierbtn2 = new Button();
            categories2btn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Size = new Size(1020, 659);
            panel2.Controls.SetChildIndex(panel3, 0);
            panel2.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // panel3
            // 
            panel3.Size = new Size(1020, 46);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(purchasebtn, 3, 0);
            tableLayoutPanel1.Controls.Add(productbtn, 1, 0);
            tableLayoutPanel1.Controls.Add(USERSBTN, 0, 0);
            tableLayoutPanel1.Controls.Add(supplierbtn2, 2, 0);
            tableLayoutPanel1.Controls.Add(categories2btn, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 46);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1020, 613);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // purchasebtn
            // 
            purchasebtn.BackColor = SystemColors.ButtonHighlight;
            purchasebtn.Cursor = Cursors.Hand;
            purchasebtn.Dock = DockStyle.Fill;
            purchasebtn.FlatAppearance.BorderSize = 4;
            purchasebtn.FlatStyle = FlatStyle.Flat;
            purchasebtn.Font = new Font("Calibri", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            purchasebtn.ForeColor = Color.FromArgb(0, 192, 192);
            purchasebtn.Image = (Image)resources.GetObject("purchasebtn.Image");
            purchasebtn.ImageAlign = ContentAlignment.MiddleLeft;
            purchasebtn.Location = new Point(766, 4);
            purchasebtn.Name = "purchasebtn";
            purchasebtn.Size = new Size(250, 197);
            purchasebtn.TabIndex = 3;
            purchasebtn.Text = "PURCHASE INVOICE";
            purchasebtn.TextAlign = ContentAlignment.MiddleRight;
            purchasebtn.UseVisualStyleBackColor = false;
            purchasebtn.Click += purchasebtn_Click;
            // 
            // productbtn
            // 
            productbtn.BackColor = SystemColors.ButtonHighlight;
            productbtn.Cursor = Cursors.Hand;
            productbtn.Dock = DockStyle.Fill;
            productbtn.FlatAppearance.BorderSize = 4;
            productbtn.FlatStyle = FlatStyle.Flat;
            productbtn.Font = new Font("Calibri", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            productbtn.ForeColor = Color.FromArgb(0, 192, 192);
            productbtn.Image = (Image)resources.GetObject("productbtn.Image");
            productbtn.ImageAlign = ContentAlignment.BottomLeft;
            productbtn.Location = new Point(258, 4);
            productbtn.Name = "productbtn";
            productbtn.Size = new Size(247, 197);
            productbtn.TabIndex = 1;
            productbtn.Text = "PRODUCT";
            productbtn.TextAlign = ContentAlignment.MiddleRight;
            productbtn.UseVisualStyleBackColor = false;
            productbtn.Click += productbtn_Click;
            // 
            // USERSBTN
            // 
            USERSBTN.BackColor = SystemColors.ButtonHighlight;
            USERSBTN.Cursor = Cursors.Hand;
            USERSBTN.Dock = DockStyle.Fill;
            USERSBTN.FlatAppearance.BorderSize = 4;
            USERSBTN.FlatStyle = FlatStyle.Flat;
            USERSBTN.Font = new Font("Calibri", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            USERSBTN.ForeColor = Color.FromArgb(0, 192, 192);
            USERSBTN.Image = (Image)resources.GetObject("USERSBTN.Image");
            USERSBTN.ImageAlign = ContentAlignment.BottomCenter;
            USERSBTN.Location = new Point(4, 4);
            USERSBTN.Name = "USERSBTN";
            USERSBTN.Size = new Size(247, 197);
            USERSBTN.TabIndex = 0;
            USERSBTN.Text = "USERS";
            USERSBTN.TextAlign = ContentAlignment.MiddleRight;
            USERSBTN.UseVisualStyleBackColor = false;
            USERSBTN.Click += USERSBTN_Click;
            // 
            // supplierbtn2
            // 
            supplierbtn2.Dock = DockStyle.Fill;
            supplierbtn2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            supplierbtn2.FlatAppearance.BorderSize = 4;
            supplierbtn2.FlatStyle = FlatStyle.Flat;
            supplierbtn2.Font = new Font("Calibri", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            supplierbtn2.ForeColor = Color.FromArgb(0, 192, 192);
            supplierbtn2.Image = (Image)resources.GetObject("supplierbtn2.Image");
            supplierbtn2.Location = new Point(512, 4);
            supplierbtn2.Name = "supplierbtn2";
            supplierbtn2.Size = new Size(247, 197);
            supplierbtn2.TabIndex = 11;
            supplierbtn2.Text = "SUPPLIER";
            supplierbtn2.TextAlign = ContentAlignment.MiddleRight;
            supplierbtn2.UseVisualStyleBackColor = true;
            supplierbtn2.Click += supplierbtn2_Click;
            // 
            // categories2btn
            // 
            categories2btn.Dock = DockStyle.Fill;
            categories2btn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            categories2btn.FlatAppearance.BorderSize = 4;
            categories2btn.FlatStyle = FlatStyle.Flat;
            categories2btn.Font = new Font("Calibri", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            categories2btn.ForeColor = Color.FromArgb(0, 192, 192);
            categories2btn.Image = (Image)resources.GetObject("categories2btn.Image");
            categories2btn.ImageAlign = ContentAlignment.MiddleLeft;
            categories2btn.Location = new Point(4, 208);
            categories2btn.Name = "categories2btn";
            categories2btn.Size = new Size(247, 197);
            categories2btn.TabIndex = 12;
            categories2btn.Text = "CATEGORIES";
            categories2btn.TextAlign = ContentAlignment.MiddleRight;
            categories2btn.UseVisualStyleBackColor = true;
            categories2btn.Click += categories2btn_Click;
            // 
            // homescreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 659);
            Name = "homescreen";
            Text = "homescreen";
            WindowState = FormWindowState.Maximized;
            Load += homescreen_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button purchasebtn;
        private Button productbtn;
        private Button USERSBTN;
        private Button supplierbtn2;
        private Button categories2btn;
    }
}