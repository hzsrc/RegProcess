using System.ComponentModel;
using System.Windows.Forms;

namespace RegProcess
{
    partial class FmCfg
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


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCfg));
            this.cfgTree = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新建NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.打开OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolNewQItem = new System.Windows.Forms.ToolStripButton();
            this.toolNewRepItem = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btCsSample = new System.Windows.Forms.Button();
            this.rdCSharp = new System.Windows.Forms.RadioButton();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.btQueue = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.chkRegB = new System.Windows.Forms.CheckBox();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.chkGlobal = new System.Windows.Forms.CheckBox();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cfgTree
            // 
            this.cfgTree.AllowDrop = true;
            this.cfgTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgTree.LabelEdit = true;
            this.cfgTree.Location = new System.Drawing.Point(3, 3);
            this.cfgTree.Name = "cfgTree";
            this.cfgTree.Size = new System.Drawing.Size(199, 499);
            this.cfgTree.TabIndex = 0;
            this.cfgTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.cfgTree_AfterLabelEdit);
            this.cfgTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.cfgTree_ItemDrag);
            this.cfgTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cfgTree_AfterSelect);
            this.cfgTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.cfgTree_DragDrop);
            this.cfgTree.DragOver += new System.Windows.Forms.DragEventHandler(this.cfgTree_DragOver);
            this.cfgTree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cfgTree_KeyUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripButton,
            this.打开OToolStripButton,
            this.保存SToolStripButton,
            this.toolStripSeparator1,
            this.toolNewQItem,
            this.toolNewRepItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(950, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 新建NToolStripButton
            // 
            this.新建NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新建NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripButton.Image")));
            this.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripButton.Name = "新建NToolStripButton";
            this.新建NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新建NToolStripButton.Text = "新建(&N)";
            this.新建NToolStripButton.Click += new System.EventHandler(this.新建NToolStripButton_Click);
            // 
            // 打开OToolStripButton
            // 
            this.打开OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripButton.Image")));
            this.打开OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripButton.Name = "打开OToolStripButton";
            this.打开OToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.打开OToolStripButton.Text = "打开(&O)";
            this.打开OToolStripButton.Click += new System.EventHandler(this.打开OToolStripButton_Click);
            // 
            // 保存SToolStripButton
            // 
            this.保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripButton.Image")));
            this.保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripButton.Name = "保存SToolStripButton";
            this.保存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.保存SToolStripButton.Text = "保存(&S)";
            this.保存SToolStripButton.Click += new System.EventHandler(this.保存SToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolNewQItem
            // 
            this.toolNewQItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolNewQItem.Image = ((System.Drawing.Image)(resources.GetObject("toolNewQItem.Image")));
            this.toolNewQItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNewQItem.Name = "toolNewQItem";
            this.toolNewQItem.Size = new System.Drawing.Size(60, 22);
            this.toolNewQItem.Text = "新建队列";
            this.toolNewQItem.Click += new System.EventHandler(this.toolNewQItem_Click);
            // 
            // toolNewRepItem
            // 
            this.toolNewRepItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolNewRepItem.Image = ((System.Drawing.Image)(resources.GetObject("toolNewRepItem.Image")));
            this.toolNewRepItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNewRepItem.Name = "toolNewRepItem";
            this.toolNewRepItem.Size = new System.Drawing.Size(72, 22);
            this.toolNewRepItem.Text = "新建替换项";
            this.toolNewRepItem.Click += new System.EventHandler(this.toolNewRepItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cfgTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(950, 554);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbResult);
            this.splitContainer2.Size = new System.Drawing.Size(741, 554);
            this.splitContainer2.SplitterDistance = 248;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.tbPattern);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tbReplace);
            this.splitContainer3.Panel2.Controls.Add(this.btCsSample);
            this.splitContainer3.Panel2.Controls.Add(this.rdCSharp);
            this.splitContainer3.Panel2.Controls.Add(this.rdNormal);
            this.splitContainer3.Panel2.Controls.Add(this.btQueue);
            this.splitContainer3.Panel2.Controls.Add(this.btTest);
            this.splitContainer3.Panel2.Controls.Add(this.chkRegB);
            this.splitContainer3.Panel2.Controls.Add(this.chkDisabled);
            this.splitContainer3.Panel2.Controls.Add(this.chkGlobal);
            this.splitContainer3.Panel2.Controls.Add(this.chkCase);
            this.splitContainer3.Size = new System.Drawing.Size(741, 248);
            this.splitContainer3.SplitterDistance = 272;
            this.splitContainer3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "匹配：";
            // 
            // tbPattern
            // 
            this.tbPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPattern.Location = new System.Drawing.Point(3, 18);
            this.tbPattern.Multiline = true;
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPattern.Size = new System.Drawing.Size(267, 226);
            this.tbPattern.TabIndex = 1;
            this.tbPattern.WordWrap = false;
            this.tbPattern.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbReplace
            // 
            this.tbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplace.Location = new System.Drawing.Point(3, 18);
            this.tbReplace.Multiline = true;
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbReplace.Size = new System.Drawing.Size(347, 226);
            this.tbReplace.TabIndex = 1;
            this.tbReplace.WordWrap = false;
            this.tbReplace.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btCsSample
            // 
            this.btCsSample.Enabled = false;
            this.btCsSample.Location = new System.Drawing.Point(174, -2);
            this.btCsSample.Margin = new System.Windows.Forms.Padding(2);
            this.btCsSample.Name = "btCsSample";
            this.btCsSample.Size = new System.Drawing.Size(62, 21);
            this.btCsSample.TabIndex = 5;
            this.btCsSample.Text = "C#样例";
            this.btCsSample.UseVisualStyleBackColor = true;
            this.btCsSample.Click += new System.EventHandler(this.btCsSample_Click);
            // 
            // rdCSharp
            // 
            this.rdCSharp.AutoSize = true;
            this.rdCSharp.Location = new System.Drawing.Point(63, 1);
            this.rdCSharp.Margin = new System.Windows.Forms.Padding(2);
            this.rdCSharp.Name = "rdCSharp";
            this.rdCSharp.Size = new System.Drawing.Size(107, 16);
            this.rdCSharp.TabIndex = 4;
            this.rdCSharp.Text = "特殊处理(C#)：";
            this.rdCSharp.UseVisualStyleBackColor = true;
            this.rdCSharp.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Checked = true;
            this.rdNormal.Location = new System.Drawing.Point(3, 2);
            this.rdNormal.Margin = new System.Windows.Forms.Padding(2);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(71, 16);
            this.rdNormal.TabIndex = 4;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "替换为：";
            this.rdNormal.UseVisualStyleBackColor = true;
            this.rdNormal.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // btQueue
            // 
            this.btQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btQueue.Location = new System.Drawing.Point(361, 166);
            this.btQueue.Name = "btQueue";
            this.btQueue.Size = new System.Drawing.Size(75, 23);
            this.btQueue.TabIndex = 3;
            this.btQueue.Text = "队列测试";
            this.btQueue.UseVisualStyleBackColor = true;
            this.btQueue.Click += new System.EventHandler(this.button2_Click);
            // 
            // btTest
            // 
            this.btTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTest.Location = new System.Drawing.Point(361, 136);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 23);
            this.btTest.TabIndex = 3;
            this.btTest.Text = "测试一把";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkRegB
            // 
            this.chkRegB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRegB.AutoSize = true;
            this.chkRegB.Location = new System.Drawing.Point(359, 98);
            this.chkRegB.Name = "chkRegB";
            this.chkRegB.Size = new System.Drawing.Size(84, 16);
            this.chkRegB.TabIndex = 2;
            this.chkRegB.Text = "加单词边界";
            this.chkRegB.UseVisualStyleBackColor = true;
            this.chkRegB.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkDisabled
            // 
            this.chkDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(359, 60);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(48, 16);
            this.chkDisabled.TabIndex = 2;
            this.chkDisabled.Text = "禁用";
            this.chkDisabled.UseVisualStyleBackColor = true;
            this.chkDisabled.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkGlobal
            // 
            this.chkGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGlobal.AutoSize = true;
            this.chkGlobal.Location = new System.Drawing.Point(359, 40);
            this.chkGlobal.Name = "chkGlobal";
            this.chkGlobal.Size = new System.Drawing.Size(72, 16);
            this.chkGlobal.TabIndex = 2;
            this.chkGlobal.Text = "全局匹配";
            this.chkGlobal.UseVisualStyleBackColor = true;
            this.chkGlobal.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkCase
            // 
            this.chkCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(359, 18);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(84, 16);
            this.chkCase.TabIndex = 2;
            this.chkCase.Text = "忽略大小写";
            this.chkCase.UseVisualStyleBackColor = true;
            this.chkCase.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Location = new System.Drawing.Point(3, 3);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(735, 247);
            this.tbResult.TabIndex = 1;
            this.tbResult.WordWrap = false;
            // 
            // FmCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 530);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FmCfg";
            this.Text = "配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCfg_FormClosing);
            this.Load += new System.EventHandler(this.FmCfg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }   
        #endregion

        private System.Windows.Forms.TreeView cfgTree;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 新建NToolStripButton;
        private System.Windows.Forms.ToolStripButton 保存SToolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox tbPattern;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.CheckBox chkRegB;
        private System.Windows.Forms.CheckBox chkGlobal;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQueue;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.RadioButton rdCSharp;
        private System.Windows.Forms.ToolStripButton 打开OToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolNewQItem;
        private System.Windows.Forms.ToolStripButton toolNewRepItem;
        private CheckBox chkDisabled;
        private Button btCsSample;
    }
}