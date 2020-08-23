namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmOrderComplition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTax = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.lblFloors = new System.Windows.Forms.Label();
            this.cmbFloors = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblOrdersID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.grvOrderComplition = new System.Windows.Forms.DataGridView();
            this.SrNoGVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalBillAmountText = new System.Windows.Forms.Label();
            this.lblTotalBillAmountValue = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountReturn = new System.Windows.Forms.Label();
            this.txtAmountReturn = new System.Windows.Forms.TextBox();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1RMS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrderComplition)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.flowLayoutPanel1);
            this.leftpanel.Controls.Add(this.panel1);
            this.leftpanel.Size = new System.Drawing.Size(250, 650);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.reportViewer1RMS);
            this.rightpanel.Size = new System.Drawing.Size(668, 650);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.reportViewer1RMS, 0);
            // 
            // leftHeaderpanel1
            // 
            this.leftHeaderpanel1.Controls.Add(this.btnHome);
            this.leftHeaderpanel1.Controls.SetChildIndex(this.lblWelcome, 0);
            this.leftHeaderpanel1.Controls.SetChildIndex(this.btnHome, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTax);
            this.flowLayoutPanel1.Controls.Add(this.cmbTax);
            this.flowLayoutPanel1.Controls.Add(this.lblOrderType);
            this.flowLayoutPanel1.Controls.Add(this.cmbOrderType);
            this.flowLayoutPanel1.Controls.Add(this.lblFloors);
            this.flowLayoutPanel1.Controls.Add(this.cmbFloors);
            this.flowLayoutPanel1.Controls.Add(this.lblTables);
            this.flowLayoutPanel1.Controls.Add(this.cmbTables);
            this.flowLayoutPanel1.Controls.Add(this.lblPhone);
            this.flowLayoutPanel1.Controls.Add(this.txtPhone);
            this.flowLayoutPanel1.Controls.Add(this.lblOrdersID);
            this.flowLayoutPanel1.Controls.Add(this.txtOrderID);
            this.flowLayoutPanel1.Controls.Add(this.grvOrderComplition);
            this.flowLayoutPanel1.Controls.Add(this.lblTotalBillAmountText);
            this.flowLayoutPanel1.Controls.Add(this.lblTotalBillAmountValue);
            this.flowLayoutPanel1.Controls.Add(this.lblAmountPaid);
            this.flowLayoutPanel1.Controls.Add(this.txtAmountPaid);
            this.flowLayoutPanel1.Controls.Add(this.lblAmountReturn);
            this.flowLayoutPanel1.Controls.Add(this.txtAmountReturn);
            this.flowLayoutPanel1.Controls.Add(this.btnGenerateBill);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 564);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(3, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(22, 15);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax";
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Location = new System.Drawing.Point(3, 18);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(241, 23);
            this.cmbTax.TabIndex = 19;
            this.cmbTax.SelectedIndexChanged += new System.EventHandler(this.cmbTax_SelectedIndexChanged);
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(3, 44);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(63, 15);
            this.lblOrderType.TabIndex = 18;
            this.lblOrderType.Text = "Order Type";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Dine-In",
            "Take-Away",
            "Home-Delivery"});
            this.cmbOrderType.Location = new System.Drawing.Point(3, 62);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(241, 23);
            this.cmbOrderType.TabIndex = 13;
            this.cmbOrderType.SelectedIndexChanged += new System.EventHandler(this.cmbOrderType_SelectedIndexChanged);
            // 
            // lblFloors
            // 
            this.lblFloors.AutoSize = true;
            this.lblFloors.Location = new System.Drawing.Point(3, 88);
            this.lblFloors.Name = "lblFloors";
            this.lblFloors.Size = new System.Drawing.Size(38, 15);
            this.lblFloors.TabIndex = 12;
            this.lblFloors.Text = "Floors";
            // 
            // cmbFloors
            // 
            this.cmbFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFloors.FormattingEnabled = true;
            this.cmbFloors.Location = new System.Drawing.Point(3, 106);
            this.cmbFloors.Name = "cmbFloors";
            this.cmbFloors.Size = new System.Drawing.Size(241, 23);
            this.cmbFloors.TabIndex = 3;
            this.cmbFloors.SelectedIndexChanged += new System.EventHandler(this.cmbFloors_SelectedIndexChanged);
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(3, 132);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(37, 15);
            this.lblTables.TabIndex = 4;
            this.lblTables.Text = "Tables";
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(3, 150);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(241, 23);
            this.cmbTables.TabIndex = 5;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            this.cmbTables.Enter += new System.EventHandler(this.cmbTables_Enter);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 176);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(39, 15);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Phone";
            this.lblPhone.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(3, 194);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(241, 23);
            this.txtPhone.TabIndex = 21;
            this.txtPhone.Visible = false;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // lblOrdersID
            // 
            this.lblOrdersID.AutoSize = true;
            this.lblOrdersID.Location = new System.Drawing.Point(3, 220);
            this.lblOrdersID.Name = "lblOrdersID";
            this.lblOrdersID.Size = new System.Drawing.Size(56, 15);
            this.lblOrdersID.TabIndex = 6;
            this.lblOrdersID.Text = "Orders ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(3, 238);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(241, 23);
            this.txtOrderID.TabIndex = 7;
            // 
            // grvOrderComplition
            // 
            this.grvOrderComplition.AllowUserToAddRows = false;
            this.grvOrderComplition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvOrderComplition.BackgroundColor = System.Drawing.Color.SlateGray;
            this.grvOrderComplition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrderComplition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvOrderComplition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrderComplition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNoGVL,
            this.orderIDGV,
            this.ItemGV,
            this.QuantityGV,
            this.AmountGV,
            this.totalAmountGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvOrderComplition.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvOrderComplition.EnableHeadersVisualStyles = false;
            this.grvOrderComplition.Location = new System.Drawing.Point(3, 267);
            this.grvOrderComplition.Name = "grvOrderComplition";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrderComplition.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvOrderComplition.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.grvOrderComplition.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grvOrderComplition.Size = new System.Drawing.Size(241, 123);
            this.grvOrderComplition.TabIndex = 8;
            // 
            // SrNoGVL
            // 
            this.SrNoGVL.HeaderText = "#";
            this.SrNoGVL.Name = "SrNoGVL";
            this.SrNoGVL.ReadOnly = true;
            // 
            // orderIDGV
            // 
            this.orderIDGV.HeaderText = "ORDER ID";
            this.orderIDGV.Name = "orderIDGV";
            this.orderIDGV.Visible = false;
            // 
            // ItemGV
            // 
            this.ItemGV.HeaderText = "Item";
            this.ItemGV.Name = "ItemGV";
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            // 
            // AmountGV
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.AmountGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.AmountGV.HeaderText = "Amount";
            this.AmountGV.Name = "AmountGV";
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "totalAmount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            this.totalAmountGV.Visible = false;
            // 
            // lblTotalBillAmountText
            // 
            this.lblTotalBillAmountText.AutoSize = true;
            this.lblTotalBillAmountText.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBillAmountText.Location = new System.Drawing.Point(3, 393);
            this.lblTotalBillAmountText.Name = "lblTotalBillAmountText";
            this.lblTotalBillAmountText.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTotalBillAmountText.Size = new System.Drawing.Size(135, 25);
            this.lblTotalBillAmountText.TabIndex = 9;
            this.lblTotalBillAmountText.Text = "Total Bill :";
            // 
            // lblTotalBillAmountValue
            // 
            this.lblTotalBillAmountValue.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.lblTotalBillAmountValue, true);
            this.lblTotalBillAmountValue.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBillAmountValue.Location = new System.Drawing.Point(144, 393);
            this.lblTotalBillAmountValue.Name = "lblTotalBillAmountValue";
            this.lblTotalBillAmountValue.Size = new System.Drawing.Size(36, 25);
            this.lblTotalBillAmountValue.TabIndex = 10;
            this.lblTotalBillAmountValue.Text = "0.0";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(3, 418);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(72, 15);
            this.lblAmountPaid.TabIndex = 14;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(3, 436);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(241, 23);
            this.txtAmountPaid.TabIndex = 15;
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            // 
            // lblAmountReturn
            // 
            this.lblAmountReturn.AutoSize = true;
            this.lblAmountReturn.Location = new System.Drawing.Point(3, 462);
            this.lblAmountReturn.Name = "lblAmountReturn";
            this.lblAmountReturn.Size = new System.Drawing.Size(84, 15);
            this.lblAmountReturn.TabIndex = 16;
            this.lblAmountReturn.Text = "Amount Return";
            // 
            // txtAmountReturn
            // 
            this.txtAmountReturn.Location = new System.Drawing.Point(3, 480);
            this.txtAmountReturn.Name = "txtAmountReturn";
            this.txtAmountReturn.Size = new System.Drawing.Size(241, 23);
            this.txtAmountReturn.TabIndex = 17;
            this.txtAmountReturn.TextChanged += new System.EventHandler(this.txtAmountReturn_TextChanged);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.SlateGray;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.Location = new System.Drawing.Point(3, 509);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(241, 36);
            this.btnGenerateBill.TabIndex = 11;
            this.btnGenerateBill.Text = "GENERATE BILL";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(29, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(71, 38);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "&HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 41);
            this.panel1.TabIndex = 2;
            // 
            // reportViewer1RMS
            // 
            this.reportViewer1RMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1RMS.Location = new System.Drawing.Point(0, 45);
            this.reportViewer1RMS.Name = "reportViewer1RMS";
            this.reportViewer1RMS.Size = new System.Drawing.Size(668, 605);
            this.reportViewer1RMS.TabIndex = 2;
            // 
            // frmOrderComplition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 650);
            this.Name = "frmOrderComplition";
            this.Text = "Order Complition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderComplition_FormClosing);
            this.Load += new System.EventHandler(this.frmOrderComplition_Load);
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrderComplition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblOrdersID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DataGridView grvOrderComplition;
        private System.Windows.Forms.Label lblTotalBillAmountText;
        private System.Windows.Forms.Label lblTotalBillAmountValue;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.ComboBox cmbFloors;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNoGVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label lblFloors;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblAmountReturn;
        private System.Windows.Forms.TextBox txtAmountReturn;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1RMS;

    }
}