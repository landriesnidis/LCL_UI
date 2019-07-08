using System;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.Base
{
    public partial class ToastForm : Form
    {
        [Browsable(true)]
        public new string Text { get { return labContent.Text; }set { labContent.Text = value; } }

        private Control Context { get; set; }

        public ToastForm(string content,int delay = 2000, Control context = null)
        {
            InitializeComponent();
            Text = content;

            int len = System.Text.Encoding.Default.GetBytes(Text).Length;
            this.Width = len * 9 + 15 * 2;
            this.Height = 18;

            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(this);
            this.Left = (rect.Width - this.Width) / 2;
            this.Top = rect.Height /4*3;

            timerWait.Interval = delay;
            timerWait.Enabled = true;
        }

        private void TimerHide_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0.1)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                Close();
            }
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            try
            {
                Context.Focus();
            }
            catch { }
        }

        private void TimerWait_Tick(object sender, EventArgs e)
        {
            timerWait.Enabled = false;
            timerHide.Enabled = true;
        }

        private void LabContent_MouseMove(object sender, MouseEventArgs e)
        {
            timerWait.Enabled = false;
        }

        private void LabContent_MouseLeave(object sender, EventArgs e)
        {
            timerWait.Enabled = true;
        }
    }
}
