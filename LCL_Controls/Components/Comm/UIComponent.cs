using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Components.Comm
{

    public delegate void ChildControlListAddingHandler(object sender, ChildControlListAddingEventArgs e);
    public delegate void ChildControlListRemovedHandler(object sender, ChildControlListRemovedEventArgs e);

    public partial class UIComponent : BaseComponent
    {
        // 将BaseComponent中的FindedControl事件隐藏
        // private new event FindedControlHandler FindedControl;

        public event ChildControlListAddingHandler AddingChildControl;
        public event ChildControlListRemovedHandler RemovingChildControl;

        /// <summary>
        /// 主容器下所有的控件
        /// </summary>
        public List<Control> ChildControls { get; set; } = new List<Control>();

        public UIComponent(Control control) : base(control)
        {
            Init();
        }

        public UIComponent(IContainer container) : base(container)
        {
            Init();
        }

        private void Init()
        {
            FindedControl += UIComponent_FindedControl;
            ParentControlChanged += UIComponent_ParentControlChanged;
        }

        private void UIComponent_ParentControlChanged(object sender, ParentControlChangedEventArgs e)
        {
            // 新传入的父容器为空则忽略
            if (e.Control == null) return;

            // 已存在的主容器不为空时，解除所有子控件的事件并移除列表
            if(ParentControl != null)
            {
                // 如果没有变化则忽略
                if (e.Control != ParentControl)
                {
                    RemoveChildControl(ParentControl);
                    ChildControls.Clear();
                    parentControl = e.Control;
                    ChildControls = GetChildControls(ParentControl);
                }
            }
            else
            {
                parentControl = e.Control;
                ChildControls = GetChildControls(ParentControl);
            }

            if(ChildControls.Count == 0) ChildControls = GetChildControls(ParentControl);
        }

        public void AddChildControl(Control ctl)
        {
            if (ChildControls.Contains(ctl)) return;

            List<Control> controls = GetChildControls(ctl);
            controls.Add(ctl);
            ChildControls.AddRange(controls);
        }

        public void RemoveChildControl(Control ctl)
        {
            if (!ChildControls.Contains(ctl)) return;

            var controls = GetChildControls(ctl);
            foreach (Control c in controls)
            {
                // 控件移除前，删除事件
                try { c.ControlAdded -= ChildControlList_ControlAdded; } catch (StackOverflowException) { }
                try { c.ControlRemoved -= ChildControlList_ControlRemoved; } catch (StackOverflowException) { }
                ChildControls.Remove(c);
            }
            ChildControls.Remove(ctl);
        }

        private void UIComponent_FindedControl(object sender, FindedControlEventArgs e)
        {
            if (!e.IsCancel)
            {
                ChildControlListAddingEventArgs arg = new ChildControlListAddingEventArgs(e.Control);
                AddingChildControl?.Invoke(this, arg);
                if (!arg.IsCancel)
                {
                    AddChildControl(e.Control);
                    try { e.Control.ControlAdded += ChildControlList_ControlAdded; } catch { }
                    try { e.Control.ControlRemoved += ChildControlList_ControlRemoved; } catch { }
                }
            }
        }

        private void ChildControlList_ControlAdded(object sender, ControlEventArgs e)
        {
            UIComponent_FindedControl(sender, new FindedControlEventArgs(e.Control));
        }

        private void ChildControlList_ControlRemoved(object sender, ControlEventArgs e)
        {
            RemoveChildControl(e.Control);
            e.Control.ControlAdded -= ChildControlList_ControlAdded;
            e.Control.ControlRemoved -= ChildControlList_ControlRemoved;

            RemovingChildControl?.Invoke(sender, new ChildControlListRemovedEventArgs(e.Control));
        }

    }

    public class ChildControlListAddingEventArgs : EventArgs
    {
        /// <summary>
        /// 正在加入子控件列表的控件
        /// </summary>
        public Control Control { get; set; }

        /// <summary>
        /// 是否取消此控件加入子控件列表
        /// </summary>
        public bool IsCancel { get; set; } = false;

        /// <summary>
        /// 是否扫描此控件的子控件集合
        /// </summary>
        public bool IsScanChildControl { get; set; } = true;

        public ChildControlListAddingEventArgs(Control control)
        {
            Control = control;
        }
    }

    public class ChildControlListRemovedEventArgs : EventArgs
    {
        /// <summary>
        /// 正在加入子控件列表的控件
        /// </summary>
        public Control Control { get; set; }

        /// <summary>
        /// 是否扫描此控件的子控件集合
        /// </summary>
        public bool IsScanChildControl { get; set; } = true;

        public ChildControlListRemovedEventArgs(Control control)
        {
            Control = control;
        }
    }
}
