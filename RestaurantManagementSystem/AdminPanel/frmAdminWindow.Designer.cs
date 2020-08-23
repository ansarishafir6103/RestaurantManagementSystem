namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmAdminWindow
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
            this.AdmintableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBillGeneration = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnFloors = new System.Windows.Forms.Button();
            this.btnFoodMenu = new System.Windows.Forms.Button();
            this.btnFoodCategories = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnroles = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnOrderModification = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.AdmintableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(250, 421);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.AdmintableLayoutPanel1);
            this.rightpanel.Size = new System.Drawing.Size(642, 421);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.AdmintableLayoutPanel1, 0);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(642, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.ForeColor = System.Drawing.Color.SlateGray;
            this.lblLoginDetails.Size = new System.Drawing.Size(642, 45);
            // 
            // AdmintableLayoutPanel1
            // 
            this.AdmintableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.AdmintableLayoutPanel1.ColumnCount = 5;
            this.AdmintableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.Controls.Add(this.btnBillGeneration, 3, 1);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnTables, 2, 1);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnOrders, 1, 1);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnFloors, 0, 1);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnFoodMenu, 4, 0);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnFoodCategories, 3, 0);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnCustomers, 2, 0);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnUsers, 1, 0);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnroles, 0, 0);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnTax, 4, 1);
            this.AdmintableLayoutPanel1.Controls.Add(this.btnOrderModification, 0, 2);
            this.AdmintableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdmintableLayoutPanel1.ForeColor = System.Drawing.Color.SlateGray;
            this.AdmintableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.AdmintableLayoutPanel1.Name = "AdmintableLayoutPanel1";
            this.AdmintableLayoutPanel1.RowCount = 5;
            this.AdmintableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdmintableLayoutPanel1.Size = new System.Drawing.Size(642, 376);
            this.AdmintableLayoutPanel1.TabIndex = 2;
            // 
            // btnBillGeneration
            // 
            this.btnBillGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBillGeneration.FlatAppearance.BorderSize = 2;
            this.btnBillGeneration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillGeneration.Image = global::RestaurantManagementSystem.Properties.Resources.tablesNew_copy;
            this.btnBillGeneration.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBillGeneration.Location = new System.Drawing.Point(388, 79);
            this.btnBillGeneration.Name = "btnBillGeneration";
            this.btnBillGeneration.Size = new System.Drawing.Size(121, 68);
            this.btnBillGeneration.TabIndex = 8;
            this.btnBillGeneration.Text = "BILL GENERATION";
            this.btnBillGeneration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillGeneration.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBillGeneration.UseVisualStyleBackColor = true;
            this.btnBillGeneration.Click += new System.EventHandler(this.btnBillGeneration_Click);
            // 
            // btnTables
            // 
            this.btnTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTables.FlatAppearance.BorderSize = 2;
            this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTables.Image = global::RestaurantManagementSystem.Properties.Resources.tablesNew_copy;
            this.btnTables.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTables.Location = new System.Drawing.Point(260, 79);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(121, 68);
            this.btnTables.TabIndex = 7;
            this.btnTables.Text = "TABLES";
            this.btnTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrders.FlatAppearance.BorderSize = 2;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Image = global::RestaurantManagementSystem.Properties.Resources.ordersNew_copy;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.Location = new System.Drawing.Point(132, 79);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(121, 68);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "ORDER";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnFloors
            // 
            this.btnFloors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFloors.FlatAppearance.BorderSize = 2;
            this.btnFloors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloors.Image = global::RestaurantManagementSystem.Properties.Resources.floors_copy;
            this.btnFloors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFloors.Location = new System.Drawing.Point(4, 79);
            this.btnFloors.Name = "btnFloors";
            this.btnFloors.Size = new System.Drawing.Size(121, 68);
            this.btnFloors.TabIndex = 5;
            this.btnFloors.Text = "FLOORS";
            this.btnFloors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloors.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFloors.UseVisualStyleBackColor = true;
            this.btnFloors.Click += new System.EventHandler(this.btnFloors_Click);
            // 
            // btnFoodMenu
            // 
            this.btnFoodMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFoodMenu.FlatAppearance.BorderSize = 2;
            this.btnFoodMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodMenu.Image = global::RestaurantManagementSystem.Properties.Resources.foodMenuNew1;
            this.btnFoodMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoodMenu.Location = new System.Drawing.Point(516, 4);
            this.btnFoodMenu.Name = "btnFoodMenu";
            this.btnFoodMenu.Size = new System.Drawing.Size(122, 68);
            this.btnFoodMenu.TabIndex = 4;
            this.btnFoodMenu.Text = "FOOD  MENU";
            this.btnFoodMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFoodMenu.UseVisualStyleBackColor = true;
            this.btnFoodMenu.Click += new System.EventHandler(this.btnFoodMenu_Click);
            // 
            // btnFoodCategories
            // 
            this.btnFoodCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFoodCategories.FlatAppearance.BorderSize = 2;
            this.btnFoodCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodCategories.Image = global::RestaurantManagementSystem.Properties.Resources.foodCategoryNew_copy;
            this.btnFoodCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoodCategories.Location = new System.Drawing.Point(388, 4);
            this.btnFoodCategories.Name = "btnFoodCategories";
            this.btnFoodCategories.Size = new System.Drawing.Size(121, 68);
            this.btnFoodCategories.TabIndex = 3;
            this.btnFoodCategories.Text = "FOOD CATEGORIES";
            this.btnFoodCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFoodCategories.UseVisualStyleBackColor = true;
            this.btnFoodCategories.Click += new System.EventHandler(this.btnFoodCategories_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomers.FlatAppearance.BorderSize = 2;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Image = global::RestaurantManagementSystem.Properties.Resources.customer1_copy;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.Location = new System.Drawing.Point(260, 4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(121, 68);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "CUSTOMERS";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.FlatAppearance.BorderSize = 2;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Image = global::RestaurantManagementSystem.Properties.Resources.Users;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.Location = new System.Drawing.Point(132, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(121, 68);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "USERS";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnroles
            // 
            this.btnroles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnroles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnroles.FlatAppearance.BorderSize = 2;
            this.btnroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroles.Image = global::RestaurantManagementSystem.Properties.Resources.roles_copy;
            this.btnroles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnroles.Location = new System.Drawing.Point(4, 4);
            this.btnroles.Name = "btnroles";
            this.btnroles.Size = new System.Drawing.Size(121, 68);
            this.btnroles.TabIndex = 0;
            this.btnroles.Text = "ROLES";
            this.btnroles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnroles.UseVisualStyleBackColor = true;
            this.btnroles.Click += new System.EventHandler(this.btnroles_Click);
            // 
            // btnTax
            // 
            this.btnTax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTax.FlatAppearance.BorderSize = 2;
            this.btnTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTax.Image = global::RestaurantManagementSystem.Properties.Resources.floors_copy;
            this.btnTax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTax.Location = new System.Drawing.Point(516, 79);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(122, 68);
            this.btnTax.TabIndex = 9;
            this.btnTax.Text = "TAX MANAGEMENT";
            this.btnTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTax.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnOrderModification
            // 
            this.btnOrderModification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderModification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrderModification.FlatAppearance.BorderSize = 2;
            this.btnOrderModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderModification.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderModification.Location = new System.Drawing.Point(4, 154);
            this.btnOrderModification.Name = "btnOrderModification";
            this.btnOrderModification.Size = new System.Drawing.Size(121, 68);
            this.btnOrderModification.TabIndex = 10;
            this.btnOrderModification.Text = "ORDER MODIFICATION";
            this.btnOrderModification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderModification.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrderModification.UseVisualStyleBackColor = true;
            this.btnOrderModification.Click += new System.EventHandler(this.btnOrderModification_Click);
            // 
            // frmAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 421);
            this.Name = "frmAdminWindow";
            this.Text = "Admin Window";
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.AdmintableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AdmintableLayoutPanel1;
        private System.Windows.Forms.Button btnroles;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnFloors;
        private System.Windows.Forms.Button btnFoodMenu;
        private System.Windows.Forms.Button btnFoodCategories;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnBillGeneration;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Button btnOrderModification;
    }
}