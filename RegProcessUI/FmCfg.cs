using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace RegProcess
{
    public partial class FmCfg : Form
    {
        private Form1 _fm;
        List<RepBatch> _batches;
        private string _cfgDir;

        private bool _isSetting = true;
        private int _index;
        public FmCfg(Form1 fm, string cfgDir, int index)
        {
            InitializeComponent();
            _fm = fm;
            _cfgDir = cfgDir;
            _index = index;

            _batches = RepConfig.LoadDir(_cfgDir);
        }

        private void FmCfg_Load(object sender, EventArgs e)
        {
            LoadCfg();
        }

        private void LoadCfg()
        {
            cfgTree.Nodes.Clear();
            foreach (var bat in _batches)
            {
                TreeNode treeNode = new TreeNode(bat.Title, 1, 1);
                treeNode.Tag = bat;
                cfgTree.Nodes.Add(treeNode);
                foreach (var repItem in bat.Items)
                {
                    TreeNode treeNode2 = new TreeNode(repItem.Title, 2, 2);
                    treeNode2.ForeColor = repItem.Disabled ? Color.Silver : SystemColors.ControlText;
                    treeNode2.Tag = repItem;
                    treeNode.Nodes.Add(treeNode2);
                }
            }
            if (cfgTree.Nodes.Count > _index && _index != -1)
            {
                cfgTree.SelectedNode = cfgTree.Nodes[_index];
                cfgTree.SelectedNode.ExpandAll();
            }
            _isSetting = false;
        }

        private void ChangeNodeCfg()
        {
            if (!_isSetting)
            {
                var item = cfgTree.SelectedNode.Tag as RepItem;
                item.Disabled = chkDisabled.Checked;
                item.Boundary = chkRegB.Checked;
                item.Global = chkGlobal.Checked;
                item.IgnoreCase = chkCase.Checked;
                item.Pattern = tbPattern.Text;
                item.RepalceTo = tbReplace.Text;
                item.RepType = rdCSharp.Checked ? RepType.CS_Code : RepType.Direct;
                item.Title = cfgTree.SelectedNode.Text;
                item.NoReg = chkNoReg.Checked;
                cfgTree.SelectedNode.ForeColor = item.Disabled ? Color.Silver : SystemColors.ControlText;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeNodeCfg();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ChangeNodeCfg();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNodeCfg();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNodeCfg();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNodeCfg();
        }

        private void cfgTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _isSetting = true;
            RepItem repItem = e.Node.Tag as RepItem;
            splitContainer1.Panel2.Enabled = (repItem != null);
            if (repItem != null)
            {
                tbPattern.Text = repItem.Pattern;
                tbReplace.Text = repItem.RepalceToRN();
                chkCase.Checked = repItem.IgnoreCase;
                chkGlobal.Checked = repItem.Global;
                chkRegB.Checked = repItem.Boundary;
                chkDisabled.Checked = repItem.Disabled;
                rdNormal.Checked = (repItem.RepType == RepType.Direct);
                rdCSharp.Checked = (repItem.RepType == RepType.CS_Code);
            }
            _isSetting = false;
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            SaveCfg();
        }

        private void SaveCfg()
        {
            RepConfig.Save(_cfgDir, _batches);
            _fm.LoadConfig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_fm.SrcTextBox.Text == "")
            {
                MessageBox.Show("请先在主窗口输入待查找的文本");
                _fm.ShowSrc();
            }
            else
            {
                try
                {
                    var repItem = (cfgTree.SelectedNode.Tag as RepItem);//.Clone();
                    //cfgTree.SelectedNode.Tag = repItem;
                    repItem.ResetFeature();
                    //SyncItems(cfgTree.SelectedNode);
                    tbResult.Text = repItem.Replace(_fm.SrcTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_fm.SrcTextBox.Text == "")
            {
                MessageBox.Show("请先在主窗口输入待查找的文本");
                _fm.ShowSrc();
                return;
            }
            string str = "";
            try
            {
                TreeNode treeNode = cfgTree.SelectedNode;
                while (treeNode.Parent != null)
                {
                    treeNode = treeNode.Parent;
                }
                string text = _fm.SrcTextBox.Text;
                var bat = treeNode.Tag as RepBatch;
                tbResult.Text = bat.ReplaceBat(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(str + "\r\n" + ex.Message);
            }
        }

        public static string ReplaceEach(Match m)
        {
            string value = m.Value;
            if (m.Groups[0].Value == "hz")
            {
                return value;
            }
            return Regex.Replace(value, "(\\w+)", "bar");
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            btCsSample.Enabled = rdCSharp.Checked;
        }

        private void btCsSample_Click(object sender, EventArgs e)
        {
            tbReplace.Text = "public static string ReplaceEach(Match m)\r\n{\r\n    string src = m.Value;\r\n    if (m.Groups[0].Value == \"hz\")\r\n    {\r\n        return src;\r\n    }\r\n    else\r\n    {\r\n        return Regex.Replace(src, @\"(\\w+)\", \"bar\");\r\n    }\r\n}";
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = Path.GetDirectoryName(".");
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _cfgDir = dlg.SelectedPath;
                LoadCfg();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void 新建NToolStripButton_Click(object sender, EventArgs e)
        {
            _cfgDir = null;
            cfgTree.Nodes.Clear();
            toolNewQItem_Click(sender, e);
        }

        private void toolNewQItem_Click(object sender, EventArgs e)
        {
            cfgTree.Nodes.Add(new TreeNode("新建队列1", 1, 1));
            var node = cfgTree.Nodes[cfgTree.Nodes.Count - 1];
            var bat = new RepBatch();
            bat.Title = node.Text;
            _batches.Add(bat);
            node.Tag = bat;
            cfgTree.SelectedNode = node;
            node.BeginEdit();
        }

        private void toolNewRepItem_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = cfgTree.SelectedNode;
            if (treeNode != null)
            {
                if (treeNode.Parent != null)
                {
                    treeNode = treeNode.Parent;
                }
                RepItem repItem = new RepItem();
                repItem.Title = "描述";
                repItem.Pattern = "查找内容";
                repItem.RepalceTo = "替换为";
                repItem.IgnoreCase = false;
                repItem.Global = true;
                repItem.Boundary = false;
                TreeNode treeNode2 = new TreeNode(repItem.Title, 2, 2);
                treeNode2.Tag = repItem;
                treeNode.Nodes.Add(treeNode2);
                (treeNode.Tag as RepBatch).Items.Add(repItem);
                treeNode2.BeginEdit();
            }
        }

        private void cfgTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Node.Tag is RepItem)
                {
                    (e.Node.Tag as RepItem).Title = e.Label;
                }
                else if (e.Node.Tag is RepBatch)
                {
                    (e.Node.Tag as RepBatch).Title = e.Label;
                }
            }
        }


        private void cfgTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)// 获取判断是否是鼠标左键按下操作 ALF
            {
                TreeNode node = (TreeNode)e.Item;//获取选定拖拽节点的实例
                if (node != null)
                {
                    // 初始化拖放操作。
                    DoDragDrop(e.Item, DragDropEffects.Move | DragDropEffects.Copy);//mod为拖拽携带数据
                }
            }
        }

        private void cfgTree_DragDrop(object sender, DragEventArgs e)
        {
            //获取被拖动的节点
            TreeNode treeNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            //获取当前鼠标所处的位置，并将它赋值给全局变量point
            Point point = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
            //根据坐标点取得坐标点处的Node节点
            //拖放的目标节点
            TreeNode targetTreeNode = ((TreeView)sender).GetNodeAt(point);
            TreeNode parent = targetTreeNode.Parent;
            int index = targetTreeNode.Index + 1;
            TreeNode node = (TreeNode)treeNode.Clone();
            node.Tag = JSON.Parse<RepItem>(JSON.Stringify(treeNode.Tag));
            //同一项目
            if (targetTreeNode.Parent == treeNode.Parent)
            {
                //判断被拖动的节点与目标节点是否为同一个节点，是则不予处理
                if (treeNode != targetTreeNode)
                {

                    if (parent != null) //子节点
                    {
                        parent.Nodes.Insert(index, node);
                        //移除拖动节点
                        treeNode.Remove();
                    }
                    else // 根节点
                    {
                        cfgTree.Nodes.Insert(index, node);
                        //移除拖动节点
                        treeNode.Remove();
                    }
                }
            }
            else
            {
                if (parent != null) //子节点
                {
                    targetTreeNode.Parent.Nodes.Insert(index, node);
                }
                else
                { // 根节点

                    targetTreeNode.Nodes.Insert(targetTreeNode.Nodes.Count, node);
                }
            }

            SyncItems(targetTreeNode);
        }

        private void SyncItems(TreeNode targetTreeNode)
        {
            TreeNode parent = targetTreeNode.Parent;
            var pNode = parent == null ? targetTreeNode : parent;
            (pNode.Tag as RepBatch).Items = pNode.Nodes.Cast<TreeNode>().Select(n => n.Tag as RepItem).ToList();

            for (int i = 0; i < cfgTree.Nodes.Count; i++)
            {
                _batches[i] = cfgTree.Nodes[i].Tag as RepBatch;
                _batches[i].Order = i;
            }
        }

        private void cfgTree_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var tag = cfgTree.SelectedNode.Tag;

                if (cfgTree.SelectedNode.Parent == null)
                {
                    if (tag is RepBatch)
                    {
                        _batches.Remove(tag as RepBatch);
                    }
                    cfgTree.Nodes.Remove(cfgTree.SelectedNode);
                }
                else
                {
                    if (tag is RepItem)
                    {
                        (cfgTree.SelectedNode.Parent.Tag as RepBatch).Items.Remove(tag as RepItem);
                    }
                    cfgTree.SelectedNode.Parent.Nodes.Remove(cfgTree.SelectedNode);
                }

            }
        }

        private void FmCfg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cfgDir != null)
            {
                if (HasChanged())
                {
                    var response = MessageBox.Show("需要保存修改吗？", "", MessageBoxButtons.YesNoCancel);
                    if (response == DialogResult.Cancel)
                        e.Cancel = true;
                    else if (response == DialogResult.OK)
                    {
                        SaveCfg();
                    }
                }
            }
            CsCache.Unique.Clear();
        }

        private bool HasChanged()
        {
            var olds = RepConfig.LoadDir(_cfgDir);
            for (int i = 0; i < olds.Count; i++)
            {
                if (i >= _batches.Count || JSON.Stringify(_batches[i]) != JSON.Stringify(olds[i])) return true;
            }
            return false;
        }

        private void cfgTree_DragOver(object sender, DragEventArgs e)
        {
            Point point = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
            //根据坐标点取得坐标点处的Node节点
            //拖放的目标节点
            TreeNode targetTreeNode = ((TreeView)sender).GetNodeAt(point);
            var dragNode = e.Data.GetData("System.Windows.Forms.TreeNode") as TreeNode;

            var isOK = dragNode != null && targetTreeNode != null;
            if (!isOK)
            {
                e.Effect = DragDropEffects.None;
            }
            else
            {
                var isSameBat = targetTreeNode.Parent == dragNode.Parent;
                if (isSameBat) e.Effect = DragDropEffects.Move;
                else e.Effect = DragDropEffects.Copy;
            }
        }

        private void chkNoReg_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNodeCfg();
        }
    }
}
