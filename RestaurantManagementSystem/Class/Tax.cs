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
   public class Tax
    {
       public static void taxInsert(float value,string type)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_taxInsert", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@value",value);
               sqlCmd.Parameters.AddWithValue("@type",type);
               Main.sqlCon.Open();
               int res = sqlCmd.ExecuteNonQuery();
               Main.sqlCon.Close();
               if (res > 0) { Main.showMessage("tax is save successfully!", "success"); }
           }
           catch (Exception ex)
           {
               Main.sqlCon.Close();
               Main.showMessage(ex.Message,"error");
           }
       }
       public static void taxUpdate(int taxID,float value, string type)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_taxUpdate", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@taxID", taxID);
               sqlCmd.Parameters.AddWithValue("@value", value);
               sqlCmd.Parameters.AddWithValue("@type", type);
               Main.sqlCon.Open();
               int res = sqlCmd.ExecuteNonQuery();
               Main.sqlCon.Close();
               if (res > 0) { Main.showMessage("tax is updated successfully!", "success"); }
           }
           catch (Exception ex)
           {
               Main.sqlCon.Close();
               Main.showMessage(ex.Message, "error");
           }
       }
       public static void taxSelectAll(DataGridView gv,DataGridViewColumn taxIDGV,DataGridViewColumn valueGV,DataGridViewColumn typeGV)
       {
           try
           {
               SqlCommand SqlCmd = new SqlCommand("SP_taxSelectAll", Main.sqlCon);
               SqlCmd.CommandType = CommandType.StoredProcedure;
               SqlDataAdapter da = new SqlDataAdapter(SqlCmd);
               DataTable dt = new DataTable();
               da.Fill(dt);
               taxIDGV.DataPropertyName = dt.Columns["taxID"].ToString();
               valueGV.DataPropertyName = dt.Columns["taxValue"].ToString();
               typeGV.DataPropertyName = dt.Columns["taxType"].ToString();
               gv.DataSource = dt;
               Main.getSerialNumber(gv,"srNoGv");

           }
           catch (Exception ex)
           {
               Main.sqlCon.Close();
               Main.showMessage(ex.Message,"error");
           }
       }
    }
}
