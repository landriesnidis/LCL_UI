using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Components
{
    public delegate void FindedControlHandler(object sender, FindedControlEventArgs e);

    public partial class BaseComponent : Component
    {
        /// <summary>
        /// 使用设计器添加组件是用到的容器接口
        /// </summary>
        protected IContainer container;

        [Browsable(true)]
        [Description("受组件直接影响的主容器(使用设计器添加时默认为组件当前所在的常规容器控件/用户控件/窗体)")]
        public Control ParentControl { get { if(parentControl==null) parentControl = GetParentControl();return parentControl; } set { parentControl = value; } }
        private Control parentControl;

        [Browsable(true)]
        [Description("遍历主容器下所有子控件时发现控件/有新控件加入")]
        public event FindedControlHandler FindedControl;

        public BaseComponent(Control parent)
        {
            container = GetPrivatePropertyValue<Control, IContainer>(parent, "components");
            container.Add(this);
            InitializeComponent();
        }

        public BaseComponent(IContainer container)
        {
            container.Add(this);
            this.container = container;
            InitializeComponent();

            parentControl = GetParentControl();
        }

        protected Control GetParentControl()
        {
            foreach (Control ctl in Application.OpenForms)
            {
                IContainer ic = GetPrivatePropertyValue<Control, IContainer>(ctl, "components");
                if (ic == null) continue;

                if (ic.Equals(container))
                {
                    return ctl;
                }
            }
            return null;
        }

        protected P GetPrivatePropertyValue<T, P>(T obj, string propertyName)
        {
            Type type = obj.GetType();
            const BindingFlags flags = BindingFlags.NonPublic;
            PropertyInfo pi = null;

            while (type != null)
            {
                pi = type.GetProperty(propertyName, flags);
                if (pi == null)
                {
                    type = type.BaseType;
                }
            }
            if (pi == null) return default;

            return (P)pi.GetValue(obj);
        }

        /// <summary>
        /// 获取指定控件下的所有子控件
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        protected List<Control> GetChildControls(Control parent)
        {
            if (parent == null) return null;

            List<Control> controls = new List<Control>();

            foreach (Control ctl in parent.Controls)
            {
                // 每当发现新的控件时执行事件，将控件对象传入进去。返回的参数中如果IsCancel为true则不添加此控件进入子控件列表
                FindedControlEventArgs args = new FindedControlEventArgs(ctl);
                FindedControl?.Invoke(this, args);
                if(!args.IsCancel) controls.Add(ctl);

                if (args.IsScanChildControl && ctl.Controls.Count > 0)
                {
                    controls.AddRange(GetChildControls(ctl));
                }
            }
            return controls;
        }
    }

    public class FindedControlEventArgs : EventArgs
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

        public FindedControlEventArgs(Control control)
        {
            Control = control;
        }
    }
}
