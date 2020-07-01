using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Landriesnidis.LCL_Controls.Components;

namespace Landriesnidis.LCL_Controls.Controls.PageTitleBar
{
    public partial class NavigationTitleBar : UserControl
    {

        [Browsable(true)]
        public new String Text { get { return TitleLabel.Text; } set { TitleLabel.Text = value; } }
        [Browsable(true)]
        public event EventHandler LeftButtonClick;
        [Browsable(true)]
        public event EventHandler RightButtonClick;
        [Browsable(true)]
        public event EventHandler TitleBarClick;

        private StateColorSet stateColor;

        public NavigationTitleBar()
        {
            InitializeComponent();

            stateColor = LeftButton.MiniImageButtonColor;
            RightButton.MiniImageButtonColor = stateColor;
            LeftButton.MiniImageButtonColor = stateColor;
            stateColor.LostFocusBackgroundColor = stateColor.MouseLeaveBackgroundColor;
            stateColor.LostFocusForegroundColor = stateColor.MouseLeaveForegroundColor;
            TitleLabel.BackColor = stateColor.MouseLeaveBackgroundColor;
            TitleLabel.ForeColor = stateColor.MouseLeaveForegroundColor;

            LeftButton.Click += LeftButton_Click;
            RightButton.Click += RightButton_Click;
            TitleLabel.Click += TitleLabel_Click;

            this.LeftButton.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.android_title_bar_arrow;
            this.LeftButton.Size = new System.Drawing.Size(Height, Height);

            this.RightButton.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.android_title_bar_arrow_right;
            this.RightButton.Size = new System.Drawing.Size(Height, Height);
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {
            TitleBarClick?.Invoke(sender,e);
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            RightButtonClick?.Invoke(sender, e);
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            LeftButtonClick?.Invoke(sender, e);
        }

        private void NavigationTitleBar_Resize(object sender, EventArgs e)
        {
            if (LeftButton != null && RightButton != null)
            {
                LeftButton.Width = Height;
                RightButton.Width = Height;
            }
        }
    }
}
