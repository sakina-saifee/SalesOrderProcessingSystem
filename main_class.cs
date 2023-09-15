using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims_project
{
    internal class main_class
    {

        public static SqlConnection conn = new SqlConnection("Data Source=SAKINA\\SQLEXPRESS;Initial Catalog=imsdb;Integrated Security=True;MultipleActiveResultSets=true");
        public static void show_window(Form openwin, Form closewin, Form Form1) {
        
            openwin.Show();
            openwin.MdiParent = Form1;
            openwin.WindowState = FormWindowState.Maximized;
            closewin.Close();
        
        }

        public static void show_window(Form openwin, Form Form1)
        {

            openwin.Show();
            openwin.MdiParent = Form1;
            openwin.WindowState = FormWindowState.Maximized;
            //closewin.Close();

        }

        public static void disable_reset(Panel panel1) {

            foreach (Control c in panel1.Controls)
            {
                if(c is TextBox)
                {
                    TextBox t= (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }

                if(c is ComboBox) {
                
                    ComboBox cb= (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;

                }

                if (c is RadioButton)
                {

                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked=false;

                }

                if (c is DateTimePicker)
                {

                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                    cb.Value= DateTime.Now;

                }
                if (c is CheckBox)
                {

                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;

                }

            }
        
        
        }
        public static void disable(Panel panel1)
        {

            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    //t.Text = "";
                }

                if (c is ComboBox)
                {

                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                  //  cb.SelectedIndex = -1;

                }

                if (c is RadioButton)
                {

                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                   // rb.Checked = false;

                }

                if (c is DateTimePicker)
                {

                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = false;
                   

                }
                if (c is CheckBox)
                {

                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                  //  cb.Checked = false;

                }

            }


        }
        public static void enable_reset(Panel panel1)
        {

            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }

                if (c is DateTimePicker)
                {

                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = true;
                    //cb.Checked = false;
                    cb.Value = DateTime.Now;

                }
                if (c is ComboBox)
                {

                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;

                }

                if (c is RadioButton)
                {

                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;

                }

                if (c is CheckBox)
                {

                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;

                }

            }


        }
        public static void enable(Panel panel1)
        {

            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    //t.Text = "";
                }

                if (c is DateTimePicker)
                {

                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = true;
                    

                }

                if (c is ComboBox)
                {

                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    //  cb.SelectedIndex = -1;

                }

                if (c is RadioButton)
                {

                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    // rb.Checked = false;

                }

                if (c is CheckBox)
                {

                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    //  cb.Checked = false;

                }

            }


        }

        public static DialogResult showmsg(string msg, string heading, string type)
        {
            if (type == "sucess")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            else if(type=="error") { 
            
            return MessageBox.Show(msg,heading,MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else if(type == "question")
            {
               return MessageBox.Show(msg, heading, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {

                return MessageBox.Show(msg, heading, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

        }
    }
}
