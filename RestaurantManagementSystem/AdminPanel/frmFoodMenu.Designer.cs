namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmFoodMenu
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
            this.lblMenuItem = new System.Windows.Forms.Label();
            this.txtMenuItem = new System.Windows.Forms.TextBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbFoodMenuDetails = new System.Windows.Forms.GroupBox();
            this.grvFoodMenu = new System.Windows.Forms.DataGridView();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.btnItemBrowse = new System.Windows.Forms.Button();
            this.openFileDialogFoodMenu = new System.Windows.Forms.OpenFileDialog();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbFoodMenuDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvFoodMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.SuspendLayout();
            // 
            // rightHeaderpanel2
            // 
            this.rightHeaderpanel2.Size = new System.Drawing.Size(642, 48);
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
            this.leftpanel.Controls.Add(this.btnItemBrowse);
            this.leftpanel.Controls.Add(this.pbItem);
            this.leftpanel.Controls.Add(this.cmbStatus);
            this.leftpanel.Controls.Add(this.lblStatus);
            this.leftpanel.Controls.Add(this.txtPrice);
            this.leftpanel.Controls.Add(this.lblPrice);
            this.leftpanel.Controls.Add(this.cmbCategories);
            this.leftpanel.Controls.Add(this.lblCategories);
            this.leftpanel.Controls.Add(this.txtMenuItem);
            this.leftpanel.Controls.Add(this.lblMenuItem);
            this.leftpanel.Size = new System.Drawing.Size(250, 494);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblMenuItem, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtMenuItem, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblCategories, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbCategories, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblPrice, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtPrice, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblStatus, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbStatus, 0);
            this.leftpanel.Controls.SetChildIndex(this.pbItem, 0);
            this.leftpanel.Controls.SetChildIndex(this.btnItemBrowse, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbFoodMenuDetails);
            this.rightpanel.Size = new System.Drawing.Size(642, 494);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbFoodMenuDetails, 0);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(642, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Size = new System.Drawing.Size(642, 45);
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Location = new System.Drawing.Point(9, 110);
            this.lblMenuItem.Name = "lblMenuItem";
            this.lblMenuItem.Size = new System.Drawing.Size(61, 15);
            this.lblMenuItem.TabIndex = 2;
            this.lblMenuItem.Text = "Menu Item";
            // 
            // txtMenuItem
            // 
            this.txtMenuItem.Enabled = false;
            this.txtMenuItem.Location = new System.Drawing.Point(12, 129);
            this.txtMenuItem.MaxLength = 50;
            this.txtMenuItem.Name = "txtMenuItem";
            this.txtMenuItem.Size = new System.Drawing.Size(224, 23);
            this.txtMenuItem.TabIndex = 3;
            this.txtMenuItem.TextChanged += new System.EventHandler(this.txtMenuItem_TextChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(10, 155);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(61, 15);
            this.lblCategories.TabIndex = 4;
            this.lblCategories.Text = "Categories";
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.Enabled = false;
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(13, 174);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(221, 23);
            this.cmbCategories.TabIndex = 5;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(13, 219);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(223, 23);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(10, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 15);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmbStatus.Location = new System.Drawing.Point(13, 263);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(221, 23);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 244);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // gbFoodMenuDetails
            // 
            this.gbFoodMenuDetails.Controls.Add(this.grvFoodMenu);
            this.gbFoodMenuDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFoodMenuDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFoodMenuDetails.Location = new System.Drawing.Point(0, 93);
            this.gbFoodMenuDetails.Name = "gbFoodMenuDetails";
            this.gbFoodMenuDetails.Size = new System.Drawing.Size(642, 401);
            this.gbFoodMenuDetails.TabIndex = 7;
            this.gbFoodMenuDetails.TabStop = false;
            this.gbFoodMenuDetails.Text = "Details";
            // 
            // grvFoodMenu
            // 
            this.grvFoodMenu.AllowUserToAddRows = false;
            this.grvFoodMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvFoodMenu.BackgroundColor = System.Drawing.Color.White;
            this.grvFoodMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvFoodMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvFoodMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFoodMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.MenuIDGV,
            this.MenuItemGV,
            this.PriceGV,
            this.CategoryGV,
            this.StatusGV,
            this.CategoryIDGV,
            this.ImageGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvFoodMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvFoodMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvFoodMenu.EnableHeadersVisualStyles = false;
            this.grvFoodMenu.Location = new System.Drawing.Point(3, 25);
            this.grvFoodMenu.Name = "grvFoodMenu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvFoodMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvFoodMenu.RowHeadersVisible = false;
            this.grvFoodMenu.Size = new System.Drawing.Size(636, 373);
            this.grvFoodMenu.TabIndex = 4;
            this.grvFoodMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvFoodMenu_CellClick);
            // 
            // pbItem
            // 
            this.pbItem.Location = new System.Drawing.Point(15, 338);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(220, 89);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem.TabIndex = 11;
            this.pbItem.TabStop = false;
            // 
            // btnItemBrowse
            // 
            this.btnItemBrowse.BackColor = System.Drawing.Color.SlateGray;
            this.btnItemBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemBrowse.Enabled = false;
            this.btnItemBrowse.Location = new System.Drawing.Point(12, 303);
            this.btnItemBrowse.Name = "btnItemBrowse";
            this.btnItemBrowse.Size = new System.Drawing.Size(224, 32);
            this.btnItemBrowse.TabIndex = 12;
            this.btnItemBrowse.Text = "BROWSE";
            this.btnItemBrowse.UseVisualStyleBackColor = false;
            this.btnItemBrowse.Click += new System.EventHandler(this.btnItemBrowse_Click);
            // 
            // openFileDialogFoodMenu
            // 
            this.openFileDialogFoodMenu.FileName = "openFileDialogFoodMenu";
            // 
            // serialNoGV
            // 
            this.serialNoGV.HeaderText = "SERIAL NO";
            this.serialNoGV.Name = "serialNoGV";
            // 
            // MenuIDGV
            // 
            this.MenuIDGV.HeaderText = "MENUIDGV";
            this.MenuIDGV.Name = "MenuIDGV";
            this.MenuIDGV.Visible = false;
            // 
            // MenuItemGV
            // 
            this.MenuItemGV.HeaderText = "MENU ITEM";
            this.MenuItemGV.Name = "MenuItemGV";
            // 
            // PriceGV
            // 
            this.PriceGV.HeaderText = "PRICE";
            this.PriceGV.Name = "PriceGV";
            // 
            // CategoryGV
            // 
            this.CategoryGV.HeaderText = "CATEGORY";
            this.CategoryGV.Name = "CategoryGV";
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "STATUS";
            this.StatusGV.Name = "StatusGV";
            // 
            // CategoryIDGV
            // 
            this.CategoryIDGV.HeaderText = "CATEGORYIDGV";
            this.CategoryIDGV.Name = "CategoryIDGV";
            this.CategoryIDGV.Visible = false;
            // 
            // ImageGV
            // 
            this.ImageGV.HeaderText = "Image";
            this.ImageGV.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageGV.Name = "ImageGV";
            this.ImageGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmFoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 494);
            this.Name = "frmFoodMenu";
            this.Text = "Food Menu";
            this.Load += new System.EventHandler(this.frmFoodMenu_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbFoodMenuDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvFoodMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TextBox txtMenuItem;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gbFoodMenuDetails;
        private System.Windows.Forms.DataGridView grvFoodMenu;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Button btnItemBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoodMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIDGV;
        private System.Windows.Forms.DataGridViewImageColumn ImageGV;
    }
}