namespace ims_project
{
    partial class sample2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sample2));
            tableLayoutPanel1 = new TableLayoutPanel();
            viewbtn = new Button();
            delbtn = new Button();
            savebtn = new Button();
            addbtn = new Button();
            editbtn = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            searchtxtbox = new TextBox();
            backbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(backbtn);
            panel1.Size = new Size(250, 655);
            panel1.Controls.SetChildIndex(panel4, 0);
            panel1.Controls.SetChildIndex(backbtn, 0);
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.None;
            panel2.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            panel2.ForeColor = Color.FromArgb(0, 192, 192);
            panel2.Size = new Size(1072, 655);
            panel2.Paint += panel2_Paint_1;
            panel2.Controls.SetChildIndex(panel3, 0);
            panel2.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Dock = DockStyle.None;
            panel3.Size = new Size(1722, 46);
            // 
            // welcomelbl
            // 
            welcomelbl.Location = new Point(70, 0);
            welcomelbl.Click += welcomelbl_Click;
            // 
            // userlbl
            // 
            userlbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(viewbtn, 4, 0);
            tableLayoutPanel1.Controls.Add(delbtn, 3, 0);
            tableLayoutPanel1.Controls.Add(savebtn, 2, 0);
            tableLayoutPanel1.Controls.Add(addbtn, 0, 0);
            tableLayoutPanel1.Controls.Add(editbtn, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 5, 0);
            tableLayoutPanel1.Location = new Point(6, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1063, 86);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // viewbtn
            // 
            viewbtn.BackColor = SystemColors.ButtonHighlight;
            viewbtn.Cursor = Cursors.Hand;
            viewbtn.Dock = DockStyle.Fill;
            viewbtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            viewbtn.FlatAppearance.BorderSize = 3;
            viewbtn.FlatStyle = FlatStyle.Flat;
            viewbtn.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            viewbtn.ForeColor = Color.FromArgb(0, 192, 192);
            viewbtn.Image = (Image)resources.GetObject("viewbtn.Image");
            viewbtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewbtn.Location = new Point(711, 3);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(171, 80);
            viewbtn.TabIndex = 5;
            viewbtn.Text = "VIEW";
            viewbtn.TextAlign = ContentAlignment.MiddleRight;
            viewbtn.UseVisualStyleBackColor = false;
            viewbtn.Click += viewbtn_Click;
            // 
            // delbtn
            // 
            delbtn.BackColor = SystemColors.ButtonHighlight;
            delbtn.Cursor = Cursors.Hand;
            delbtn.Dock = DockStyle.Fill;
            delbtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            delbtn.FlatAppearance.BorderSize = 3;
            delbtn.FlatStyle = FlatStyle.Flat;
            delbtn.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            delbtn.ForeColor = Color.FromArgb(0, 192, 192);
            delbtn.Image = (Image)resources.GetObject("delbtn.Image");
            delbtn.ImageAlign = ContentAlignment.MiddleLeft;
            delbtn.Location = new Point(534, 3);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(171, 80);
            delbtn.TabIndex = 3;
            delbtn.Text = "DELETE";
            delbtn.TextAlign = ContentAlignment.MiddleRight;
            delbtn.UseVisualStyleBackColor = false;
            delbtn.Click += delbtn_Click;
            // 
            // savebtn
            // 
            savebtn.BackColor = SystemColors.ButtonHighlight;
            savebtn.Cursor = Cursors.Hand;
            savebtn.Dock = DockStyle.Fill;
            savebtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            savebtn.FlatAppearance.BorderSize = 3;
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            savebtn.ForeColor = Color.FromArgb(0, 192, 192);
            savebtn.Image = (Image)resources.GetObject("savebtn.Image");
            savebtn.ImageAlign = ContentAlignment.MiddleLeft;
            savebtn.Location = new Point(357, 3);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(171, 80);
            savebtn.TabIndex = 2;
            savebtn.Text = "SAVE ";
            savebtn.TextAlign = ContentAlignment.MiddleRight;
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += savebtn_Click;
            // 
            // addbtn
            // 
            addbtn.Cursor = Cursors.Hand;
            addbtn.Dock = DockStyle.Fill;
            addbtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            addbtn.FlatAppearance.BorderSize = 3;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addbtn.ForeColor = Color.FromArgb(0, 192, 192);
            addbtn.Image = (Image)resources.GetObject("addbtn.Image");
            addbtn.ImageAlign = ContentAlignment.MiddleLeft;
            addbtn.Location = new Point(3, 3);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(171, 80);
            addbtn.TabIndex = 0;
            addbtn.Text = "ADD";
            addbtn.TextAlign = ContentAlignment.MiddleRight;
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = SystemColors.ButtonHighlight;
            editbtn.Cursor = Cursors.Hand;
            editbtn.Dock = DockStyle.Fill;
            editbtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            editbtn.FlatAppearance.BorderSize = 3;
            editbtn.FlatStyle = FlatStyle.Flat;
            editbtn.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            editbtn.ForeColor = Color.FromArgb(0, 192, 192);
            editbtn.Image = (Image)resources.GetObject("editbtn.Image");
            editbtn.ImageAlign = ContentAlignment.MiddleLeft;
            editbtn.Location = new Point(180, 3);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(171, 80);
            editbtn.TabIndex = 1;
            editbtn.Text = "EDIT";
            editbtn.TextAlign = ContentAlignment.MiddleRight;
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(searchtxtbox);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.FromArgb(0, 192, 192);
            groupBox1.Location = new Point(888, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 80);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SEARCH";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 46);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // searchtxtbox
            // 
            searchtxtbox.AcceptsTab = true;
            searchtxtbox.Location = new Point(0, 49);
            searchtxtbox.MaximumSize = new Size(1000, 0);
            searchtxtbox.Name = "searchtxtbox";
            searchtxtbox.Size = new Size(158, 25);
            searchtxtbox.TabIndex = 2;
            searchtxtbox.TextChanged += searchtxtbox_TextChanged_1;
            // 
            // backbtn
            // 
            backbtn.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            backbtn.ForeColor = Color.FromArgb(0, 192, 192);
            backbtn.Image = (Image)resources.GetObject("backbtn.Image");
            backbtn.ImageAlign = ContentAlignment.MiddleLeft;
            backbtn.Location = new Point(3, 52);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(61, 38);
            backbtn.TabIndex = 2;
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // sample2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 655);
            Name = "sample2";
            Text = "sample2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public TableLayoutPanel tableLayoutPanel1;
        public Button delbtn;
        public Button savebtn;
        public Button addbtn;
        public Button editbtn;
        public TextBox searchtxtbox;
        public GroupBox groupBox1;
        public Button backbtn;
        public Button viewbtn;
        private PictureBox pictureBox1;
    }
}