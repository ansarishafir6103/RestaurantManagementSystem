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
    public partial class frmAdminWindow : frmSample
    {
        #region Constructors
        public frmAdminWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnBillGeneration_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrderComplition objORDCMP = new frmOrderComplition();
                Main.showWindow(objORDCMP, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
        private void btnTax_Click(object sender, EventArgs e)
        {
            try
            {
                frmTex tax = new frmTex();
                Main.showWindow(tax,this,frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message,"error");
            }
        }
        private void btnroles_Click(object sender, EventArgs e)
        {
            try
            {
                frmRoles objRoles = new frmRoles();
                Main.showWindow(objRoles, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsers objUser = new frmUsers();
                Main.showWindow(objUser, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomers objCustomer = new frmCustomers();
                Main.showWindow(objCustomer, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        private void btnFoodCategories_Click(object sender, EventArgs e)
        {
            try
            {
                frmFoodCategories objFoodCategories = new frmFoodCategories();
                Main.showWindow(objFoodCategories, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        private void btnFoodMenu_Click(object sender, EventArgs e)
        {
            try
            {
                frmFoodMenu objFoodMenu = new frmFoodMenu();
                Main.showWindow(objFoodMenu, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        private void btnFloors_Click(object sender, EventArgs e)
        {
            try
            {
                frmFloors objFloor = new frmFloors();
                Main.showWindow(objFloor, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        private void btnFoods_Click(object sender, EventArgs e)
        {
            try
            {
                frmFloors objFood = new frmFloors();
                Main.showWindow(objFood, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            try
            {
                frmOdrers objOrders = new frmOdrers();
                Main.showWindow(objOrders, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            try
            {
                frmTables objTables = new frmTables();
                Main.showWindow(objTables, this, frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }
        private void btnOrderModification_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrderModification objOrderModification = new frmOrderModification();
                Main.showWindow(objOrderModification,this,frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message, "error");
            }
        }
        #endregion


    }
}
