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
using RestaurantManagementSystem.ReportingTools.Classes;
using System.IO;
namespace RestaurantManagementSystem.AdminPanel
{
    public partial class frmOrderComplition : frmSample
    {
        #region Constructors
        public frmOrderComplition()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        int chk = 0;
        #endregion
        #region Methods
        public void clears()
        {
            cmbFloors.SelectedIndex = -1;
            cmbTables.SelectedIndex = -1;
            txtPhone.Text = "";
            txtOrderID.Text = "";
            grvOrderComplition.DataSource = null;
            txtAmountPaid.Text = "";
            txtAmountReturn.Text = "";
            lblTotalBillAmountValue.Text = "";
        }
        #endregion
        #region Events
        private void frmOrderComplition_Load(object sender, EventArgs e)
        {
            try
            {
                grvOrderComplition.AutoGenerateColumns = false;
                Roles.LoadItem("SP_floorsSelectAll", cmbFloors, "FloorName", "FloorID");
                cmbFloors.SelectedIndex = -1;
                cmbFloors.BackColor = Color.White;
                Roles.LoadItem("SP_taxSelectAll", cmbTax, "taxType", "taxValue");
                cmbTax.SelectedIndex = -1;
                grvOrderComplition.DataSource = null;
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            //this.crystalReportViewer1RMS.RefreshReport();
            this.reportViewer1RMS.RefreshReport();
        }
        private void cmbFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFloors.SelectedIndex != -1)
                {
                    cmbFloors.BackColor = Color.White;
                    Roles.LoadItem("SP_getTablesWRTfloor", cmbTables, "TableNumber", "TableID", "@f_id", Convert.ToInt32(cmbFloors.SelectedValue.ToString()));
                    cmbTables.SelectedIndex = -1;
                    grvOrderComplition.DataSource = null;
                    txtOrderID.Text = "";
                    lblTotalBillAmountValue.Text = "";
                }
                else
                {
                    cmbFloors.BackColor = Color.Firebrick;
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
      
        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdminWindow adm = new frmAdminWindow();
                Main.showWindow(adm, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }

        private void cmbTables_Enter(object sender, EventArgs e)
        {
            chk = 1;
        }
        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmountPaid.Text=="")
                {
                    txtAmountPaid.BackColor = Color.Firebrick;
                }
                else
                {
                    txtAmountPaid.BackColor = Color.White;
                    if (Convert.ToDouble(txtAmountPaid.Text) >= Convert.ToDouble(lblTotalBillAmountValue.Text))
                    {
                        double amtPaid = Convert.ToDouble(txtAmountPaid.Text);
                        double amtReturn = amtPaid - Convert.ToDouble(lblTotalBillAmountValue.Text);
                        txtAmountReturn.Text = amtReturn.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
        }
        private void txtAmountReturn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmountReturn.Text == "")
                {
                    txtAmountReturn.BackColor = Color.Firebrick;
                    return;
                }
                else
                {
                    txtAmountReturn.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        //ReportDocument rd;
        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOrderType.SelectedIndex!=-1 && txtAmountPaid.Text!="" && cmbTax.SelectedIndex!=-1)
                {
                    int ch=Orders.ordersUpdate(Convert.ToInt64(txtOrderID.Text),Convert.ToSingle(txtAmountPaid.Text),Convert.ToSingle(txtAmountReturn.Text),2,taxID,taxAmt);
                    if (ch > 0)
                    {
                        DialogResult dr = MessageBox.Show("order is updated successfully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            if (txtOrderID.Text!="")
                            {
                                Reports.LoadBillReport(reportViewer1RMS,Convert.ToInt64(txtOrderID.Text));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
        }
        private void cmbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOrderType.SelectedIndex!=-1)
                {
                    if (cmbOrderType.SelectedIndex==0)
                    {
                        cmbTables.Enabled = true;
                        cmbFloors.Enabled = true;
                        lblFloors.Visible = true;
                        cmbFloors.Visible = true;
                        lblTables.Visible = true;
                        cmbTables.Visible = true;
                        lblPhone.Visible = false;
                        txtPhone.Visible = false;
                        clears();
                    }
                    else
                    {
                        cmbTables.Enabled = false;
                        cmbFloors.Enabled = false;
                        lblFloors.Visible = false;
                        cmbFloors.Visible = false;
                        lblTables.Visible = false;
                        cmbTables.Visible = false;
                        lblPhone.Visible = true;
                        txtPhone.Visible = true;
                        clears(); 
                        
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
        }
        float taxAmt = 0;
        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTables.SelectedIndex != -1)
                {
                    if (chk != 0)
                    {
                        bool isTrue = Orders.getOrderBill(Convert.ToInt32(cmbTables.SelectedValue.ToString()), grvOrderComplition, orderIDGV, ItemGV, QuantityGV, AmountGV, totalAmountGV);
                        if (isTrue)
                        {
                            float amount = (float)Math.Round(Convert.ToSingle(grvOrderComplition.Rows[0].Cells["totalAmountGV"].Value.ToString()), 0);
                            float percentage = Convert.ToSingle(cmbTax.SelectedValue.ToString()) / 100;
                            taxAmt = amount * percentage;
                            DataRowView drv = cmbTax.SelectedItem as DataRowView;
                            if (drv["taxType"].ToString() == "Inclusive")
                            {

                            }
                            else if (drv["taxType"].ToString() == "Exclusive")
                            {
                                amount += taxAmt;
                            }
                            lblTotalBillAmountValue.Text = amount.ToString();
                            txtOrderID.Text = grvOrderComplition.Rows[0].Cells["orderIDGV"].Value.ToString();
                            Main.getSerialNumber(grvOrderComplition, "SrNoGVL");
                            txtAmountPaid.Text = "";
                            txtAmountReturn.Text = "";
                        }
                        else
                        {
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPhone.Text))
                {
                    bool isTrue=Orders.getOrderBill(txtPhone.Text, grvOrderComplition, orderIDGV, ItemGV, QuantityGV, AmountGV, totalAmountGV);
                    if (isTrue)
                    {
                    float amount =(float)Math.Round(Convert.ToSingle(grvOrderComplition.Rows[0].Cells["totalAmountGV"].Value.ToString()), 0);
                    float  percentage = Convert.ToSingle(cmbTax.SelectedValue.ToString()) / 100;
                    taxAmt = amount * percentage;
                    DataRowView drv = cmbTax.SelectedItem as DataRowView;
                    if (drv["taxType"].ToString() == "Inclusive")
                    {

                    }
                    else if (drv["taxType"].ToString() == "Exclusive")
                    {
                        amount += taxAmt;
                    }
                    lblTotalBillAmountValue.Text = amount.ToString();
                    txtOrderID.Text = grvOrderComplition.Rows[0].Cells["orderIDGV"].Value.ToString();
                    Main.getSerialNumber(grvOrderComplition, "SrNoGVL");    
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
        #region cmbTax_SelectedIndexChanged
        Int16 taxID=0;
        private void cmbTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTax.SelectedIndex != -1)
                {
                   DataRowView drv = cmbTax.SelectedItem as DataRowView;
                   taxID= Orders.getTaxID(drv["taxType"].ToString());
                }
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
        #endregion
        private void frmOrderComplition_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reportViewer1RMS!=null)
            {
                reportViewer1RMS.Clear();   
            }
        }
        #endregion


    }
}
