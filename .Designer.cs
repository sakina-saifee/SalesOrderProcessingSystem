namespace ims_project
{
    partial class categories
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
            categorytxtbox = new TextBox();
            isactivelbl = new Label();
            categorylbl = new Label();
            isactive_error = new Label();
            categoryname_error = new Label();
            isactive_comboBox = new ComboBox();
            panel5 = new Panel();
            categoryDGV = new DataGridView();
            CatidDGV = new DataGridViewTextBoxColumn();
            catnameDGV = new DataGridViewTextBoxColumn();
            IsActiveDGV = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(isactive_comboBox);
            panel1.Controls.Add(categorytxtbox);
            panel1.Controls.Add(isactivelbl);
            panel1.Controls.Add(categorylbl);
            panel1.Controls.Add(isactive_error);
            panel1.Controls.Add(categoryname_error);
            panel1.Size = new Size(250, 607);
            panel1.Controls.SetChildIndex(panel4, 0);
            panel1.Controls.SetChildIndex(categoryname_error, 0);
            panel1.Controls.SetChildIndex(isactive_error, 0);
            panel1.Controls.SetChildIndex(categorylbl, 0);
            panel1.Controls.SetChildIndex(isactivelbl, 0);
            panel1.Controls.SetChildIndex(categorytxtbox, 0);
            panel1.Controls.SetChildIndex(isactive_comboBox, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Size = new Size(1119, 607);
            panel2.Controls.SetChildIndex(panel3, 0);
            panel2.Controls.SetChildIndex(panel5, 0);
            // 
            // panel3
            // 
            panel3.Size = new Size(1119, 46);
            // 
            // categorytxtbox
            // 
            categorytxtbox.Location = new Point(12, 115);
            categorytxtbox.Name = "categorytxtbox";
            categorytxtbox.Size = new Size(206, 27);
            categorytxtbox.TabIndex = 17;
            // 
            // isactivelbl
            // 
            isactivelbl.AutoSize = true;
            isactivelbl.Location = new Point(12, 164);
            isactivelbl.Name = "isactivelbl";
            isactivelbl.Size = new Size(64, 20);
            isactivelbl.TabIndex = 16;
            isactivelbl.Text = "Is Active";
            // 
            // categorylbl
            // 
            categorylbl.AutoSize = true;
            categorylbl.Location = new Point(12, 88);
            categorylbl.Name = "categorylbl";
            categorylbl.Size = new Size(113, 20);
            categorylbl.TabIndex = 15;
            categorylbl.Text = "Category Name";
            // 
            // isactive_error
            // 
            isactive_error.AutoSize = true;
            isactive_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            isactive_error.ForeColor = Color.Red;
            isactive_error.Location = new Point(122, 164);
            isactive_error.Name = "isactive_error";
            isactive_error.Size = new Size(31, 41);
            isactive_error.TabIndex = 20;
            isactive_error.Text = "*";
            isactive_error.Visible = false;
            // 
            // categoryname_error
            // 
            categoryname_error.AutoSize = true;
            categoryname_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            categoryname_error.ForeColor = Color.Red;
            categoryname_error.Location = new Point(122, 88);
            categoryname_error.Name = "categoryname_error";
            categoryname_error.Size = new Size(31, 41);
            categoryname_error.TabIndex = 19;
            categoryname_error.Text = "*";
            categoryname_error.Visible = false;
            // 
            // isactive_comboBox
            // 
            isactive_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            isactive_comboBox.FormattingEnabled = true;
            isactive_comboBox.Items.AddRange(new object[] { "Yes", "No" });
            isactive_comboBox.Location = new Point(12, 187);
            isactive_comboBox.Name = "isactive_comboBox";
            isactive_comboBox.Size = new Size(235, 28);
            isactive_comboBox.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.Controls.Add(categoryDGV);
            panel5.Location = new Point(3, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(1018, 477);
            panel5.TabIndex = 2;
            // 
            // categoryDGV
            // 
            categoryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDGV.Columns.AddRange(new DataGridViewColumn[] { CatidDGV, catnameDGV, IsActiveDGV });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            categoryDGV.DefaultCellStyle = dataGridViewCellStyle1;
            categoryDGV.Dock = DockStyle.Fill;
            categoryDGV.Location = new Point(0, 0);
            categoryDGV.Name = "categoryDGV";
            categoryDGV.RowHeadersWidth = 51;
            categoryDGV.RowTemplate.Height = 29;
            categoryDGV.Size = new Size(1018, 477);
            categoryDGV.TabIndex = 0;
            categoryDGV.CellClick += categoryDGV_CellClick;
            // 
            // CatidDGV
            // 
            CatidDGV.HeaderText = "Category ID";
            CatidDGV.MinimumWidth = 6;
            CatidDGV.Name = "CatidDGV";
            // 
            // catnameDGV
            // 
            catnameDGV.HeaderText = "Category Name";
            catnameDGV.MinimumWidth = 6;
            catnameDGV.Name = "catnameDGV";
            // 
            // IsActiveDGV
            // 
            IsActiveDGV.HeaderText = "IsActive";
            IsActiveDGV.MinimumWidth = 6;
            IsActiveDGV.Name = "IsActiveDGV";
            // 
            // categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 607);
            Name = "categories";
            Text = "categories";
            Load += categories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoryDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox isactive_comboBox;
        private TextBox categorytxtbox;
        private Label isactivelbl;
        private Label categorylbl;
        private Label isactive_error;
        private Label categoryname_error;
        private Panel panel5;
        private DataGridView categoryDGV;
        private DataGridViewTextBoxColumn CatidDGV;
        private DataGridViewTextBoxColumn catnameDGV;
        private DataGridViewTextBoxColumn IsActiveDGV;
    }
}