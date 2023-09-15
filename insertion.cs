using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Transactions;

namespace ims_project
{
    internal class insertion
    {
        public static void insertuser(string name,string username, string pass, string phone, string email)
        {
            try {

                SqlCommand cmd = new SqlCommand("st_insertUsers", main_class.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@mail", email);
                main_class.conn.Open();
                cmd.ExecuteNonQuery();
                main_class.conn.Close();
                main_class.showmsg(name+ " "+ "added successfully to the system", "New user Added!", "sucess");


            }
            catch (Exception e) {

                main_class.conn.Close();
                main_class.showmsg(e.Message,"Exception Error","error");
            
            }
            finally
            {
                main_class.conn.Close();
            }

        }


        public static void insertcategories(string catname, short isActive)
        {
            try
            {
                if (main_class.conn.State != ConnectionState.Open)
                {
                    main_class.conn.Open();
                    SqlCommand cmd = new SqlCommand("insert_categories", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", catname);
                    cmd.Parameters.AddWithValue("@is_Active", isActive);


                    
                    cmd.ExecuteNonQuery();
                    main_class.conn.Close();
                    main_class.showmsg(catname + " " + "added successfully to the system", "New Category Added!", "sucess");

                }
            }
            catch (Exception e)
            {

                main_class.conn.Close();
                main_class.showmsg(e.Message, "Exception Error", "error");

            }
            finally
            {
                main_class.conn.Close();
            }

        }

        public static void insertProduct(string prodname, string prodbarcode, DateTime? prodexpiry, float prodprice, int catID) //-> DateTime? means app null value bhi insert krwas sakhte.
        {
            try
            {
                if (main_class.conn.State != ConnectionState.Open) { 
                main_class.conn.Open();

                SqlCommand cmd = new SqlCommand("st_insertProducts", main_class.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_name", prodname);
                cmd.Parameters.AddWithValue("@p_barcode", prodbarcode);
                cmd.Parameters.AddWithValue("@p_expiry", prodexpiry);
                cmd.Parameters.AddWithValue("@p_price", prodprice);
                cmd.Parameters.AddWithValue("@catID", catID);
               
                cmd.ExecuteNonQuery();
                main_class.conn.Close();
                main_class.showmsg(prodname + " " + "added successfully to the Product List", "New Product Added!", "sucess");
            }

            }
            catch (Exception e)
            {

                main_class.conn.Close();
                main_class.showmsg(e.Message, "Exception Error", "error");

            }
            finally
            {
                main_class.conn.Close();
            }

        }

        public static void insert_signup_user(string name,string username,string  password,string gender,string phone,string dob) {
            try
            {
                if (main_class.conn.State != ConnectionState.Open)
                {
                    main_class.conn.Open();

                    SqlCommand cmd = new SqlCommand("signup_insertion", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@signup_name", name);
                    cmd.Parameters.AddWithValue("@signup_usernamee", username);
                    cmd.Parameters.AddWithValue("@signup_pass", password);
                    cmd.Parameters.AddWithValue("@signup_gender", gender);
                    cmd.Parameters.AddWithValue("@signup_phone", phone);
                    cmd.Parameters.AddWithValue("@signup_dob", dob);

                    //main_class.conn.Open();
                    cmd.ExecuteNonQuery();
                    main_class.conn.Close();
                    main_class.showmsg("Sign up successfully!", "You are signed up now!", "sucess");
                }
            }catch(Exception e) { 
                
                main_class.conn.Close();
                main_class.showmsg(e.Message, "Exception Error", "error");
            }
            finally
            {
                main_class.conn.Close();
            }
        }

        public static void insertsupplier(string companyname, string suppname, string phone, string nic)
        {
            try
            {
                if(main_class.conn.State != ConnectionState.Open) { 
                    
                    main_class.conn.Open();
                    SqlCommand cmd = new SqlCommand("insert_supplier", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company", companyname);
                    cmd.Parameters.AddWithValue("@suppname", suppname);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@nic", nic);
                 
                 //   main_class.conn.Open();
                    cmd.ExecuteNonQuery();
                    main_class.conn.Close();
                    main_class.showmsg(suppname + " " + "added successfully to the system", "New supplier Added!", "sucess");


                }


            }
            catch (Exception e)
            {

                main_class.conn.Close();
                main_class.showmsg(e.Message, "Exception Error", "error");

            }
            finally
            {
                main_class.conn.Close();
            }

        }

        private static int purchaseInvoiceId;
        public static int insertPurchaseInvoice(DateTime? date, int doneby, int suppID)
        {
            try
            {

               
                    SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@doneby", doneby);
                    cmd.Parameters.AddWithValue("@suppID", suppID);

                    main_class.conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "st_getlastPurchaseID";
                    cmd.Parameters.Clear();
                    purchaseInvoiceId = Convert.ToInt16(cmd.ExecuteScalar()); //scalar se srf ek rercord utha k ata hai

                    main_class.conn.Close();

                    
                
                


            }
            catch (Exception e)
            {

                main_class.conn.Close();
                main_class.showmsg(e.Message, "Exception Error", "error");

            }
            finally
            {
                main_class.conn.Close();
            }
            return purchaseInvoiceId;
        }

      
        public  static void insertPurchaseInvoiceDetails(string prodname, float perunitprice, int quant, float totalprice)
        {

            try
            {
                if(main_class.conn.State != ConnectionState.Open)
                {
                    main_class.conn.Open();
                    SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                  //  cmd.Parameters.AddWithValue("@purchaseID", purchaseID);
                    cmd.Parameters.AddWithValue("@prodname", prodname);
                    cmd.Parameters.AddWithValue("@prodquantity", quant);
                    cmd.Parameters.AddWithValue("@prodtotprice", totalprice);
                    cmd.Parameters.AddWithValue("@perunitprice", perunitprice);
                  

                    /*SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while(dr.Read())
                    {
                            purchaseInvoiceID = Convert.ToInt16(dr[0].ToString());

                        }
                    }*/
                    
                   // dr.Close();
                    cmd.ExecuteNonQuery();


                    main_class.conn.Close();
                    // main_class.showmsg("PurchaseInvoice details created!", "Success", "sucess");
                }

               


            }
            catch (Exception e)
            {

                main_class.conn.Close();
                main_class.showmsg(e.Message, "Exception Error", "error");

            }
            finally
            {
                main_class.conn.Close();
            }

           
        }

    }
}
