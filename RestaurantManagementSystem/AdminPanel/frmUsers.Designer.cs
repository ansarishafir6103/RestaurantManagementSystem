namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtu_name = new System.Windows.Forms.TextBox();
            this.lblu_name = new System.Windows.Forms.Label();
            this.txtu_uname = new System.Windows.Forms.TextBox();
            this.lblu_uname = new System.Windows.Forms.Label();
            this.txtu_password = new System.Windows.Forms.TextBox();
            this.lblu_password = new System.Windows.Forms.Label();
            this.txtu_phone = new System.Windows.Forms.TextBox();
            this.lblu_phone = new System.Windows.Forms.Label();
            this.txtu_address = new System.Windows.Forms.TextBox();
            this.lblu_address = new System.Windows.Forms.Label();
            this.cbu_roles = new System.Windows.Forms.ComboBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.gbUsersDetails = new System.Windows.Forms.GroupBox();
            this.grvUsers = new System.Windows.Forms.DataGridView();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolesGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbUsersDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // rightHeaderpanel2
            // 
            this.rightHeaderpanel2.Size = new System.Drawing.Size(677, 48);
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(105, 23);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.lblRoles);
            this.leftpanel.Controls.Add(this.cbu_roles);
            this.leftpanel.Controls.Add(this.txtu_address);
            this.leftpanel.Controls.Add(this.lblu_address);
            this.leftpanel.Controls.Add(this.txtu_phone);
            this.leftpanel.Controls.Add(this.lblu_phone);
            this.leftpanel.Controls.Add(this.txtu_password);
            this.leftpanel.Controls.Add(this.lblu_password);
            this.leftpanel.Controls.Add(this.txtu_uname);
            this.leftpanel.Controls.Add(this.lblu_uname);
            this.leftpanel.Controls.Add(this.txtu_name);
            this.leftpanel.Controls.Add(this.lblu_name);
            this.leftpanel.Size = new System.Drawing.Size(250, 502);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblu_name, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtu_name, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblu_uname, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtu_uname, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblu_password, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtu_password, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblu_phone, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtu_phone, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblu_address, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtu_address, 0);
            this.leftpanel.Controls.SetChildIndex(this.cbu_roles, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblRoles, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbUsersDetails);
            this.rightpanel.Size = new System.Drawing.Size(677, 502);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbUsersDetails, 0);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(677, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Size = new System.Drawing.Size(677, 45);
            // 
            // txtu_name
            // 
            this.txtu_name.Enabled = false;
            this.txtu_name.Location = new System.Drawing.Point(12, 120);
            this.txtu_name.Name = "txtu_name";
            this.txtu_name.Size = new System.Drawing.Size(224, 23);
            this.txtu_name.TabIndex = 6;
            this.txtu_name.TextChanged += new System.EventHandler(this.txtu_name_TextChanged);
            // 
            // lblu_name
            // 
            this.lblu_name.AutoSize = true;
            this.lblu_name.Location = new System.Drawing.Point(12, 102);
            this.lblu_name.Name = "lblu_name";
            this.lblu_name.Size = new System.Drawing.Size(38, 15);
            this.lblu_name.TabIndex = 5;
            this.lblu_name.Text = "Name";
            // 
            // txtu_uname
            // 
            this.txtu_uname.Enabled = false;
            this.txtu_uname.Location = new System.Drawing.Point(12, 168);
            this.txtu_uname.Name = "txtu_uname";
            this.txtu_uname.Size = new System.Drawing.Size(224, 23);
            this.txtu_uname.TabIndex = 9;
            this.txtu_uname.TextChanged += new System.EventHandler(this.txtu_uname_TextChanged);
            // 
            // lblu_uname
            // 
            this.lblu_uname.AutoSize = true;
            this.lblu_uname.Location = new System.Drawing.Point(12, 150);
            this.lblu_uname.Name = "lblu_uname";
            this.lblu_uname.Size = new System.Drawing.Size(58, 15);
            this.lblu_uname.TabIndex = 8;
            this.lblu_uname.Text = "Username";
            // 
            // txtu_password
            // 
            this.txtu_password.Enabled = false;
            this.txtu_password.Location = new System.Drawing.Point(12, 217);
            this.txtu_password.Name = "txtu_password";
            this.txtu_password.Size = new System.Drawing.Size(224, 23);
            this.txtu_password.TabIndex = 12;
            this.txtu_password.UseSystemPasswordChar = true;
            this.txtu_password.TextChanged += new System.EventHandler(this.txtu_password_TextChanged);
            // 
            // lblu_password
            // 
            this.lblu_password.AutoSize = true;
            this.lblu_password.Location = new System.Drawing.Point(12, 199);
            this.lblu_password.Name = "lblu_password";
            this.lblu_password.Size = new System.Drawing.Size(55, 15);
            this.lblu_password.TabIndex = 11;
            this.lblu_password.Text = "Password";
            // 
            // txtu_phone
            // 
            this.txtu_phone.Enabled = false;
            this.txtu_phone.Location = new System.Drawing.Point(12, 266);
            this.txtu_phone.Name = "txtu_phone";
            this.txtu_phone.Size = new System.Drawing.Size(224, 23);
            this.txtu_phone.TabIndex = 15;
            this.txtu_phone.TextChanged += new System.EventHandler(this.txtu_phone_TextChanged);
            // 
            // lblu_phone
            // 
            this.lblu_phone.AutoSize = true;
            this.lblu_phone.Location = new System.Drawing.Point(12, 248);
            this.lblu_phone.Name = "lblu_phone";
            this.lblu_phone.Size = new System.Drawing.Size(39, 15);
            this.lblu_phone.TabIndex = 14;
            this.lblu_phone.Text = "Phone";
            // 
            // txtu_address
            // 
            this.txtu_address.Enabled = false;
            this.txtu_address.Location = new System.Drawing.Point(12, 314);
            this.txtu_address.Name = "txtu_address";
            this.txtu_address.Size = new System.Drawing.Size(224, 23);
            this.txtu_address.TabIndex = 18;
            this.txtu_address.TextChanged += new System.EventHandler(this.txtu_address_TextChanged);
            // 
            // lblu_address
            // 
            this.lblu_address.AutoSize = true;
            this.lblu_address.Location = new System.Drawing.Point(12, 296);
            this.lblu_address.Name = "lblu_address";
            this.lblu_address.Size = new System.Drawing.Size(49, 15);
            this.lblu_address.TabIndex = 17;
            this.lblu_address.Text = "Address";
            // 
            // cbu_roles
            // 
            this.cbu_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbu_roles.Enabled = false;
            this.cbu_roles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbu_roles.FormattingEnabled = true;
            this.cbu_roles.Location = new System.Drawing.Point(12, 367);
            this.cbu_roles.Name = "cbu_roles";
            this.cbu_roles.Size = new System.Drawing.Size(224, 23);
            this.cbu_roles.TabIndex = 20;
            this.cbu_roles.SelectedIndexChanged += new System.EventHandler(this.cbu_roles_SelectedIndexChanged);
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(12, 347);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(34, 15);
            this.lblRoles.TabIndex = 21;
            this.lblRoles.Text = "Roles";
            // 
            // gbUsersDetails
            // 
            this.gbUsersDetails.Controls.Add(this.grvUsers);
            this.gbUsersDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUsersDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsersDetails.Location = new System.Drawing.Point(0, 93);
            this.gbUsersDetails.Name = "gbUsersDetails";
            this.gbUsersDetails.Size = new System.Drawing.Size(677, 409);
            this.gbUsersDetails.TabIndex = 3;
            this.gbUsersDetails.TabStop = false;
            this.gbUsersDetails.Text = "Details";
            // 
            // grvUsers
            // 
            this.grvUsers.AllowUserToAddRows = false;
            this.grvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvUsers.BackgroundColor = System.Drawing.Color.White;
            this.grvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.passwordGV,
            this.userIDGV,
            this.nameGV,
            this.usernameGV,
            this.phoneGV,
            this.addressGV,
            this.RoleIDGV,
            this.RolesGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvUsers.EnableHeadersVisualStyles = false;
            this.grvUsers.Location = new System.Drawing.Point(3, 25);
            this.grvUsers.Name = "grvUsers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvUsers.RowHeadersVisible = false;
            this.grvUsers.Size = new System.Drawing.Size(671, 381);
            this.grvUsers.TabIndex = 4;
            this.grvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvUsers_CellClick);
            // 
            // serialNoGV
            // 
            this.serialNoGV.HeaderText = "Serial No";
            this.serialNoGV.Name = "serialNoGV";
            // 
            // passwordGV
            // 
            this.passwordGV.HeaderText = "password";
            this.passwordGV.Name = "passwordGV";
            this.passwordGV.Visible = false;
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "userIDGV";
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "name";
            this.nameGV.Name = "nameGV";
            // 
            // usernameGV
            // 
            this.usernameGV.HeaderText = "username";
            this.usernameGV.Name = "usernameGV";
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "phone";
            this.phoneGV.Name = "phoneGV";
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "address";
            this.addressGV.Name = "addressGV";
            // 
            // RoleIDGV
            // 
            this.RoleIDGV.HeaderText = "RoleIDGV";
            this.RoleIDGV.Name = "RoleIDGV";
            this.RoleIDGV.Visible = false;
            // 
            // RolesGV
            // 
            this.RolesGV.HeaderText = "Roles";
            this.RolesGV.Name = "RolesGV";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 502);
            this.Name = "frmUsers";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbUsersDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtu_phone;
        private System.Windows.Forms.Label lblu_phone;
        private System.Windows.Forms.TextBox txtu_password;
        private System.Windows.Forms.Label lblu_password;
        private System.Windows.Forms.TextBox txtu_uname;
        private System.Windows.Forms.Label lblu_uname;
        private System.Windows.Forms.TextBox txtu_name;
        private System.Windows.Forms.Label lblu_name;
        private System.Windows.Forms.TextBox txtu_address;
        private System.Windows.Forms.Label lblu_address;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.ComboBox cbu_roles;
        private System.Windows.Forms.GroupBox gbUsersDetails;
        private System.Windows.Forms.DataGridView grvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolesGV;

    }
}