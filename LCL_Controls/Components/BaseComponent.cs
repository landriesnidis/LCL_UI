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
    public partial class BaseComponent : Component
    {
        protected IContainer container;

        [Browsable(true)]
        [Description("接收监听的容器(默认为组件当前所在的容器)")]
        public Control ParentControl { get; set; }

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
            List<Control> controls = new List<Control>();

            foreach (Control ctl in parent.Controls)
            {
                controls.Add(ctl);
                if (ctl.Controls.Count > 0)
                {
                    controls.AddRange(GetChildControls(ctl));
                }
            }
            return controls;
        }
    }
}
