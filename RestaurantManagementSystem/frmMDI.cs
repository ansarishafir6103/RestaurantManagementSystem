using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
namespace RestaurantManagementSystem
{
    public partial class frmMDI : Form
    {
        #region Constructors
        public frmMDI()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect"))
                {
                    frmSettings objsetting = new frmSettings();
                    Main.showWindow(objsetting, this);
                }
                else
                {
                    frmLoginScreen objls = new frmLoginScreen();
                    Main.showWindow(objls, this);
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message,"error");
            }
            

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSample.isLogOut = true;
                frmLoginScreen objLogin = new frmLoginScreen();
                Main.showWindow(objLogin, this);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            

        }
        #endregion
    }
}
