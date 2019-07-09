using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Botton
{
    [DefaultEvent("ExitButtonClick")]
    public partial class ButtonGroup : UserControl
    {
        [Browsable(true)]
        public bool MaximizeBox { get { return maximizeButton.Visible; } set { maximizeButton.Visible = value; } }
        [Browsable(true)]
        public bool MinimizeBox { get { return minimizeButton.Visible; } set { minimizeButton.Visible = value; } }
        [Browsable(true)]
        public bool AutoPosition { get{ return autoPosition; } set { autoPosition = value;if (value) AutoSetPosition(parentForm); } }
        private bool autoPosition;
        [Browsable(true)]
        public int AutoPositionOffset { get { return autoPositionOffset; } set { autoPositionOffset = value; AutoSetPosition(parentForm); } }
        private int autoPositionOffset;

        public event EventHandler ExitButtonClick;
        public event EventHandler MaximizeButtonClick;
        public event EventHandler MinimizeButtonClick;

        private Form parentForm;

        public ButtonGroup()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (ExitButtonClick != null)
            {
                ExitButtonClick(sender, e);
            }
            else
            {
                if (parentForm != null) parentForm.Close();
            }
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (MaximizeButtonClick != null)
            {
                MaximizeButtonClick(sender, e);
            }
            else
            {
                if (parentForm != null)
                {
                    if (parentForm.WindowState != FormWindowState.Maximized)
                    {
                        parentForm.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        parentForm.WindowState = FormWindowState.Normal;
                    }
                }
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            if (MinimizeButtonClick != null)
            {
                MinimizeButtonClick(sender, e);
            }
            else
            {
                if (parentForm != null) parentForm.WindowState = FormWindowState.Minimized;
            }
        }

        /// <summary>
        /// 获取控件所属的Form对象
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private Form SearchParentForm(Control control)
        {
            try
            {
                if (typeof(Form).IsAssignableFrom(control.GetType()))
                {
                    return (Form)control;
                }
                else
                {
                    return SearchParentForm(control.Parent);
                }
            }
            catch
            {
                return null;
            }
        }

        public void AutoSetPosition(Control parentControl)
        {
            if (parentControl == null)
            {
                parentControl = SearchParentForm(this);
                if (parentControl == null) return;
            }

            // 将控件加入父容器
            if(parentControl.Controls.Contains(this)) parentControl.Controls.Add(this);

            // 确定位置
            this.Top = 1;
            this.Left = parentControl.Width - this.Width - 1 + AutoPositionOffset;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // 将控件置顶
            this.BringToFront();
        }

        private void ButtonGroup_Load(object sender, EventArgs e)
        {
            // 获取父窗体
            parentForm = SearchParentForm(this);

            // 判断是否设置自动位置
            if (AutoPosition && parentForm != null)
            {
                AutoSetPosition(parentForm);
            }
        }
    }
}
