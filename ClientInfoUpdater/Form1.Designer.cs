namespace ClientInfoUpdater
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDNS = new System.Windows.Forms.Button();
            this.buttonLocalHost = new System.Windows.Forms.Button();
            this.buttonIP = new System.Windows.Forms.Button();
            this.buttonPort = new System.Windows.Forms.Button();
            this.textBoxDNSHost = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxLocalHost = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxClientInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDNS
            // 
            this.buttonDNS.Location = new System.Drawing.Point(12, 33);
            this.buttonDNS.Name = "buttonDNS";
            this.buttonDNS.Size = new System.Drawing.Size(75, 23);
            this.buttonDNS.TabIndex = 0;
            this.buttonDNS.Text = "DNS IP更新";
            this.buttonDNS.UseVisualStyleBackColor = true;
            this.buttonDNS.Click += new System.EventHandler(this.buttonDNS_Click);
            // 
            // buttonLocalHost
            // 
            this.buttonLocalHost.Location = new System.Drawing.Point(12, 62);
            this.buttonLocalHost.Name = "buttonLocalHost";
            this.buttonLocalHost.Size = new System.Drawing.Size(75, 23);
            this.buttonLocalHost.TabIndex = 1;
            this.buttonLocalHost.Text = "LocalHost";
            this.buttonLocalHost.UseVisualStyleBackColor = true;
            this.buttonLocalHost.Click += new System.EventHandler(this.buttonLocalHost_Click);
            // 
            // buttonIP
            // 
            this.buttonIP.Location = new System.Drawing.Point(12, 91);
            this.buttonIP.Name = "buttonIP";
            this.buttonIP.Size = new System.Drawing.Size(75, 23);
            this.buttonIP.TabIndex = 2;
            this.buttonIP.Text = "IP指定";
            this.buttonIP.UseVisualStyleBackColor = true;
            this.buttonIP.Click += new System.EventHandler(this.buttonIP_Click);
            // 
            // buttonPort
            // 
            this.buttonPort.Location = new System.Drawing.Point(12, 120);
            this.buttonPort.Name = "buttonPort";
            this.buttonPort.Size = new System.Drawing.Size(75, 23);
            this.buttonPort.TabIndex = 3;
            this.buttonPort.Text = "Port指定";
            this.buttonPort.UseVisualStyleBackColor = true;
            this.buttonPort.Click += new System.EventHandler(this.buttonPort_Click);
            // 
            // textBoxDNSHost
            // 
            this.textBoxDNSHost.Location = new System.Drawing.Point(93, 35);
            this.textBoxDNSHost.Name = "textBoxDNSHost";
            this.textBoxDNSHost.Size = new System.Drawing.Size(287, 19);
            this.textBoxDNSHost.TabIndex = 4;
            this.textBoxDNSHost.TextChanged += new System.EventHandler(this.textBoxDNSHost_TextChanged);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(93, 93);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(287, 19);
            this.textBoxIP.TabIndex = 6;
            this.textBoxIP.TextChanged += new System.EventHandler(this.textBoxIP_TextChanged);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(93, 122);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(287, 19);
            this.textBoxPort.TabIndex = 7;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // textBoxLocalHost
            // 
            this.textBoxLocalHost.Location = new System.Drawing.Point(93, 64);
            this.textBoxLocalHost.Name = "textBoxLocalHost";
            this.textBoxLocalHost.Size = new System.Drawing.Size(287, 19);
            this.textBoxLocalHost.TabIndex = 5;
            this.textBoxLocalHost.TextChanged += new System.EventHandler(this.textBoxLocalHost_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 182);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(368, 79);
            this.textBoxResult.TabIndex = 8;
            // 
            // textBoxClientInfo
            // 
            this.textBoxClientInfo.Location = new System.Drawing.Point(93, 10);
            this.textBoxClientInfo.Name = "textBoxClientInfo";
            this.textBoxClientInfo.Size = new System.Drawing.Size(287, 19);
            this.textBoxClientInfo.TabIndex = 9;
            this.textBoxClientInfo.TextChanged += new System.EventHandler(this.textBoxClientInfo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "clientinfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "実行結果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClientInfo);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.textBoxLocalHost);
            this.Controls.Add(this.textBoxDNSHost);
            this.Controls.Add(this.buttonPort);
            this.Controls.Add(this.buttonIP);
            this.Controls.Add(this.buttonLocalHost);
            this.Controls.Add(this.buttonDNS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ClientInfoUpdater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDNS;
        private System.Windows.Forms.Button buttonLocalHost;
        private System.Windows.Forms.Button buttonIP;
        private System.Windows.Forms.Button buttonPort;
        private System.Windows.Forms.TextBox textBoxDNSHost;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxLocalHost;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxClientInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

