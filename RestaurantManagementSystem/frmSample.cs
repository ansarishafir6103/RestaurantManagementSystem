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
    public partial class frmSample : Form
    {
        #region Constructors
        public frmSample()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        public static bool isLogOut = false;
        #endregion

        #region Events
        private void frmSample_Load(object sender, EventArgs e)
        {
           
                if (isLogOut)
                {
                    lblLoginDetails.Text = string.Empty;
                }
                else
                {
                    lblLoginDetails.Text = Main.USERNAME;
                }
            
        }
        #endregion


       
    }
}
