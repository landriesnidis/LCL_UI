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
    public partial class AndroidTitleBar : UserControl
    {

        [Browsable(true)]
        public new String Text { get { return labTitle.Text; } set { labTitle.Text = value; } }
        [Browsable(true)]
        public event EventHandler BackButtonClick;
        [Browsable(true)]
        public event EventHandler FunctionButtonClick;

        private Button.MiniImageButton btnBack;
        private Button.MiniImageButton btnFunc;

        private StateColorSet stateColor;

        public AndroidTitleBar()
        {
            InitializeComponent();

            this.btnBack = new Landriesnidis.LCL_Controls.Controls.Button.MiniImageButton();
            this.btnFunc = new Landriesnidis.LCL_Controls.Controls.Button.MiniImageButton();

            stateColor = btnBack.MiniImageButtonColor;
            btnFunc.MiniImageButtonColor = stateColor;
            stateColor.LostFocusBackgroundColor = stateColor.MouseLeaveBackgroundColor;
            stateColor.LostFocusForegroundColor = stateColor.MouseLeaveForegroundColor;
            labTitle.BackColor = stateColor.MouseLeaveBackgroundColor;
            labTitle.ForeColor = stateColor.MouseLeaveForegroundColor;


            this.btnBack.AllowNoFocusResponseMouseEvent = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.android_title_bar_arrow;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(Height, Height);
            this.btnBack.TabIndex = 1;


            this.btnFunc.AllowNoFocusResponseMouseEvent = true;
            this.btnFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFunc.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.android_title_bar_arrow;
            this.btnFunc.Location = new System.Drawing.Point(465, 0);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(Height, Height);
            this.btnFunc.TabIndex = 2;

            btnBack.Click += BtnBack_Click;
            btnFunc.Click += BtnFunc_Click;
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnBack);

        }

        private void BtnFunc_Click(object sender, EventArgs e)
        {
            FunctionButtonClick?.Invoke(sender, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BackButtonClick?.Invoke(sender, e);
        }

        private void AndroidTitleBar_Resize(object sender, EventArgs e)
        {
            if (btnBack != null && btnFunc != null)
            {
                btnBack.Width = Height;
                btnFunc.Width = Height;
            }
        }
    }
}
