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
   public class Tables
    {
       public static bool checkTableStatus(int tableID,Int16 floorID)
       {
           bool status=false;
           try
           {
               SqlCommand sqlCmd = new SqlCommand("SP_checkTableBusyFree",Main.sqlCon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.AddWithValue("@tableID", tableID);
               sqlCmd.Parameters.AddWithValue("@floorID", floorID);
               Main.sqlCon.Open();
               SqlDataReader dr = sqlCmd.ExecuteReader();
               if (dr.HasRows)
               {
                   status = true;
               }
               else
               {
                   status = false;
               }
               Main.sqlCon.Close();
           }
           catch (Exception ex)
           {
               Main.sqlCon.Close();
               Main.showMessage(ex.Message,"error");
           }
           return status;
       }
        public static void tablesInsert(Int16 TableNumber, Int32 TableChair,Int32 FloorID)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_TablesInsert", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@t_number",TableNumber);
                sqlCmd.Parameters.AddWithValue("@t_chair", TableChair);
                sqlCmd.Parameters.AddWithValue("@t_floorid", FloorID);
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage("table number " +TableNumber + " of record save successfully", "success"); }
            }
            catch (Exception)
            {
                Main.sqlCon.Close();
                Main.showMessage("unable to save table number.\n posible error :\n table number may exist already-\n contact techincal support ", "error");
            }
        }
        public static void tablesUpdate(Int16 TableID,Int16 TableNumber, Int32 TableChair, Int32 FloorID)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_TablesUpdate", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@t_id", TableID);
                sqlCmd.Parameters.AddWithValue("@t_number", TableNumber);
                sqlCmd.Parameters.AddWithValue("@t_chair", TableChair);
                sqlCmd.Parameters.AddWithValue("@t_floorid", FloorID);
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage("table number" + TableNumber + "of record updated successfully", "success"); }
            }
            catch (Exception)
            {
                Main.sqlCon.Close();
                Main.showMessage("unable to update table number.\n is alredy exist table number\nposible error :contact techincal support ", "error");
            }
        }
        public static void tablesSelectAll(DataGridView gv, DataGridViewColumn TableIDGV, DataGridViewColumn TableNumberGV, DataGridViewColumn TableChairGV, DataGridViewColumn FloorNumberGV, DataGridViewColumn FloorNameGV, DataGridViewColumn TableFloorIDGV)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_TablesSelectAll", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TableIDGV.DataPropertyName = dt.Columns["TableID"].ToString();
                TableNumberGV.DataPropertyName = dt.Columns["TableNumber"].ToString();
                TableChairGV.DataPropertyName = dt.Columns["TableChair"].ToString();
                FloorNumberGV.DataPropertyName = dt.Columns["FloorNumber"].ToString();
                FloorNameGV.DataPropertyName = dt.Columns["FloorName"].ToString();
                TableFloorIDGV.DataPropertyName = dt.Columns["TableFloorID"].ToString();
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
