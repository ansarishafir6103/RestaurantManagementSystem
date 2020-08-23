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

namespace RestaurantManagementSystem.AdminPanel
{
    public partial class frmFloors : frmSample2
    {
        #region Constructors
        public frmFloors()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        Int16 _FloorID = 0;
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
        private void txtFloorName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtFloorName.Text == "") { txtFloorName.BackColor = Color.Firebrick; } else { txtFloorName.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        private void cmbFloorNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbFloorNumber.SelectedIndex == -1) { cmbFloorNumber.BackColor = Color.Firebrick; } else { cmbFloorNumber.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main.CheckControls(leftpanel).Count == 0)
                {
                    if (base.edit == 0)//save
                    {
                        Floors.floorsInsert(txtFloorName.Text, Convert.ToInt32(cmbFloorNumber.SelectedItem));
                        Main.resetDisable(leftpanel);
                        Floors.floorsSelectAll(grvFloors, FloorIDGV, FloorNameGV, FloorNumberGV);
                    }
                    else if (edit == 1)//update
                    {
                        Floors.floorsUpdate(_FloorID, txtFloorName.Text, Convert.ToInt32(cmbFloorNumber.SelectedItem));
                        Main.resetDisable(leftpanel);
                        Floors.floorsSelectAll(grvFloors, FloorIDGV, FloorNameGV, FloorNumberGV);
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
                        Roles.commonDelete("SP_floorsDelete", "@f_id", 0, _FloorID);
                        Main.resetDisable(leftpanel);
                        Floors.floorsSelectAll(grvFloors, FloorIDGV, FloorNameGV, FloorNumberGV);
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

                Floors.floorsSelectAll(grvFloors, FloorIDGV, FloorNameGV, FloorNumberGV);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void grvFloors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    base.edit = 1;
                    base.delStates = 1;
                    Main.DisableControls(leftpanel);
                    DataGridViewRow row = grvFloors.Rows[e.RowIndex];
                    _FloorID = Convert.ToInt16(row.Cells["FloorIDGV"].Value.ToString());
                    txtFloorName.Text = row.Cells["FloorNameGV"].Value.ToString();
                    cmbFloorNumber.SelectedItem = row.Cells["FloorNumberGV"].Value.ToString();
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
