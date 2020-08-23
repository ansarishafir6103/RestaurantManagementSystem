using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Class
{
    public class FoodMenu
    {
        public static void FoodMenuInsert(string MenuItem, float Price, int CatID, Int16 Status, Image img)
        {
            try
            {
                MemoryStream objMS = new MemoryStream();
                img.Save(objMS, ImageFormat.Png);
                byte[] arr = objMS.ToArray();

                SqlCommand sqlCmd = new SqlCommand("SP_FoodMenuInsert", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@m_name", MenuItem);
                sqlCmd.Parameters.AddWithValue("@m_catID", CatID);
                sqlCmd.Parameters.AddWithValue("@m_price", Price);
                sqlCmd.Parameters.AddWithValue("@m_status", Status);
                sqlCmd.Parameters.AddWithValue("@m_image", arr);
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage(MenuItem + " " + "record save successfully", "success"); }
            }
            catch (Exception)
            {

                Main.sqlCon.Close();
                Main.showMessage("unable to save menu Item.\n posible error :\n menu item may exist already-\n contact techincal support ", "error");
            }
        }
        public static void FoodMenuUpdate(int MenuID, string MenuItem, float Price, int CatID, Int16 Status, Image img)
        {
            try
            {
                MemoryStream objMS = new MemoryStream();
                img.Save(objMS, ImageFormat.Png);
                byte[] arr = objMS.ToArray();

                SqlCommand sqlCmd = new SqlCommand("SP_FoodMenuUpdate", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@m_id", MenuID);
                sqlCmd.Parameters.AddWithValue("@m_name", MenuItem);
                sqlCmd.Parameters.AddWithValue("@m_catID", CatID);
                sqlCmd.Parameters.AddWithValue("@m_price", Price);
                sqlCmd.Parameters.AddWithValue("@m_status", Status);
                sqlCmd.Parameters.AddWithValue("@m_image", arr);
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage(MenuItem + " " + "record updated successfully", "success"); }
            }
            catch (Exception)
            {

                Main.sqlCon.Close();
                Main.showMessage("unable to update category.\n posible error :\n contact techincal support ", "error");
            }
        }
        public static void FoodMenuSelectAll(DataGridView gv, DataGridViewColumn MenuIDGV, DataGridViewColumn MenuItemGV, DataGridViewColumn PriceGV, DataGridViewColumn StatusGV, DataGridViewColumn CategoryIDGV, DataGridViewColumn CategoryGV, DataGridViewColumn ImageGV)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_FoodMenuSelectAll", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MenuIDGV.DataPropertyName = dt.Columns["MenuID"].ToString();
                MenuItemGV.DataPropertyName = dt.Columns["MenuItem"].ToString();
                PriceGV.DataPropertyName = dt.Columns["Price"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                CategoryIDGV.DataPropertyName = dt.Columns["CategoryID"].ToString();
                CategoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                ImageGV.DataPropertyName = dt.Columns["Image"].ToString();
                gv.DataSource = dt;
                Main.getSerialNumber(gv, "serialNoGV");
            }
            catch (Exception ex)
            {

                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        public static Image getItemImage(int m_id)
        {
            byte[] arr;
            Image img=null;
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getItemImage", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@m_id",m_id);
                Main.sqlCon.Open();
                arr = (byte[])sqlCmd.ExecuteScalar();
                MemoryStream ms = new MemoryStream(arr);
                img = Image.FromStream(ms);
                Main.sqlCon.Close();
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
            return img;
        }
    }
}
