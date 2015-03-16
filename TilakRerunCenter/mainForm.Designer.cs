namespace RerunCenter {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gwApplications = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAppDeliveryTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtbxComputer = new System.Windows.Forms.TextBox();
            this.btnRerun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gwApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // gwApplications
            // 
            this.gwApplications.AllowUserToAddRows = false;
            this.gwApplications.AllowUserToDeleteRows = false;
            this.gwApplications.AllowUserToOrderColumns = true;
            this.gwApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gwApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colRevision,
            this.colAppDeliveryTypeID});
            this.gwApplications.Location = new System.Drawing.Point(13, 37);
            this.gwApplications.Name = "gwApplications";
            this.gwApplications.ReadOnly = true;
            this.gwApplications.RowHeadersVisible = false;
            this.gwApplications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gwApplications.Size = new System.Drawing.Size(820, 423);
            this.gwApplications.StandardTab = true;
            this.gwApplications.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 60;
            // 
            // colRevision
            // 
            this.colRevision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRevision.DataPropertyName = "Revision";
            this.colRevision.HeaderText = "Revision";
            this.colRevision.Name = "colRevision";
            this.colRevision.ReadOnly = true;
            this.colRevision.Width = 73;
            // 
            // colAppDeliveryTypeID
            // 
            this.colAppDeliveryTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAppDeliveryTypeID.DataPropertyName = "AppDeliveryTypeID";
            this.colAppDeliveryTypeID.HeaderText = "AppDeliveryTypeID";
            this.colAppDeliveryTypeID.Name = "colAppDeliveryTypeID";
            this.colAppDeliveryTypeID.ReadOnly = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(119, 9);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtbxComputer
            // 
            this.txtbxComputer.Location = new System.Drawing.Point(13, 11);
            this.txtbxComputer.Name = "txtbxComputer";
            this.txtbxComputer.Size = new System.Drawing.Size(100, 20);
            this.txtbxComputer.TabIndex = 2;
            this.txtbxComputer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxComputer_KeyDown);
            // 
            // btnRerun
            // 
            this.btnRerun.Location = new System.Drawing.Point(200, 9);
            this.btnRerun.Name = "btnRerun";
            this.btnRerun.Size = new System.Drawing.Size(75, 23);
            this.btnRerun.TabIndex = 3;
            this.btnRerun.Text = "ReRun";
            this.btnRerun.UseVisualStyleBackColor = true;
            this.btnRerun.Click += new System.EventHandler(this.btnRerun_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 472);
            this.Controls.Add(this.btnRerun);
            this.Controls.Add(this.txtbxComputer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gwApplications);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "ReRun Center";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gwApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gwApplications;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtbxComputer;
        private System.Windows.Forms.Button btnRerun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppDeliveryTypeID;
    }
}

