using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    public partial class Box : Form
    {
        [Browsable(true)]
        public new string Text { get { return labTitle.Text; } set { labTitle.Text = value; } }

        [Browsable(true)]
        public string ButtonDefaultCancelText { get { return btnCancel.Text; } set { btnCancel.Text = value; } }

        public Box()
        {
            InitializeComponent();

            mmc.Form = this;
            mmc.Add(new Control[] { labTitle,panelBase });
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// 窗体抖动
        /// </summary>
        protected void Shake()
        {
            shakeTimes = 8;
            timerShake.Enabled = true;
            this.Enabled = false;
        }

        // 窗体剩余抖动次数
        int shakeTimes = 0;

        private void TimerShake_Tick(object sender, EventArgs e)
        {
            this.Left += (shakeTimes%2==0?10  : -10);
            shakeTimes--;
            if (shakeTimes == 0)
            {
                timerShake.Enabled = false;
                this.Enabled = true;
            }
        }

    }
}
