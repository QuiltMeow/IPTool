namespace IPLookUp
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tcResult = new System.Windows.Forms.TabControl();
            this.tpGeoIP = new System.Windows.Forms.TabPage();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnCopyGeoIP = new System.Windows.Forms.Button();
            this.labelGeoIP = new System.Windows.Forms.Label();
            this.tpQQWry = new System.Windows.Forms.TabPage();
            this.btnCopyQQWry = new System.Windows.Forms.Button();
            this.labelQQWry = new System.Windows.Forms.Label();
            this.tpReverse = new System.Windows.Forms.TabPage();
            this.txtReverse = new System.Windows.Forms.TextBox();
            this.btnDNSTool = new System.Windows.Forms.Button();
            this.btnDiagnosticTool = new System.Windows.Forms.Button();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timerNetworkStatus = new System.Windows.Forms.Timer(this.components);
            this.btnIP = new System.Windows.Forms.Button();
            this.btnWake = new System.Windows.Forms.Button();
            this.btnSpeedTest = new System.Windows.Forms.Button();
            this.tcResult.SuspendLayout();
            this.tpGeoIP.SuspendLayout();
            this.tpQQWry.SuspendLayout();
            this.tpReverse.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(50, 75);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(81, 12);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "輸入 IP 或域名";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(150, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(415, 22);
            this.txtInput.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(385, 105);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tcResult
            // 
            this.tcResult.Controls.Add(this.tpGeoIP);
            this.tcResult.Controls.Add(this.tpQQWry);
            this.tcResult.Controls.Add(this.tpReverse);
            this.tcResult.Location = new System.Drawing.Point(52, 145);
            this.tcResult.Name = "tcResult";
            this.tcResult.SelectedIndex = 0;
            this.tcResult.Size = new System.Drawing.Size(513, 275);
            this.tcResult.TabIndex = 6;
            // 
            // tpGeoIP
            // 
            this.tpGeoIP.Controls.Add(this.btnMap);
            this.tpGeoIP.Controls.Add(this.btnCopyGeoIP);
            this.tpGeoIP.Controls.Add(this.labelGeoIP);
            this.tpGeoIP.Location = new System.Drawing.Point(4, 22);
            this.tpGeoIP.Name = "tpGeoIP";
            this.tpGeoIP.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeoIP.Size = new System.Drawing.Size(505, 249);
            this.tpGeoIP.TabIndex = 0;
            this.tpGeoIP.Text = "Geo IP 查詢結果";
            this.tpGeoIP.UseVisualStyleBackColor = true;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(335, 215);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 1;
            this.btnMap.Text = "地圖檢視";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnCopyGeoIP
            // 
            this.btnCopyGeoIP.Location = new System.Drawing.Point(420, 215);
            this.btnCopyGeoIP.Name = "btnCopyGeoIP";
            this.btnCopyGeoIP.Size = new System.Drawing.Size(75, 23);
            this.btnCopyGeoIP.TabIndex = 2;
            this.btnCopyGeoIP.Text = "複製資訊";
            this.btnCopyGeoIP.UseVisualStyleBackColor = true;
            this.btnCopyGeoIP.Click += new System.EventHandler(this.btnCopyGeoIP_Click);
            // 
            // labelGeoIP
            // 
            this.labelGeoIP.AutoSize = true;
            this.labelGeoIP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGeoIP.Location = new System.Drawing.Point(15, 15);
            this.labelGeoIP.Name = "labelGeoIP";
            this.labelGeoIP.Size = new System.Drawing.Size(121, 20);
            this.labelGeoIP.TabIndex = 0;
            this.labelGeoIP.Text = "正在等待查詢 ...";
            // 
            // tpQQWry
            // 
            this.tpQQWry.Controls.Add(this.btnCopyQQWry);
            this.tpQQWry.Controls.Add(this.labelQQWry);
            this.tpQQWry.Location = new System.Drawing.Point(4, 22);
            this.tpQQWry.Name = "tpQQWry";
            this.tpQQWry.Padding = new System.Windows.Forms.Padding(3);
            this.tpQQWry.Size = new System.Drawing.Size(505, 249);
            this.tpQQWry.TabIndex = 1;
            this.tpQQWry.Text = "QQWry 查詢結果";
            this.tpQQWry.UseVisualStyleBackColor = true;
            // 
            // btnCopyQQWry
            // 
            this.btnCopyQQWry.Location = new System.Drawing.Point(420, 215);
            this.btnCopyQQWry.Name = "btnCopyQQWry";
            this.btnCopyQQWry.Size = new System.Drawing.Size(75, 23);
            this.btnCopyQQWry.TabIndex = 1;
            this.btnCopyQQWry.Text = "複製資訊";
            this.btnCopyQQWry.UseVisualStyleBackColor = true;
            this.btnCopyQQWry.Click += new System.EventHandler(this.btnCopyQQWry_Click);
            // 
            // labelQQWry
            // 
            this.labelQQWry.AutoSize = true;
            this.labelQQWry.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelQQWry.Location = new System.Drawing.Point(15, 15);
            this.labelQQWry.Name = "labelQQWry";
            this.labelQQWry.Size = new System.Drawing.Size(121, 20);
            this.labelQQWry.TabIndex = 0;
            this.labelQQWry.Text = "正在等待查詢 ...";
            // 
            // tpReverse
            // 
            this.tpReverse.Controls.Add(this.txtReverse);
            this.tpReverse.Location = new System.Drawing.Point(4, 22);
            this.tpReverse.Name = "tpReverse";
            this.tpReverse.Size = new System.Drawing.Size(505, 249);
            this.tpReverse.TabIndex = 3;
            this.tpReverse.Text = "反查結果";
            this.tpReverse.UseVisualStyleBackColor = true;
            // 
            // txtReverse
            // 
            this.txtReverse.BackColor = System.Drawing.Color.White;
            this.txtReverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReverse.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReverse.Location = new System.Drawing.Point(0, 0);
            this.txtReverse.Multiline = true;
            this.txtReverse.Name = "txtReverse";
            this.txtReverse.ReadOnly = true;
            this.txtReverse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReverse.Size = new System.Drawing.Size(505, 249);
            this.txtReverse.TabIndex = 0;
            this.txtReverse.Text = "正在等待查詢 ...";
            // 
            // btnDNSTool
            // 
            this.btnDNSTool.Location = new System.Drawing.Point(490, 105);
            this.btnDNSTool.Name = "btnDNSTool";
            this.btnDNSTool.Size = new System.Drawing.Size(75, 23);
            this.btnDNSTool.TabIndex = 5;
            this.btnDNSTool.Text = "DNS 工具";
            this.btnDNSTool.UseVisualStyleBackColor = true;
            this.btnDNSTool.Click += new System.EventHandler(this.btnDNSTool_Click);
            // 
            // btnDiagnosticTool
            // 
            this.btnDiagnosticTool.Location = new System.Drawing.Point(465, 435);
            this.btnDiagnosticTool.Name = "btnDiagnosticTool";
            this.btnDiagnosticTool.Size = new System.Drawing.Size(100, 23);
            this.btnDiagnosticTool.TabIndex = 9;
            this.btnDiagnosticTool.Text = "網路診斷工具";
            this.btnDiagnosticTool.UseVisualStyleBackColor = true;
            this.btnDiagnosticTool.Click += new System.EventHandler(this.btnDiagnosticTool_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.SystemColors.Control;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 489);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(609, 22);
            this.ssStatus.SizingGrip = false;
            this.ssStatus.TabIndex = 10;
            this.ssStatus.Text = "狀態列";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(112, 17);
            this.tsslStatus.Text = "網路狀態 : 等待中 ...";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(15, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(92, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "IP 查詢工具";
            // 
            // timerNetworkStatus
            // 
            this.timerNetworkStatus.Interval = 30000;
            this.timerNetworkStatus.Tick += new System.EventHandler(this.timerNetworkStatus_Tick);
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(52, 105);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(75, 23);
            this.btnIP.TabIndex = 3;
            this.btnIP.Text = "本機 IP";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnWake
            // 
            this.btnWake.Location = new System.Drawing.Point(370, 435);
            this.btnWake.Name = "btnWake";
            this.btnWake.Size = new System.Drawing.Size(75, 23);
            this.btnWake.TabIndex = 8;
            this.btnWake.Text = "網路喚醒";
            this.btnWake.UseVisualStyleBackColor = true;
            this.btnWake.Click += new System.EventHandler(this.btnWake_Click);
            // 
            // btnSpeedTest
            // 
            this.btnSpeedTest.Location = new System.Drawing.Point(52, 435);
            this.btnSpeedTest.Name = "btnSpeedTest";
            this.btnSpeedTest.Size = new System.Drawing.Size(100, 23);
            this.btnSpeedTest.TabIndex = 7;
            this.btnSpeedTest.Text = "網路速度測試";
            this.btnSpeedTest.UseVisualStyleBackColor = true;
            this.btnSpeedTest.Click += new System.EventHandler(this.btnSpeedTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(609, 511);
            this.Controls.Add(this.btnSpeedTest);
            this.Controls.Add(this.btnWake);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.btnDiagnosticTool);
            this.Controls.Add(this.btnDNSTool);
            this.Controls.Add(this.tcResult);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "IP 查詢工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcResult.ResumeLayout(false);
            this.tpGeoIP.ResumeLayout(false);
            this.tpGeoIP.PerformLayout();
            this.tpQQWry.ResumeLayout(false);
            this.tpQQWry.PerformLayout();
            this.tpReverse.ResumeLayout(false);
            this.tpReverse.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TabControl tcResult;
        private System.Windows.Forms.TabPage tpGeoIP;
        private System.Windows.Forms.Label labelGeoIP;
        private System.Windows.Forms.TabPage tpQQWry;
        private System.Windows.Forms.Label labelQQWry;
        private System.Windows.Forms.Button btnDNSTool;
        private System.Windows.Forms.Button btnDiagnosticTool;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Timer timerNetworkStatus;
        private System.Windows.Forms.Button btnCopyGeoIP;
        private System.Windows.Forms.Button btnCopyQQWry;
        private System.Windows.Forms.TabPage tpReverse;
        private System.Windows.Forms.TextBox txtReverse;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnWake;
        private System.Windows.Forms.Button btnSpeedTest;
    }
}

