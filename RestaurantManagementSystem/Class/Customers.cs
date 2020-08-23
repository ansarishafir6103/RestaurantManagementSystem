using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace RestaurantManagementSystem.Class
{
   public class Customers
    {
       public static void customersInsert(string customerName, string cutomerPhone, string customerAddress)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_customersInsert", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@c_name",customerName);
               sqlCmd.Parameters.AddWithValue("@c_phone",cutomerPhone);
               sqlCmd.Parameters.AddWithValue("@c_address",customerAddress);
               Main.sqlCon.Open();
               int value = sqlCmd.ExecuteNonQuery();
               Main.sqlCon.Close();
               if (value > 0) { Main.showMessage(customerName + " record save successfully", "success"); }
           }
           catch (Exception)
           {
               Main.sqlCon.Close();
               Main.showMessage("unable to save customer phone number.\n posible error :\n phone number may exist already-\n contact techincal support ", "error");
           }
       }
       public static void customersUpdate(Int64 customerID,string customerName, string cutomerPhone, string customerAddress)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_customersUpdate", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@c_id", customerID);
               sqlCmd.Parameters.AddWithValue("@c_name", customerName);
               sqlCmd.Parameters.AddWithValue("@c_phone", cutomerPhone);
               sqlCmd.Parameters.AddWithValue("@c_address", customerAddress);
               Main.sqlCon.Open();
               int value = sqlCmd.ExecuteNonQuery();
               Main.sqlCon.Close();
               if (value > 0) { Main.showMessage(customerName + " record updated successfully", "success"); }
           }
           catch (Exception)
           {
               Main.sqlCon.Close();
               Main.showMessage("unable to update customer.\n posible error :contact techincal support ", "error");
           }
       }
       public static void customersSelectAll(DataGridView gv, DataGridViewColumn customerIDGV, DataGridViewColumn customerNameGV, DataGridViewColumn customerPhoneGV, DataGridViewColumn customerAddressGV)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_customersSelectAll", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
               DataTable dt = new DataTable();
               da.Fill(dt);
               customerIDGV.DataPropertyName = dt.Columns["Customer ID"].ToString();
               customerNameGV.DataPropertyName = dt.Columns["Name"].ToString();
               customerPhoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
               customerAddressGV.DataPropertyName = dt.Columns["Address"].ToString();
               gv.DataSource = dt;
               Main.getSerialNumber(gv, "serialNoGV");
           }
           catch (Exception ex)
           {

               Main.sqlCon.Close();
               Main.showMessage(ex.Message, "error");
           }
       }
    }
}
