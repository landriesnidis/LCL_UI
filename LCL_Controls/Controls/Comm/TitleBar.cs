using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Comm
{
    public partial class TitleBar : UserControl
    {
        [Browsable(true)]
        public string Title { get { return title; } set { labTitle.Text = value; title = value; } }
        private string title;

        [Browsable(true)]
        public new bool AutoSize { set { AutoChangeBarWidth(value); } }

        public TitleBar()
        {
            InitializeComponent();

            btnArrow.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Arrow;
            btnClose.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Close;
        }

        private void TitleBar_Load(object sender, EventArgs e)
        {
            labTitle.Text = title;
        }

        private void AutoChangeBarWidth(bool b)
        {
            if (b)
            {
                int len = labTitle.Text.Length * 9 + flowLayoutPanel.Width;
                this.MaximumSize = new System.Drawing.Size(0, 30);
                this.MinimumSize = new System.Drawing.Size(len, 30);
                this.Width = len;
            }
            else
            {
                this.MaximumSize = new System.Drawing.Size(0, 30);
                this.MinimumSize = new System.Drawing.Size(200, 30);
                this.Width = 200;
            }
        }
    }
}
