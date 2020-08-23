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

namespace RestaurantManagementSystem
{
    public partial class frmSample2 : frmSample
    {

        #region Constructors
        public frmSample2()
        {
            InitializeComponent();
        } 
        #endregion
        #region Variables
        public int edit = 0,delStates=0;
        #endregion

        #region Events
        public virtual void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Main.resetEnable(leftpanel);
            delStates = 0;
        }

        public virtual void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Main.EnableControls(leftpanel);
        }
        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }
        public virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }
        public virtual void btnView_Click(object sender, EventArgs e)
        {

        }
        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

       

       
        

    }
}
