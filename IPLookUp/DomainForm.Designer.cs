namespace IPLookUp
{
    partial class DomainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DomainForm));
            this.labelInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tcResult = new System.Windows.Forms.TabControl();
            this.tpWhois = new System.Windows.Forms.TabPage();
            this.txtWhois = new System.Windows.Forms.TextBox();
            this.tpDNSRecord = new System.Windows.Forms.TabPage();
            this.txtDNSRecord = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tcResult.SuspendLayout();
            this.tpWhois.SuspendLayout();
            this.tpDNSRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(60, 65);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(53, 12);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "輸入域名";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(125, 62);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(385, 22);
            this.txtInput.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(435, 95);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tcResult
            // 
            this.tcResult.Controls.Add(this.tpWhois);
            this.tcResult.Controls.Add(this.tpDNSRecord);
            this.tcResult.Location = new System.Drawing.Point(62, 135);
            this.tcResult.Name = "tcResult";
            this.tcResult.SelectedIndex = 0;
            this.tcResult.Size = new System.Drawing.Size(448, 500);
            this.tcResult.TabIndex = 4;
            // 
            // tpWhois
            // 
            this.tpWhois.Controls.Add(this.txtWhois);
            this.tpWhois.Location = new System.Drawing.Point(4, 22);
            this.tpWhois.Name = "tpWhois";
            this.tpWhois.Padding = new System.Windows.Forms.Padding(3);
            this.tpWhois.Size = new System.Drawing.Size(440, 474);
            this.tpWhois.TabIndex = 0;
            this.tpWhois.Text = "WHOIS 資訊";
            this.tpWhois.UseVisualStyleBackColor = true;
            // 
            // txtWhois
            // 
            this.txtWhois.BackColor = System.Drawing.Color.White;
            this.txtWhois.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWhois.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWhois.Location = new System.Drawing.Point(3, 3);
            this.txtWhois.Multiline = true;
            this.txtWhois.Name = "txtWhois";
            this.txtWhois.ReadOnly = true;
            this.txtWhois.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWhois.Size = new System.Drawing.Size(434, 468);
            this.txtWhois.TabIndex = 0;
            this.txtWhois.Text = "正在等待查詢 ...";
            // 
            // tpDNSRecord
            // 
            this.tpDNSRecord.Controls.Add(this.txtDNSRecord);
            this.tpDNSRecord.Location = new System.Drawing.Point(4, 22);
            this.tpDNSRecord.Name = "tpDNSRecord";
            this.tpDNSRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tpDNSRecord.Size = new System.Drawing.Size(440, 474);
            this.tpDNSRecord.TabIndex = 1;
            this.tpDNSRecord.Text = "DNS 紀錄";
            this.tpDNSRecord.UseVisualStyleBackColor = true;
            // 
            // txtDNSRecord
            // 
            this.txtDNSRecord.BackColor = System.Drawing.Color.White;
            this.txtDNSRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDNSRecord.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDNSRecord.Location = new System.Drawing.Point(3, 3);
            this.txtDNSRecord.Multiline = true;
            this.txtDNSRecord.Name = "txtDNSRecord";
            this.txtDNSRecord.ReadOnly = true;
            this.txtDNSRecord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDNSRecord.Size = new System.Drawing.Size(434, 468);
            this.txtDNSRecord.TabIndex = 0;
            this.txtDNSRecord.Text = "正在等待查詢 ...";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(15, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(143, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DNS 資訊查詢工具";
            // 
            // DomainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(564, 666);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tcResult);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "DomainForm";
            this.Text = "DNS 資訊查詢工具";
            this.tcResult.ResumeLayout(false);
            this.tpWhois.ResumeLayout(false);
            this.tpWhois.PerformLayout();
            this.tpDNSRecord.ResumeLayout(false);
            this.tpDNSRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TabControl tcResult;
        private System.Windows.Forms.TabPage tpWhois;
        private System.Windows.Forms.TabPage tpDNSRecord;
        private System.Windows.Forms.TextBox txtDNSRecord;
        private System.Windows.Forms.TextBox txtWhois;
        private System.Windows.Forms.Label labelTitle;
    }
}