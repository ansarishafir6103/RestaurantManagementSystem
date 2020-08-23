using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Collections;
namespace RestaurantManagementSystem
{
    class Main
    {
        #region Variables
        private static string connection;
        static string path;

        private static string name;//for create assign username
        private static string role;//for create assign role
        #endregion

        #region Properties
        public static string USERNAME { get { return name; } private set { name = value; } }
        public static string ROLE { get { return role; } private set { role = value; } }
        #endregion

        #region Methods

        public static bool isValidUser(string username, string password)
        {
            bool status = false;
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_getUserForAuthentication", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", username);
                sqlCmd.Parameters.AddWithValue("@password", password);
                sqlCon.Open();
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (username == dr["username"].ToString() && password == dr["password"].ToString())
                        {
                            USERNAME = dr["Name"].ToString();
                            ROLE = dr["Role"].ToString();
                            status = true;
                        }
                    }
                }
                else
                {
                    showMessage("invalid username and password !", "error");
                    status = false;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {

                showMessage(ex.Message, "error");
                sqlCon.Close();
            }
            return status;
        }

        public static void getSerialNumber(DataGridView gridView, string serialNoGV)
        {
            int count = 0;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                count++;
                row.Cells[serialNoGV].Value = count;
            }
        }

        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form MDI)
        {
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showMessage(string msg, string type)
        {
            if (type == "success")
            {
                MessageBox.Show(msg, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "error")
            {
                MessageBox.Show(msg, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Get Connection String OverLoaded Method
        public static void getConnectionString(string serverName, string databaseName)
        {
            connection = "Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Integrated Security=true;MultipleActiveResultSets=true;";

        }
        public static void getConnectionString(string serverName, string databaseName, string username, string password)
        {
            connection = "Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";User ID=" + username + ";Password=" + password + ";Integrated Security=true;MulgipleActiveResultSets=true;";
        }
        #endregion
        //for write connection string on hard drive file
        public static void writeConnectionFile()
        {
            try
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
                File.WriteAllText(path, connection);
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }

        }

        public static string readConnectionFile()
        {
            string connectString = "";
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            try
            {
                if (File.Exists(path))
                {
                    //string f = File.ReadAllText(path);
                    //return File.ReadAllText(path);
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string ss = sr.ReadLine();
                            string[] strSplit = ss.Split(';');
                            //now loop through the arry
                            string server = strSplit[0].ToString();
                            string database = strSplit[1].ToString();
                            string username = strSplit[2].ToString();
                            string password = strSplit[3].ToString();
                            connectString = server + ";" + database + ";" + username + ";" + password;
                        }
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
            return connectString;
        }

        public static SqlConnection sqlCon = new SqlConnection(readConnectionFile());
        public static void updateConfigFile(string connection)
        {
            //update config file
            XmlDocument xmlDoc = new XmlDocument();
            //Loading the Config file
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if (xmlElement.Name == "connectionStrings")
                {
                    //setting the connection string
                    xmlElement.FirstChild.Attributes[2].Value = connection;
                }
            }
            //wirte the connection string in config file
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionString");

        }
        public static void resetEnable(Panel panel)
        {
            try
            {
                foreach (Control Ctrl in panel.Controls)
                {
                    if (Ctrl is NumericUpDown)
                    {
                        NumericUpDown nd = (NumericUpDown)Ctrl;
                        nd.Value = 0;
                        nd.Enabled = true;
                        nd.BackColor = Color.White;
                    }
                    if (Ctrl is PictureBox)
                    {
                        PictureBox pb = (PictureBox)Ctrl;
                        pb.Image = null;
                        pb.Enabled = true;
                    }
                    if (Ctrl is Button)
                    {
                        Button bt = (Button)Ctrl;
                        bt.Enabled = true;
                    }
                    if (Ctrl is TextBox)
                    {
                        TextBox tb = (TextBox)Ctrl;
                        tb.Text = "";
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }
                    if (Ctrl is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)Ctrl;
                        cmb.SelectedIndex = -1;
                        cmb.Enabled = true;
                        cmb.BackColor = Color.White;
                    }
                    if (Ctrl is RadioButton)
                    {
                        RadioButton rb = (RadioButton)Ctrl;
                        rb.Checked = false;
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                    if (Ctrl is CheckBox)
                    {
                        CheckBox cb = (CheckBox)Ctrl;
                        cb.Checked = false;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }
                    if (Ctrl is DateTimePicker)
                    {
                        DateTimePicker dt = (DateTimePicker)Ctrl;
                        dt.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public static void resetDisable(Panel panel)
        {
            try
            {
                foreach (Control Ctrl in panel.Controls)
                {
                    if (Ctrl is NumericUpDown)
                    {
                        NumericUpDown nd = (NumericUpDown)Ctrl;
                        nd.Value = 0;
                        nd.Enabled = false;
                        nd.BackColor = Color.White;
                    }
                    if (Ctrl is PictureBox)
                    {
                        PictureBox pb = (PictureBox)Ctrl;
                        pb.Image = null;
                        pb.Enabled = false;
                    }
                    if (Ctrl is Button)
                    {
                        Button bt = (Button)Ctrl;
                        bt.Enabled = false;
                    }
                    if (Ctrl is TextBox)
                    {
                        TextBox tb = (TextBox)Ctrl;
                        tb.Text = "";
                        tb.Enabled = false;
                        tb.BackColor = Color.White;

                    }
                    if (Ctrl is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)Ctrl;
                        cmb.SelectedIndex = -1;
                        cmb.Enabled = false;
                        cmb.BackColor = Color.White;
                    }
                    if (Ctrl is RadioButton)
                    {
                        RadioButton rb = (RadioButton)Ctrl;
                        rb.Checked = false;
                        rb.Enabled = false;
                        rb.BackColor = Color.White;
                    }
                    if (Ctrl is CheckBox)
                    {
                        CheckBox cb = (CheckBox)Ctrl;
                        cb.Checked = false;
                        cb.Enabled = false;
                        cb.BackColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public static void EnableControls(Panel panel)
        {
            try
            {
                foreach (Control Ctrl in panel.Controls)
                {
                    if (Ctrl is NumericUpDown)
                    {
                        NumericUpDown nd = (NumericUpDown)Ctrl;
                        nd.Value = 0;
                        nd.Enabled = true;
                        nd.BackColor = Color.White;
                    }
                    if (Ctrl is PictureBox)
                    {
                        PictureBox pb = (PictureBox)Ctrl;
                        pb.Image = null;
                        pb.Enabled = true;
                    }
                    if (Ctrl is Button)
                    {
                        Button bt = (Button)Ctrl;
                        bt.Enabled = true;
                    }
                    if (Ctrl is TextBox)
                    {
                        TextBox tb = (TextBox)Ctrl;
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }
                    if (Ctrl is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)Ctrl;
                        cmb.Enabled = true;
                        cmb.BackColor = Color.White;
                    }
                    if (Ctrl is RadioButton)
                    {
                        RadioButton rb = (RadioButton)Ctrl;
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                    if (Ctrl is CheckBox)
                    {
                        CheckBox cb = (CheckBox)Ctrl;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }
                    if (Ctrl is DateTimePicker)
                    {
                        DateTimePicker dt = (DateTimePicker)Ctrl;
                        dt.Enabled = true;
                        dt.BackColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }
        public static void DisableControls(Panel panel)
        {
            try
            {
                foreach (Control Ctrl in panel.Controls)
                {
                    if (Ctrl is TextBox)
                    {
                        TextBox tb = (TextBox)Ctrl;
                        tb.Enabled = false;
                    }
                    if (Ctrl is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)Ctrl;
                        cmb.Enabled = false;
                    }
                    if (Ctrl is RadioButton)
                    {
                        RadioButton rb = (RadioButton)Ctrl;
                        rb.Enabled = false;
                    }
                    if (Ctrl is CheckBox)
                    {
                        CheckBox cb = (CheckBox)Ctrl;
                        cb.Enabled = false;
                    }
                    if (Ctrl is DateTimePicker)
                    {
                        DateTimePicker dt = (DateTimePicker)Ctrl;
                        dt.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

                Main.showMessage(ex.Message, "error");
            }
        }

        #region checkControls

        public static ArrayList CheckControls(Panel panel)
        {

            ArrayList arr = new ArrayList();
            foreach (Control Ctrl in panel.Controls)
            {
                if (Ctrl is NumericUpDown)
                {
                    NumericUpDown nd = (NumericUpDown)Ctrl;
                    if (nd.AllowDrop == true) { }
                    else
                    {
                        if (nd.Value <= 0) { arr.Add(nd); } else { if (arr.Contains(nd)) { arr.Remove(nd); } }
                        nd.BackColor = nd.Value <= 0 ? nd.BackColor = Color.Firebrick : nd.BackColor = Color.White;
                    }

                }
                if (Ctrl is TextBox)
                {
                    TextBox tb = (TextBox)Ctrl;
                    if (tb.AllowDrop == true) { }
                    else
                    {
                        if (tb.Text == "") { arr.Add(tb); } else { if (arr.Contains(tb)) { arr.Remove(tb); } }
                        tb.BackColor = tb.Text == "" ? tb.BackColor = Color.Firebrick : tb.BackColor = Color.White;
                    }

                }
                if (Ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)Ctrl;
                    if (cmb.AllowDrop == true) { }
                    else
                    {
                        if (cmb.SelectedIndex == -1) { arr.Add(cmb); } else { if (arr.Contains(cmb)) { arr.Remove(cmb); } }
                        cmb.BackColor = cmb.SelectedIndex == -1 ? cmb.BackColor = Color.Firebrick : cmb.BackColor = Color.White;
                    }

                }
                if (Ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)Ctrl;
                    if (rb.AllowDrop==true){ }
                    else
                    {
                        if (!rb.Checked) { arr.Add(rb); } else { if (arr.Contains(rb)) { arr.Remove(rb); } }
                        rb.BackColor = !rb.Checked ? rb.BackColor = Color.Firebrick : rb.BackColor = Color.White;
                    }
                }
                if (Ctrl is CheckBox)
                {
                    CheckBox cb = (CheckBox)Ctrl;
                    if (cb.AllowDrop == true) { }
                    else
                    {
                        if (!cb.Checked) { arr.Add(cb); } else { if (arr.Contains(cb)) { arr.Remove(cb); } }
                        cb.BackColor = !cb.Checked ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                    }
                    
                }
                //if (Ctrl is DateTimePicker)
                //{
                //    DateTimePicker dt = (DateTimePicker)Ctrl;
                //    if (dt.AllowDrop == true) { }
                //    else
                //    {
                //        if (dt.Text != "") { arr.Add(dt); }
                //    }
                //}
            }
            return arr;
        }
        #endregion

        #endregion

    }
}
