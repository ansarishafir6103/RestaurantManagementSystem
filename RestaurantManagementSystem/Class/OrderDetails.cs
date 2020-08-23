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
  public  class OrderDetails
    {
      public static int orderDetailsInsert(Int64 od_orderID,int od_foodMenuID,Int32 od_qty)
      {
          int res = 0;
          try
          {
              SqlCommand sqlCmd = new SqlCommand("SP_orderDetailsInsert", Main.sqlCon);
              sqlCmd.CommandType = CommandType.StoredProcedure;
              sqlCmd.Parameters.AddWithValue("@od_orderID",od_orderID);
              sqlCmd.Parameters.AddWithValue("@od_foodMenuID",od_foodMenuID);
              sqlCmd.Parameters.AddWithValue("@od_qty",od_qty);
              Main.sqlCon.Open();
              res=sqlCmd.ExecuteNonQuery();
              Main.sqlCon.Close();
          }
          catch (Exception ex)
          {
              Main.sqlCon.Close();
              Main.showMessage(ex.Message,"error");
          }
          return res;
      }
      public static int orderDetailsUpdate(Int64 od_id, Int64 od_orderID, int od_foodMenuID,Int32 od_qty)
      {
          int res = 0;
          try
          {
              SqlCommand sqlCmd = new SqlCommand("SP_orderDetailsUpdate", Main.sqlCon);
              sqlCmd.CommandType = CommandType.StoredProcedure;
              sqlCmd.Parameters.AddWithValue("@od_id",od_id);
              sqlCmd.Parameters.AddWithValue("@od_orderID", od_orderID);
              sqlCmd.Parameters.AddWithValue("@od_foodMenuID", od_foodMenuID);
              sqlCmd.Parameters.AddWithValue("@od_qty", od_qty);
              Main.sqlCon.Open();
              res=sqlCmd.ExecuteNonQuery();
              Main.sqlCon.Close();
          }
          catch (Exception ex)
          {
              Main.sqlCon.Close();
              Main.showMessage(ex.Message, "error");
          }
          return res;
      }
      public static void getPendingOrders(DataGridView gv,DataGridViewColumn orderIDGV,DataGridViewColumn statusGV)
      {
          try
          {
              SqlCommand sqlCmd = new SqlCommand("SP_getPendingOrders",Main.sqlCon);
              sqlCmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              orderIDGV.DataPropertyName = dt.Columns["orderID"].ToString();
              statusGV.DataPropertyName = dt.Columns["Status"].ToString();
              gv.DataSource = dt;
              Main.getSerialNumber(gv, "serialNoGVL");
          }
          catch (Exception ex)
          {
              Main.sqlCon.Close();
              Main.showMessage(ex.Message,"error");
          }
      }
        public static void getPendingOrders(Int64 orderId, DataGridView gv, DataGridViewColumn ItemGV, DataGridViewColumn QuantityGV)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getOrderDetails", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@orderID", orderId);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ItemGV.DataPropertyName = dt.Columns["item"].ToString();
                QuantityGV.DataPropertyName = dt.Columns["qty"].ToString();
                gv.DataSource = dt;
                Main.getSerialNumber(gv, "serialNoGVR");
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        public static void getOrderDetailsWRTOrderID(DataGridView gv,DataGridViewColumn ItemIDGV,DataGridViewColumn OrderIDGV,DataGridViewColumn ItemGV,DataGridViewColumn QuantityGV,DataGridViewColumn PerPriceGV, DataGridViewColumn TotalPriceGV,DataGridViewColumn TotalOrderAmountGV,Int64 OrderID)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getOrderDetailsWRTOrderID", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@OrderID",OrderID);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt!=null)
                {
                    ItemIDGV.DataPropertyName = dt.Columns["item ID"].ToString();
                    OrderIDGV.DataPropertyName = dt.Columns["order ID"].ToString();
                    ItemGV.DataPropertyName = dt.Columns["item"].ToString();
                    QuantityGV.DataPropertyName = dt.Columns["quantity"].ToString();
                    PerPriceGV.DataPropertyName = dt.Columns["per Item Price"].ToString();
                    TotalPriceGV.DataPropertyName = dt.Columns["price"].ToString();
                    TotalOrderAmountGV.DataPropertyName = dt.Columns["total Amount"].ToString();
                    gv.DataSource = dt;
                    Main.getSerialNumber(gv, "serialNoGV");
                }
                else
                {
                    Main.showMessage("record not found !","error");
                }
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message,"error");
            }
        }
    }
}
