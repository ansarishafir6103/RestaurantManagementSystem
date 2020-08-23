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
    public class Orders
    {
        #region Variable
        private static string customer, address;
        #endregion
        #region Properties


        public static string CUSTOMER { get { return customer; } private set { customer = value; } }
        public static string ADDRESS { get { return address; } set { address = value; } }
        #endregion

        #region Methods
        public static void getOrderIdWRTDate(DateTime date, ComboBox cmb = null, ListBox lb = null)
        {

            try
            {
                cmb.Items.Clear();
                SqlCommand sqlCmd = new SqlCommand("SP_getOrdersWRTDate", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb.DisplayMember = "ID";
                cmb.ValueMember = "ID";
                if (cmb == null)
                {
                    lb.DataSource = dt;
                }
                else if (lb == null)
                {
                    cmb.DataSource = dt;
                }
                cmb.SelectedIndex = -1;  

            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        public static Int16 getTaxID(string taxType)
        {
            Int16 _id = 0;
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GetTaxID", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@type", taxType);
                Main.sqlCon.Open();
                _id = Convert.ToInt16(sqlCmd.ExecuteScalar());
                Main.sqlCon.Close();
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
            return _id;
        }
        public static bool getOrderBill(string phone, DataGridView gv, DataGridViewColumn orderIDGV, DataGridViewColumn ItemGV, DataGridViewColumn QuantityGV, DataGridViewColumn AmountGV, DataGridViewColumn totalAmountGV)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getOrderDetailsWRTPhone", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Phone", phone);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    orderIDGV.DataPropertyName = dt.Columns["order ID"].ToString();
                    ItemGV.DataPropertyName = dt.Columns["item"].ToString();
                    QuantityGV.DataPropertyName = dt.Columns["quantity"].ToString();
                    AmountGV.DataPropertyName = dt.Columns["price"].ToString();
                    totalAmountGV.DataPropertyName = dt.Columns["total Amount"].ToString();
                    gv.DataSource = dt;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
            return false;
        }
        public static bool getOrderBill(int tableID, DataGridView gv, DataGridViewColumn orderIDGV, DataGridViewColumn ItemGV, DataGridViewColumn QuantityGV, DataGridViewColumn AmountGV, DataGridViewColumn totalAmountGV)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getOrderDetailsWRTTable", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@tableID", tableID);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    orderIDGV.DataPropertyName = dt.Columns["order ID"].ToString();
                    ItemGV.DataPropertyName = dt.Columns["item"].ToString();
                    QuantityGV.DataPropertyName = dt.Columns["quantity"].ToString();
                    AmountGV.DataPropertyName = dt.Columns["price"].ToString();
                    totalAmountGV.DataPropertyName = dt.Columns["total Amount"].ToString();
                    gv.DataSource = dt;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
            return false;
        }
        public static int updateOrderStatus(Int64 orderID, Int16 Status)
        {
            int res = 0;
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_updateOrderStatus", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@o_id", orderID);
                sqlCmd.Parameters.AddWithValue("@status", Status);
                Main.sqlCon.Open();
                res = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (res > 0)
                {
                    Main.showMessage("order status updated !", "success");
                }
            }
            catch (Exception)
            {
                Main.sqlCon.Close();
                Main.showMessage("unable to update \n please contact technical support", "error");
            }
            return res;
        }
        public static Int64 getCustomerIdWRTPhone(string Phone) //for make fuction get phone get customer Id before insert order
        {
            Int64 custID = 0;
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getCustomerIdWRTPhone", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Phone", Phone);
                Main.sqlCon.Open();
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        custID = Convert.ToInt64(dr["CustomerID"].ToString());
                        CUSTOMER = dr["Name"].ToString();
                        ADDRESS = dr["Address"].ToString();
                    }
                }
                else
                {
                    custID = 0;
                    CUSTOMER = "";
                    ADDRESS = "";
                }
                Main.sqlCon.Close();
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
            return custID;
        }
        public static void ordersInsert(DateTime orderDate, Int64 CustID, Int16 orderType, Int16 FloorId, Int16 TableId, float totalAmount, float amountPaid, float amountReturn, int Status, Int16 taxType, float taxAmount)
        {
            try
            {

                SqlCommand sqlcmd = new SqlCommand("SP_orderInsert", Main.sqlCon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@o_date", orderDate);
                sqlcmd.Parameters.AddWithValue("@o_custID", CustID);
                sqlcmd.Parameters.AddWithValue("@o_orderType", orderType);
                sqlcmd.Parameters.AddWithValue("@o_floorId", FloorId);
                sqlcmd.Parameters.AddWithValue("@o_tableId", TableId);
                sqlcmd.Parameters.AddWithValue("@o_totalAmount", totalAmount);
                sqlcmd.Parameters.AddWithValue("@o_amountPaid", amountPaid);
                sqlcmd.Parameters.AddWithValue("@o_amountReturn", amountReturn);
                sqlcmd.Parameters.AddWithValue("@o_status", Status);
                sqlcmd.Parameters.AddWithValue("@o_taxType", taxType);
                sqlcmd.Parameters.AddWithValue("@o_taxAmount", taxAmount);
                Main.sqlCon.Open();
                int val = sqlcmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                //if (val > 0) { Main.showMessage("order is save successfully.", "success"); }
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        public static int ordersUpdate(Int64 orderId, float amountPaid, float amountReturn, int Status, Int16 taxID, float taxAmount)
        {
            int res = 0;
            try
            {
                SqlCommand sqlcmd = new SqlCommand("SP_orderUpdate", Main.sqlCon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@o_id", orderId);
                sqlcmd.Parameters.AddWithValue("@o_amountPaid", amountPaid);
                sqlcmd.Parameters.AddWithValue("@o_amountReturn", amountReturn);
                sqlcmd.Parameters.AddWithValue("@o_status", Status);
                sqlcmd.Parameters.AddWithValue("@o_taxID", taxID);
                sqlcmd.Parameters.AddWithValue("@o_taxAmount", taxAmount);
                Main.sqlCon.Open();
                res = sqlcmd.ExecuteNonQuery();
                Main.sqlCon.Close();
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
            return res;
        }
        #endregion
    }
}
