namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmTex
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
            this.lblTaxPrecentage = new System.Windows.Forms.Label();
            this.txtTaxPercentage = new System.Windows.Forms.TextBox();
            this.lblTexType = new System.Windows.Forms.Label();
            this.cmbTexType = new System.Windows.Forms.ComboBox();
            this.gbDetailsTax = new System.Windows.Forms.GroupBox();
            this.grvTax = new System.Windows.Forms.DataGridView();
            this.srNoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbDetailsTax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.cmbTexType);
            this.leftpanel.Controls.Add(this.lblTexType);
            this.leftpanel.Controls.Add(this.txtTaxPercentage);
            this.leftpanel.Controls.Add(this.lblTaxPrecentage);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblTaxPrecentage, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtTaxPercentage, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblTexType, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbTexType, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbDetailsTax);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbDetailsTax, 0);
            // 
            // lblTaxPrecentage
            // 
            this.lblTaxPrecentage.AutoSize = true;
            this.lblTaxPrecentage.Location = new System.Drawing.Point(12, 117);
            this.lblTaxPrecentage.Name = "lblTaxPrecentage";
            this.lblTaxPrecentage.Size = new System.Drawing.Size(96, 15);
            this.lblTaxPrecentage.TabIndex = 2;
            this.lblTaxPrecentage.Text = "Tax Amount IN(%)";
            // 
            // txtTaxPercentage
            // 
            this.txtTaxPercentage.Enabled = false;
            this.txtTaxPercentage.Location = new System.Drawing.Point(15, 135);
            this.txtTaxPercentage.Name = "txtTaxPercentage";
            this.txtTaxPercentage.Size = new System.Drawing.Size(204, 23);
            this.txtTaxPercentage.TabIndex = 3;
            // 
            // lblTexType
            // 
            this.lblTexType.AutoSize = true;
            this.lblTexType.Location = new System.Drawing.Point(12, 161);
            this.lblTexType.Name = "lblTexType";
            this.lblTexType.Size = new System.Drawing.Size(30, 15);
            this.lblTexType.TabIndex = 4;
            this.lblTexType.Text = "Type";
            // 
            // cmbTexType
            // 
            this.cmbTexType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTexType.Enabled = false;
            this.cmbTexType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTexType.FormattingEnabled = true;
            this.cmbTexType.Items.AddRange(new object[] {
            "Inclusive",
            "Exclusive"});
            this.cmbTexType.Location = new System.Drawing.Point(15, 179);
            this.cmbTexType.Name = "cmbTexType";
            this.cmbTexType.Size = new System.Drawing.Size(204, 23);
            this.cmbTexType.TabIndex = 5;
            // 
            // gbDetailsTax
            // 
            this.gbDetailsTax.Controls.Add(this.grvTax);
            this.gbDetailsTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetailsTax.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailsTax.Location = new System.Drawing.Point(0, 93);
            this.gbDetailsTax.Name = "gbDetailsTax";
            this.gbDetailsTax.Size = new System.Drawing.Size(668, 429);
            this.gbDetailsTax.TabIndex = 4;
            this.gbDetailsTax.TabStop = false;
            this.gbDetailsTax.Text = "Details";
            // 
            // grvTax
            // 
            this.grvTax.AllowUserToAddRows = false;
            this.grvTax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTax.BackgroundColor = System.Drawing.Color.White;
            this.grvTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srNoGv,
            this.taxIDGV,
            this.valueGV,
            this.typeGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvTax.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTax.EnableHeadersVisualStyles = false;
            this.grvTax.Location = new System.Drawing.Point(3, 25);
            this.grvTax.Name = "grvTax";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTax.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvTax.RowHeadersVisible = false;
            this.grvTax.Size = new System.Drawing.Size(662, 401);
            this.grvTax.TabIndex = 0;
            this.grvTax.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTax_CellClick);
            // 
            // srNoGv
            // 
            this.srNoGv.HeaderText = "#";
            this.srNoGv.Name = "srNoGv";
            // 
            // taxIDGV
            // 
            this.taxIDGV.HeaderText = "taxIDGV";
            this.taxIDGV.Name = "taxIDGV";
            this.taxIDGV.Visible = false;
            // 
            // valueGV
            // 
            this.valueGV.HeaderText = "TAX VALUE";
            this.valueGV.Name = "valueGV";
            // 
            // typeGV
            // 
            this.typeGV.HeaderText = "TAX TYPE";
            this.typeGV.Name = "typeGV";
            // 
            // frmTex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 522);
            this.Name = "frmTex";
            this.Text = "frrmTex";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbDetailsTax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTaxPrecentage;
        private System.Windows.Forms.Label lblTexType;
        private System.Windows.Forms.TextBox txtTaxPercentage;
        private System.Windows.Forms.ComboBox cmbTexType;
        private System.Windows.Forms.GroupBox gbDetailsTax;
        private System.Windows.Forms.DataGridView grvTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeGV;
    }
}