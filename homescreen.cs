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
    public partial class homescreen : sample
    {
        public homescreen()
        {
            InitializeComponent();
        }

        private void salesreturnbtn_Click(object sender, EventArgs e)
        {

        }

        private void USERSBTN_Click(object sender, EventArgs e)
        {
            users userswin = new users();
            main_class.show_window(userswin, this, MdiParent);
        }

        public void productbtn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            main_class.show_window(products, this, MdiParent);
        }

        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            categories categories = new categories();
            main_class.show_window(categories, this, MdiParent);
        }

        private void homescreen_Load(object sender, EventArgs e)
        {
            userlbl.Text = retrieval.user_login_name;


        }





        private void purchasebtn_Click(object sender, EventArgs e)
        {
            purchaseInvoice pi = new purchaseInvoice();
            main_class.show_window(pi, this, MdiParent);
        }

        private void suplierbtn_Click(object sender, EventArgs e)
        {

        }

        private void supplierbtn_Click_1(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            main_class.show_window(supplier, this, MdiParent);
        }

        private void supplierbtn2_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            main_class.show_window(supplier, this, MdiParent);
        }

        private void categories2btn_Click(object sender, EventArgs e)
        {
            categories categories = new categories();
            main_class.show_window(categories, this, MdiParent);
        }
    }
}
