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
using System.IO;
namespace RestaurantManagementSystem.AdminPanel
{
    public partial class frmFoodMenu : frmSample2
    {
        #region Constructors
        public frmFoodMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        int _menuID = 0;
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
        private void txtMenuItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMenuItem.Text == "") { txtMenuItem.BackColor = Color.Firebrick; } else { txtMenuItem.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
         
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategories.SelectedIndex == -1) { cmbCategories.BackColor = Color.Firebrick; } else { cmbCategories.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Text == "") { txtPrice.BackColor = Color.Firebrick; } else { txtPrice.BackColor = Color.White; }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
           
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.SelectedIndex == -1) { cmbStatus.BackColor = Color.Firebrick; } else { cmbStatus.BackColor = Color.White; }
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
                short Status = cmbStatus.SelectedItem.ToString() == "Available" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                if (base.edit == 0)//save
                {
                    FoodMenu.FoodMenuInsert(txtMenuItem.Text,Convert.ToSingle(txtPrice.Text),Convert.ToInt32(cmbCategories.SelectedValue),Status,pbItem.Image);
                    Main.resetDisable(leftpanel);
                    FoodMenu.FoodMenuSelectAll(grvFoodMenu,MenuIDGV,MenuItemGV,PriceGV,StatusGV,CategoryIDGV,CategoryGV,ImageGV);
                }
                else if (edit == 1)//update
                {
                    FoodMenu.FoodMenuUpdate(_menuID,txtMenuItem.Text, Convert.ToSingle(txtPrice.Text), Convert.ToInt32(cmbCategories.SelectedValue), Status,pbItem.Image);
                    Main.resetDisable(leftpanel);
                    FoodMenu.FoodMenuSelectAll(grvFoodMenu, MenuIDGV, MenuItemGV, PriceGV, StatusGV, CategoryIDGV, CategoryGV, ImageGV);
                }
            }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
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
                        Roles.commonDelete("SP_FoodMenuDelete", "@m_id", 0, _menuID);
                        Main.resetDisable(leftpanel);
                        FoodMenu.FoodMenuSelectAll(grvFoodMenu, MenuIDGV, MenuItemGV, PriceGV, StatusGV, CategoryIDGV, CategoryGV, ImageGV);
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
                FoodMenu.FoodMenuSelectAll(grvFoodMenu, MenuIDGV, MenuItemGV, PriceGV, StatusGV, CategoryIDGV, CategoryGV, ImageGV);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void grvFoodMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    base.edit = 1;
                    base.delStates = 1;
                    Main.DisableControls(leftpanel);
                    DataGridViewRow row = grvFoodMenu.Rows[e.RowIndex];
                    _menuID = Convert.ToInt16(row.Cells["MenuIDGV"].Value.ToString());
                    txtMenuItem.Text = row.Cells["MenuItemGV"].Value.ToString();
                    cmbCategories.SelectedValue = row.Cells["CategoryIDGV"].Value.ToString();
                    txtPrice.Text = row.Cells["PriceGV"].Value.ToString();
                    cmbStatus.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                    //ForImage Update
                    MemoryStream ms = new MemoryStream((byte[])row.Cells["ImageGV"].Value);
                    pbItem.Image = Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
           
        }
        private void frmFoodMenu_Load(object sender, EventArgs e)
        {
            try
            {
                Roles.LoadItem("SP_categoriesSelectAll", cmbCategories, "CatName", "CatID");
                cmbCategories.SelectedIndex = -1;
                cmbCategories.BackColor = Color.White;
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
           
        }
        private void btnItemBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = openFileDialogFoodMenu.ShowDialog();
                if (dr==DialogResult.OK)
                {
                    Image im = new Bitmap(openFileDialogFoodMenu.FileName);
                    pbItem.Image = im;
                    pbItem.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
        }
        #endregion

        

     
    }
}
