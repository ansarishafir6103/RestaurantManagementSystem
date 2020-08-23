using RestaurantManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.AdminPanel
{
    public partial class frmCustomers : frmSample2
    {
        #region Constructors
        public frmCustomers()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        Int64 custID = 0;
        #endregion

        #region Events
        public override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main.CheckControls(leftpanel).Count == 0)
                {
                    if (base.edit == 0)//save
                    {
                        Customers.customersInsert(txtcustName.Text, txtcustPhone.Text, txtcustAddress.Text);
                        Main.resetDisable(leftpanel);
                        Customers.customersSelectAll(grvCustomers, customerIDGV, customerNameGV, customerPhoneGV, customerAddressGV);
                    }
                    else if (edit == 1)//update
                    {
                        Customers.customersUpdate(custID, txtcustName.Text, txtcustPhone.Text, txtcustAddress.Text);
                        Main.resetDisable(leftpanel);
                        Customers.customersSelectAll(grvCustomers, customerIDGV, customerNameGV, customerPhoneGV, customerAddressGV);
                    }
                }
                else
                {
                    MessageBox.Show("please enter all required fields.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (base.delStates == 1)
                {
                    DialogResult dr = MessageBox.Show("are you sure,you want to delete this record ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Roles.commonDelete("SP_customersDelete", "@c_id", 0, custID);
                        Main.resetDisable(leftpanel);
                        Customers.customersSelectAll(grvCustomers, customerIDGV, customerNameGV, customerPhoneGV, customerAddressGV);
                        delStates = 0;
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                Customers.customersSelectAll(grvCustomers, customerIDGV, customerNameGV, customerPhoneGV, customerAddressGV);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void grvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    base.edit = 1;
                    base.delStates = 1;
                    Main.DisableControls(leftpanel);
                    DataGridViewRow row = grvCustomers.Rows[e.RowIndex];
                    custID = Convert.ToInt64(row.Cells["customerIDGV"].Value.ToString());
                    txtcustName.Text = row.Cells["customerNameGV"].Value.ToString();
                    txtcustPhone.Text = row.Cells["customerPhoneGV"].Value.ToString();
                    txtcustAddress.Text = row.Cells["customerAddressGV"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        private void txtcustName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcustName.Text == "") { txtcustName.BackColor = Color.Firebrick; } else { txtcustName.BackColor = Color.White; }

            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }

        private void txtcustPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtcustPhone.Text == "") { txtcustPhone.BackColor = Color.Firebrick; } else { txtcustPhone.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }

        private void txtcustAddress_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcustAddress.Text == "") { txtcustAddress.BackColor = Color.Firebrick; } else { txtcustAddress.BackColor = Color.White; }

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

                frmAdminWindow objAdmin = new frmAdminWindow();
                Main.showWindow(objAdmin, frmMDI.ActiveForm);

            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        #endregion





    }
}
