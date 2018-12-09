namespace Ruby_Tool
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TBRuby = new System.Windows.Forms.TextBox();
            this.TBText = new System.Windows.Forms.TextBox();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.CBEncoding = new System.Windows.Forms.ComboBox();
            this.BtnCpy = new System.Windows.Forms.Button();
            this.LblEncoding = new System.Windows.Forms.Label();
            this.LblRuby = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
            this.GBSetting = new System.Windows.Forms.GroupBox();
            this.TBFmt = new System.Windows.Forms.TextBox();
            this.LblFmt = new System.Windows.Forms.Label();
            this.CBTop = new System.Windows.Forms.CheckBox();
            this.TBGroupName = new System.Windows.Forms.TextBox();
            this.LblGroupName = new System.Windows.Forms.Label();
            this.TBClassName = new System.Windows.Forms.TextBox();
            this.LblClassName = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnExchange = new System.Windows.Forms.Button();
            this.GBSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBRuby
            // 
            this.TBRuby.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBRuby.Location = new System.Drawing.Point(59, 120);
            this.TBRuby.Name = "TBRuby";
            this.TBRuby.Size = new System.Drawing.Size(242, 21);
            this.TBRuby.TabIndex = 0;
            this.TBRuby.TextChanged += new System.EventHandler(this.TBRuby_TextChanged);
            // 
            // TBText
            // 
            this.TBText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBText.Location = new System.Drawing.Point(59, 147);
            this.TBText.Name = "TBText";
            this.TBText.Size = new System.Drawing.Size(242, 21);
            this.TBText.TabIndex = 1;
            this.TBText.TextChanged += new System.EventHandler(this.TBText_TextChanged);
            // 
            // TBOutput
            // 
            this.TBOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOutput.Location = new System.Drawing.Point(59, 174);
            this.TBOutput.Multiline = true;
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.ReadOnly = true;
            this.TBOutput.Size = new System.Drawing.Size(295, 73);
            this.TBOutput.TabIndex = 2;
            this.TBOutput.TextChanged += new System.EventHandler(this.TBOutput_TextChanged);
            // 
            // CBEncoding
            // 
            this.CBEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEncoding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBEncoding.FormattingEnabled = true;
            this.CBEncoding.Items.AddRange(new object[] {
            "Unicode",
            "UTF-8",
            "Shift-JIS"});
            this.CBEncoding.Location = new System.Drawing.Point(239, 14);
            this.CBEncoding.Name = "CBEncoding";
            this.CBEncoding.Size = new System.Drawing.Size(93, 20);
            this.CBEncoding.TabIndex = 3;
            this.CBEncoding.SelectedIndexChanged += new System.EventHandler(this.CBEncoding_SelectedIndexChanged);
            // 
            // BtnCpy
            // 
            this.BtnCpy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCpy.Location = new System.Drawing.Point(279, 253);
            this.BtnCpy.Name = "BtnCpy";
            this.BtnCpy.Size = new System.Drawing.Size(75, 23);
            this.BtnCpy.TabIndex = 4;
            this.BtnCpy.Text = "复制";
            this.BtnCpy.UseVisualStyleBackColor = true;
            this.BtnCpy.Click += new System.EventHandler(this.BtnCpy_Click);
            // 
            // LblEncoding
            // 
            this.LblEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEncoding.AutoSize = true;
            this.LblEncoding.Location = new System.Drawing.Point(192, 17);
            this.LblEncoding.Name = "LblEncoding";
            this.LblEncoding.Size = new System.Drawing.Size(41, 12);
            this.LblEncoding.TabIndex = 5;
            this.LblEncoding.Text = "编码：";
            // 
            // LblRuby
            // 
            this.LblRuby.AutoSize = true;
            this.LblRuby.Location = new System.Drawing.Point(12, 123);
            this.LblRuby.Name = "LblRuby";
            this.LblRuby.Size = new System.Drawing.Size(41, 12);
            this.LblRuby.TabIndex = 6;
            this.LblRuby.Text = "注音：";
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Location = new System.Drawing.Point(12, 150);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(41, 12);
            this.LblText.TabIndex = 7;
            this.LblText.Text = "文本：";
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(12, 177);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(41, 12);
            this.LblOutput.TabIndex = 8;
            this.LblOutput.Text = "输出：";
            // 
            // GBSetting
            // 
            this.GBSetting.Controls.Add(this.TBFmt);
            this.GBSetting.Controls.Add(this.LblFmt);
            this.GBSetting.Controls.Add(this.CBTop);
            this.GBSetting.Controls.Add(this.TBGroupName);
            this.GBSetting.Controls.Add(this.LblGroupName);
            this.GBSetting.Controls.Add(this.TBClassName);
            this.GBSetting.Controls.Add(this.LblClassName);
            this.GBSetting.Controls.Add(this.CBEncoding);
            this.GBSetting.Controls.Add(this.LblEncoding);
            this.GBSetting.Location = new System.Drawing.Point(12, 12);
            this.GBSetting.Name = "GBSetting";
            this.GBSetting.Size = new System.Drawing.Size(342, 99);
            this.GBSetting.TabIndex = 9;
            this.GBSetting.TabStop = false;
            this.GBSetting.Text = "输出设置";
            // 
            // TBFmt
            // 
            this.TBFmt.Location = new System.Drawing.Point(59, 67);
            this.TBFmt.Name = "TBFmt";
            this.TBFmt.Size = new System.Drawing.Size(273, 21);
            this.TBFmt.TabIndex = 12;
            this.TBFmt.Text = "<{class}.{group}:{data}>";
            // 
            // LblFmt
            // 
            this.LblFmt.AutoSize = true;
            this.LblFmt.Location = new System.Drawing.Point(6, 70);
            this.LblFmt.Name = "LblFmt";
            this.LblFmt.Size = new System.Drawing.Size(41, 12);
            this.LblFmt.TabIndex = 11;
            this.LblFmt.Text = "格式：";
            // 
            // CBTop
            // 
            this.CBTop.AutoSize = true;
            this.CBTop.Location = new System.Drawing.Point(194, 42);
            this.CBTop.Name = "CBTop";
            this.CBTop.Size = new System.Drawing.Size(72, 16);
            this.CBTop.TabIndex = 10;
            this.CBTop.Text = "窗口置顶";
            this.CBTop.UseVisualStyleBackColor = true;
            this.CBTop.CheckedChanged += new System.EventHandler(this.CBTop_CheckedChanged);
            // 
            // TBGroupName
            // 
            this.TBGroupName.Location = new System.Drawing.Point(59, 40);
            this.TBGroupName.Name = "TBGroupName";
            this.TBGroupName.Size = new System.Drawing.Size(100, 21);
            this.TBGroupName.TabIndex = 9;
            this.TBGroupName.Text = "00";
            this.TBGroupName.TextChanged += new System.EventHandler(this.TBRuby_TextChanged);
            // 
            // LblGroupName
            // 
            this.LblGroupName.AutoSize = true;
            this.LblGroupName.Location = new System.Drawing.Point(6, 43);
            this.LblGroupName.Name = "LblGroupName";
            this.LblGroupName.Size = new System.Drawing.Size(47, 12);
            this.LblGroupName.TabIndex = 8;
            this.LblGroupName.Text = "Group：";
            // 
            // TBClassName
            // 
            this.TBClassName.Location = new System.Drawing.Point(59, 14);
            this.TBClassName.Name = "TBClassName";
            this.TBClassName.Size = new System.Drawing.Size(100, 21);
            this.TBClassName.TabIndex = 7;
            this.TBClassName.Text = "00";
            this.TBClassName.TextChanged += new System.EventHandler(this.TBRuby_TextChanged);
            // 
            // LblClassName
            // 
            this.LblClassName.AutoSize = true;
            this.LblClassName.Location = new System.Drawing.Point(6, 17);
            this.LblClassName.Name = "LblClassName";
            this.LblClassName.Size = new System.Drawing.Size(47, 12);
            this.LblClassName.TabIndex = 6;
            this.LblClassName.Text = "Class：";
            // 
            // LblInfo
            // 
            this.LblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(57, 253);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(0, 12);
            this.LblInfo.TabIndex = 10;
            // 
            // BtnExchange
            // 
            this.BtnExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExchange.Location = new System.Drawing.Point(308, 117);
            this.BtnExchange.Name = "BtnExchange";
            this.BtnExchange.Size = new System.Drawing.Size(46, 51);
            this.BtnExchange.TabIndex = 11;
            this.BtnExchange.Text = "↑↓";
            this.BtnExchange.UseVisualStyleBackColor = true;
            this.BtnExchange.Click += new System.EventHandler(this.BtnExchange_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 288);
            this.Controls.Add(this.BtnExchange);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.GBSetting);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.LblRuby);
            this.Controls.Add(this.BtnCpy);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.TBText);
            this.Controls.Add(this.TBRuby);
            this.Name = "FrmMain";
            this.Text = "Ruby Tool";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.GBSetting.ResumeLayout(false);
            this.GBSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBRuby;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.ComboBox CBEncoding;
        private System.Windows.Forms.Button BtnCpy;
        private System.Windows.Forms.Label LblEncoding;
        private System.Windows.Forms.Label LblRuby;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.GroupBox GBSetting;
        private System.Windows.Forms.CheckBox CBTop;
        private System.Windows.Forms.TextBox TBGroupName;
        private System.Windows.Forms.Label LblGroupName;
        private System.Windows.Forms.TextBox TBClassName;
        private System.Windows.Forms.Label LblClassName;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button BtnExchange;
        private System.Windows.Forms.TextBox TBFmt;
        private System.Windows.Forms.Label LblFmt;
    }
}

