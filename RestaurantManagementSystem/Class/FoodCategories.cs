using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Class
{
   public class FoodCategories
    {
       public static void categoriesInsert(string c_name)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_categoriesInsert", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@c_name", c_name);
               Main.sqlCon.Open();
               int value = sqlCmd.ExecuteNonQuery();
               Main.sqlCon.Close();
               if (value > 0) { Main.showMessage(c_name + "record save successfully", "success"); }
           }
           catch (Exception)
           {

               Main.sqlCon.Close();
               Main.showMessage("unable to save category.\n posible error :\n category may exist already-\n contact techincal support ", "error");
           }
       }

       public static void categoriesUpdate(int c_id,string c_name)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_categoriesUpdate", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@c_id", c_id);
               sqlCmd.Parameters.AddWithValue("@c_name", c_name);
               Main.sqlCon.Open();
               int value = sqlCmd.ExecuteNonQuery();
               Main.sqlCon.Close();
               if (value > 0) { Main.showMessage(c_name + "record updated successfully", "success"); }
           }
           catch (Exception)
           {

               Main.sqlCon.Close();
               Main.showMessage("unable to update category.\n posible error :\n contact techincal support ", "error");
           }
       }
       public static void categoriesSelectAll(DataGridView gv, DataGridViewColumn CategoryIDGV, DataGridViewColumn CategoryNameGV)
       {
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_categoriesSelectAll", Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
               DataTable dt = new DataTable();
               da.Fill(dt);
               CategoryIDGV.DataPropertyName = dt.Columns["CatID"].ToString();
               CategoryNameGV.DataPropertyName = dt.Columns["CatName"].ToString();
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
