namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtcustName = new System.Windows.Forms.TextBox();
            this.lblcustName = new System.Windows.Forms.Label();
            this.txtcustPhone = new System.Windows.Forms.TextBox();
            this.lblcustPhone = new System.Windows.Forms.Label();
            this.txtcustAddress = new System.Windows.Forms.TextBox();
            this.lblcustAddress = new System.Windows.Forms.Label();
            this.gbCustomersDetails = new System.Windows.Forms.GroupBox();
            this.grvCustomers = new System.Windows.Forms.DataGridView();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbCustomersDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // rightHeaderpanel2
            // 
            this.rightHeaderpanel2.Size = new System.Drawing.Size(660, 48);
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(103, 23);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.txtcustAddress);
            this.leftpanel.Controls.Add(this.lblcustAddress);
            this.leftpanel.Controls.Add(this.txtcustPhone);
            this.leftpanel.Controls.Add(this.lblcustPhone);
            this.leftpanel.Controls.Add(this.txtcustName);
            this.leftpanel.Controls.Add(this.lblcustName);
            this.leftpanel.Size = new System.Drawing.Size(250, 504);
            this.leftpanel.Controls.SetChildIndex(this.lblcustName, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtcustName, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblcustPhone, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtcustPhone, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblcustAddress, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtcustAddress, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbCustomersDetails);
            this.rightpanel.Size = new System.Drawing.Size(660, 504);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbCustomersDetails, 0);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(660, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Size = new System.Drawing.Size(660, 45);
            // 
            // txtcustName
            // 
            this.txtcustName.Enabled = false;
            this.txtcustName.Location = new System.Drawing.Point(14, 121);
            this.txtcustName.MaxLength = 50;
            this.txtcustName.Name = "txtcustName";
            this.txtcustName.Size = new System.Drawing.Size(224, 23);
            this.txtcustName.TabIndex = 8;
            this.txtcustName.TextChanged += new System.EventHandler(this.txtcustName_TextChanged);
            // 
            // lblcustName
            // 
            this.lblcustName.AutoSize = true;
            this.lblcustName.Location = new System.Drawing.Point(14, 103);
            this.lblcustName.Name = "lblcustName";
            this.lblcustName.Size = new System.Drawing.Size(38, 15);
            this.lblcustName.TabIndex = 7;
            this.lblcustName.Text = "Name";
            // 
            // txtcustPhone
            // 
            this.txtcustPhone.Enabled = false;
            this.txtcustPhone.Location = new System.Drawing.Point(12, 163);
            this.txtcustPhone.MaxLength = 15;
            this.txtcustPhone.Name = "txtcustPhone";
            this.txtcustPhone.Size = new System.Drawing.Size(224, 23);
            this.txtcustPhone.TabIndex = 10;
            this.txtcustPhone.TextChanged += new System.EventHandler(this.txtcustPhone_TextChanged);
            // 
            // lblcustPhone
            // 
            this.lblcustPhone.AutoSize = true;
            this.lblcustPhone.Location = new System.Drawing.Point(12, 145);
            this.lblcustPhone.Name = "lblcustPhone";
            this.lblcustPhone.Size = new System.Drawing.Size(39, 15);
            this.lblcustPhone.TabIndex = 9;
            this.lblcustPhone.Text = "Phone";
            // 
            // txtcustAddress
            // 
            this.txtcustAddress.Enabled = false;
            this.txtcustAddress.Location = new System.Drawing.Point(12, 205);
            this.txtcustAddress.MaxLength = 100;
            this.txtcustAddress.Multiline = true;
            this.txtcustAddress.Name = "txtcustAddress";
            this.txtcustAddress.Size = new System.Drawing.Size(224, 96);
            this.txtcustAddress.TabIndex = 12;
            this.txtcustAddress.TextChanged += new System.EventHandler(this.txtcustAddress_TextChanged);
            // 
            // lblcustAddress
            // 
            this.lblcustAddress.AutoSize = true;
            this.lblcustAddress.Location = new System.Drawing.Point(12, 187);
            this.lblcustAddress.Name = "lblcustAddress";
            this.lblcustAddress.Size = new System.Drawing.Size(49, 15);
            this.lblcustAddress.TabIndex = 11;
            this.lblcustAddress.Text = "Address";
            // 
            // gbCustomersDetails
            // 
            this.gbCustomersDetails.Controls.Add(this.grvCustomers);
            this.gbCustomersDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCustomersDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomersDetails.Location = new System.Drawing.Point(0, 93);
            this.gbCustomersDetails.Name = "gbCustomersDetails";
            this.gbCustomersDetails.Size = new System.Drawing.Size(660, 411);
            this.gbCustomersDetails.TabIndex = 4;
            this.gbCustomersDetails.TabStop = false;
            this.gbCustomersDetails.Text = "Details";
            // 
            // grvCustomers
            // 
            this.grvCustomers.AllowUserToAddRows = false;
            this.grvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.grvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.customerIDGV,
            this.customerNameGV,
            this.customerPhoneGV,
            this.customerAddressGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCustomers.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvCustomers.EnableHeadersVisualStyles = false;
            this.grvCustomers.Location = new System.Drawing.Point(3, 25);
            this.grvCustomers.Name = "grvCustomers";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grvCustomers.RowHeadersVisible = false;
            this.grvCustomers.Size = new System.Drawing.Size(654, 383);
            this.grvCustomers.TabIndex = 4;
            this.grvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCustomers_CellClick);
            // 
            // serialNoGV
            // 
            this.serialNoGV.HeaderText = "SERIAL NO";
            this.serialNoGV.Name = "serialNoGV";
            // 
            // customerIDGV
            // 
            this.customerIDGV.HeaderText = "customerIDGV";
            this.customerIDGV.Name = "customerIDGV";
            this.customerIDGV.Visible = false;
            // 
            // customerNameGV
            // 
            this.customerNameGV.HeaderText = "NAME";
            this.customerNameGV.Name = "customerNameGV";
            // 
            // customerPhoneGV
            // 
            this.customerPhoneGV.HeaderText = "PHONE";
            this.customerPhoneGV.Name = "customerPhoneGV";
            // 
            // customerAddressGV
            // 
            this.customerAddressGV.HeaderText = "ADDRESS";
            this.customerAddressGV.Name = "customerAddressGV";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 504);
            this.Name = "frmCustomers";
            this.Text = "Customers";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbCustomersDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtcustName;
        private System.Windows.Forms.Label lblcustName;
        private System.Windows.Forms.TextBox txtcustAddress;
        private System.Windows.Forms.Label lblcustAddress;
        private System.Windows.Forms.TextBox txtcustPhone;
        private System.Windows.Forms.Label lblcustPhone;
        private System.Windows.Forms.GroupBox gbCustomersDetails;
        private System.Windows.Forms.DataGridView grvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressGV;
    }
}