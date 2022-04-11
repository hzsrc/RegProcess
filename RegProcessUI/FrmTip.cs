using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegProcess
{
    public partial class FrmTip : Form
    {
        public FrmTip()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_NOACTIVATE = 0x08000000;
                //const int WS_CHILD = 0x40000000;
                CreateParams cp = base.CreateParams;
                //cp.Style |= WS_CHILD;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                return cp;
            }
        }
        public void Show(string text, Control ctl, int duaration)
        {
            label1.Text = text;
            timer1.Interval = duaration;

            Visible = true;
            Size = new Size(60, 20);
            var form = ctl.FindForm();
            var size = form.Height - form.ClientSize.Height;
            Location = form.PointToScreen(ctl.Location);
            Top += size + ctl.Height + 10;
            Left += 20;
            form.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
