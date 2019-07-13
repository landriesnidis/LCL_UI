using Landriesnidis.LCL_Controls.Components.Comm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Components
{
    public partial class BackColorSupport : UIComponent
    {

        [Browsable(true)]
        [Description("不参与背景色变换的控件类型")]
        public Type[] FiltrateTypes { get; set; }

        [Browsable(true)]
        [Description("参与背景色变换的目标控件类型（当设置了该属性，过滤类型数组会失效）")]
        public Type[] TargetTypes { get; set; }

        [Browsable(true)]
        [Description("颜色集合")]
        public StateColorSet StateColorSet { get; set; }

        [Browsable(true)]
        [Description("响应鼠标经过事件")]
        public bool RespondMouseMoveEvent { get; set; }
        [Browsable(true)]
        [Description("响应鼠标移开事件")]
        public bool RespondMouseLeaveEvent { get; set; }
        [Browsable(true)]
        [Description("响应鼠标按下事件")]
        public bool RespondMouseDownEvent { get; set; }
        [Browsable(true)]
        [Description("响应失去焦点事件")]
        public bool RespondLostFocusEvent { get; set; }
        [Browsable(true)]
        [Description("响应获得焦点事件")]
        public bool RespondGotFocusEvent { get; set; }

        public BackColorSupport(Control control):base(control)
        {
           Init();
        }
        public BackColorSupport(IContainer container):base(container)
        {
           Init();
        }

        private void Init()
        {
            // 用事件监听子控件集合的添加或移除
            this.AddingChildControl += BackColorSupport_AddingChildControl;
            this.RemovingChildControl += BackColorSupport_RemovingChildControl; 
        }

        private void BackColorSupport_AddingChildControl(object sender, ChildControlListAddingEventArgs e)
        {
            try
            {
                if (TargetTypes == null)
                {
                    // 如果控件的类型存在于过滤表中，则忽略
                    if (FiltrateTypes.Contains(e.Control.GetType()))
                    {
                        e.IsCancel = true;
                        return;
                    }
                    else
                    {
                        // 给控件赋予事件
                        AddEvents(e.Control);
                    }
                }
                else
                {
                    if (TargetTypes.Contains(e.Control.GetType()))
                    {
                        // 给控件赋予事件
                        AddEvents(e.Control);
                    }
                    else
                    {
                        e.IsCancel = true;
                        return;
                    }
                }
            }
            catch { }
        }

        private void BackColorSupport_RemovingChildControl(object sender, ChildControlListRemovedEventArgs e)
        {
            var control = e.Control;

            if (RespondMouseMoveEvent)
            {
                control.MouseMove -= Control_MouseMove;
            }
            if (RespondMouseLeaveEvent)
            {
                control.MouseLeave -= Control_MouseLeave;
            }
            if (RespondMouseDownEvent)
            {
                control.MouseDown -= Control_MouseDown;
            }
            if (RespondLostFocusEvent)
            {
                control.LostFocus -= Control_LostFocus;
            }
            if (RespondGotFocusEvent)
            {
                control.GotFocus -= Control_GotFocus;
            }
        }

        private void AddEvents(Control control)
        {
            if (RespondMouseMoveEvent)
            {
                control.MouseMove += Control_MouseMove;
            }
            if (RespondMouseLeaveEvent)
            {
                control.MouseLeave += Control_MouseLeave;
            }
            if (RespondMouseDownEvent)
            {
                control.MouseDown += Control_MouseDown;
            }
            if (RespondLostFocusEvent)
            {
                control.LostFocus += Control_LostFocus;
            }
            if (RespondGotFocusEvent)
            {
                control.GotFocus += Control_GotFocus;
            }
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = StateColorSet.GotFocusBackgroundColor;
            ((Control)sender).ForeColor = StateColorSet.GotFocusForegroundColor;
        }

        private void Control_LostFocus(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = StateColorSet.LostFocusBackgroundColor;
            ((Control)sender).ForeColor = StateColorSet.LostFocusForegroundColor;
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).BackColor = StateColorSet.MouseDownBackgroundColor;
            ((Control)sender).ForeColor = StateColorSet.MouseDownForegroundColor;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = StateColorSet.MouseLeaveBackgroundColor;
            ((Control)sender).ForeColor = StateColorSet.MouseLeaveForegroundColor;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            ((Control)sender).BackColor = StateColorSet.MouseMoveBackgroundColor;
            ((Control)sender).ForeColor = StateColorSet.MouseMoveForegroundColor;
        }
    }
}
