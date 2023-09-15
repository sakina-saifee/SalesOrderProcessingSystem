namespace ims_project
{
    public partial class mainwin : Form
    {
        public mainwin()
        {
            InitializeComponent();
        }



        private void main_Load(object sender, EventArgs e)
        {
            login log = new login();
            main_class.show_window(log, this);
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            login l = new login();
            main_class.show_window(l, this, MdiParent);
            Console.ReadLine();
            // mainwin m = new mainwin();
            // m.logoutToolStripMenuItem.Enabled = false;

        }
    }
}