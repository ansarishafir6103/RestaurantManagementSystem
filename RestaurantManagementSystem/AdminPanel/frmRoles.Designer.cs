namespace RestaurantManagementSystem.AdminPanel
{
    partial class frmRoles
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
            this.lblRoles = new System.Windows.Forms.Label();
            this.txtRoles = new System.Windows.Forms.TextBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.grvRoles = new System.Windows.Forms.DataGridView();
            this.serialNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.txtRoles);
            this.leftpanel.Controls.Add(this.lblRoles);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.leftHeaderpanel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblRoles, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtRoles, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.gbDetails);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.rightHeaderpanel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.gbDetails, 0);
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(12, 101);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(34, 15);
            this.lblRoles.TabIndex = 2;
            this.lblRoles.Text = "Roles";
            // 
            // txtRoles
            // 
            this.txtRoles.Enabled = false;
            this.txtRoles.Location = new System.Drawing.Point(12, 119);
            this.txtRoles.Name = "txtRoles";
            this.txtRoles.Size = new System.Drawing.Size(224, 23);
            this.txtRoles.TabIndex = 3;
            this.txtRoles.TextChanged += new System.EventHandler(this.txtRoles_TextChanged);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.grvRoles);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(0, 93);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(668, 429);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // grvRoles
            // 
            this.grvRoles.AllowUserToAddRows = false;
            this.grvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvRoles.BackgroundColor = System.Drawing.Color.White;
            this.grvRoles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoGV,
            this.r_id,
            this.r_name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoles.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvRoles.EnableHeadersVisualStyles = false;
            this.grvRoles.Location = new System.Drawing.Point(3, 25);
            this.grvRoles.Name = "grvRoles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvRoles.RowHeadersVisible = false;
            this.grvRoles.Size = new System.Drawing.Size(662, 401);
            this.grvRoles.TabIndex = 0;
            this.grvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvRoles_CellClick);
            // 
            // serialNoGV
            // 
            this.serialNoGV.HeaderText = "SERIAL NO";
            this.serialNoGV.Name = "serialNoGV";
            // 
            // r_id
            // 
            this.r_id.HeaderText = "r_id";
            this.r_id.Name = "r_id";
            this.r_id.Visible = false;
            // 
            // r_name
            // 
            this.r_name.HeaderText = "ROLES";
            this.r_name.Name = "r_name";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 522);
            this.Name = "frmRoles";
            this.Text = "Roles";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.TextBox txtRoles;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DataGridView grvRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_name;
    }
}