using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementSystem.AdminPanel;
using RestaurantManagementSystem.ChefPanel;
namespace RestaurantManagementSystem
{
    public partial class frmLoginScreen : frmSample
    {
        #region Constructors
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main.CheckControls(leftpanel).Count == 0)
                {
                    if (Main.isValidUser(txtUsername.Text, txtPassword.Text))
                    {
                        if (Main.ROLE == "admin")
                        {
                            frmAdminWindow objAdmin = new frmAdminWindow();
                            Main.showWindow(objAdmin, this, frmMDI.ActiveForm);
                        }
                        else if(Main.ROLE=="chef")
                        {
                            frmHomeChef objChef = new frmHomeChef();
                            Main.showWindow(objChef,this,frmMDI.ActiveForm);
                        }
                    }
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
                if (txtUsername.Text == "") { txtUsername.BackColor = Color.Firebrick; } else { txtUsername.BackColor = Color.White; }
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
                if (txtPassword.Text == "") { txtPassword.BackColor = Color.Firebrick; } else { txtPassword.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        #endregion

    }
}
