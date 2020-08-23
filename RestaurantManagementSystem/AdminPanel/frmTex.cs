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
    public partial class frmTex : frmSample2
    {
        #region Constructors
        public frmTex()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables 
        int _taxId=0;
        #endregion

        #region Events
        public override void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdminWindow adm = new frmAdminWindow();
                Main.showWindow(adm,this,frmMDI.ActiveForm);
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
                if (Main.CheckControls(leftpanel).Count==0)
                {
                    if(edit==0)//save
                    {
                        Tax.taxInsert(float.Parse(txtTaxPercentage.Text),cmbTexType.SelectedItem.ToString());
                        Main.resetDisable(leftpanel);
                        Tax.taxSelectAll(grvTax,taxIDGV,valueGV,typeGV);
                    }
                    else if(edit==1)//update
                    {
                        Tax.taxUpdate(_taxId,float.Parse(txtTaxPercentage.Text), cmbTexType.SelectedItem.ToString());
                        Main.resetDisable(leftpanel);
                        Tax.taxSelectAll(grvTax, taxIDGV, valueGV, typeGV);
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
                if (delStates == 1)
                {
                    DialogResult dr = MessageBox.Show("are you sure,you want to delete this record ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Roles.commonDelete("SP_taxDelete", "@taxID", 0, _taxId);
                        Main.resetDisable(leftpanel);
                        Tax.taxSelectAll(grvTax, taxIDGV, valueGV, typeGV);
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
            Tax.taxSelectAll(grvTax, taxIDGV, valueGV, typeGV);
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void grvTax_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    base.edit = 1;
                    base.delStates = 1;
                    DataGridViewRow row = grvTax.Rows[e.RowIndex];
                    _taxId = Convert.ToInt16(row.Cells["taxIDGV"].Value);
                    txtTaxPercentage.Text = row.Cells["valueGV"].Value.ToString();
                    cmbTexType.SelectedItem = row.Cells["typeGV"].Value.ToString();
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
