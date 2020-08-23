namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmOrderModification
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.listBoxOrderIDs = new System.Windows.Forms.ListBox();
            this.gbOrderDetails = new System.Windows.Forms.GroupBox();
            this.grvOrdersDetails = new System.Windows.Forms.DataGridView();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOrderAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1FooterOrders = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2FooterOrders = new System.Windows.Forms.TableLayoutPanel();
            this.numUpQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbFoodMenu = new System.Windows.Forms.ComboBox();
            this.lblFoodMenu = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.pbItemDiss = new System.Windows.Forms.PictureBox();
            this.lblTotalAmountText = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrdersDetails)).BeginInit();
            this.panel1FooterOrders.SuspendLayout();
            this.tableLayoutPanel2FooterOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemDiss)).BeginInit();
            this.SuspendLayout();
            // 
            // rightHeaderpanel2
            // 
            this.rightHeaderpanel2.Size = new System.Drawing.Size(662, 48);
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.btnAddToCart);
            this.leftpanel.Controls.Add(this.pbItemDiss);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Controls.Add(this.listBoxOrderIDs);
            this.leftpanel.Controls.Add(this.dtpOrderDate);
            this.leftpanel.Controls.Add(this.txtPrice);
            this.leftpanel.Controls.Add(this.cmbFoodMenu);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.lblQuantity);
            this.leftpanel.Controls.Add(this.lblPrice);
            this.leftpanel.Controls.Add(this.lblFoodMenu);
            this.leftpanel.Controls.Add(this.cmbOrderID);
            this.leftpanel.Controls.Add(this.numUpQuantity);
            this.leftpanel.Size = new System.Drawing.Size(250, 493);
            this.leftpanel.Controls.SetChildIndex(this.numUpQuantity, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbOrderID, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblFoodMenu, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblPrice, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblQuantity, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbFoodMenu, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtPrice, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.dtpOrderDate, 0);
            this.leftpanel.Controls.SetChildIndex(this.listBoxOrderIDs, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label1, 0);
            this.leftpanel.Controls.SetChildIndex(this.pbItemDiss, 0);
            this.leftpanel.Controls.SetChildIndex(this.btnAddToCart, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbOrderDetails);
            this.rightpanel.Size = new System.Drawing.Size(662, 493);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbOrderDetails, 0);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(662, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Size = new System.Drawing.Size(662, 45);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(5, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Date";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "dd-MMM-YYYY";
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(5, 123);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(241, 23);
            this.dtpOrderDate.TabIndex = 3;
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(5, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order ID";
            // 
            // cmbOrderID
            // 
            this.cmbOrderID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrderID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrderID.Enabled = false;
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Location = new System.Drawing.Point(5, 167);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(241, 23);
            this.cmbOrderID.TabIndex = 5;
            this.cmbOrderID.SelectedIndexChanged += new System.EventHandler(this.cmbOrderID_SelectedIndexChanged);
            // 
            // listBoxOrderIDs
            // 
            this.listBoxOrderIDs.Enabled = false;
            this.listBoxOrderIDs.FormattingEnabled = true;
            this.listBoxOrderIDs.ItemHeight = 15;
            this.listBoxOrderIDs.Location = new System.Drawing.Point(5, 328);
            this.listBoxOrderIDs.Name = "listBoxOrderIDs";
            this.listBoxOrderIDs.Size = new System.Drawing.Size(120, 94);
            this.listBoxOrderIDs.TabIndex = 6;
            this.listBoxOrderIDs.Visible = false;
            // 
            // gbOrderDetails
            // 
            this.gbOrderDetails.Controls.Add(this.grvOrdersDetails);
            this.gbOrderDetails.Controls.Add(this.panel1FooterOrders);
            this.gbOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderDetails.Location = new System.Drawing.Point(0, 93);
            this.gbOrderDetails.Name = "gbOrderDetails";
            this.gbOrderDetails.Size = new System.Drawing.Size(662, 400);
            this.gbOrderDetails.TabIndex = 5;
            this.gbOrderDetails.TabStop = false;
            this.gbOrderDetails.Text = "Details";
            // 
            // grvOrdersDetails
            // 
            this.grvOrdersDetails.AllowUserToAddRows = false;
            this.grvOrdersDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvOrdersDetails.BackgroundColor = System.Drawing.Color.White;
            this.grvOrdersDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrdersDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvOrdersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrdersDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.OrderIDGV,
            this.ItemIDGV,
            this.ItemGV,
            this.QuantityGV,
            this.PerPriceGV,
            this.TotalPriceGV,
            this.TotalOrderAmountGV,
            this.Remove});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvOrdersDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvOrdersDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvOrdersDetails.EnableHeadersVisualStyles = false;
            this.grvOrdersDetails.Location = new System.Drawing.Point(3, 25);
            this.grvOrdersDetails.Name = "grvOrdersDetails";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrdersDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grvOrdersDetails.RowHeadersVisible = false;
            this.grvOrdersDetails.Size = new System.Drawing.Size(656, 298);
            this.grvOrdersDetails.TabIndex = 4;
            // 
            // serialNoGV
            // 
            this.serialNoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.serialNoGV.HeaderText = "#";
            this.serialNoGV.Name = "serialNoGV";
            this.serialNoGV.ReadOnly = true;
            this.serialNoGV.Width = 45;
            // 
            // OrderIDGV
            // 
            this.OrderIDGV.HeaderText = "OrderID";
            this.OrderIDGV.Name = "OrderIDGV";
            this.OrderIDGV.ReadOnly = true;
            this.OrderIDGV.Visible = false;
            // 
            // ItemIDGV
            // 
            this.ItemIDGV.HeaderText = "ItemIDGV";
            this.ItemIDGV.Name = "ItemIDGV";
            this.ItemIDGV.ReadOnly = true;
            this.ItemIDGV.Visible = false;
            // 
            // ItemGV
            // 
            this.ItemGV.HeaderText = "ITEM";
            this.ItemGV.Name = "ItemGV";
            this.ItemGV.ReadOnly = true;
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "QUANTITY";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // PerPriceGV
            // 
            this.PerPriceGV.HeaderText = "Per Unit Price";
            this.PerPriceGV.Name = "PerPriceGV";
            this.PerPriceGV.ReadOnly = true;
            // 
            // TotalPriceGV
            // 
            this.TotalPriceGV.HeaderText = "Total PRICE";
            this.TotalPriceGV.Name = "TotalPriceGV";
            this.TotalPriceGV.ReadOnly = true;
            // 
            // TotalOrderAmountGV
            // 
            this.TotalOrderAmountGV.HeaderText = "TotalOrderAmount";
            this.TotalOrderAmountGV.Name = "TotalOrderAmountGV";
            this.TotalOrderAmountGV.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "REMOVE ROW";
            this.Remove.Name = "Remove";
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Remove.Text = "X";
            this.Remove.ToolTipText = "Remove";
            this.Remove.UseColumnTextForLinkValue = true;
            // 
            // panel1FooterOrders
            // 
            this.panel1FooterOrders.Controls.Add(this.tableLayoutPanel2FooterOrders);
            this.panel1FooterOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1FooterOrders.Location = new System.Drawing.Point(3, 323);
            this.panel1FooterOrders.Name = "panel1FooterOrders";
            this.panel1FooterOrders.Size = new System.Drawing.Size(656, 74);
            this.panel1FooterOrders.TabIndex = 5;
            // 
            // tableLayoutPanel2FooterOrders
            // 
            this.tableLayoutPanel2FooterOrders.ColumnCount = 2;
            this.tableLayoutPanel2FooterOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.Controls.Add(this.lblTotalAmountValue, 0, 0);
            this.tableLayoutPanel2FooterOrders.Controls.Add(this.lblTotalAmountText, 0, 0);
            this.tableLayoutPanel2FooterOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2FooterOrders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2FooterOrders.Name = "tableLayoutPanel2FooterOrders";
            this.tableLayoutPanel2FooterOrders.RowCount = 1;
            this.tableLayoutPanel2FooterOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.Size = new System.Drawing.Size(656, 74);
            this.tableLayoutPanel2FooterOrders.TabIndex = 0;
            // 
            // numUpQuantity
            // 
            this.numUpQuantity.Enabled = false;
            this.numUpQuantity.Location = new System.Drawing.Point(5, 255);
            this.numUpQuantity.Name = "numUpQuantity";
            this.numUpQuantity.Size = new System.Drawing.Size(241, 23);
            this.numUpQuantity.TabIndex = 16;
            this.numUpQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Enabled = false;
            this.lblQuantity.Location = new System.Drawing.Point(5, 237);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 15);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbFoodMenu
            // 
            this.cmbFoodMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFoodMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFoodMenu.Enabled = false;
            this.cmbFoodMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFoodMenu.FormattingEnabled = true;
            this.cmbFoodMenu.Location = new System.Drawing.Point(5, 211);
            this.cmbFoodMenu.Name = "cmbFoodMenu";
            this.cmbFoodMenu.Size = new System.Drawing.Size(241, 23);
            this.cmbFoodMenu.TabIndex = 14;
            this.cmbFoodMenu.SelectedIndexChanged += new System.EventHandler(this.cmbFoodMenu_SelectedIndexChanged);
            // 
            // lblFoodMenu
            // 
            this.lblFoodMenu.AutoSize = true;
            this.lblFoodMenu.Enabled = false;
            this.lblFoodMenu.Location = new System.Drawing.Point(5, 193);
            this.lblFoodMenu.Name = "lblFoodMenu";
            this.lblFoodMenu.Size = new System.Drawing.Size(62, 15);
            this.lblFoodMenu.TabIndex = 13;
            this.lblFoodMenu.Text = "Select Item";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Enabled = false;
            this.lblPrice.Location = new System.Drawing.Point(5, 281);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 15);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(5, 299);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(241, 23);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.SlateGray;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(8, 328);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(236, 32);
            this.btnAddToCart.TabIndex = 18;
            this.btnAddToCart.Text = "ADD TO CART";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // pbItemDiss
            // 
            this.pbItemDiss.Enabled = false;
            this.pbItemDiss.Location = new System.Drawing.Point(8, 364);
            this.pbItemDiss.Name = "pbItemDiss";
            this.pbItemDiss.Size = new System.Drawing.Size(236, 84);
            this.pbItemDiss.TabIndex = 17;
            this.pbItemDiss.TabStop = false;
            // 
            // lblTotalAmountText
            // 
            this.lblTotalAmountText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmountText.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountText.Location = new System.Drawing.Point(3, 0);
            this.lblTotalAmountText.Name = "lblTotalAmountText";
            this.lblTotalAmountText.Size = new System.Drawing.Size(322, 74);
            this.lblTotalAmountText.TabIndex = 1;
            this.lblTotalAmountText.Text = "TOTAL AMOUNT";
            this.lblTotalAmountText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(331, 0);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(322, 74);
            this.lblTotalAmountValue.TabIndex = 2;
            this.lblTotalAmountValue.Text = "0.00";
            this.lblTotalAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmOrderModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Name = "frmOrderModification";
            this.Text = "frmOrderModification";
            this.Load += new System.EventHandler(this.frmOrderModification_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrdersDetails)).EndInit();
            this.panel1FooterOrders.ResumeLayout(false);
            this.tableLayoutPanel2FooterOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemDiss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrderID;
        private System.Windows.Forms.ListBox listBoxOrderIDs;
        private System.Windows.Forms.GroupBox gbOrderDetails;
        private System.Windows.Forms.DataGridView grvOrdersDetails;
        private System.Windows.Forms.Panel panel1FooterOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2FooterOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrderAmountGV;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
        private System.Windows.Forms.Label lblFoodMenu;
        private System.Windows.Forms.ComboBox cmbFoodMenu;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numUpQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.PictureBox pbItemDiss;
        private System.Windows.Forms.Label lblTotalAmountText;
        private System.Windows.Forms.Label lblTotalAmountValue;
    }
}