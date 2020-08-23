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
    public partial class frmRoles : frmSample2
    {
        #region Constructors
        public frmRoles()
        {
            InitializeComponent();
        } 
        #endregion

        #region Variables
        //int edit = 0,delStates=0;
        Int16 roleID;
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
        private void txtRoles_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRoles.Text == "") { txtRoles.BackColor = Color.Firebrick; } else { txtRoles.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
           
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (Main.CheckControls(leftpanel).Count == 0)
                {
                    if (base.edit == 0)//code for save operation
                    {
                        Roles.rolesInsert(txtRoles.Text);
                        Main.resetDisable(leftpanel);
                        Roles.roleSelectAll(grvRoles, r_id, r_name);//this column name is datagrid view column name
                    }
                    else if (base.edit == 1)
                    {
                        Roles.rolesUpdate(roleID, txtRoles.Text);
                        Main.resetDisable(leftpanel);
                        Roles.roleSelectAll(grvRoles, r_id, r_name); //this column name is datagrid view column name
                    }
                    edit = 0;
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
                        Roles.commonDelete("SP_rolesDelete", "@r_id", roleID, 0);
                        Main.resetDisable(leftpanel);
                        Roles.roleSelectAll(grvRoles, r_id, r_name);
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
                Roles.roleSelectAll(grvRoles, r_id, r_name);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
          
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void grvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    base.edit = 1;
                    base.delStates = 1;
                    Main.DisableControls(leftpanel);
                    DataGridViewRow row = grvRoles.Rows[e.RowIndex];
                    roleID = Convert.ToInt16(row.Cells["r_id"].Value.ToString());
                    txtRoles.Text = row.Cells["r_name"].Value.ToString();
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
