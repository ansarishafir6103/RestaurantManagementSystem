namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmFloors
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
            this.txtFloorName = new System.Windows.Forms.TextBox();
            this.lblFloorName = new System.Windows.Forms.Label();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.cmbFloorNumber = new System.Windows.Forms.ComboBox();
            this.gbFloorsDetails = new System.Windows.Forms.GroupBox();
            this.grvFloors = new System.Windows.Forms.DataGridView();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbFloorsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvFloors)).BeginInit();
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
            this.leftpanel.Controls.Add(this.cmbFloorNumber);
            this.leftpanel.Controls.Add(this.lblFloorNumber);
            this.leftpanel.Controls.Add(this.txtFloorName);
            this.leftpanel.Controls.Add(this.lblFloorName);
            this.leftpanel.Size = new System.Drawing.Size(250, 487);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblFloorName, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtFloorName, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblFloorNumber, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbFloorNumber, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbFloorsDetails);
            this.rightpanel.Size = new System.Drawing.Size(642, 487);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbFloorsDetails, 0);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(642, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Size = new System.Drawing.Size(642, 45);
            // 
            // txtFloorName
            // 
            this.txtFloorName.Enabled = false;
            this.txtFloorName.Location = new System.Drawing.Point(12, 131);
            this.txtFloorName.MaxLength = 20;
            this.txtFloorName.Name = "txtFloorName";
            this.txtFloorName.Size = new System.Drawing.Size(224, 23);
            this.txtFloorName.TabIndex = 10;
            this.txtFloorName.TextChanged += new System.EventHandler(this.txtFloorName_TextChanged);
            // 
            // lblFloorName
            // 
            this.lblFloorName.AutoSize = true;
            this.lblFloorName.Location = new System.Drawing.Point(12, 113);
            this.lblFloorName.Name = "lblFloorName";
            this.lblFloorName.Size = new System.Drawing.Size(33, 15);
            this.lblFloorName.TabIndex = 9;
            this.lblFloorName.Text = "Floor";
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.AutoSize = true;
            this.lblFloorNumber.Location = new System.Drawing.Point(12, 157);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Size = new System.Drawing.Size(78, 15);
            this.lblFloorNumber.TabIndex = 11;
            this.lblFloorNumber.Text = "Floor Number";
            // 
            // cmbFloorNumber
            // 
            this.cmbFloorNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloorNumber.Enabled = false;
            this.cmbFloorNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFloorNumber.FormattingEnabled = true;
            this.cmbFloorNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbFloorNumber.Location = new System.Drawing.Point(12, 175);
            this.cmbFloorNumber.Name = "cmbFloorNumber";
            this.cmbFloorNumber.Size = new System.Drawing.Size(224, 23);
            this.cmbFloorNumber.TabIndex = 12;
            this.cmbFloorNumber.SelectedIndexChanged += new System.EventHandler(this.cmbFloorNumber_SelectedIndexChanged);
            // 
            // gbFloorsDetails
            // 
            this.gbFloorsDetails.Controls.Add(this.grvFloors);
            this.gbFloorsDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFloorsDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFloorsDetails.Location = new System.Drawing.Point(0, 93);
            this.gbFloorsDetails.Name = "gbFloorsDetails";
            this.gbFloorsDetails.Size = new System.Drawing.Size(642, 394);
            this.gbFloorsDetails.TabIndex = 5;
            this.gbFloorsDetails.TabStop = false;
            this.gbFloorsDetails.Text = "Details";
            // 
            // grvFloors
            // 
            this.grvFloors.AllowUserToAddRows = false;
            this.grvFloors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvFloors.BackgroundColor = System.Drawing.Color.White;
            this.grvFloors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvFloors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvFloors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFloors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.FloorIDGV,
            this.FloorNameGV,
            this.FloorNumberGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvFloors.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvFloors.EnableHeadersVisualStyles = false;
            this.grvFloors.Location = new System.Drawing.Point(3, 25);
            this.grvFloors.Name = "grvFloors";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvFloors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvFloors.RowHeadersVisible = false;
            this.grvFloors.Size = new System.Drawing.Size(636, 366);
            this.grvFloors.TabIndex = 4;
            this.grvFloors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvFloors_CellClick);
            // 
            // serialNoGV
            // 
            this.serialNoGV.HeaderText = "SERIAL NO";
            this.serialNoGV.Name = "serialNoGV";
            // 
            // FloorIDGV
            // 
            this.FloorIDGV.HeaderText = "FloorIDGV";
            this.FloorIDGV.Name = "FloorIDGV";
            this.FloorIDGV.Visible = false;
            // 
            // FloorNameGV
            // 
            this.FloorNameGV.HeaderText = "FLOOR";
            this.FloorNameGV.Name = "FloorNameGV";
            // 
            // FloorNumberGV
            // 
            this.FloorNumberGV.HeaderText = "Floor Number";
            this.FloorNumberGV.Name = "FloorNumberGV";
            // 
            // frmFloors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 487);
            this.Name = "frmFloors";
            this.Text = "Floors";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbFloorsDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvFloors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFloorNumber;
        private System.Windows.Forms.TextBox txtFloorName;
        private System.Windows.Forms.Label lblFloorName;
        private System.Windows.Forms.ComboBox cmbFloorNumber;
        private System.Windows.Forms.GroupBox gbFloorsDetails;
        private System.Windows.Forms.DataGridView grvFloors;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNumberGV;
    }
}