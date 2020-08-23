using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementSystem.Class;
namespace RestaurantManagementSystem.ChefPanel
{
    public partial class frmOrderChef : frmSample2
    {
        #region Constructors
        public frmOrderChef()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void frmOrderChef_Load(object sender, EventArgs e)
        {
            try
            {
                OrderDetails.getPendingOrders(grvChefOrdersLeftPanel, orderIDGV, statusGV);
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                timer1.Start();
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
        Int64 orderID;
        private void grvChefOrdersLeftPanel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    DataGridViewRow row = grvChefOrdersLeftPanel.Rows[e.RowIndex];
                    orderID = Convert.ToInt64(row.Cells["orderIDGV"].Value.ToString());
                    OrderDetails.getPendingOrders(orderID, grvOrdersRightPanel, ItemGV, QuantityGV);
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public override void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                frmHomeChef objChef = new frmHomeChef();
                Main.showWindow(objChef, this, frmMDI.ActiveForm);
                timer1.Start();
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        int counnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counnt++;
            if (counnt==5)
            {
                 OrderDetails.getPendingOrders(grvChefOrdersLeftPanel, orderIDGV, statusGV);
                 counnt = 0;
            }
        }
        #endregion

        private void frmOrderChef_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
        Int64 _orederID;
        private void grvChefOrdersLeftPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 DataGridViewRow row = grvChefOrdersLeftPanel.Rows[e.RowIndex];
                 _orederID = Convert.ToInt64(row.Cells["orderIDGV"].Value.ToString());
                 //int columnIndex = grvChefOrdersLeftPanel.CurrentCell.ColumnIndex;//fetching the Current Column Index
                 string columnName = grvChefOrdersLeftPanel.Columns[e.ColumnIndex].Name;//using column index fech Column name
                 if (columnName=="DoneBtnGV")
                 {
                     DialogResult dr = MessageBox.Show("are you sure,you want update status ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (dr == DialogResult.Yes)
                     {
                         Orders.updateOrderStatus(_orederID,1);
                         OrderDetails.getPendingOrders(orderID, grvOrdersRightPanel, ItemGV, QuantityGV);
                     }
                 }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
       
    }
}
