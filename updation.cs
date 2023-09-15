using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims_project
{
    internal class updation
    {
        public static void updateuser(int id,string name, string username, string pass, string phone, string email)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updationUsers", main_class.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@id", id);
                main_class.conn.Open();
                cmd.ExecuteNonQuery();
                main_class.conn.Close();
                main_class.showmsg(name+" " + "updated successfully to the system", "Updated User!", "sucess");


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

        public static void updatecategories(int catid, string catname, Int16 isActive)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("update_categories", main_class.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", catname);
                cmd.Parameters.AddWithValue("@is_Active", isActive);            
                cmd.Parameters.AddWithValue("@id", catid);
                main_class.conn.Open();
                cmd.ExecuteNonQuery();
                main_class.conn.Close();
                main_class.showmsg(catname + " " + "updated successfully to the system", "Updated User!", "sucess");


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
        public static void updateProduct(int prodID, string prodname, string prodbarcode, DateTime? prodexpiry, float prodprice, int catID) //-> DateTime? means app null value bhi insert krwas sakhte.
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateProducts", main_class.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_name", prodname);
                cmd.Parameters.AddWithValue("@p_barcode", prodbarcode);
                cmd.Parameters.AddWithValue("@p_expiry", prodexpiry);
                cmd.Parameters.AddWithValue("@p_price", prodprice);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@p_id", prodID);

                main_class.conn.Open();
                cmd.ExecuteNonQuery();
                main_class.conn.Close();
                main_class.showmsg(prodname + " " + "updated successfully to the Product List", "Product updated!", "sucess");


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

        public static void updatesupplier(int suppid, string companyname, string suppname, string phone, string nic)
        {
            try
            {
                if(main_class.conn.State == ConnectionState.Open)
                {
                    main_class.conn.Close();
                }
                else if (main_class.conn.State != ConnectionState.Open)
                {

                    main_class.conn.Open();
                    SqlCommand cmd = new SqlCommand("update_supplier", main_class.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company", companyname);
                    cmd.Parameters.AddWithValue("@suppname", suppname);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@nic", nic);
                    cmd.Parameters.AddWithValue("@id", suppid);
                  //  main_class.conn.Open();
                    cmd.ExecuteNonQuery();
                    main_class.conn.Close();
                    main_class.showmsg(suppname + " " + "updated successfully to the system", "Updated Supplier!", "sucess");

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
