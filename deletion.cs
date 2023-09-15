using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims_project
{
    internal class deletion
    {
        //dynamic hi;
        public static void delete(object any_type_to_delete_data_through, string proceduredb, string paramfromdb)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(proceduredb, main_class.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(paramfromdb,any_type_to_delete_data_through);
              
                main_class.conn.Open();
                cmd.ExecuteNonQuery();
                main_class.conn.Close();
                main_class.showmsg( "Data deleted successfully from the system", "Deleted!", "sucess");


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

        public static void truncate()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("truncate table purchaseInvoiceDetails", main_class.conn);
              //  cmd.CommandType = CommandType.StoredProcedure;
              //  cmd.Parameters.AddWithValue(paramfromdb, any_type_to_delete_data_through);

                main_class.conn.Open();
                cmd.ExecuteNonQuery();
                main_class.conn.Close();
                main_class.showmsg("Data deleted successfully from the system", "Deleted!", "sucess");


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
