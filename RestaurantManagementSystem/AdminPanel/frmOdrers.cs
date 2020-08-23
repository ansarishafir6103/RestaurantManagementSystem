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
using System.Transactions;
namespace RestaurantManagementSystem.AdminPanel
{
    public partial class frmOdrers : frmSample2
    {
        #region Constructors
        public frmOdrers()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables;
        float _totalAmount = 0;//for Calculate Total amount Make it
        Int64 CustID = 0;// for make this variab
        int _catId;//for create get category 
        string _catName;//for create get category 
        #endregion
        #region Methods
        public void SaveOrderDetails()
        {
            try
            {
                Int64 lastOrderId = Roles.LoadLastOrderId();
                int count = 0;
                foreach (DataGridViewRow row in grvOrders.Rows)
                {
                    count += OrderDetails.orderDetailsInsert(lastOrderId, Convert.ToInt32(row.Cells["ItemIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()));
                }
                if (count > 0)
                {
                    Main.showMessage("order placed", "success");

                }
                else
                {
                    Main.showMessage("error occured", "error");
                }
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
        #endregion
        #region Events
        public override void btnHome_Click(object sender, EventArgs e)
        {
            try
            {

                frmAdminWindow objAdmin = new frmAdminWindow();
                Main.showWindow(objAdmin, frmMDI.ActiveForm);

            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        private void frmOdrers_Load(object sender, EventArgs e)
        {
            try
            {
                Roles.LoadItem("SP_FoodMenuSelectAll", listBoxItem, "MenuItem", "MenuID");
                Roles.LoadItem("SP_FoodMenuSelectAll", cmbFoodMenu, "MenuItem", "MenuID");
                Roles.LoadItem("SP_floorsSelectAll", cmbFloors, "FloorName", "FloorID");
                cmbFloors.SelectedIndex = -1;
                cmbFoodMenu.SelectedIndex = -1;
                cmbTables.SelectedIndex = -1;
                cmbFloors.BackColor = Color.White;
                cmbTables.BackColor = Color.White;
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
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
        private void cmbFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOrderType.SelectedIndex == 0)
                {
                    if (cmbFloors.SelectedIndex != -1)
                    {
                        cmbFloors.BackColor = Color.White;
                        Roles.LoadItem("SP_getTablesWRTfloor", cmbTables, "TableNumber", "TableID", "@f_id", Convert.ToInt32(cmbFloors.SelectedValue.ToString()));
                        cmbTables.SelectedIndex = -1;
                    }
                    else
                    {
                        cmbFloors.BackColor = Color.Firebrick;
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        private void cmbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOrderType.SelectedIndex != -1)
                {
                    cmbOrderType.BackColor = Color.White;
                    if (cmbOrderType.SelectedIndex == 0)
                    {
                        cmbFloors.Enabled = true;
                        cmbTables.Enabled = true;
                        txtPhone.Visible = false;
                        lblPhone.Visible = false;
                        cmbFloors.BackColor = Color.Firebrick;
                        cmbTables.BackColor = Color.Firebrick;
                        txtPhone.BackColor = Color.White;
                    }
                    else
                    {
                        cmbFloors.Enabled = false;
                        cmbTables.Enabled = false;
                        txtPhone.Visible = true;
                        lblPhone.Visible = true;
                        cmbFloors.BackColor = Color.White;
                        cmbTables.BackColor = Color.White;
                        txtPhone.BackColor = Color.Firebrick;
                    }
                }
                else
                {
                    cmbOrderType.BackColor = Color.Firebrick;
                }
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
                    foreach (DataGridViewRow row in grvOrders.Rows)
                    {
                        if (row.Cells["ItemIDGV"].Value.ToString() == cmbFoodMenu.SelectedValue.ToString())
                        {
                            check = true;
                            break;
                        }
                    }

                    DataRowView drItem = cmbFoodMenu.SelectedItem as DataRowView;
                    if (check)
                    {
                        Main.showMessage("item is already exist!", "error");
                    }
                    else
                    {
                        if (cmbOrderType.SelectedIndex == 0)
                        {
                            if (Tables.checkTableStatus(Convert.ToInt32(cmbTables.SelectedValue.ToString()), Convert.ToInt16(cmbFloors.SelectedValue.ToString())))
                            {
                                cmbTables.SelectedIndex = -1;
                                Main.showMessage("table no is" + cmbTables.SelectedItem + " " + " is already busy !", "error");
                                return;
                            }
                            else
                            {
                                DataRowView drFloor = cmbFloors.SelectedItem as DataRowView;
                                DataRowView drTable = cmbTables.SelectedItem as DataRowView;

                                _catId = Roles.CATEGORYID;
                                _catName = Roles.CATEGORYNAME;
                                _totalAmount += Convert.ToSingle(txtPrice.Text) * Convert.ToSingle(numUpQuantity.Value);
                                lblTotalAmountValue.Text = _totalAmount.ToString();
                                grvOrders.Rows.Add
                                (
                                null,
                                _catId,
                                Convert.ToInt32(cmbFoodMenu.SelectedValue.ToString()),
                                Convert.ToInt32(cmbFloors.SelectedValue.ToString()),
                                Convert.ToInt32(cmbTables.SelectedValue.ToString()),
                                _catName,
                                drItem["MenuItem"],
                                Convert.ToInt32(numUpQuantity.Value),
                                Convert.ToSingle(txtPrice.Text),
                                cmbOrderType.SelectedItem,
                                drFloor["FloorName"],
                                drTable["TableNumber"],
                                null
                                );
                                return;
                            }
                        }
                        else if (cmbOrderType.SelectedIndex == 1 || cmbOrderType.SelectedIndex == 2)
                        {
                            if (!string.IsNullOrEmpty(txtPhone.Text))
                            {
                                _totalAmount += Convert.ToSingle(txtPrice.Text) * Convert.ToSingle(numUpQuantity.Value);
                                lblTotalAmountValue.Text = _totalAmount.ToString();
                                grvOrders.Rows.Add
                                 (
                                  null,
                                 _catId,
                                 Convert.ToInt32(cmbFoodMenu.SelectedValue.ToString()),
                                 null,
                                 null,
                                 _catName,
                                 drItem["MenuItem"],
                                 Convert.ToInt32(numUpQuantity.Value),
                                 Convert.ToSingle(txtPrice.Text),
                                 cmbOrderType.SelectedItem.ToString(),
                                 null,
                                 null,
                                 txtPhone.Text
                                 );
                            }
                        }
                    }
                }
                Main.getSerialNumber(grvOrders, "serialNoGV");
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Text == "") { txtPrice.BackColor = Color.Firebrick; } else { txtPrice.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text != "") { txtPhone.BackColor = Color.White; } else { txtPhone.BackColor = Color.Firebrick; }
        }

        private void numUpQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (numUpQuantity.Value <= 0) { numUpQuantity.BackColor = Color.Firebrick; } else { numUpQuantity.BackColor = Color.White; }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOrderType.SelectedIndex == 0)
                {
                    if (cmbTables.SelectedIndex != -1)
                    {
                        cmbTables.BackColor = Color.White;
                    }
                    else
                    {
                        cmbTables.BackColor = Color.Firebrick;
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        private void grvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("are you sure,you want to delete this record ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int selectedRowIndex = grvOrders.CurrentCell.RowIndex;
                    int columnIndex = grvOrders.CurrentCell.ColumnIndex;//fetching the Current Column Index
                    string columnName = grvOrders.Columns[columnIndex].Name;//using column index fech Column name
                    if (columnName == "Remove")
                    {
                        DataGridViewRow row = grvOrders.Rows[e.RowIndex];
                        float price = Convert.ToSingle(row.Cells["PriceGV"].Value.ToString()) * Convert.ToSingle(numUpQuantity.Value);
                        _totalAmount -= price;
                        lblTotalAmountValue.Text = _totalAmount.ToString();
                        grvOrders.Rows.RemoveAt(selectedRowIndex);
                        grvOrders.Refresh();
                    }
                }
                Main.getSerialNumber(grvOrders, "serialNoGV");
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            using (TransactionScope objTransaction = new TransactionScope())
            {
                try
                {
                    if (cmbOrderType.SelectedIndex == 0)
                    {
                        Orders.ordersInsert(DateTime.Today, 3, Convert.ToInt16(cmbOrderType.SelectedIndex.ToString()), Convert.ToInt16(cmbFloors.SelectedValue.ToString()), Convert.ToInt16(cmbTables.SelectedValue.ToString()), Convert.ToSingle(lblTotalAmountValue.Text), 0, 0, 0,0,0);
                        SaveOrderDetails();
                    }
                    else
                    {
                        Orders.ordersInsert(DateTime.Today, CustID, Convert.ToInt16(cmbOrderType.SelectedIndex.ToString()), 0, 0, Convert.ToSingle(lblTotalAmountValue.Text), 0, 0, 0,0,0);
                        SaveOrderDetails();
                    }
                }
                catch (Exception ex)
                {
                    Main.showMessage(ex.Message, "error");
                }
                objTransaction.Complete();
            }
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
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPhone.Text != "")
                {
                    if (txtPhone.Visible)
                    {
                        txtPhone.BackColor = Color.White;
                        CustID = Orders.getCustomerIdWRTPhone(txtPhone.Text); //get phone number to insert for customerID
                        if (CustID == 0)
                        {
                            frmCustomers objCust = new frmCustomers();
                            Main.showWindow(objCust, this, frmMDI.ActiveForm);
                        }
                        else
                        {
                            Main.showMessage(Orders.CUSTOMER + "\n" + Orders.ADDRESS + "\n", "success");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        #endregion
    }
}
