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
   public class Floors
    {
        public static void floorsInsert(string FloorName,Int32 FloorNumber)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_floorsInsert", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@f_name",FloorName);
                sqlCmd.Parameters.AddWithValue("@f_number", FloorNumber);
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage(FloorName + " record save successfully", "success"); }
            }
            catch (Exception)
            {
                Main.sqlCon.Close();
                Main.showMessage("unable to save customer floor number.\n posible error :\n floor number may exist already-\n contact techincal support ", "error");
            }
        }
        public static void floorsUpdate(Int32 FloorID, string FloorName,Int32 FloorNumber)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_floorsUpdate", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@f_id", FloorID);
                sqlCmd.Parameters.AddWithValue("@f_name", FloorName);
                sqlCmd.Parameters.AddWithValue("@f_number", FloorNumber);
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage(FloorName + " record updated successfully", "success"); }
            }
            catch (Exception)
            {
                Main.sqlCon.Close();
                Main.showMessage("unable to update floor number.\n posible error :contact techincal support ", "error");
            }
        }
        public static void floorsSelectAll(DataGridView gv, DataGridViewColumn FloorIDGV, DataGridViewColumn FloorNameGV, DataGridViewColumn FloorNumberGV)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_floorsSelectAll", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                FloorIDGV.DataPropertyName = dt.Columns["FloorID"].ToString();
                FloorNameGV.DataPropertyName = dt.Columns["FloorName"].ToString();
                FloorNumberGV.DataPropertyName = dt.Columns["FloorNumber"].ToString();
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
