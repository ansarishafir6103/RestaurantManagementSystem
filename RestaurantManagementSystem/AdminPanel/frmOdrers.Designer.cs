namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmOdrers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbFoodMenu = new System.Windows.Forms.ComboBox();
            this.lblFoodMenu = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numUpQuantity = new System.Windows.Forms.NumericUpDown();
            this.pbItemDiss = new System.Windows.Forms.PictureBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.cmbFloors = new System.Windows.Forms.ComboBox();
            this.lblFloors = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.gbOrderDetails = new System.Windows.Forms.GroupBox();
            this.grvOrders = new System.Windows.Forms.DataGridView();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1FooterOrders = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2FooterOrders = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmountText = new System.Windows.Forms.Label();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemDiss)).BeginInit();
            this.gbOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).BeginInit();
            this.panel1FooterOrders.SuspendLayout();
            this.tableLayoutPanel2FooterOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightHeaderpanel2
            // 
            this.rightHeaderpanel2.Size = new System.Drawing.Size(640, 48);
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(98, 23);
            // 
            // leftHeaderpanel2
            // 
            this.leftHeaderpanel2.Size = new System.Drawing.Size(252, 48);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.listBoxItem);
            this.leftpanel.Controls.Add(this.lblPhone);
            this.leftpanel.Controls.Add(this.txtPhone);
            this.leftpanel.Controls.Add(this.cmbTables);
            this.leftpanel.Controls.Add(this.lblTables);
            this.leftpanel.Controls.Add(this.cmbFloors);
            this.leftpanel.Controls.Add(this.lblFloors);
            this.leftpanel.Controls.Add(this.cmbOrderType);
            this.leftpanel.Controls.Add(this.lblOrderType);
            this.leftpanel.Controls.Add(this.btnAddToCart);
            this.leftpanel.Controls.Add(this.pbItemDiss);
            this.leftpanel.Controls.Add(this.numUpQuantity);
            this.leftpanel.Controls.Add(this.lblQuantity);
            this.leftpanel.Controls.Add(this.cmbFoodMenu);
            this.leftpanel.Controls.Add(this.lblFoodMenu);
            this.leftpanel.Controls.Add(this.lblPrice);
            this.leftpanel.Controls.Add(this.txtPrice);
            this.leftpanel.Size = new System.Drawing.Size(252, 640);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtPrice, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblPrice, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblFoodMenu, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbFoodMenu, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblQuantity, 0);
            this.leftpanel.Controls.SetChildIndex(this.numUpQuantity, 0);
            this.leftpanel.Controls.SetChildIndex(this.pbItemDiss, 0);
            this.leftpanel.Controls.SetChildIndex(this.btnAddToCart, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblOrderType, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbOrderType, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblFloors, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbFloors, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblTables, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbTables, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtPhone, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblPhone, 0);
            this.leftpanel.Controls.SetChildIndex(this.listBoxItem, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbOrderDetails);
            this.rightpanel.Location = new System.Drawing.Point(252, 0);
            this.rightpanel.Size = new System.Drawing.Size(640, 640);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbOrderDetails, 0);
            // 
            // leftHeaderpanel1
            // 
            this.leftHeaderpanel1.Size = new System.Drawing.Size(252, 45);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(640, 45);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Size = new System.Drawing.Size(252, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Size = new System.Drawing.Size(640, 45);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(26, 164);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(201, 23);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 146);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // cmbFoodMenu
            // 
            this.cmbFoodMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFoodMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFoodMenu.Enabled = false;
            this.cmbFoodMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFoodMenu.FormattingEnabled = true;
            this.cmbFoodMenu.Location = new System.Drawing.Point(26, 122);
            this.cmbFoodMenu.Name = "cmbFoodMenu";
            this.cmbFoodMenu.Size = new System.Drawing.Size(201, 23);
            this.cmbFoodMenu.TabIndex = 7;
            this.cmbFoodMenu.SelectedIndexChanged += new System.EventHandler(this.cmbFoodMenu_SelectedIndexChanged);
            // 
            // lblFoodMenu
            // 
            this.lblFoodMenu.AutoSize = true;
            this.lblFoodMenu.Location = new System.Drawing.Point(23, 103);
            this.lblFoodMenu.Name = "lblFoodMenu";
            this.lblFoodMenu.Size = new System.Drawing.Size(62, 15);
            this.lblFoodMenu.TabIndex = 6;
            this.lblFoodMenu.Text = "Select Item";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(23, 187);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 15);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // numUpQuantity
            // 
            this.numUpQuantity.Enabled = false;
            this.numUpQuantity.Location = new System.Drawing.Point(26, 205);
            this.numUpQuantity.Name = "numUpQuantity";
            this.numUpQuantity.Size = new System.Drawing.Size(201, 23);
            this.numUpQuantity.TabIndex = 10;
            this.numUpQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpQuantity.ValueChanged += new System.EventHandler(this.numUpQuantity_ValueChanged);
            // 
            // pbItemDiss
            // 
            this.pbItemDiss.Enabled = false;
            this.pbItemDiss.Location = new System.Drawing.Point(26, 440);
            this.pbItemDiss.Name = "pbItemDiss";
            this.pbItemDiss.Size = new System.Drawing.Size(201, 84);
            this.pbItemDiss.TabIndex = 11;
            this.pbItemDiss.TabStop = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.SlateGray;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(26, 404);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(201, 32);
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Text = "ADD TO CART";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.Enabled = false;
            this.cmbOrderType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Dine-In",
            "Take-Away",
            "Home-Delivery"});
            this.cmbOrderType.Location = new System.Drawing.Point(26, 247);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(201, 23);
            this.cmbOrderType.TabIndex = 14;
            this.cmbOrderType.SelectedIndexChanged += new System.EventHandler(this.cmbOrderType_SelectedIndexChanged);
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(23, 228);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(63, 15);
            this.lblOrderType.TabIndex = 13;
            this.lblOrderType.Text = "Order Type";
            // 
            // cmbFloors
            // 
            this.cmbFloors.AllowDrop = true;
            this.cmbFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloors.Enabled = false;
            this.cmbFloors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFloors.FormattingEnabled = true;
            this.cmbFloors.Location = new System.Drawing.Point(26, 290);
            this.cmbFloors.Name = "cmbFloors";
            this.cmbFloors.Size = new System.Drawing.Size(201, 23);
            this.cmbFloors.TabIndex = 16;
            this.cmbFloors.SelectedIndexChanged += new System.EventHandler(this.cmbFloors_SelectedIndexChanged);
            // 
            // lblFloors
            // 
            this.lblFloors.AutoSize = true;
            this.lblFloors.Location = new System.Drawing.Point(23, 271);
            this.lblFloors.Name = "lblFloors";
            this.lblFloors.Size = new System.Drawing.Size(38, 15);
            this.lblFloors.TabIndex = 15;
            this.lblFloors.Text = "Floors";
            // 
            // cmbTables
            // 
            this.cmbTables.AllowDrop = true;
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.Enabled = false;
            this.cmbTables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(26, 334);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(201, 23);
            this.cmbTables.TabIndex = 18;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(23, 315);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(37, 15);
            this.lblTables.TabIndex = 17;
            this.lblTables.Text = "Tables";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(23, 358);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(113, 15);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Enter Phone Number";
            this.lblPhone.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.AllowDrop = true;
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(26, 376);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 23);
            this.txtPhone.TabIndex = 19;
            this.txtPhone.Visible = false;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // gbOrderDetails
            // 
            this.gbOrderDetails.Controls.Add(this.grvOrders);
            this.gbOrderDetails.Controls.Add(this.panel1FooterOrders);
            this.gbOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderDetails.Location = new System.Drawing.Point(0, 93);
            this.gbOrderDetails.Name = "gbOrderDetails";
            this.gbOrderDetails.Size = new System.Drawing.Size(640, 547);
            this.gbOrderDetails.TabIndex = 4;
            this.gbOrderDetails.TabStop = false;
            this.gbOrderDetails.Text = "Details";
            // 
            // grvOrders
            // 
            this.grvOrders.AllowUserToAddRows = false;
            this.grvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvOrders.BackgroundColor = System.Drawing.Color.White;
            this.grvOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.CategoryIDGV,
            this.ItemIDGV,
            this.FloorIDGV,
            this.TableIDGV,
            this.CategoryNameGV,
            this.ItemGV,
            this.QuantityGV,
            this.PriceGV,
            this.OrderTypeGV,
            this.FloorGV,
            this.TableGV,
            this.PhoneGV,
            this.Remove});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvOrders.DefaultCellStyle = dataGridViewCellStyle8;
            this.grvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvOrders.EnableHeadersVisualStyles = false;
            this.grvOrders.Location = new System.Drawing.Point(3, 25);
            this.grvOrders.Name = "grvOrders";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grvOrders.RowHeadersVisible = false;
            this.grvOrders.Size = new System.Drawing.Size(634, 445);
            this.grvOrders.TabIndex = 4;
            this.grvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOrders_CellContentClick);
            // 
            // serialNoGV
            // 
            this.serialNoGV.HeaderText = "Serial No";
            this.serialNoGV.Name = "serialNoGV";
            this.serialNoGV.ReadOnly = true;
            // 
            // CategoryIDGV
            // 
            this.CategoryIDGV.HeaderText = "CategoryIDGV";
            this.CategoryIDGV.Name = "CategoryIDGV";
            this.CategoryIDGV.Visible = false;
            // 
            // ItemIDGV
            // 
            this.ItemIDGV.HeaderText = "ItemIDGV";
            this.ItemIDGV.Name = "ItemIDGV";
            this.ItemIDGV.ReadOnly = true;
            this.ItemIDGV.Visible = false;
            // 
            // FloorIDGV
            // 
            this.FloorIDGV.HeaderText = "FloorIDGV";
            this.FloorIDGV.Name = "FloorIDGV";
            this.FloorIDGV.ReadOnly = true;
            this.FloorIDGV.Visible = false;
            // 
            // TableIDGV
            // 
            this.TableIDGV.HeaderText = "TableIDGV";
            this.TableIDGV.Name = "TableIDGV";
            this.TableIDGV.ReadOnly = true;
            this.TableIDGV.Visible = false;
            // 
            // CategoryNameGV
            // 
            this.CategoryNameGV.HeaderText = "CATEGORY NAME";
            this.CategoryNameGV.Name = "CategoryNameGV";
            this.CategoryNameGV.ReadOnly = true;
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
            // PriceGV
            // 
            this.PriceGV.HeaderText = "PRICE";
            this.PriceGV.Name = "PriceGV";
            this.PriceGV.ReadOnly = true;
            // 
            // OrderTypeGV
            // 
            this.OrderTypeGV.HeaderText = "ORDER TYPE";
            this.OrderTypeGV.Name = "OrderTypeGV";
            this.OrderTypeGV.ReadOnly = true;
            // 
            // FloorGV
            // 
            this.FloorGV.HeaderText = "FLOOR";
            this.FloorGV.Name = "FloorGV";
            this.FloorGV.ReadOnly = true;
            // 
            // TableGV
            // 
            this.TableGV.HeaderText = "TABLE";
            this.TableGV.Name = "TableGV";
            this.TableGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "PHONE";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
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
            this.panel1FooterOrders.Location = new System.Drawing.Point(3, 470);
            this.panel1FooterOrders.Name = "panel1FooterOrders";
            this.panel1FooterOrders.Size = new System.Drawing.Size(634, 74);
            this.panel1FooterOrders.TabIndex = 5;
            // 
            // tableLayoutPanel2FooterOrders
            // 
            this.tableLayoutPanel2FooterOrders.ColumnCount = 2;
            this.tableLayoutPanel2FooterOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.Controls.Add(this.lblTotalAmountValue, 1, 0);
            this.tableLayoutPanel2FooterOrders.Controls.Add(this.lblTotalAmountText, 0, 0);
            this.tableLayoutPanel2FooterOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2FooterOrders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2FooterOrders.Name = "tableLayoutPanel2FooterOrders";
            this.tableLayoutPanel2FooterOrders.RowCount = 1;
            this.tableLayoutPanel2FooterOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.Size = new System.Drawing.Size(634, 74);
            this.tableLayoutPanel2FooterOrders.TabIndex = 0;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(320, 0);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(311, 74);
            this.lblTotalAmountValue.TabIndex = 1;
            this.lblTotalAmountValue.Text = "0.00";
            this.lblTotalAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmountText
            // 
            this.lblTotalAmountText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmountText.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountText.Location = new System.Drawing.Point(3, 0);
            this.lblTotalAmountText.Name = "lblTotalAmountText";
            this.lblTotalAmountText.Size = new System.Drawing.Size(311, 74);
            this.lblTotalAmountText.TabIndex = 0;
            this.lblTotalAmountText.Text = "TOTAL AMOUNT";
            this.lblTotalAmountText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 15;
            this.listBoxItem.Location = new System.Drawing.Point(26, 534);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(201, 79);
            this.listBoxItem.TabIndex = 23;
            this.listBoxItem.Visible = false;
            // 
            // frmOdrers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 640);
            this.Name = "frmOdrers";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.frmOdrers_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemDiss)).EndInit();
            this.gbOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).EndInit();
            this.panel1FooterOrders.ResumeLayout(false);
            this.tableLayoutPanel2FooterOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbFoodMenu;
        private System.Windows.Forms.Label lblFoodMenu;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numUpQuantity;
        private System.Windows.Forms.PictureBox pbItemDiss;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.ComboBox cmbFloors;
        private System.Windows.Forms.Label lblFloors;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox gbOrderDetails;
        private System.Windows.Forms.DataGridView grvOrders;
        private System.Windows.Forms.Panel panel1FooterOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2FooterOrders;
        private System.Windows.Forms.Label lblTotalAmountText;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
        private System.Windows.Forms.ListBox listBoxItem;
    }
}