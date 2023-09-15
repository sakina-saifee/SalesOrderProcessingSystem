namespace ims_project
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            USERNAME = new Label();
            login_usernametxtbox = new TextBox();
            PASSWORD = new Label();
            login_passtxtbox = new TextBox();
            loginbtn = new Button();
            login_usernameerror = new Label();
            login_passerror = new Label();
            signup_lbl = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(signup_lbl);
            panel1.Controls.Add(login_passerror);
            panel1.Controls.Add(loginbtn);
            panel1.Controls.Add(login_passtxtbox);
            panel1.Controls.Add(PASSWORD);
            panel1.Controls.Add(login_usernametxtbox);
            panel1.Controls.Add(USERNAME);
            panel1.Controls.Add(login_usernameerror);
            panel1.Size = new Size(303, 547);
            panel1.Controls.SetChildIndex(login_usernameerror, 0);
            panel1.Controls.SetChildIndex(USERNAME, 0);
            panel1.Controls.SetChildIndex(login_usernametxtbox, 0);
            panel1.Controls.SetChildIndex(PASSWORD, 0);
            panel1.Controls.SetChildIndex(login_passtxtbox, 0);
            panel1.Controls.SetChildIndex(loginbtn, 0);
            panel1.Controls.SetChildIndex(login_passerror, 0);
            panel1.Controls.SetChildIndex(signup_lbl, 0);
            panel1.Controls.SetChildIndex(panel4, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(303, 0);
            panel2.Size = new Size(798, 547);
            panel2.Controls.SetChildIndex(panel3, 0);
            panel2.Controls.SetChildIndex(pictureBox1, 0);
            // 
            // panel4
            // 
            panel4.Size = new Size(303, 46);
            // 
            // panel3
            // 
            panel3.Size = new Size(798, 46);
            // 
            // welcomelbl
            // 
            welcomelbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            welcomelbl.ImageAlign = ContentAlignment.TopRight;
            welcomelbl.Location = new Point(89, -1);
            welcomelbl.Size = new Size(155, 46);
            welcomelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userlbl
            // 
            userlbl.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userlbl.Location = new Point(0, 4);
            userlbl.Size = new Size(145, 37);
            // 
            // USERNAME
            // 
            USERNAME.AutoSize = true;
            USERNAME.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            USERNAME.Location = new Point(22, 187);
            USERNAME.Name = "USERNAME";
            USERNAME.Size = new Size(119, 28);
            USERNAME.TabIndex = 2;
            USERNAME.Text = "USERNAME";
            // 
            // login_usernametxtbox
            // 
            login_usernametxtbox.Location = new Point(12, 222);
            login_usernametxtbox.Name = "login_usernametxtbox";
            login_usernametxtbox.Size = new Size(214, 27);
            login_usernametxtbox.TabIndex = 3;
            login_usernametxtbox.TextChanged += login_usernametxtbox_TextChanged;
            // 
            // PASSWORD
            // 
            PASSWORD.AutoSize = true;
            PASSWORD.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PASSWORD.Location = new Point(17, 264);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(124, 28);
            PASSWORD.TabIndex = 4;
            PASSWORD.Text = "PASSWORD";
            PASSWORD.Click += PASSWORD_Click;
            // 
            // login_passtxtbox
            // 
            login_passtxtbox.AcceptsTab = true;
            login_passtxtbox.Enabled = false;
            login_passtxtbox.Location = new Point(12, 307);
            login_passtxtbox.MaxLength = 30;
            login_passtxtbox.Name = "login_passtxtbox";
            login_passtxtbox.Size = new Size(214, 27);
            login_passtxtbox.TabIndex = 5;
            login_passtxtbox.TextChanged += passtxt_TextChanged;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.Teal;
            loginbtn.Location = new Point(52, 397);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(174, 37);
            loginbtn.TabIndex = 6;
            loginbtn.Text = "LOGIN";
            loginbtn.UseMnemonic = false;
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.UseWaitCursor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // login_usernameerror
            // 
            login_usernameerror.AutoSize = true;
            login_usernameerror.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            login_usernameerror.ForeColor = Color.Red;
            login_usernameerror.Location = new Point(147, 187);
            login_usernameerror.Name = "login_usernameerror";
            login_usernameerror.Size = new Size(32, 41);
            login_usernameerror.TabIndex = 7;
            login_usernameerror.Text = "*";
            login_usernameerror.Visible = false;
            // 
            // login_passerror
            // 
            login_passerror.AutoSize = true;
            login_passerror.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            login_passerror.ForeColor = Color.Red;
            login_passerror.Location = new Point(147, 263);
            login_passerror.Name = "login_passerror";
            login_passerror.Size = new Size(32, 41);
            login_passerror.TabIndex = 8;
            login_passerror.Text = "*";
            login_passerror.Visible = false;
            // 
            // signup_lbl
            // 
            signup_lbl.AutoSize = true;
            signup_lbl.BackColor = Color.Teal;
            signup_lbl.Cursor = Cursors.Hand;
            signup_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            signup_lbl.ForeColor = Color.Black;
            signup_lbl.Location = new Point(4, 462);
            signup_lbl.Name = "signup_lbl";
            signup_lbl.Size = new Size(296, 23);
            signup_lbl.TabIndex = 9;
            signup_lbl.Text = "Don't have an account? Sign up now!";
            signup_lbl.Click += signup_lbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 501);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 547);
            Name = "login";
            Text = ".0";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox login_passtxtbox;
        private Label PASSWORD;
        private TextBox login_usernametxtbox;
        private Label USERNAME;
        private Button loginbtn;
        private Label login_usernameerror;
        private Label signup_lbl;
        public Label login_passerror;
        private PictureBox pictureBox1;
    }
}