namespace RestaurantManagementSystem
{
    partial class frmSample
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.leftHeaderpanel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.rightHeaderpanel1 = new System.Windows.Forms.Panel();
            this.lblLoginDetails = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.leftHeaderpanel1.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.rightHeaderpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.SlateGray;
            this.leftpanel.Controls.Add(this.leftHeaderpanel1);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftpanel.ForeColor = System.Drawing.Color.White;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(250, 522);
            this.leftpanel.TabIndex = 0;
            // 
            // leftHeaderpanel1
            // 
            this.leftHeaderpanel1.Controls.Add(this.lblWelcome);
            this.leftHeaderpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftHeaderpanel1.Location = new System.Drawing.Point(0, 0);
            this.leftHeaderpanel1.Name = "leftHeaderpanel1";
            this.leftHeaderpanel1.Size = new System.Drawing.Size(250, 45);
            this.leftHeaderpanel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 45);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome,";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.rightHeaderpanel1);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightpanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.rightpanel.Location = new System.Drawing.Point(250, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(668, 522);
            this.rightpanel.TabIndex = 1;
            // 
            // rightHeaderpanel1
            // 
            this.rightHeaderpanel1.Controls.Add(this.lblLoginDetails);
            this.rightHeaderpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightHeaderpanel1.Location = new System.Drawing.Point(0, 0);
            this.rightHeaderpanel1.Name = "rightHeaderpanel1";
            this.rightHeaderpanel1.Size = new System.Drawing.Size(668, 45);
            this.rightHeaderpanel1.TabIndex = 1;
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoginDetails.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginDetails.Location = new System.Drawing.Point(0, 0);
            this.lblLoginDetails.Name = "lblLoginDetails";
            this.lblLoginDetails.Size = new System.Drawing.Size(668, 45);
            this.lblLoginDetails.TabIndex = 0;
            this.lblLoginDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 522);
            this.ControlBox = false;
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.leftpanel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSample";
            this.Load += new System.EventHandler(this.frmSample_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftHeaderpanel1.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.rightHeaderpanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel leftpanel;
        public System.Windows.Forms.Panel rightpanel;
        public System.Windows.Forms.Panel leftHeaderpanel1;
        public System.Windows.Forms.Panel rightHeaderpanel1;
        public  System.Windows.Forms.Label lblWelcome;
        public  System.Windows.Forms.Label lblLoginDetails;
    }
}

