using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.ChefPanel
{
    public partial class frmHomeChef : frmSample
    {
        #region Constructors
        public frmHomeChef()
        {
            InitializeComponent();
        }

        #endregion
        #region Events
        private void btnOrders_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrderChef objChef = new frmOrderChef();
                Main.showWindow(objChef,this,frmMDI.ActiveForm);
            }
            catch (Exception ex)
            {
                Main.showMessage(ex.Message,"error");
            }
        }
        #endregion
    }
}
