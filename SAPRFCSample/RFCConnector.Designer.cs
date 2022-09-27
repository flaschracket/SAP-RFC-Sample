namespace SAPRFCSample
{
    partial class RFCConnector
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.loginSID = new System.Windows.Forms.Label();
            this.loginSessionID = new System.Windows.Forms.Label();
            this.tbRFCName = new System.Windows.Forms.TextBox();
            this.lblRFCName = new System.Windows.Forms.Label();
            this.lbFunctionName = new System.Windows.Forms.Label();
            this.tbFunctionName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(44, 159);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(156, 23);
            this.connect.TabIndex = 4;
            this.connect.Text = "Test Connection";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(187, 220);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 5;
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.Location = new System.Drawing.Point(41, 220);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(118, 13);
            this.connectionStatus.TabIndex = 6;
            this.connectionStatus.Text = "Connect Successfully? ";
            // 
            // loginSID
            // 
            this.loginSID.AutoSize = true;
            this.loginSID.Location = new System.Drawing.Point(124, 249);
            this.loginSID.Name = "loginSID";
            this.loginSID.Size = new System.Drawing.Size(0, 13);
            this.loginSID.TabIndex = 10;
            // 
            // loginSessionID
            // 
            this.loginSessionID.AutoSize = true;
            this.loginSessionID.Location = new System.Drawing.Point(41, 249);
            this.loginSessionID.Name = "loginSessionID";
            this.loginSessionID.Size = new System.Drawing.Size(53, 13);
            this.loginSessionID.TabIndex = 12;
            this.loginSessionID.Text = "sessionID";
            // 
            // tbRFCName
            // 
            this.tbRFCName.Location = new System.Drawing.Point(219, 22);
            this.tbRFCName.Name = "tbRFCName";
            this.tbRFCName.Size = new System.Drawing.Size(259, 20);
            this.tbRFCName.TabIndex = 13;
            // 
            // lblRFCName
            // 
            this.lblRFCName.AutoSize = true;
            this.lblRFCName.Location = new System.Drawing.Point(44, 28);
            this.lblRFCName.Name = "lblRFCName";
            this.lblRFCName.Size = new System.Drawing.Size(114, 13);
            this.lblRFCName.TabIndex = 14;
            this.lblRFCName.Text = "RFC Name in SAP(R3)";
            // 
            // lbFunctionName
            // 
            this.lbFunctionName.AutoSize = true;
            this.lbFunctionName.Location = new System.Drawing.Point(44, 73);
            this.lbFunctionName.Name = "lbFunctionName";
            this.lbFunctionName.Size = new System.Drawing.Size(111, 13);
            this.lbFunctionName.TabIndex = 16;
            this.lbFunctionName.Text = "Function Name to Call";
            // 
            // tbFunctionName
            // 
            this.tbFunctionName.Location = new System.Drawing.Point(219, 67);
            this.tbFunctionName.Name = "tbFunctionName";
            this.tbFunctionName.Size = new System.Drawing.Size(259, 20);
            this.tbFunctionName.TabIndex = 15;
            this.tbFunctionName.Text = "SXMI_XOM_RMGS_QUERY";
            // 
            // RFCConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFunctionName);
            this.Controls.Add(this.tbFunctionName);
            this.Controls.Add(this.lblRFCName);
            this.Controls.Add(this.tbRFCName);
            this.Controls.Add(this.loginSessionID);
            this.Controls.Add(this.loginSID);
            this.Controls.Add(this.connectionStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.connect);
            this.Name = "RFCConnector";
            this.Text = "RFC Connector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.Label loginSID;
        private System.Windows.Forms.Label loginSessionID;
        private System.Windows.Forms.TextBox tbRFCName;
        private System.Windows.Forms.Label lblRFCName;
        private System.Windows.Forms.Label lbFunctionName;
        private System.Windows.Forms.TextBox tbFunctionName;
    }
}

