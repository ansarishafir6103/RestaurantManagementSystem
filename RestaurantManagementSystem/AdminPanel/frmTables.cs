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
    public partial class frmTables : frmSample2
    {
        #region Constructors
         public frmTables()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
		Int16 _tableID=0; 
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
        private void frmTables_Load(object sender, EventArgs e)
        {
            try
            {
                Roles.LoadItem("SP_floorsSelectAll", cmbFloorNumber, "FloorNumber", "FloorID");
                cmbFloorNumber.SelectedIndex = -1;
                cmbFloorNumber.BackColor = Color.White;
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
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

        private void cmbTableChairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTableChairs.SelectedIndex == -1) { cmbTableChairs.BackColor = Color.Firebrick; } else { cmbTableChairs.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }

        private void cmbTableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTableNumber.SelectedIndex == -1) { cmbTableNumber.BackColor = Color.Firebrick; } else { cmbTableNumber.BackColor = Color.White; }
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
                        Tables.tablesInsert(Convert.ToInt16(cmbTableNumber.SelectedItem), Convert.ToInt32(cmbTableChairs.SelectedItem), Convert.ToInt32(cmbFloorNumber.SelectedValue));
                        Main.resetDisable(leftpanel);
                        Tables.tablesSelectAll(grvTables, TableIDGV, TableNumberGV, TableChairGV, FloorNumberGV, FloorNameGV, TableFloorIDGV);
                    }
                    else if (edit == 1)//update
                    {
                        Tables.tablesUpdate(_tableID, Convert.ToInt16(cmbTableNumber.SelectedItem), Convert.ToInt32(cmbTableChairs.SelectedItem), Convert.ToInt32(cmbFloorNumber.SelectedValue));
                        Main.resetDisable(leftpanel);
                        Tables.tablesSelectAll(grvTables, TableIDGV, TableNumberGV, TableChairGV, FloorNumberGV, FloorNameGV, TableFloorIDGV);
                    }
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
                        Roles.commonDelete("SP_TablesDelete", "@t_id", _tableID, 0);
                        Main.resetDisable(leftpanel);
                        Tables.tablesSelectAll(grvTables, TableIDGV, TableNumberGV, TableChairGV, FloorNumberGV, FloorNameGV, TableFloorIDGV);
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
                Tables.tablesSelectAll(grvTables, TableIDGV, TableNumberGV, TableChairGV, FloorNumberGV, FloorNameGV, TableFloorIDGV);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
           
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void grvTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    base.edit = 1;
                    base.delStates = 1;
                    Main.DisableControls(leftpanel);
                    DataGridViewRow row = grvTables.Rows[e.RowIndex];
                    _tableID = Convert.ToInt16(row.Cells["TableIDGV"].Value.ToString());
                    cmbTableNumber.SelectedItem = row.Cells["TableNumberGV"].Value.ToString();
                    cmbTableChairs.SelectedItem = row.Cells["TableChairGV"].Value.ToString();
                    cmbFloorNumber.SelectedValue = row.Cells["FloorNumberGV"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
           
        #endregion    
        }

    }
}
