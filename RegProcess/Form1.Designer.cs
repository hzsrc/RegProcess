using System.Drawing;
using System.Windows.Forms;

namespace RegProcess
{
    partial class Form1
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
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btPaste = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.lab = new System.Windows.Forms.TextBox();
            this.btBat = new System.Windows.Forms.Button();
            this.btBrowser = new System.Windows.Forms.Button();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSrc
            // 
            this.tbSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSrc.Location = new System.Drawing.Point(0, 0);
            this.tbSrc.MaxLength = 0;
            this.tbSrc.Multiline = true;
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSrc.Size = new System.Drawing.Size(710, 134);
            this.tbSrc.TabIndex = 0;
            this.tbSrc.WordWrap = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tComboBox,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tComboBox
            // 
            this.tComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tComboBox.DropDownWidth = 421;
            this.tComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tComboBox.Name = "tComboBox";
            this.tComboBox.Size = new System.Drawing.Size(161, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "配置";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDesc.Location = new System.Drawing.Point(0, 0);
            this.tbDesc.MaxLength = 0;
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDesc.Size = new System.Drawing.Size(710, 304);
            this.tbDesc.TabIndex = 0;
            this.tbDesc.WordWrap = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbSrc);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbDesc);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(710, 442);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(730, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "执行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPaste
            // 
            this.btPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPaste.Location = new System.Drawing.Point(730, 12);
            this.btPaste.Name = "btPaste";
            this.btPaste.Size = new System.Drawing.Size(56, 26);
            this.btPaste.TabIndex = 4;
            this.btPaste.Text = "粘贴";
            this.btPaste.UseVisualStyleBackColor = true;
            this.btPaste.Click += new System.EventHandler(this.btPaste_Click);
            // 
            // btCopy
            // 
            this.btCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopy.Location = new System.Drawing.Point(730, 291);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(56, 26);
            this.btCopy.TabIndex = 5;
            this.btCopy.Text = "复制";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabText);
            this.tabs.Controls.Add(this.tabFile);
            this.tabs.Location = new System.Drawing.Point(2, 27);
            this.tabs.Margin = new System.Windows.Forms.Padding(2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(798, 472);
            this.tabs.TabIndex = 6;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.btCopy);
            this.tabText.Controls.Add(this.splitContainer1);
            this.tabText.Controls.Add(this.btPaste);
            this.tabText.Controls.Add(this.button1);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Margin = new System.Windows.Forms.Padding(2);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(2);
            this.tabText.Size = new System.Drawing.Size(790, 446);
            this.tabText.TabIndex = 1;
            this.tabText.Text = "文本";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.lab);
            this.tabFile.Controls.Add(this.btBat);
            this.tabFile.Controls.Add(this.btBrowser);
            this.tabFile.Controls.Add(this.tbPattern);
            this.tabFile.Controls.Add(this.tbDir);
            this.tabFile.Controls.Add(this.label2);
            this.tabFile.Controls.Add(this.label1);
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Margin = new System.Windows.Forms.Padding(2);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(2);
            this.tabFile.Size = new System.Drawing.Size(790, 446);
            this.tabFile.TabIndex = 0;
            this.tabFile.Text = "文件批量处理";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // lab
            // 
            this.lab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab.BackColor = System.Drawing.SystemColors.Control;
            this.lab.Location = new System.Drawing.Point(12, 119);
            this.lab.MaxLength = 0;
            this.lab.Multiline = true;
            this.lab.Name = "lab";
            this.lab.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lab.Size = new System.Drawing.Size(766, 327);
            this.lab.TabIndex = 3;
            this.lab.WordWrap = false;
            // 
            // btBat
            // 
            this.btBat.Location = new System.Drawing.Point(66, 76);
            this.btBat.Margin = new System.Windows.Forms.Padding(2);
            this.btBat.Name = "btBat";
            this.btBat.Size = new System.Drawing.Size(89, 28);
            this.btBat.TabIndex = 2;
            this.btBat.Text = "开始转换";
            this.btBat.UseVisualStyleBackColor = true;
            this.btBat.Click += new System.EventHandler(this.btBat_Click);
            // 
            // btBrowser
            // 
            this.btBrowser.Location = new System.Drawing.Point(418, 18);
            this.btBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(42, 20);
            this.btBrowser.TabIndex = 2;
            this.btBrowser.Text = "浏览";
            this.btBrowser.UseVisualStyleBackColor = true;
            this.btBrowser.Click += new System.EventHandler(this.btBrowser_Click);
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(66, 46);
            this.tbPattern.Margin = new System.Windows.Forms.Padding(2);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(352, 21);
            this.tbPattern.TabIndex = 1;
            this.tbPattern.Text = "*.cs;*.java";
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(66, 18);
            this.tbDir.Margin = new System.Windows.Forms.Padding(2);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(352, 21);
            this.tbDir.TabIndex = 1;
            this.tbDir.Text = "D:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "匹配";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正则处理器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabFile.ResumeLayout(false);
            this.tabFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbSrc;


        private TextBox tbDesc;





        private Button btPaste;
        private Button btCopy;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripComboBox tComboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private TabControl tabs;
        private TabPage tabText;
        private TabPage tabFile;
        private Label label1;
        private Button btBrowser;
        private TextBox tbDir;
        private TextBox tbPattern;
        private Label label2;
        private Button btBat;
        private TextBox lab;
    }
}

