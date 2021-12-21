namespace IPLookUp
{
    partial class IPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPForm));
            this.labelIP = new System.Windows.Forms.Label();
            this.labelIPv4Tip = new System.Windows.Forms.Label();
            this.labelIPv6Tip = new System.Windows.Forms.Label();
            this.labelIPv4 = new System.Windows.Forms.Label();
            this.labelIPv6 = new System.Windows.Forms.Label();
            this.btnCopyIPv4 = new System.Windows.Forms.Button();
            this.btnCopyIPv6 = new System.Windows.Forms.Button();
            this.txtAdapter = new System.Windows.Forms.TextBox();
            this.labelAdapter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelIP.Location = new System.Drawing.Point(15, 15);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(60, 20);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP 工具";
            // 
            // labelIPv4Tip
            // 
            this.labelIPv4Tip.AutoSize = true;
            this.labelIPv4Tip.Location = new System.Drawing.Point(50, 55);
            this.labelIPv4Tip.Name = "labelIPv4Tip";
            this.labelIPv4Tip.Size = new System.Drawing.Size(27, 12);
            this.labelIPv4Tip.TabIndex = 1;
            this.labelIPv4Tip.Text = "IPv4";
            // 
            // labelIPv6Tip
            // 
            this.labelIPv6Tip.AutoSize = true;
            this.labelIPv6Tip.Location = new System.Drawing.Point(50, 90);
            this.labelIPv6Tip.Name = "labelIPv6Tip";
            this.labelIPv6Tip.Size = new System.Drawing.Size(27, 12);
            this.labelIPv6Tip.TabIndex = 4;
            this.labelIPv6Tip.Text = "IPv6";
            // 
            // labelIPv4
            // 
            this.labelIPv4.AutoSize = true;
            this.labelIPv4.Location = new System.Drawing.Point(100, 55);
            this.labelIPv4.Name = "labelIPv4";
            this.labelIPv4.Size = new System.Drawing.Size(53, 12);
            this.labelIPv4.TabIndex = 2;
            this.labelIPv4.Text = "取得中 ...";
            // 
            // labelIPv6
            // 
            this.labelIPv6.AutoSize = true;
            this.labelIPv6.Location = new System.Drawing.Point(100, 90);
            this.labelIPv6.Name = "labelIPv6";
            this.labelIPv6.Size = new System.Drawing.Size(53, 12);
            this.labelIPv6.TabIndex = 5;
            this.labelIPv6.Text = "取得中 ...";
            // 
            // btnCopyIPv4
            // 
            this.btnCopyIPv4.Location = new System.Drawing.Point(397, 50);
            this.btnCopyIPv4.Name = "btnCopyIPv4";
            this.btnCopyIPv4.Size = new System.Drawing.Size(75, 23);
            this.btnCopyIPv4.TabIndex = 3;
            this.btnCopyIPv4.Text = "複製";
            this.btnCopyIPv4.UseVisualStyleBackColor = true;
            this.btnCopyIPv4.Click += new System.EventHandler(this.btnCopyIPv4_Click);
            // 
            // btnCopyIPv6
            // 
            this.btnCopyIPv6.Location = new System.Drawing.Point(397, 85);
            this.btnCopyIPv6.Name = "btnCopyIPv6";
            this.btnCopyIPv6.Size = new System.Drawing.Size(75, 23);
            this.btnCopyIPv6.TabIndex = 6;
            this.btnCopyIPv6.Text = "複製";
            this.btnCopyIPv6.UseVisualStyleBackColor = true;
            this.btnCopyIPv6.Click += new System.EventHandler(this.btnCopyIPv6_Click);
            // 
            // txtAdapter
            // 
            this.txtAdapter.BackColor = System.Drawing.Color.White;
            this.txtAdapter.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAdapter.Location = new System.Drawing.Point(52, 165);
            this.txtAdapter.Multiline = true;
            this.txtAdapter.Name = "txtAdapter";
            this.txtAdapter.ReadOnly = true;
            this.txtAdapter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdapter.Size = new System.Drawing.Size(420, 335);
            this.txtAdapter.TabIndex = 8;
            this.txtAdapter.Text = "取得中 ...";
            // 
            // labelAdapter
            // 
            this.labelAdapter.AutoSize = true;
            this.labelAdapter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAdapter.Location = new System.Drawing.Point(15, 125);
            this.labelAdapter.Name = "labelAdapter";
            this.labelAdapter.Size = new System.Drawing.Size(89, 20);
            this.labelAdapter.TabIndex = 7;
            this.labelAdapter.Text = "網路卡資訊";
            // 
            // IPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(524, 531);
            this.Controls.Add(this.labelAdapter);
            this.Controls.Add(this.txtAdapter);
            this.Controls.Add(this.btnCopyIPv6);
            this.Controls.Add(this.btnCopyIPv4);
            this.Controls.Add(this.labelIPv6);
            this.Controls.Add(this.labelIPv4);
            this.Controls.Add(this.labelIPv6Tip);
            this.Controls.Add(this.labelIPv4Tip);
            this.Controls.Add(this.labelIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "IPForm";
            this.Text = "IP 工具";
            this.Load += new System.EventHandler(this.IPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelIPv4Tip;
        private System.Windows.Forms.Label labelIPv6Tip;
        private System.Windows.Forms.Label labelIPv4;
        private System.Windows.Forms.Label labelIPv6;
        private System.Windows.Forms.Button btnCopyIPv4;
        private System.Windows.Forms.Button btnCopyIPv6;
        private System.Windows.Forms.TextBox txtAdapter;
        private System.Windows.Forms.Label labelAdapter;
    }
}