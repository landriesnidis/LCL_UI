using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.Base
{
    public partial class LCLForm : Form
    {
        [Browsable(true)]
        public new string Text { get { return labTitle.Text; } set { labTitle.Text = value; } }

        [Bindable(true)]
        [Browsable(true)]
        [Localizable(true)]
        public Image Image { get { return pic.Image; } set { pic.Image = value; } }

        [Browsable(true)]
        public bool AllowDoubleClickMaximization { get { return mmc.AllowDoubleClickMaximization; }set { mmc.AllowDoubleClickMaximization = value; } }

        public LCLForm()
        {
            InitializeComponent();

            mmc.Form = this;
            mmc.Add(new Control[] { labTitle,panelBase });
            this.StartPosition = FormStartPosition.CenterScreen;
            // 获取执行程序的图标
            Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
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

        private void LCLForm_Load(object sender, EventArgs e)
        {
            pic.Visible = pic.Image != null;
        }
    }
}
