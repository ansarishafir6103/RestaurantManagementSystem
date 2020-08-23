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
    public partial class frmUsers : frmSample2
    {
        #region Constructors
        public frmUsers()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        int _userID=0;
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
        private void frmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                Roles.LoadItem("SP_rolesSelectAll", cbu_roles, "r_name", "r_id");
                cbu_roles.SelectedIndex = -1;
                cbu_roles.BackColor = Color.White;
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
            
            
        }

        private void txtu_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtu_name.Text == "") { txtu_name.BackColor = Color.Firebrick; } else { txtu_name.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }
        private void txtu_uname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtu_uname.Text == "") { txtu_uname.BackColor = Color.Firebrick; } else { txtu_uname.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }

        private void txtu_password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtu_password.Text == "") { txtu_password.BackColor = Color.Firebrick; } else { txtu_password.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }

        private void txtu_phone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtu_phone.Text == "") { txtu_phone.BackColor = Color.Firebrick; } else { txtu_phone.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }

        private void txtu_address_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtu_address.Text == "") { txtu_address.BackColor = Color.Firebrick; } else { txtu_address.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }

        private void cbu_roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbu_roles.SelectedIndex == -1) { cbu_roles.BackColor = Color.Firebrick; } else { cbu_roles.BackColor = Color.White; }
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
                        Users.usersInsert(txtu_name.Text, txtu_uname.Text, txtu_password.Text, txtu_phone.Text, txtu_address.Text, Convert.ToInt16(cbu_roles.SelectedValue));
                        Main.resetDisable(leftpanel);
                        Users.usersSelectAll(grvUsers, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, addressGV, RolesGV, RoleIDGV);
                    }
                    else if (edit == 1)//update
                    {
                        Users.usersUpdate(_userID, txtu_name.Text, txtu_uname.Text, txtu_password.Text, txtu_phone.Text, txtu_address.Text, Convert.ToInt16(cbu_roles.SelectedValue));
                        Main.resetDisable(leftpanel);
                        Users.usersSelectAll(grvUsers, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, addressGV, RolesGV, RoleIDGV);
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
                        Roles.commonDelete("SP_usersDelete", "@u_id", _userID, 0);
                        Main.resetDisable(leftpanel);
                        Users.usersSelectAll(grvUsers, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, addressGV, RolesGV, RoleIDGV);
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
                Users.usersSelectAll(grvUsers, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, addressGV, RolesGV, RoleIDGV);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }
        private void grvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                edit = 1;
                delStates = 1;
                Main.DisableControls(leftpanel);
                DataGridViewRow row = grvUsers.Rows[e.RowIndex];
                _userID = Convert.ToInt16(row.Cells["userIDGV"].Value);
                txtu_name.Text = row.Cells["nameGV"].Value.ToString();
                txtu_uname.Text = row.Cells["usernameGV"].Value.ToString();
                txtu_password.Text = row.Cells["passwordGV"].Value.ToString();
                txtu_phone.Text = row.Cells["phoneGV"].Value.ToString();
                txtu_address.Text = row.Cells["addressGV"].Value.ToString();
                cbu_roles.SelectedValue = row.Cells["RoleIDGV"].Value.ToString();
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        #endregion

      
    }
}
