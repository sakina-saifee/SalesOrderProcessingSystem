using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace ims_project
{
    internal class retrieval
    {                                                                                                                                                                                                                                                              //hamesha optional v parameters ko end mai add kro
        public static void showusers(DataGridView dgv, DataGridViewColumn useriddgv, DataGridViewColumn namedgv, DataGridViewColumn usernamedgv, DataGridViewColumn passdgv, DataGridViewColumn phonedgv, DataGridViewColumn emaildgv, DataGridViewColumn statusdgv, string data = null) //string data=null-> means k jb is function ko call kroge tw ye parameter ho sakhta aur nhi bhi hosakhta.
        {
            try {

                SqlCommand cmd;

                if(data == null)
                {
                    cmd = new SqlCommand("get_usersdata", main_class.conn);

                }
                else
                {
                    cmd = new SqlCommand("get_usersdataLIKE", main_class.conn);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                useriddgv.DataPropertyName = dt.Columns["ID"].ToString();
                namedgv.DataPropertyName = dt.Columns["Name"].ToString();
                usernamedgv.DataPropertyName = dt.Columns["Username"].ToString();
                passdgv.DataPropertyName = dt.Columns["Password"].ToString();
                phonedgv.DataPropertyName = dt.Columns["Phone"].ToString();
                emaildgv.DataPropertyName = dt.Columns["Mail"].ToString();
                statusdgv.DataPropertyName = dt.Columns["Status"].ToString();

                dgv.DataSource = dt;
            }
            catch(Exception ex) {


            }
            finally
            {
                main_class.conn.Close();
            }

        }

        public static void showcategorydata(DataGridView dgv, DataGridViewColumn catiddgv, DataGridViewColumn catnamedgv, DataGridViewColumn isActivedgv, string data = null) { 
            try
            {

                //SqlCommand cmd = new SqlCommand("get_categories_data_info", main_class.conn);

                SqlCommand cmd;

                if (data == null)
                {
                    cmd = new SqlCommand("get_categories_data_info", main_class.conn);

                }
                else
                {
                    cmd = new SqlCommand("get_categoriesdataLIKE", main_class.conn);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                catiddgv.DataPropertyName = dt.Columns["Category ID"].ToString();
                catnamedgv.DataPropertyName = dt.Columns["Category Name"].ToString();
                isActivedgv.DataPropertyName = dt.Columns["Active_Status"].ToString();
              

                dgv.DataSource = dt;




            }
            catch (Exception e)
            {
                main_class.conn.Close();
                main_class.showmsg("Cannot load data", "Data loading Error!", "error");
            }
            finally
            {
                main_class.conn.Close();
            }
        }

        public static void getcategorieslist(string proc, ComboBox cb,string displaymember, string valuemember)
        {

            try {

                cb.Items.Clear();
                cb.DataSource = null;
                cb.Items.Insert(0, "Select..");
                SqlCommand cmd = new SqlCommand(proc, main_class.conn);
                cmd.CommandType=CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter( cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cb.DataSource = dt;
                cb.DisplayMember = displaymember;
                cb.ValueMember = valuemember;
               

            
            } catch (Exception e) {
                main_class.conn.Close();
            }
            finally
            {
                main_class.conn.Close();
            }
        }

        public static void showProducts(DataGridView dgv, DataGridViewColumn proiddgv, DataGridViewColumn pronamedgv, DataGridViewColumn barcodedgv, DataGridViewColumn pricedgv, DataGridViewColumn catiddgv, DataGridViewColumn expirydgv, DataGridViewColumn catnamedgv, string data=null) //string data=null-> means k jb is function ko call kroge tw ye parameter ho sakhta aur nhi bhi hosakhta.
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_viewProducts", main_class.conn);
                }
                else
                {
                    cmd = new SqlCommand("st_viewProducts", main_class.conn);

                }
   
                cmd.CommandType = CommandType.StoredProcedure;
               
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                proiddgv.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronamedgv.DataPropertyName = dt.Columns["Product Name"].ToString();
                barcodedgv.DataPropertyName = dt.Columns["Product Barcode"].ToString();
                pricedgv.DataPropertyName = dt.Columns["Product Price"].ToString();
                expirydgv.DataPropertyName = dt.Columns["Product Expiry"].ToString();
                catnamedgv.DataPropertyName = dt.Columns["Category Name"].ToString();
                catiddgv.DataPropertyName = dt.Columns["Category ID"].ToString();

                dgv.DataSource = dt;
               
            }
            catch (Exception ex)
            {
              //  main_class.conn.Close();
                main_class.showmsg("Error has occured!","Error of exception!","error");
            }
            finally
            {
                main_class.conn.Close();
            }

        }

       public static int user_login_id
        {

            get;
            private set;
        }

        public static string user_login_name
        {

            get;
            private set;
        }
        public static string user_name=null, pass_word=null;
        public static bool checklogin=false;
        public static bool getUserDetails(string username, string password)
        {

            try {
                if (main_class.conn.State != ConnectionState.Open)
                {
                    main_class.conn.Open();
                    SqlCommand cmd = new SqlCommand("get_user_details", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                 
                    SqlDataReader reader = cmd.ExecuteReader(); //srf read krta ye, dont write it
                    if(reader.HasRows)
                    {
                        checklogin= true;
                        while(reader.Read())
                        {
                            user_login_id = Convert.ToInt32(reader["ID"].ToString());
                            user_login_name = reader["Name"].ToString();
                            user_name = reader["Username"].ToString();
                            pass_word = reader["Password"].ToString();
                        }
                    }
                    else
                    {
                        checklogin = false;
                        if(username!=null && password != null)
                        {

                            if (user_name != username && pass_word !=password)
                            {

                                main_class.showmsg("Invalid username and password!","Invalid login credentials","error");
                            }
                           else if (user_name == username && pass_word != password)
                            {

                                main_class.showmsg("Invalid password!", "Invalid login credentials", "error");
                            }
                            else if (user_name != username && pass_word == password)
                            {

                                main_class.showmsg("Invalid username!", "Invalid login credentials", "error");
                            }
                            if(username==user_name && pass_word == password)
                            {

                                main_class.showmsg("Credentials Matched!", "Success", "sucess");
                            }
                            
                        }



                    }
                   // cmd.ExecuteNonQuery();

                    main_class.conn.Close();
                }

            }
            catch(Exception ex) {

                main_class.conn.Close();
                main_class.showmsg("Error has occured!", "Error of exception!", "error");
            }
            finally
            {
                main_class.conn.Close();
                
            }
            return checklogin;
        }

        public static void show_suppliers(DataGridView dgv, DataGridViewColumn supplierid, DataGridViewColumn companynamedgv, DataGridViewColumn suppliernamedgv, DataGridViewColumn nicdgv,DataGridViewColumn phonedgv ,string data=null) //string data=null-> means k jb is function ko call kroge tw ye parameter ho sakhta aur nhi bhi hosakhta.
        {
            try
            {
               // if (main_class.conn.State != ConnectionState.Open)
                //{

                 //   main_class.conn.Open();
                    SqlCommand cmd;

                    if (data == null)
                    {
                        cmd = new SqlCommand("view_supplier", main_class.conn);

                    }
                    else
                    {
                        cmd = new SqlCommand("search_supplier", main_class.conn);
                        cmd.Parameters.AddWithValue("@data", data);
                    }
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    supplierid.DataPropertyName = dt.Columns["Supplier ID"].ToString();
                    companynamedgv.DataPropertyName = dt.Columns["Company Name"].ToString();
                    suppliernamedgv.DataPropertyName = dt.Columns["Supplier Name"].ToString();
                    phonedgv.DataPropertyName = dt.Columns["Supplier contact"].ToString();
                    nicdgv.DataPropertyName = dt.Columns["NIC"].ToString();


                    dgv.DataSource = dt;
                //}
            }
            catch (Exception ex)
            {

                main_class.conn.Close();
                main_class.showmsg("Error has occured!", "Error of exception!", "error");
            }
            finally
            {
                main_class.conn.Close();
            }

        }

        public static void getsupplierlist(string proc, ComboBox cb, string displaymember, string valuemember)
        {

            try
            {

                cb.Items.Clear();
                cb.DataSource = null;
                cb.Items.Insert(0, "Select..");
                SqlCommand cmd = new SqlCommand(proc, main_class.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cb.DataSource = dt;
                cb.DisplayMember = displaymember; //Company name
                cb.ValueMember = valuemember;



            }
            catch (Exception e)
            {
                main_class.conn.Close();
            }
            finally
            {
                main_class.conn.Close();
            }
        }

        public static string[] productsData = new string[10];
       static int barcodefound_ornot = 0;
        public static string[] get_product_by_barcode(string barcode)
        {

            try
            {
                if (main_class.conn.State != ConnectionState.Open)
                {
                    main_class.conn.Open();



                    SqlCommand cmd = new SqlCommand("get_productinfo_through_barcode", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    SqlDataReader dr=cmd.ExecuteReader();
                    if(dr.HasRows)
                    {
                        barcodefound_ornot = 1;
                        while (dr.Read())
                        {

                            productsData[0] = dr[0].ToString();
                            productsData[1] = dr[1].ToString();
                            productsData[2] = dr[2].ToString();
                            productsData[3] = dr[3].ToString();
                        }


                    }
                    else
                    {
                        

                    }

                    main_class.conn.Close();



                }


            }
            catch (Exception e)
            {
                main_class.conn.Close();
                //main_class.showmsg("Error has occured!", "Error of exception!", "error");
            }
            finally
            {
                main_class.conn.Close();
            }

            
            return productsData;
        }

        public static void show_purchaseInvoice(DataGridView dgv, DataGridViewColumn prodiddgv, DataGridViewColumn prodnamedgv, DataGridViewColumn perunitpricedgv, DataGridViewColumn quantdgv, DataGridViewColumn totalamountdgv, string data = null) //string data=null-> means k jb is function ko call kroge tw ye parameter ho sakhta aur nhi bhi hosakhta.
        {
            try
            {
                // if (main_class.conn.State != ConnectionState.Open)
               // {

                   main_class.conn.Open();
                    SqlCommand cmd;

               // if (data == null)
              //  {
                    cmd = new SqlCommand("st_get_purchaseInvoiceDetails", main_class.conn);

               // }
               // else
               // {
                   // cmd = new SqlCommand("search_supplier", main_class.conn);
                   // cmd.Parameters.AddWithValue("@data", data);
               // }
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                prodiddgv.DataPropertyName = dt.Columns["Purchase ID"].ToString();
                prodnamedgv.DataPropertyName = dt.Columns["Product Name"].ToString();
                perunitpricedgv.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                quantdgv.DataPropertyName = dt.Columns["Quantity"].ToString();            
                totalamountdgv.DataPropertyName = dt.Columns["Total Price"].ToString();


                dgv.DataSource = dt;

                main_class.conn.Close();
                // }
            }
            catch (Exception ex)
            {

                main_class.conn.Close();
                main_class.showmsg("Error has occured!", "Error of exception!", "error");
            }
            finally
            {
                main_class.conn.Close();
            }

        }
        public static int purchase_invoice_id = 0;

        public static int get_Purchase_invoice_Id()
        {
            purchase_invoice_id++;

            return purchase_invoice_id;

            /*
            try
            {
                if (main_class.conn.State != ConnectionState.Open)
                {
                    main_class.conn.Open();



                    SqlCommand cmd = new SqlCommand("st_get_purchaseInvoiceDetails", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                       
                        while (dr.Read())
                        {

                           purchase_invoice_id= Convert.ToInt16(dr[0].ToString())  ;
                           
                        }


                    }
                    else
                    {


                    }

                    main_class.conn.Close();



                }


            }
            catch (Exception e)
            {
                main_class.conn.Close();
                //main_class.showmsg("Error has occured!", "Error of exception!", "error");
            }
            finally
            {
                main_class.conn.Close();
            }
            */


        }

    }

   
}
