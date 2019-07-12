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

        [Browsable(true)]
        public new Color ForeColor { get { return labTitle.ForeColor; } set { labTitle.ForeColor = value; } }

        public TitleBar()
        {
            InitializeComponent();

            TabStop = true;

            btnArrow.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Arrow;
            btnClose.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Close;

            BackColorChanged += (s, e) =>
            {
                if (labTitle.BackColor != this.BackColor) labTitle.BackColor = this.BackColor;
            };
            ForeColorChanged += (s, e) =>
            {
                if (labTitle.ForeColor != this.ForeColor) labTitle.ForeColor = this.ForeColor;
            };

            labTitle.BackColorChanged += (s, e) =>
            {
                if (this.BackColor != labTitle.BackColor) this.BackColor = labTitle.BackColor;
            };
            labTitle.ForeColorChanged += (s, e) =>
            {
                if (this.ForeColor != labTitle.ForeColor) this.ForeColor = labTitle.ForeColor;
            };
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
