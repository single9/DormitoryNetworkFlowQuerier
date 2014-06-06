namespace DormitoryNetworkFlowQuerier
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbFlowIn = new System.Windows.Forms.Label();
            this.lbFlowOut = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.rtbIn = new System.Windows.Forms.RichTextBox();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.lbInValue = new System.Windows.Forms.Label();
            this.lbOutValue = new System.Windows.Forms.Label();
            this.cbM = new System.Windows.Forms.ComboBox();
            this.cbD = new System.Windows.Forms.ComboBox();
            this.cbH = new System.Windows.Forms.ComboBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lbSingle9 = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFlowIn
            // 
            this.lbFlowIn.AutoSize = true;
            this.lbFlowIn.Location = new System.Drawing.Point(24, 154);
            this.lbFlowIn.Name = "lbFlowIn";
            this.lbFlowIn.Size = new System.Drawing.Size(31, 13);
            this.lbFlowIn.TabIndex = 1;
            this.lbFlowIn.Text = "上傳";
            // 
            // lbFlowOut
            // 
            this.lbFlowOut.AutoSize = true;
            this.lbFlowOut.Location = new System.Drawing.Point(24, 17);
            this.lbFlowOut.Name = "lbFlowOut";
            this.lbFlowOut.Size = new System.Drawing.Size(31, 13);
            this.lbFlowOut.TabIndex = 2;
            this.lbFlowOut.Text = "下載";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(16, 282);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(42, 13);
            this.lbIP.TabIndex = 3;
            this.lbIP.Text = "Your IP";
            // 
            // rtbIn
            // 
            this.rtbIn.Location = new System.Drawing.Point(27, 33);
            this.rtbIn.Name = "rtbIn";
            this.rtbIn.Size = new System.Drawing.Size(368, 102);
            this.rtbIn.TabIndex = 6;
            this.rtbIn.TabStop = false;
            this.rtbIn.Text = "";
            // 
            // rtbOut
            // 
            this.rtbOut.Location = new System.Drawing.Point(27, 170);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(368, 102);
            this.rtbOut.TabIndex = 7;
            this.rtbOut.TabStop = false;
            this.rtbOut.Text = "";
            // 
            // lbInValue
            // 
            this.lbInValue.AutoSize = true;
            this.lbInValue.Location = new System.Drawing.Point(337, 17);
            this.lbInValue.Name = "lbInValue";
            this.lbInValue.Size = new System.Drawing.Size(28, 13);
            this.lbInValue.TabIndex = 9;
            this.lbInValue.Text = "XXX";
            // 
            // lbOutValue
            // 
            this.lbOutValue.AutoSize = true;
            this.lbOutValue.Location = new System.Drawing.Point(337, 154);
            this.lbOutValue.Name = "lbOutValue";
            this.lbOutValue.Size = new System.Drawing.Size(28, 13);
            this.lbOutValue.TabIndex = 10;
            this.lbOutValue.Text = "XXX";
            // 
            // cbM
            // 
            this.cbM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbM.FormattingEnabled = true;
            this.cbM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbM.Location = new System.Drawing.Point(154, 279);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(45, 21);
            this.cbM.TabIndex = 2;
            this.toolTip.SetToolTip(this.cbM, "月份");
            // 
            // cbD
            // 
            this.cbD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbD.FormattingEnabled = true;
            this.cbD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbD.Location = new System.Drawing.Point(205, 279);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(46, 21);
            this.cbD.TabIndex = 3;
            this.toolTip.SetToolTip(this.cbD, "日期");
            // 
            // cbH
            // 
            this.cbH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbH.FormattingEnabled = true;
            this.cbH.Items.AddRange(new object[] {
            "daily",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbH.Location = new System.Drawing.Point(257, 279);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(45, 21);
            this.cbH.TabIndex = 4;
            this.toolTip.SetToolTip(this.cbH, "小時");
            // 
            // btnGet
            // 
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Location = new System.Drawing.Point(305, 278);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(45, 23);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "查詢";
            this.toolTip.SetToolTip(this.btnGet, "查詢所選定的IP及所選的時間");
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnToday
            // 
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Location = new System.Drawing.Point(349, 278);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(45, 23);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "今天";
            this.toolTip.SetToolTip(this.btnToday, "這台電腦至目前為止的紀錄");
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // tbIP
            // 
            this.tbIP.BackColor = System.Drawing.Color.White;
            this.tbIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIP.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbIP.Location = new System.Drawing.Point(64, 282);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(84, 13);
            this.tbIP.TabIndex = 1;
            this.toolTip.SetToolTip(this.tbIP, "你的或欲查詢的IP位址");
            // 
            // lbSingle9
            // 
            this.lbSingle9.AutoSize = true;
            this.lbSingle9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSingle9.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSingle9.ForeColor = System.Drawing.Color.Silver;
            this.lbSingle9.Location = new System.Drawing.Point(282, 304);
            this.lbSingle9.Name = "lbSingle9";
            this.lbSingle9.Size = new System.Drawing.Size(116, 15);
            this.lbSingle9.TabIndex = 11;
            this.lbSingle9.Text = "Designed by Single.9";
            this.toolTip.SetToolTip(this.lbSingle9, "拜訪設計者網站");
            this.lbSingle9.Click += new System.EventHandler(this.lbSingle9_Click);
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFrom.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFrom.ForeColor = System.Drawing.Color.LightGray;
            this.lbFrom.Location = new System.Drawing.Point(16, 304);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(192, 15);
            this.lbFrom.TabIndex = 12;
            this.lbFrom.Text = "Data via STU Dorm Network System";
            this.lbFrom.Click += new System.EventHandler(this.lbFrom_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 318);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbSingle9);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.cbH);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.cbM);
            this.Controls.Add(this.lbOutValue);
            this.Controls.Add(this.lbInValue);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.rtbIn);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.lbFlowOut);
            this.Controls.Add(this.lbFlowIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Network Flow Querier";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFlowIn;
        private System.Windows.Forms.Label lbFlowOut;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.RichTextBox rtbIn;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Label lbInValue;
        private System.Windows.Forms.Label lbOutValue;
        private System.Windows.Forms.ComboBox cbM;
        private System.Windows.Forms.ComboBox cbD;
        private System.Windows.Forms.ComboBox cbH;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lbSingle9;
        private System.Windows.Forms.Label lbFrom;
    }
}

