namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmTables
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
            this.cmbTableNumber = new System.Windows.Forms.ComboBox();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.cmbTableChairs = new System.Windows.Forms.ComboBox();
            this.lblChairNumber = new System.Windows.Forms.Label();
            this.cmbFloorNumber = new System.Windows.Forms.ComboBox();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.gbTablesDetails = new System.Windows.Forms.GroupBox();
            this.grvTables = new System.Windows.Forms.DataGridView();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableFloorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableChairGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbTablesDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTables)).BeginInit();
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
            this.leftpanel.Controls.Add(this.cmbTableChairs);
            this.leftpanel.Controls.Add(this.lblChairNumber);
            this.leftpanel.Controls.Add(this.cmbTableNumber);
            this.leftpanel.Controls.Add(this.lblTableNumber);
            this.leftpanel.Size = new System.Drawing.Size(250, 421);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblTableNumber, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbTableNumber, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblChairNumber, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbTableChairs, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblFloorNumber, 0);
            this.leftpanel.Controls.SetChildIndex(this.cmbFloorNumber, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbTablesDetails);
            this.rightpanel.Size = new System.Drawing.Size(642, 421);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbTablesDetails, 0);
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Size = new System.Drawing.Size(642, 45);
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Size = new System.Drawing.Size(642, 45);
            // 
            // cmbTableNumber
            // 
            this.cmbTableNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNumber.Enabled = false;
            this.cmbTableNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTableNumber.FormattingEnabled = true;
            this.cmbTableNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbTableNumber.Location = new System.Drawing.Point(12, 117);
            this.cmbTableNumber.Name = "cmbTableNumber";
            this.cmbTableNumber.Size = new System.Drawing.Size(224, 23);
            this.cmbTableNumber.TabIndex = 14;
            this.cmbTableNumber.SelectedIndexChanged += new System.EventHandler(this.cmbTableNumber_SelectedIndexChanged);
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(12, 99);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(77, 15);
            this.lblTableNumber.TabIndex = 13;
            this.lblTableNumber.Text = "Table Number";
            // 
            // cmbTableChairs
            // 
            this.cmbTableChairs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableChairs.Enabled = false;
            this.cmbTableChairs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTableChairs.FormattingEnabled = true;
            this.cmbTableChairs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbTableChairs.Location = new System.Drawing.Point(12, 161);
            this.cmbTableChairs.Name = "cmbTableChairs";
            this.cmbTableChairs.Size = new System.Drawing.Size(224, 23);
            this.cmbTableChairs.TabIndex = 16;
            this.cmbTableChairs.SelectedIndexChanged += new System.EventHandler(this.cmbTableChairs_SelectedIndexChanged);
            // 
            // lblChairNumber
            // 
            this.lblChairNumber.AutoSize = true;
            this.lblChairNumber.Location = new System.Drawing.Point(12, 143);
            this.lblChairNumber.Name = "lblChairNumber";
            this.lblChairNumber.Size = new System.Drawing.Size(71, 15);
            this.lblChairNumber.TabIndex = 15;
            this.lblChairNumber.Text = "No Of Chairs";
            // 
            // cmbFloorNumber
            // 
            this.cmbFloorNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloorNumber.Enabled = false;
            this.cmbFloorNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFloorNumber.FormattingEnabled = true;
            this.cmbFloorNumber.Items.AddRange(new object[] {
            ""});
            this.cmbFloorNumber.Location = new System.Drawing.Point(13, 208);
            this.cmbFloorNumber.Name = "cmbFloorNumber";
            this.cmbFloorNumber.Size = new System.Drawing.Size(224, 23);
            this.cmbFloorNumber.TabIndex = 18;
            this.cmbFloorNumber.SelectedIndexChanged += new System.EventHandler(this.cmbFloorNumber_SelectedIndexChanged);
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.AutoSize = true;
            this.lblFloorNumber.Location = new System.Drawing.Point(13, 190);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Size = new System.Drawing.Size(78, 15);
            this.lblFloorNumber.TabIndex = 17;
            this.lblFloorNumber.Text = "Floor Number";
            // 
            // gbTablesDetails
            // 
            this.gbTablesDetails.Controls.Add(this.grvTables);
            this.gbTablesDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTablesDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTablesDetails.Location = new System.Drawing.Point(0, 93);
            this.gbTablesDetails.Name = "gbTablesDetails";
            this.gbTablesDetails.Size = new System.Drawing.Size(642, 328);
            this.gbTablesDetails.TabIndex = 6;
            this.gbTablesDetails.TabStop = false;
            this.gbTablesDetails.Text = "Details";
            // 
            // grvTables
            // 
            this.grvTables.AllowUserToAddRows = false;
            this.grvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTables.BackgroundColor = System.Drawing.Color.White;
            this.grvTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.TableFloorIDGV,
            this.TableNumberGV,
            this.TableIDGV,
            this.TableChairGV,
            this.FloorNumberGV,
            this.FloorNameGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvTables.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTables.EnableHeadersVisualStyles = false;
            this.grvTables.Location = new System.Drawing.Point(3, 25);
            this.grvTables.Name = "grvTables";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTables.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvTables.RowHeadersVisible = false;
            this.grvTables.Size = new System.Drawing.Size(636, 300);
            this.grvTables.TabIndex = 4;
            this.grvTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTables_CellClick);
            // 
            // serialNoGV
            // 
            this.serialNoGV.HeaderText = "SERIAL NO";
            this.serialNoGV.Name = "serialNoGV";
            // 
            // TableFloorIDGV
            // 
            this.TableFloorIDGV.HeaderText = "TableFloorIDGV";
            this.TableFloorIDGV.Name = "TableFloorIDGV";
            this.TableFloorIDGV.Visible = false;
            // 
            // TableNumberGV
            // 
            this.TableNumberGV.HeaderText = "Table Number";
            this.TableNumberGV.Name = "TableNumberGV";
            // 
            // TableIDGV
            // 
            this.TableIDGV.HeaderText = "TableIDGV";
            this.TableIDGV.Name = "TableIDGV";
            this.TableIDGV.Visible = false;
            // 
            // TableChairGV
            // 
            this.TableChairGV.HeaderText = "No Of Chairs";
            this.TableChairGV.Name = "TableChairGV";
            // 
            // FloorNumberGV
            // 
            this.FloorNumberGV.HeaderText = "Floor Number";
            this.FloorNumberGV.Name = "FloorNumberGV";
            // 
            // FloorNameGV
            // 
            this.FloorNameGV.HeaderText = "Floor Name";
            this.FloorNameGV.Name = "FloorNameGV";
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 421);
            this.Name = "frmTables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.frmTables_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbTablesDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFloorNumber;
        private System.Windows.Forms.Label lblFloorNumber;
        private System.Windows.Forms.ComboBox cmbTableChairs;
        private System.Windows.Forms.Label lblChairNumber;
        private System.Windows.Forms.ComboBox cmbTableNumber;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.GroupBox gbTablesDetails;
        private System.Windows.Forms.DataGridView grvTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableFloorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumberGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableChairGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNumberGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNameGV;
    }
}