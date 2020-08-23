namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmFoodCategories
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
            this.txtfoodcategory = new System.Windows.Forms.TextBox();
            this.lblfoodcategory = new System.Windows.Forms.Label();
            this.gbFoodCategory = new System.Windows.Forms.GroupBox();
            this.grvFoodCategories = new System.Windows.Forms.DataGridView();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbFoodCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvFoodCategories)).BeginInit();
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
            this.leftpanel.Controls.Add(this.lblfoodcategory);
            this.leftpanel.Controls.Add(this.txtfoodcategory);
            this.leftpanel.Size = new System.Drawing.Size(250, 421);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtfoodcategory, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblfoodcategory, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbFoodCategory);
            this.rightpanel.Size = new System.Drawing.Size(642, 421);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbFoodCategory, 0);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(642, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Size = new System.Drawing.Size(642, 45);
            // 
            // txtfoodcategory
            // 
            this.txtfoodcategory.Enabled = false;
            this.txtfoodcategory.Location = new System.Drawing.Point(12, 129);
            this.txtfoodcategory.Name = "txtfoodcategory";
            this.txtfoodcategory.Size = new System.Drawing.Size(223, 23);
            this.txtfoodcategory.TabIndex = 2;
            this.txtfoodcategory.TextChanged += new System.EventHandler(this.txtfoodcategory_TextChanged);
            // 
            // lblfoodcategory
            // 
            this.lblfoodcategory.AutoSize = true;
            this.lblfoodcategory.Location = new System.Drawing.Point(12, 110);
            this.lblfoodcategory.Name = "lblfoodcategory";
            this.lblfoodcategory.Size = new System.Drawing.Size(84, 15);
            this.lblfoodcategory.TabIndex = 3;
            this.lblfoodcategory.Text = "Food Category";
            // 
            // gbFoodCategory
            // 
            this.gbFoodCategory.Controls.Add(this.grvFoodCategories);
            this.gbFoodCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFoodCategory.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFoodCategory.Location = new System.Drawing.Point(0, 93);
            this.gbFoodCategory.Name = "gbFoodCategory";
            this.gbFoodCategory.Size = new System.Drawing.Size(642, 328);
            this.gbFoodCategory.TabIndex = 4;
            this.gbFoodCategory.TabStop = false;
            this.gbFoodCategory.Text = "Details";
            // 
            // grvFoodCategories
            // 
            this.grvFoodCategories.AllowUserToAddRows = false;
            this.grvFoodCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvFoodCategories.BackgroundColor = System.Drawing.Color.White;
            this.grvFoodCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvFoodCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvFoodCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFoodCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.CategoryIDGV,
            this.CategoryNameGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvFoodCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvFoodCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvFoodCategories.EnableHeadersVisualStyles = false;
            this.grvFoodCategories.Location = new System.Drawing.Point(3, 25);
            this.grvFoodCategories.Name = "grvFoodCategories";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvFoodCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvFoodCategories.RowHeadersVisible = false;
            this.grvFoodCategories.Size = new System.Drawing.Size(636, 300);
            this.grvFoodCategories.TabIndex = 0;
            this.grvFoodCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvFoodCategories_CellClick);
            // 
            // serialNoGV
            // 
            this.serialNoGV.HeaderText = "SERIAL NO";
            this.serialNoGV.Name = "serialNoGV";
            // 
            // CategoryIDGV
            // 
            this.CategoryIDGV.HeaderText = "CategoryIDGV";
            this.CategoryIDGV.Name = "CategoryIDGV";
            this.CategoryIDGV.Visible = false;
            // 
            // CategoryNameGV
            // 
            this.CategoryNameGV.HeaderText = "Category Name";
            this.CategoryNameGV.Name = "CategoryNameGV";
            // 
            // frmFoodCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 421);
            this.Name = "frmFoodCategories";
            this.Text = "Food Categories";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbFoodCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvFoodCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtfoodcategory;
        private System.Windows.Forms.Label lblfoodcategory;
        private System.Windows.Forms.GroupBox gbFoodCategory;
        private System.Windows.Forms.DataGridView grvFoodCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameGV;
    }
}