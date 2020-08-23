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
    public partial class frmFoodCategories : frmSample2
    {
        #region Constructors
        public frmFoodCategories()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        int _categoryID = 0;
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
        private void txtfoodcategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtfoodcategory.Text == "") { txtfoodcategory.BackColor = Color.Firebrick; } else { txtfoodcategory.BackColor = Color.White; }

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
                        FoodCategories.categoriesInsert(txtfoodcategory.Text);
                        Main.resetDisable(leftpanel);
                        FoodCategories.categoriesSelectAll(grvFoodCategories, CategoryIDGV, CategoryNameGV);
                    }
                    else if (edit == 1)//update
                    {
                        FoodCategories.categoriesUpdate(_categoryID, txtfoodcategory.Text);
                        Main.resetDisable(leftpanel);
                        FoodCategories.categoriesSelectAll(grvFoodCategories, CategoryIDGV, CategoryNameGV);
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
                        Roles.commonDelete("SP_categoriesDelete", "@c_id", 0, _categoryID);
                        Main.resetDisable(leftpanel);
                        FoodCategories.categoriesSelectAll(grvFoodCategories, CategoryIDGV, CategoryNameGV);
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

                FoodCategories.categoriesSelectAll(grvFoodCategories, CategoryIDGV, CategoryNameGV);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void grvFoodCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    base.edit = 1;
                    base.delStates = 1;
                    Main.DisableControls(leftpanel);
                    DataGridViewRow row = grvFoodCategories.Rows[e.RowIndex];
                    _categoryID = Convert.ToInt16(row.Cells["CategoryIDGV"].Value.ToString());
                    txtfoodcategory.Text = row.Cells["CategoryNameGV"].Value.ToString();
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
