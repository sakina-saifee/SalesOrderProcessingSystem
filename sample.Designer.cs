namespace ims_project
{
    partial class sample
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
            panel1 = new Panel();
            panel4 = new Panel();
            welcomelbl = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            userlbl = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 659);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(welcomelbl);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 46);
            panel4.TabIndex = 1;
            // 
            // welcomelbl
            // 
            welcomelbl.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            welcomelbl.ForeColor = SystemColors.ButtonHighlight;
            welcomelbl.Location = new Point(50, 9);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(200, 60);
            welcomelbl.TabIndex = 1;
            welcomelbl.Text = "WELCOME";
            welcomelbl.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1674, 659);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(userlbl);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1674, 46);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // userlbl
            // 
            userlbl.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userlbl.ForeColor = Color.FromArgb(0, 192, 192);
            userlbl.Location = new Point(26, 9);
            userlbl.Name = "userlbl";
            userlbl.Size = new Size(157, 47);
            userlbl.TabIndex = 2;
            userlbl.Text = "USER";
            userlbl.Click += userlbl_Click;
            // 
            // sample
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 659);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "sample";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Panel panel2;
        public Panel panel4;
        public Panel panel3;
        public Label welcomelbl;
        public Label userlbl;
    }
}