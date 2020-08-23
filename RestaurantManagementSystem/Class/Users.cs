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
   public  class Users
    {
       public static void usersInsert(string name,string uname,string password,string phone,string address,Int16 roleID)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_usersInsert", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@u_name", name);
               sqlCmd.Parameters.AddWithValue("@u_uname", uname);
               sqlCmd.Parameters.AddWithValue("@u_password", password);
               sqlCmd.Parameters.AddWithValue("@u_phone", phone);
               sqlCmd.Parameters.AddWithValue("@u_address", address);
               sqlCmd.Parameters.AddWithValue("@u_roleId", roleID);
               Main.sqlCon.Open();
               int value = sqlCmd.ExecuteNonQuery();
               Main.sqlCon.Close();
               if (value > 0) { Main.showMessage(name + " record save successfully", "success"); }
           }
           catch (Exception)
           {
               Main.sqlCon.Close();
               Main.showMessage("unable to save username.\n posible error :\n username may exist already-\n contact techincal support ", "error");
           }
       }
       public static void usersUpdate(int userID,string name, string uname, string password, string phone, string address, Int16 roleID)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_usersUpdate", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@u_id", userID);
               sqlCmd.Parameters.AddWithValue("@u_name", name);
               sqlCmd.Parameters.AddWithValue("@u_uname", uname);
               sqlCmd.Parameters.AddWithValue("@u_password", password);
               sqlCmd.Parameters.AddWithValue("@u_phone", phone);
               sqlCmd.Parameters.AddWithValue("@u_address", address);
               sqlCmd.Parameters.AddWithValue("@u_roleId", roleID);
               Main.sqlCon.Open();
               int value = sqlCmd.ExecuteNonQuery();
               Main.sqlCon.Close();
               if (value > 0) { Main.showMessage(name + " record updated successfully", "success"); }
           }
           catch (Exception)
           {
               Main.sqlCon.Close();
               Main.showMessage("unable to updated user.\n posible error :\n contact techincal support ", "error");
           }
       }
       public static void usersSelectAll(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV,DataGridViewColumn usernameGV,DataGridViewColumn passwordGV,DataGridViewColumn phoneGV,DataGridViewColumn addressGV,DataGridViewColumn RoleGV,DataGridViewColumn RoleIDGV)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_usersSelectAll", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
               DataTable dt = new DataTable();
               da.Fill(dt);
               userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
               nameGV.DataPropertyName = dt.Columns["Name"].ToString();
               usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
               passwordGV.DataPropertyName = dt.Columns["Password"].ToString();
               phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
               addressGV.DataPropertyName = dt.Columns["Address"].ToString();
               RoleIDGV.DataPropertyName = dt.Columns["Role ID"].ToString();
               RoleGV.DataPropertyName = dt.Columns["Role"].ToString();
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
