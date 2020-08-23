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
    public class Roles
    {
        public static void rolesInsert(string r_name)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_rolesInsert",Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@r_name",r_name);
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage(r_name + "record save successfully", "success"); }
            }
            catch (Exception)
            {

                Main.sqlCon.Close();
                Main.showMessage("unable to save role.\n posible error :\n role may exist already-\n contact techincal support ", "error");
            }
        }
        public static void rolesUpdate(Int16 r_id,string r_name)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_rolesUpdate", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@r_id",r_id);
                sqlCmd.Parameters.AddWithValue("@r_name",r_name);
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage(r_name + "record updated successfully", "success"); }

            }
            catch (Exception ex)
            {

                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        public static void commonDelete(string procedure, string param, int val1=0,Int64 val2=0)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(procedure, Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (val1 != 0) { sqlCmd.Parameters.AddWithValue(param, val1); } else if(val2!=0) { sqlCmd.Parameters.AddWithValue(param, val2); }
                Main.sqlCon.Open();
                int value = sqlCmd.ExecuteNonQuery();
                Main.sqlCon.Close();
                if (value > 0) { Main.showMessage("record deleted successfully", "success"); }
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        public static void roleSelectAll(DataGridView gv, DataGridViewColumn r_idGV, DataGridViewColumn r_nameGV)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_rolesSelectAll", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                r_idGV.DataPropertyName = dt.Columns["r_id"].ToString();
                r_nameGV.DataPropertyName = dt.Columns["r_name"].ToString();
                gv.DataSource = dt;
                Main.getSerialNumber(gv, "serialNoGV");
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        public static void LoadItem(string procedure, ComboBox cb, string dMember, string vMember,string param=null,int val=0)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(procedure, Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (param==null && val==0)
                {
                    
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue(param,val);
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
            }
            catch (Exception ex)
            {

                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }

        public static void LoadItem(string procedure, ListBox listBox, string dMember, string vMember, string param = null, int val = 0)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(procedure, Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (param == null && val == 0)
                {

                }
                else
                {
                    sqlCmd.Parameters.AddWithValue(param, val);
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                listBox.DisplayMember = dMember;
                listBox.ValueMember = vMember;
                listBox.DataSource = dt;
            }
            catch (Exception ex)
            {

                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        #region LoadCategoryWRTItem
        #region Variables
        private static int _categoryid;
        private static string _categoryname;
        #endregion
        #region Properties
        public static int CATEGORYID { get { return _categoryid; } set { _categoryid = value; } }
        public static string CATEGORYNAME { get { return _categoryname; } set { _categoryname = value; } }
        #endregion
        #region Methods
        public static void LoadCategoryWRTItem(string item)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getCategoryWRTItem", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mname", item);
                Main.sqlCon.Open();
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CATEGORYID = Convert.ToInt32(dr["cid"].ToString());
                        CATEGORYNAME = dr["cname"].ToString();
                    }
                }
                Main.sqlCon.Close();
            }
            catch (Exception ex)
            {

                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
        }
        #endregion
           
        #endregion

        #region MyRegion
        public static Int64 LoadLastOrderId()
        {
            Int64 latsOrderId = 0;
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getLastOrderId", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                Main.sqlCon.Open();
                latsOrderId = Convert.ToInt64(sqlCmd.ExecuteScalar().ToString());
                Main.sqlCon.Close();
            }
            catch (Exception ex)
            {
                Main.sqlCon.Close();
                Main.showMessage(ex.Message, "error");
            }
            return latsOrderId;
        }
        #endregion
        //public static void LoadItem(string procedure, ComboBox cb, string dMember, string vMember)
        //{
        //    try
        //    {
        //        SqlCommand sqlCmd = new SqlCommand(procedure, Main.sqlCon);
        //        sqlCmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        cb.DisplayMember = dMember;
        //        cb.ValueMember = vMember;
        //        cb.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {

        //        Main.sqlCon.Close();
        //        Main.showMessage(ex.Message, "error");
        //    }
        //}
    }
    
}
