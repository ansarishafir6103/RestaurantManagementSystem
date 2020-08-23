namespace RestaurantManagementSystem.ChefPanel
{
    partial class frmOrderChef
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbOrderDetails = new System.Windows.Forms.GroupBox();
            this.panel1FooterOrders = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2FooterOrders = new System.Windows.Forms.TableLayoutPanel();
            this.grvOrdersRightPanel = new System.Windows.Forms.DataGridView();
            this.serialNoGVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvChefOrdersLeftPanel = new System.Windows.Forms.DataGridView();
            this.serialNoGVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoneBtnGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbOrderDetails.SuspendLayout();
            this.panel1FooterOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrdersRightPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChefOrdersLeftPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.grvChefOrdersLeftPanel);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.grvChefOrdersLeftPanel, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbOrderDetails);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbOrderDetails, 0);
            // 
            // gbOrderDetails
            // 
            this.gbOrderDetails.Controls.Add(this.panel1FooterOrders);
            this.gbOrderDetails.Controls.Add(this.grvOrdersRightPanel);
            this.gbOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderDetails.Location = new System.Drawing.Point(0, 93);
            this.gbOrderDetails.Name = "gbOrderDetails";
            this.gbOrderDetails.Size = new System.Drawing.Size(668, 429);
            this.gbOrderDetails.TabIndex = 5;
            this.gbOrderDetails.TabStop = false;
            this.gbOrderDetails.Text = "Details";
            // 
            // panel1FooterOrders
            // 
            this.panel1FooterOrders.Controls.Add(this.tableLayoutPanel2FooterOrders);
            this.panel1FooterOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1FooterOrders.Location = new System.Drawing.Point(3, 352);
            this.panel1FooterOrders.Name = "panel1FooterOrders";
            this.panel1FooterOrders.Size = new System.Drawing.Size(662, 74);
            this.panel1FooterOrders.TabIndex = 5;
            // 
            // tableLayoutPanel2FooterOrders
            // 
            this.tableLayoutPanel2FooterOrders.ColumnCount = 2;
            this.tableLayoutPanel2FooterOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2FooterOrders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2FooterOrders.Name = "tableLayoutPanel2FooterOrders";
            this.tableLayoutPanel2FooterOrders.RowCount = 1;
            this.tableLayoutPanel2FooterOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2FooterOrders.Size = new System.Drawing.Size(662, 74);
            this.tableLayoutPanel2FooterOrders.TabIndex = 0;
            // 
            // grvOrdersRightPanel
            // 
            this.grvOrdersRightPanel.AllowUserToAddRows = false;
            this.grvOrdersRightPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvOrdersRightPanel.BackgroundColor = System.Drawing.Color.White;
            this.grvOrdersRightPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrdersRightPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvOrdersRightPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrdersRightPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGVR,
            this.ItemGV,
            this.QuantityGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvOrdersRightPanel.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvOrdersRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvOrdersRightPanel.EnableHeadersVisualStyles = false;
            this.grvOrdersRightPanel.Location = new System.Drawing.Point(3, 25);
            this.grvOrdersRightPanel.Name = "grvOrdersRightPanel";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrdersRightPanel.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grvOrdersRightPanel.RowHeadersVisible = false;
            this.grvOrdersRightPanel.Size = new System.Drawing.Size(662, 401);
            this.grvOrdersRightPanel.TabIndex = 6;
            // 
            // serialNoGVR
            // 
            this.serialNoGVR.HeaderText = "Serial No";
            this.serialNoGVR.Name = "serialNoGVR";
            this.serialNoGVR.ReadOnly = true;
            // 
            // ItemGV
            // 
            this.ItemGV.HeaderText = "ITEM";
            this.ItemGV.Name = "ItemGV";
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "QUANTITY";
            this.QuantityGV.Name = "QuantityGV";
            // 
            // grvChefOrdersLeftPanel
            // 
            this.grvChefOrdersLeftPanel.AllowUserToAddRows = false;
            this.grvChefOrdersLeftPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvChefOrdersLeftPanel.BackgroundColor = System.Drawing.Color.SlateGray;
            this.grvChefOrdersLeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvChefOrdersLeftPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvChefOrdersLeftPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvChefOrdersLeftPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGVL,
            this.orderIDGV,
            this.statusGV,
            this.DoneBtnGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvChefOrdersLeftPanel.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvChefOrdersLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvChefOrdersLeftPanel.EnableHeadersVisualStyles = false;
            this.grvChefOrdersLeftPanel.Location = new System.Drawing.Point(0, 93);
            this.grvChefOrdersLeftPanel.Name = "grvChefOrdersLeftPanel";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvChefOrdersLeftPanel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvChefOrdersLeftPanel.RowHeadersVisible = false;
            this.grvChefOrdersLeftPanel.Size = new System.Drawing.Size(250, 429);
            this.grvChefOrdersLeftPanel.TabIndex = 4;
            this.grvChefOrdersLeftPanel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvChefOrdersLeftPanel_CellClick);
            this.grvChefOrdersLeftPanel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvChefOrdersLeftPanel_CellContentClick);
            // 
            // serialNoGVL
            // 
            this.serialNoGVL.HeaderText = "SERIAL NO";
            this.serialNoGVL.Name = "serialNoGVL";
            this.serialNoGVL.ReadOnly = true;
            // 
            // orderIDGV
            // 
            this.orderIDGV.HeaderText = "ORDER ID";
            this.orderIDGV.Name = "orderIDGV";
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            // 
            // DoneBtnGV
            // 
            this.DoneBtnGV.HeaderText = "Action";
            this.DoneBtnGV.Name = "DoneBtnGV";
            this.DoneBtnGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DoneBtnGV.Text = "Done";
            this.DoneBtnGV.UseColumnTextForButtonValue = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmOrderChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 522);
            this.Name = "frmOrderChef";
            this.Text = "frmOrderChef";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderChef_FormClosing);
            this.Load += new System.EventHandler(this.frmOrderChef_Load);
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbOrderDetails.ResumeLayout(false);
            this.panel1FooterOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrdersRightPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChefOrdersLeftPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderDetails;
        private System.Windows.Forms.DataGridView grvChefOrdersLeftPanel;
        private System.Windows.Forms.Panel panel1FooterOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2FooterOrders;
        private System.Windows.Forms.DataGridView grvOrdersRightPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewButtonColumn DoneBtnGV;
    }
}