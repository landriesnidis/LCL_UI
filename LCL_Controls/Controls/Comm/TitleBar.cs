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
using System.Diagnostics;

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

        /// <summary>
        /// 主要用于改变TitleBar背景色的焦点监听器
        /// </summary>
        public FocusListener FocusListener { get; set; }

        /// <summary>
        /// 与TitleBar焦点状态关联的控件组
        /// </summary>
        public List<Control> FocusStateAssociatedControlList { get { return FocusListener.ChildControls; } }

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

            FocusListener = new FocusListener(this);
            FocusListener.ParentControl = this;
            FocusListener.AllowUseClickEvent = true;

            FocusListener.GotFocus += FocusListener_GotFocus;
            FocusListener.LostFocus += FocusListener_LostFocus;

            labTitle.MouseMove += All_MouseMove;
            labTitle.MouseLeave += All_MouseLeave;
            flowLayoutPanel.MouseMove += All_MouseMove;
            flowLayoutPanel.MouseLeave += All_MouseLeave;
            /*
            backColorSupport = new BackColorSupport(this);
            backColorSupport.RespondMouseLeaveEvent = true;
            backColorSupport.RespondMouseMoveEvent = true;
            backColorSupport.StateColorSet = this.stateColorSet;
            backColorSupport.TargetTypes = new Type[] { typeof(TitleBar), typeof(Label) };
            backColorSupport.ParentControl = this;
            */
        }

        private void All_MouseLeave(object sender, EventArgs e)
        {
            if (FocusListener.Focused)
            {
                BackColor = stateColorSet.MouseLeaveBackgroundColor;
                ForeColor = stateColorSet.MouseLeaveForegroundColor;
            }
            else
            {
                BackColor = stateColorSet.LostFocusBackgroundColor;
                ForeColor = stateColorSet.LostFocusForegroundColor;
            }
            
        }

        private void All_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = stateColorSet.MouseMoveBackgroundColor;
            ForeColor = stateColorSet.MouseMoveForegroundColor;
        }

        private void FocusListener_GotFocus(object sender, EventArgs e)
        {
            Debug.WriteLine($"[{this.GetType().ToString()}]FocusListener_GotFocus - sender:{((Control)sender).Name}");

            BackColor = stateColorSet.GotFocusBackgroundColor;
            ForeColor = stateColorSet.GotFocusForegroundColor;

            btnClose.MiniImageButton_MouseUp(sender, null);
            btnArrow.MiniImageButton_MouseUp(sender, null);
        }

        private void FocusListener_LostFocus(object sender, EventArgs e)
        {
            Debug.WriteLine($"[{this.GetType().ToString()}]FocusListener_LostFocus - sender:{((Control)sender).Name}");

            string s = this.Name;

            BackColor = stateColorSet.LostFocusBackgroundColor;
            ForeColor = stateColorSet.LostFocusForegroundColor;

            btnClose.MiniImageButton_LostFocus(sender, null);
            btnArrow.MiniImageButton_LostFocus(sender, null);
        }


        private void TitleBar_Load(object sender, EventArgs e)
        {
            labTitle.Text = title;

            FocusListener_LostFocus(this, null);
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
