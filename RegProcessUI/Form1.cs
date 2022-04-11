using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RegProcess
{
    public partial class Form1 : Form
    {
        private delegate void ClearItemsD();

        private delegate void AddItemD(string item);

        List<RepBatch> _batches;

        private string _cfgDir = AppDomain.CurrentDomain.BaseDirectory;


        public TextBox SrcTextBox
        {
            get
            {
                return tbSrc;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string cfgDir)
            : this()
        {
            _cfgDir = cfgDir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = _batches[tComboBox.SelectedIndex].ReplaceBat(tbSrc.Text);
            tbDesc.Text = text;
            new FrmTip().Show("Done", button1, 1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
            LoadForm();
        }

        private void LoadForm()
        {
            try
            {
                var s = File.ReadAllText("laststate.cfg").Split(new String[] { "\r\n" }, StringSplitOptions.None);
                tComboBox.SelectedIndex = Convert.ToInt32(s[2]);
                tbDir.Text = s[0];
                tbPattern.Text = s[1];
            }
            catch { }
        }

        private void ClearItems()
        {
            tComboBox.Items.Clear();
        }

        private void AddItem(string item)
        {
            tComboBox.Items.Add(item);
            tComboBox.SelectedIndex = 0;
        }

        public void LoadConfig()
        {
            var index = tComboBox.SelectedIndex;
            _batches = RepConfig.LoadDir(_cfgDir);
            Invoke(new ClearItemsD(ClearItems));
            for (int i = 0; i < _batches.Count; i++)
            {
                Invoke(new AddItemD(AddItem), _batches[i].Title);
            }
            if (tComboBox.Items.Count > index && index != -1)
            {
                tComboBox.SelectedIndex = index;
            }
        }

        private void p_Exited(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new FmCfg(this, _cfgDir, tComboBox.SelectedIndex).Show();
            LoadConfig();
        }



        private void btPaste_Click(object sender, EventArgs e)
        {
            tbSrc.Text = Clipboard.GetText(TextDataFormat.Text);
            new FrmTip().Show("Done", btPaste, 1000);
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbDesc.Text, TextDataFormat.Text);
            new FrmTip().Show("Done", btCopy, 1000);
        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.SelectedPath = tbDir.Text;
            if (d.ShowDialog() == DialogResult.OK)
            {
                tbDir.Text = d.SelectedPath;
            }
        }

        private void btBat_Click(object sender, EventArgs e)
        {
            lab.Text = "";
            labCur.Text = "";
            Application.DoEvents();
            var bat = _batches[tComboBox.SelectedIndex];
            EnumFiles(tbDir.Text, tbPattern.Text, file =>
            {
                labCur.Text = file;
                var textEnc = new TextEncode();
                string content = textEnc.ReadText(file);
                string result = bat.ReplaceBat(content);
                if (content != result)
                {
                    textEnc.WriteBySameEncoding(file, result);
                    lab.AppendText(file + "\r\n");
                }
                Application.DoEvents();
            });
            labCur.Text = "";
            lab.AppendText("Done!");
        }

        private void SaveForm()
        {
            string[] s = new string[] { tbDir.Text, tbPattern.Text, tComboBox.SelectedIndex.ToString() };
            File.WriteAllText("laststate.cfg", String.Join("\r\n", s));
        }

        private void EnumFiles(string dir, string patterns, Action<string> cb)
        {
            foreach (string pattern in patterns.Split(';'))
            {
                foreach (var file in Directory.GetFiles(dir, pattern))
                {
                    cb(file);
                }
            }
            foreach (var sub in Directory.GetDirectories(dir))
            {
                EnumFiles(sub, patterns, cb);
            }
        }

        public void ShowSrc()
        {
            tabs.SelectedTab = tabText;
            tbSrc.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveForm();
        }
    }
}
