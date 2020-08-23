namespace RestaurantManagementSystem
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.chkIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblServerError = new System.Windows.Forms.Label();
            this.lblDatabaseError = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.txtDatabase);
            this.leftpanel.Controls.Add(this.lblDatabase);
            this.leftpanel.Controls.Add(this.txtServer);
            this.leftpanel.Controls.Add(this.lblServer);
            this.leftpanel.Controls.Add(this.chkIntegratedSecurity);
            this.leftpanel.Controls.Add(this.btnSave);
            this.leftpanel.Controls.Add(this.txtPassword);
            this.leftpanel.Controls.Add(this.lblPassword);
            this.leftpanel.Controls.Add(this.txtUsername);
            this.leftpanel.Controls.Add(this.lblUsername);
            this.leftpanel.Controls.Add(this.lblServerError);
            this.leftpanel.Controls.Add(this.lblDatabaseError);
            this.leftpanel.Controls.Add(this.lblUsernameError);
            this.leftpanel.Controls.Add(this.lblPasswordError);
            this.leftpanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftpanel.Size = new System.Drawing.Size(250, 529);
            this.leftpanel.Controls.SetChildIndex(this.lblPasswordError, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblUsernameError, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblDatabaseError, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblServerError, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblUsername, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtUsername, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblPassword, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtPassword, 0);
            this.leftpanel.Controls.SetChildIndex(this.btnSave, 0);
            this.leftpanel.Controls.SetChildIndex(this.chkIntegratedSecurity, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblServer, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtServer, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblDatabase, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtDatabase, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightpanel.Size = new System.Drawing.Size(668, 529);
            // 
            // leftHeaderpanel1
            // 
            this.leftHeaderpanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(8, 388);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(238, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(8, 328);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(239, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 310);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(8, 280);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(239, 23);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 262);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 15);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // chkIntegratedSecurity
            // 
            this.chkIntegratedSecurity.AutoSize = true;
            this.chkIntegratedSecurity.Location = new System.Drawing.Point(8, 358);
            this.chkIntegratedSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.chkIntegratedSecurity.Name = "chkIntegratedSecurity";
            this.chkIntegratedSecurity.Size = new System.Drawing.Size(120, 19);
            this.chkIntegratedSecurity.TabIndex = 11;
            this.chkIntegratedSecurity.Text = "Integrated Security";
            this.chkIntegratedSecurity.UseVisualStyleBackColor = true;
            this.chkIntegratedSecurity.CheckedChanged += new System.EventHandler(this.chkIntegratedSecurity_CheckedChanged);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(8, 231);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatabase.MaxLength = 30;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(239, 23);
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(6, 213);
            this.lblDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(55, 15);
            this.lblDatabase.TabIndex = 14;
            this.lblDatabase.Text = "Database";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(8, 180);
            this.txtServer.Margin = new System.Windows.Forms.Padding(2);
            this.txtServer.MaxLength = 30;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(239, 23);
            this.txtServer.TabIndex = 0;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(6, 163);
            this.lblServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(39, 15);
            this.lblServer.TabIndex = 12;
            this.lblServer.Text = "Server";
            // 
            // lblServerError
            // 
            this.lblServerError.AutoSize = true;
            this.lblServerError.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerError.Location = new System.Drawing.Point(226, 154);
            this.lblServerError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerError.Name = "lblServerError";
            this.lblServerError.Size = new System.Drawing.Size(20, 25);
            this.lblServerError.TabIndex = 16;
            this.lblServerError.Text = "*";
            this.lblServerError.Visible = false;
            // 
            // lblDatabaseError
            // 
            this.lblDatabaseError.AutoSize = true;
            this.lblDatabaseError.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseError.Location = new System.Drawing.Point(226, 206);
            this.lblDatabaseError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatabaseError.Name = "lblDatabaseError";
            this.lblDatabaseError.Size = new System.Drawing.Size(20, 25);
            this.lblDatabaseError.TabIndex = 17;
            this.lblDatabaseError.Text = "*";
            this.lblDatabaseError.Visible = false;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.Location = new System.Drawing.Point(228, 255);
            this.lblUsernameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(20, 25);
            this.lblUsernameError.TabIndex = 18;
            this.lblUsernameError.Text = "*";
            this.lblUsernameError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.Location = new System.Drawing.Point(228, 302);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(20, 25);
            this.lblPasswordError.TabIndex = 19;
            this.lblPasswordError.Text = "*";
            this.lblPasswordError.Visible = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 529);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chkIntegratedSecurity;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblServerError;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblDatabaseError;
        private System.Windows.Forms.Label lblPasswordError;
    }
}