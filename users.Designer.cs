namespace ims_project
{
    partial class users
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            nametxtbox = new TextBox();
            usernametxtbox = new Label();
            label3 = new Label();
            usertxtbox = new TextBox();
            passtxtbox = new TextBox();
            phonetxtbox = new TextBox();
            phonelbl = new Label();
            mailtxtbox = new Label();
            emailtxtbox = new TextBox();
            name_error = new Label();
            phone_error = new Label();
            mail_error = new Label();
            pass_error = new Label();
            username_error = new Label();
            displaypanel = new Panel();
            displaydgv = new DataGridView();
            namedgv = new DataGridViewTextBoxColumn();
            useriddgv = new DataGridViewTextBoxColumn();
            usernamedgv = new DataGridViewTextBoxColumn();
            passdgv = new DataGridViewTextBoxColumn();
            phonedgv = new DataGridViewTextBoxColumn();
            emaildgv = new DataGridViewTextBoxColumn();
            statusdgv = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            displaypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displaydgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(emailtxtbox);
            panel1.Controls.Add(mailtxtbox);
            panel1.Controls.Add(phonelbl);
            panel1.Controls.Add(phonetxtbox);
            panel1.Controls.Add(passtxtbox);
            panel1.Controls.Add(usertxtbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(usernametxtbox);
            panel1.Controls.Add(nametxtbox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(name_error);
            panel1.Controls.Add(username_error);
            panel1.Controls.Add(pass_error);
            panel1.Controls.Add(mail_error);
            panel1.Controls.Add(phone_error);
            panel1.Size = new Size(250, 613);
            panel1.Paint += panel1_Paint;
            panel1.Controls.SetChildIndex(backbtn, 0);
            panel1.Controls.SetChildIndex(phone_error, 0);
            panel1.Controls.SetChildIndex(mail_error, 0);
            panel1.Controls.SetChildIndex(pass_error, 0);
            panel1.Controls.SetChildIndex(username_error, 0);
            panel1.Controls.SetChildIndex(name_error, 0);
            panel1.Controls.SetChildIndex(panel4, 0);
            panel1.Controls.SetChildIndex(label1, 0);
            panel1.Controls.SetChildIndex(nametxtbox, 0);
            panel1.Controls.SetChildIndex(usernametxtbox, 0);
            panel1.Controls.SetChildIndex(label3, 0);
            panel1.Controls.SetChildIndex(usertxtbox, 0);
            panel1.Controls.SetChildIndex(passtxtbox, 0);
            panel1.Controls.SetChildIndex(phonetxtbox, 0);
            panel1.Controls.SetChildIndex(phonelbl, 0);
            panel1.Controls.SetChildIndex(mailtxtbox, 0);
            panel1.Controls.SetChildIndex(emailtxtbox, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(displaypanel);
            panel2.Size = new Size(985, 613);
            panel2.Paint += panel2_Paint;
            panel2.Controls.SetChildIndex(panel3, 0);
            panel2.Controls.SetChildIndex(displaypanel, 0);
            // 
            // panel3
            // 
            panel3.Location = new Point(-91, 0);
            panel3.Size = new Size(985, 46);
            // 
            // userlbl
            // 
            userlbl.Location = new Point(99, 5);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 108);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "NAME";
            // 
            // nametxtbox
            // 
            nametxtbox.Location = new Point(0, 140);
            nametxtbox.MaxLength = 30;
            nametxtbox.Name = "nametxtbox";
            nametxtbox.Size = new Size(220, 27);
            nametxtbox.TabIndex = 3;
            // 
            // usernametxtbox
            // 
            usernametxtbox.AutoSize = true;
            usernametxtbox.Location = new Point(0, 180);
            usernametxtbox.Name = "usernametxtbox";
            usernametxtbox.Size = new Size(86, 20);
            usernametxtbox.TabIndex = 4;
            usernametxtbox.Text = "USERNAME";
            usernametxtbox.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 259);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "PASSWORD";
            // 
            // usertxtbox
            // 
            usertxtbox.Location = new Point(3, 215);
            usertxtbox.MaxLength = 35;
            usertxtbox.Name = "usertxtbox";
            usertxtbox.Size = new Size(220, 27);
            usertxtbox.TabIndex = 6;
            // 
            // passtxtbox
            // 
            passtxtbox.Location = new Point(0, 282);
            passtxtbox.MaxLength = 20;
            passtxtbox.Name = "passtxtbox";
            passtxtbox.PasswordChar = '*';
            passtxtbox.Size = new Size(220, 27);
            passtxtbox.TabIndex = 7;
            passtxtbox.UseSystemPasswordChar = true;
            // 
            // phonetxtbox
            // 
            phonetxtbox.Location = new Point(3, 359);
            phonetxtbox.MaxLength = 11;
            phonetxtbox.Name = "phonetxtbox";
            phonetxtbox.Size = new Size(220, 27);
            phonetxtbox.TabIndex = 8;
            // 
            // phonelbl
            // 
            phonelbl.AutoSize = true;
            phonelbl.Location = new Point(0, 324);
            phonelbl.Name = "phonelbl";
            phonelbl.Size = new Size(62, 20);
            phonelbl.TabIndex = 9;
            phonelbl.Text = "PHIONE";
            // 
            // mailtxtbox
            // 
            mailtxtbox.AutoSize = true;
            mailtxtbox.Location = new Point(3, 407);
            mailtxtbox.Name = "mailtxtbox";
            mailtxtbox.Size = new Size(51, 20);
            mailtxtbox.TabIndex = 10;
            mailtxtbox.Text = "EMAIL";
            // 
            // emailtxtbox
            // 
            emailtxtbox.Location = new Point(3, 430);
            emailtxtbox.MaxLength = 20;
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.Size = new Size(220, 27);
            emailtxtbox.TabIndex = 11;
            // 
            // name_error
            // 
            name_error.AutoSize = true;
            name_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            name_error.ForeColor = Color.Red;
            name_error.Location = new Point(189, 96);
            name_error.Name = "name_error";
            name_error.Size = new Size(31, 41);
            name_error.TabIndex = 12;
            name_error.Text = "*";
            name_error.Visible = false;
            // 
            // phone_error
            // 
            phone_error.AutoSize = true;
            phone_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            phone_error.ForeColor = Color.Red;
            phone_error.Location = new Point(189, 324);
            phone_error.Name = "phone_error";
            phone_error.Size = new Size(31, 41);
            phone_error.TabIndex = 13;
            phone_error.Text = "*";
            phone_error.Visible = false;
            // 
            // mail_error
            // 
            mail_error.AutoSize = true;
            mail_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            mail_error.ForeColor = Color.Red;
            mail_error.Location = new Point(192, 390);
            mail_error.Name = "mail_error";
            mail_error.Size = new Size(31, 41);
            mail_error.TabIndex = 14;
            mail_error.Text = "*";
            mail_error.Visible = false;
            // 
            // pass_error
            // 
            pass_error.AutoSize = true;
            pass_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pass_error.ForeColor = Color.Red;
            pass_error.Location = new Point(192, 245);
            pass_error.Name = "pass_error";
            pass_error.Size = new Size(31, 41);
            pass_error.TabIndex = 15;
            pass_error.Text = "*";
            pass_error.Visible = false;
            // 
            // username_error
            // 
            username_error.AutoSize = true;
            username_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            username_error.ForeColor = Color.Red;
            username_error.Location = new Point(192, 170);
            username_error.Name = "username_error";
            username_error.Size = new Size(31, 41);
            username_error.TabIndex = 16;
            username_error.Text = "*";
            username_error.Visible = false;
            // 
            // displaypanel
            // 
            displaypanel.Controls.Add(displaydgv);
            displaypanel.Location = new Point(6, 127);
            displaypanel.Name = "displaypanel";
            displaypanel.Size = new Size(979, 484);
            displaypanel.TabIndex = 2;
            // 
            // displaydgv
            // 
            displaydgv.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            displaydgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            displaydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            displaydgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            displaydgv.BackgroundColor = SystemColors.ButtonHighlight;
            displaydgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            displaydgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            displaydgv.ColumnHeadersHeight = 29;
            displaydgv.Columns.AddRange(new DataGridViewColumn[] { namedgv, useriddgv, usernamedgv, passdgv, phonedgv, emaildgv, statusdgv });
            displaydgv.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            displaydgv.DefaultCellStyle = dataGridViewCellStyle3;
            displaydgv.Dock = DockStyle.Fill;
            displaydgv.EnableHeadersVisualStyles = false;
            displaydgv.GridColor = Color.Teal;
            displaydgv.Location = new Point(0, 0);
            displaydgv.Name = "displaydgv";
            displaydgv.ReadOnly = true;
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
            displaydgv.Size = new Size(979, 484);
            displaydgv.TabIndex = 0;
            displaydgv.CellClick += displaydgv_CellClick;
            // 
            // namedgv
            // 
            namedgv.HeaderText = "Name";
            namedgv.MinimumWidth = 6;
            namedgv.Name = "namedgv";
            namedgv.ReadOnly = true;
            // 
            // useriddgv
            // 
            useriddgv.HeaderText = "User ID";
            useriddgv.MinimumWidth = 6;
            useriddgv.Name = "useriddgv";
            useriddgv.ReadOnly = true;
            useriddgv.Visible = false;
            // 
            // usernamedgv
            // 
            usernamedgv.HeaderText = "Username";
            usernamedgv.MinimumWidth = 6;
            usernamedgv.Name = "usernamedgv";
            usernamedgv.ReadOnly = true;
            // 
            // passdgv
            // 
            passdgv.HeaderText = "Password";
            passdgv.MinimumWidth = 6;
            passdgv.Name = "passdgv";
            passdgv.ReadOnly = true;
            // 
            // phonedgv
            // 
            phonedgv.HeaderText = "Phone";
            phonedgv.MinimumWidth = 6;
            phonedgv.Name = "phonedgv";
            phonedgv.ReadOnly = true;
            // 
            // emaildgv
            // 
            emaildgv.HeaderText = "Email";
            emaildgv.MinimumWidth = 6;
            emaildgv.Name = "emaildgv";
            emaildgv.ReadOnly = true;
            // 
            // statusdgv
            // 
            statusdgv.HeaderText = "Status";
            statusdgv.MinimumWidth = 6;
            statusdgv.Name = "statusdgv";
            statusdgv.ReadOnly = true;
            statusdgv.Visible = false;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 613);
            Name = "users";
            Text = "users";
            Load += users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            displaypanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)displaydgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label usernametxtbox;
        private TextBox nametxtbox;
        private Label label1;
        private Label phonelbl;
        private TextBox phonetxtbox;
        private TextBox passtxtbox;
        private TextBox usertxtbox;
        private Label label3;
        private TextBox emailtxtbox;
        private Label mailtxtbox;
        private Label name_error;
        private Label phone_error;
        private Label username_error;
        private Label pass_error;
        private Label mail_error;
        private Panel displaypanel;
        public DataGridView displaydgv;
        private DataGridViewTextBoxColumn namedgv;
        private DataGridViewTextBoxColumn useriddgv;
        private DataGridViewTextBoxColumn usernamedgv;
        private DataGridViewTextBoxColumn passdgv;
        private DataGridViewTextBoxColumn phonedgv;
        private DataGridViewTextBoxColumn emaildgv;
        private DataGridViewTextBoxColumn statusdgv;
    }
}