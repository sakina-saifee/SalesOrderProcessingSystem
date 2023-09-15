using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims_project
{
    public partial class sample2 : sample
    {
        public sample2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void welcomelbl_Click(object sender, EventArgs e)
        {

        }

        public virtual void backbtn_Click(object sender, EventArgs e)
        {
            homescreen hs = new homescreen();
            main_class.show_window(hs, this, Form.ActiveForm);
        }

        public virtual void editbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void addbtn_Click(object sender, EventArgs e)
        {

            main_class.enable(panel1);
        }

        public virtual void searchtxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        public virtual void savebtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void delbtn_Click(object sender, EventArgs e)
        {

        }



        public virtual void viewbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
