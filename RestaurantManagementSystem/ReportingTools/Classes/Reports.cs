using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace RestaurantManagementSystem.ReportingTools.Classes
{
    class Reports
    {
        public static void LoadBillReport(ReportViewer rv,Int64? OrderID=null)
        {
            try
            {
                
                SqlCommand sqlCmd = new SqlCommand("SP_getOrderReport", Main.sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (OrderID!= null)
                {
                    sqlCmd.Parameters.AddWithValue("@OrderID", OrderID);
                    SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                    DataTable dt = new DataTable();// name of dataset file 
                    da.Fill(dt);// name of dataset file table which you want to show
                    ReportDataSource dataSource = new ReportDataSource("RMS_DataSet", dt); // qunique dataset name dataset you add in Data set report file
                    rv.LocalReport.DataSources.Clear();
                    rv.LocalReport.DataSources.Add(dataSource);
                    string path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
                    string fullpath = Path.Combine(path, @"ReportingTools\Reports\BillReport.rdlc");
                    rv.LocalReport.ReportPath = fullpath;
                    rv.RefreshReport();
                    return;
                }
                Main.showMessage("Record not found!", "error");
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
    }
}
