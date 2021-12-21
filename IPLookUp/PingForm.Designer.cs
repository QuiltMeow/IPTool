namespace IPLookUp
{
    partial class PingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingForm));
            this.labelPing = new System.Windows.Forms.Label();
            this.labelTraceRouter = new System.Windows.Forms.Label();
            this.txtPing = new System.Windows.Forms.TextBox();
            this.txtTraceRouter = new System.Windows.Forms.TextBox();
            this.btnExecutePing = new System.Windows.Forms.Button();
            this.btnExecuteTraceRouter = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnResetWinsock = new System.Windows.Forms.Button();
            this.btnFlushDNS = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnResetTcpIp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPing
            // 
            this.labelPing.AutoSize = true;
            this.labelPing.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPing.Location = new System.Drawing.Point(15, 140);
            this.labelPing.Name = "labelPing";
            this.labelPing.Size = new System.Drawing.Size(79, 20);
            this.labelPing.TabIndex = 4;
            this.labelPing.Text = "Ping 資訊";
            // 
            // labelTraceRouter
            // 
            this.labelTraceRouter.AutoSize = true;
            this.labelTraceRouter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTraceRouter.Location = new System.Drawing.Point(15, 380);
            this.labelTraceRouter.Name = "labelTraceRouter";
            this.labelTraceRouter.Size = new System.Drawing.Size(141, 20);
            this.labelTraceRouter.TabIndex = 7;
            this.labelTraceRouter.Text = "Trace Router 資訊";
            // 
            // txtPing
            // 
            this.txtPing.BackColor = System.Drawing.Color.White;
            this.txtPing.Location = new System.Drawing.Point(62, 180);
            this.txtPing.Multiline = true;
            this.txtPing.Name = "txtPing";
            this.txtPing.ReadOnly = true;
            this.txtPing.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPing.Size = new System.Drawing.Size(493, 160);
            this.txtPing.TabIndex = 6;
            // 
            // txtTraceRouter
            // 
            this.txtTraceRouter.BackColor = System.Drawing.Color.White;
            this.txtTraceRouter.Location = new System.Drawing.Point(62, 420);
            this.txtTraceRouter.Multiline = true;
            this.txtTraceRouter.Name = "txtTraceRouter";
            this.txtTraceRouter.ReadOnly = true;
            this.txtTraceRouter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTraceRouter.Size = new System.Drawing.Size(493, 160);
            this.txtTraceRouter.TabIndex = 9;
            // 
            // btnExecutePing
            // 
            this.btnExecutePing.Enabled = false;
            this.btnExecutePing.Location = new System.Drawing.Point(480, 141);
            this.btnExecutePing.Name = "btnExecutePing";
            this.btnExecutePing.Size = new System.Drawing.Size(75, 23);
            this.btnExecutePing.TabIndex = 5;
            this.btnExecutePing.Text = "執行";
            this.btnExecutePing.UseVisualStyleBackColor = true;
            this.btnExecutePing.Click += new System.EventHandler(this.btnExecutePing_Click);
            // 
            // btnExecuteTraceRouter
            // 
            this.btnExecuteTraceRouter.Enabled = false;
            this.btnExecuteTraceRouter.Location = new System.Drawing.Point(480, 381);
            this.btnExecuteTraceRouter.Name = "btnExecuteTraceRouter";
            this.btnExecuteTraceRouter.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteTraceRouter.TabIndex = 8;
            this.btnExecuteTraceRouter.Text = "執行";
            this.btnExecuteTraceRouter.UseVisualStyleBackColor = true;
            this.btnExecuteTraceRouter.Click += new System.EventHandler(this.btnExecuteTraceRouter_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(60, 65);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(81, 12);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "輸入 IP 或域名";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(155, 62);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(400, 22);
            this.txtInput.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(480, 95);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnResetWinsock
            // 
            this.btnResetWinsock.Location = new System.Drawing.Point(455, 605);
            this.btnResetWinsock.Name = "btnResetWinsock";
            this.btnResetWinsock.Size = new System.Drawing.Size(100, 23);
            this.btnResetWinsock.TabIndex = 12;
            this.btnResetWinsock.Text = "重設 Winsock";
            this.btnResetWinsock.UseVisualStyleBackColor = true;
            this.btnResetWinsock.Click += new System.EventHandler(this.btnResetWinsock_Click);
            // 
            // btnFlushDNS
            // 
            this.btnFlushDNS.Location = new System.Drawing.Point(215, 605);
            this.btnFlushDNS.Name = "btnFlushDNS";
            this.btnFlushDNS.Size = new System.Drawing.Size(100, 23);
            this.btnFlushDNS.TabIndex = 10;
            this.btnFlushDNS.Text = "清除 DNS 快取";
            this.btnFlushDNS.UseVisualStyleBackColor = true;
            this.btnFlushDNS.Click += new System.EventHandler(this.btnFlushDNS_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(15, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(105, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "網路診斷工具";
            // 
            // btnResetTcpIp
            // 
            this.btnResetTcpIp.Location = new System.Drawing.Point(335, 605);
            this.btnResetTcpIp.Name = "btnResetTcpIp";
            this.btnResetTcpIp.Size = new System.Drawing.Size(100, 23);
            this.btnResetTcpIp.TabIndex = 11;
            this.btnResetTcpIp.Text = "重設 TCP / IP";
            this.btnResetTcpIp.UseVisualStyleBackColor = true;
            this.btnResetTcpIp.Click += new System.EventHandler(this.btnResetTcpIp_Click);
            // 
            // PingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(619, 661);
            this.Controls.Add(this.btnResetTcpIp);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnFlushDNS);
            this.Controls.Add(this.btnResetWinsock);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.btnExecuteTraceRouter);
            this.Controls.Add(this.btnExecutePing);
            this.Controls.Add(this.txtTraceRouter);
            this.Controls.Add(this.txtPing);
            this.Controls.Add(this.labelTraceRouter);
            this.Controls.Add(this.labelPing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "PingForm";
            this.Text = "網路診斷工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPing;
        private System.Windows.Forms.Label labelTraceRouter;
        private System.Windows.Forms.TextBox txtPing;
        private System.Windows.Forms.TextBox txtTraceRouter;
        private System.Windows.Forms.Button btnExecutePing;
        private System.Windows.Forms.Button btnExecuteTraceRouter;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnResetWinsock;
        private System.Windows.Forms.Button btnFlushDNS;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnResetTcpIp;
    }
}