using RestaurantManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.AdminPanel
{
    public partial class frmOrderModification : frmSample2
    {
        #region Constructos
        public frmOrderModification()
        {
            InitializeComponent();
        }

        #endregion
        #region Events
        private void frmOrderModification_Load(object sender, EventArgs e)
        {
            try
            {
                Orders.getOrderIdWRTDate(dtpOrderDate.Value, cmbOrderID);
                Orders.getOrderIdWRTDate(dtpOrderDate.Value, null, listBoxOrderIDs);
                Roles.LoadItem("SP_FoodMenuSelectAll", cmbFoodMenu, "MenuItem", "MenuID");
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main.CheckControls(leftpanel).Count != 0)
                {
                    return;
                }
                else
                {
                    bool check = false;
                    foreach (DataGridViewRow row in grvOrdersDetails.Rows)
                    {
                        if (row.Cells["ItemIDGV"].Value.ToString() == cmbFoodMenu.SelectedValue.ToString())
                        {
                            check = true;
                            break;
                        }
                    }
                    float _totalAmount = 0;
                   
                    if (check)
                    {
                        Main.showMessage("item is already exist!", "error");
                    }
                    else
                    {
                        _totalAmount += Convert.ToSingle(txtPrice.Text) * Convert.ToSingle(numUpQuantity.Value);
                        lblTotalAmountValue.Text = _totalAmount.ToString();
                        DataRowView drItem = cmbFoodMenu.SelectedItem as DataRowView;
                        DataRowView drOrderID = cmbOrderID.SelectedItem as DataRowView;
                        grvOrdersDetails.Rows.Add
                        (
                        null,
                        Convert.ToInt64(drOrderID[0].ToString()),
                        Convert.ToInt64(drItem[0].ToString()),
                        drItem[1].ToString(),
                        Convert.ToDouble(txtPrice.Text),
                        numUpQuantity.Value,
                        Convert.ToDouble(txtPrice.Text)* Convert.ToInt32(numUpQuantity.Value)
                        );
                    }
                }
                Main.getSerialNumber(grvOrdersDetails, "serialNoGV");
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
    }
    private void cmbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOrderID.SelectedIndex != -1)
                {
                    //DataRowView dataRow = cmbOrderID.SelectedItem as DataRowView;
                    //OrderDetails.getOrderDetailsWRTOrderID(grvOrdersDetails,ItemIDGV,OrderIDGV,ItemGV,QuantityGV,PerPriceGV,TotalPriceGV,TotalOrderAmountGV,Convert.ToInt64(dataRow[0].ToString()));
                }
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message,"error");
            }
        }
        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView dataRow = cmbOrderID.SelectedItem as DataRowView;
                OrderDetails.getOrderDetailsWRTOrderID(grvOrdersDetails, ItemIDGV, OrderIDGV, ItemGV, QuantityGV, PerPriceGV, TotalPriceGV, TotalOrderAmountGV, Convert.ToInt64(dataRow[0].ToString()));
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
        }
        private void cmbFoodMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFoodMenu.SelectedIndex != -1)
            {
                try
                {
                    cmbFoodMenu.BackColor = Color.White;
                    SqlCommand sqlCmd = new SqlCommand("SP_getPriceWRTItem", Main.sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@m_id", Convert.ToInt32(cmbFoodMenu.SelectedValue.ToString()));
                    Main.sqlCon.Open();
                    txtPrice.Text = Math.Round(Convert.ToDouble(sqlCmd.ExecuteScalar().ToString()), 0).ToString();
                    Main.sqlCon.Close();
                    Image img = FoodMenu.getItemImage(Convert.ToInt32(cmbFoodMenu.SelectedValue.ToString()));
                    pbItemDiss.Image = img;
                    pbItemDiss.SizeMode = PictureBoxSizeMode.Zoom;
                    DataRowView drv = cmbFoodMenu.SelectedItem as DataRowView;
                    Roles.LoadCategoryWRTItem(drv["MenuItem"].ToString());
                }
                catch (Exception ex)
                {
                    Main.sqlCon.Close();
                    Main.showMessage(ex.Message, "error");
                }
            }
            else
            {
                txtPrice.Text = "";
                txtPrice.BackColor = Color.White;
                pbItemDiss.Image = null;
                cmbFoodMenu.BackColor = Color.Firebrick;
            }
        }
        public override void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminWindow objAdmin = new frmAdminWindow();
            Main.showWindow(objAdmin, this, frmMDI.ActiveForm);
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {

        }
        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }
        public override void btnView_Click(object sender, EventArgs e)
        {

        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
      


        #endregion


    }
}
