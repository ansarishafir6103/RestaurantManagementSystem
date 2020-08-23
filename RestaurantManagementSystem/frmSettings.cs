using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class frmSettings : frmSample
    {
        #region Constructor
        public frmSettings()
        {
            InitializeComponent();
        }

        #endregion
        //#region Variables
        //string connection;
        //#endregion

        #region Events
        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtServer.Text == "") { lblServerError.Visible = true; } else { lblServerError.Visible = false; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
          
        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDatabase.Text == "") { lblDatabaseError.Visible = true; } else { lblDatabaseError.Visible = false; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }

        private void chkIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkIntegratedSecurity.Checked)
                {
                    lblUsernameError.Visible = false;
                    lblPasswordError.Visible = false;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
                else
                {
                    txtUsername.Enabled = true;
                    txtDatabase.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!chkIntegratedSecurity.Checked)
                {
                    if (txtUsername.Text == "") { lblUsernameError.Visible = true; } else { lblUsernameError.Visible = false; }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!chkIntegratedSecurity.Checked)
                {
                    if (txtPassword.Text == "") { lblPasswordError.Visible = true; } else { lblPasswordError.Visible = false; }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkIntegratedSecurity.Checked)
                {
                    if (txtServer.Text == "") { lblServerError.Visible = true; } else { lblServerError.Visible = false; }
                    if (txtDatabase.Text == "") { lblDatabaseError.Visible = true; } else { lblDatabaseError.Visible = false; }
                    if (lblServerError.Visible || lblDatabaseError.Visible)
                    {
                        Main.showMessage("field with * are mandatory", "error");
                    }
                    else
                    {
                        Main.getConnectionString(txtServer.Text, txtDatabase.Text);
                        Main.writeConnectionFile();
                        DialogResult dr = MessageBox.Show("Settings saved successfully.");
                        if (dr == DialogResult.OK)
                        {
                            frmLoginScreen ls = new frmLoginScreen();
                            Main.showWindow(ls, this, frmMDI.ActiveForm);
                        }
                    }
                }
                else
                {
                    if (txtServer.Text == "") { lblServerError.Visible = true; } else { lblServerError.Visible = false; }
                    if (txtDatabase.Text == "") { lblDatabaseError.Visible = true; } else { lblDatabaseError.Visible = false; }
                    if (txtUsername.Text == "") { lblUsernameError.Visible = true; } else { lblUsernameError.Visible = false; }
                    if (txtPassword.Text == "") { lblPasswordError.Visible = true; } else { lblPasswordError.Visible = false; }
                    if (lblServerError.Visible || lblDatabaseError.Visible || lblUsernameError.Visible || lblPasswordError.Visible)
                    {
                        Main.showMessage("field with * are mandatory", "error");
                    }
                    else
                    {
                        Main.getConnectionString(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
                        Main.writeConnectionFile();
                        DialogResult dr = MessageBox.Show("Settings saved successfully.");
                        if (dr == DialogResult.OK)
                        {
                            frmLoginScreen ls = new frmLoginScreen();
                            Main.showWindow(ls, this, frmMDI.ActiveForm);
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
