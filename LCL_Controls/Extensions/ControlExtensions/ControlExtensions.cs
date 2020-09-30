using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Extensions.ControlExtensions
{
    public static class ControlExtensions
    {
        /// <summary>
        /// 获取指定控件下的所有子控件
        /// </summary>
        /// <param name="control"></param>
        /// <param name="isRecursive"></param>
        /// <returns></returns>
        private static List<Control> GetChildControls(this Control control, bool isRecursive = false)
        {
            List<Control> list = new List<Control>();
            foreach (Control cc in control.Controls)
            {
                list.Add(cc);
                if (isRecursive && cc.Controls.Count > 0)
                {
                    list.AddRange(GetChildControls(cc, isRecursive));
                }
            }
            return list;
        }

        /// <summary>
        /// 遍历子控件，传入委托代码操作每一个控件
        /// </summary>
        /// <param name="control"></param>
        /// <param name="handler"></param>
        /// <param name="isRecursive"></param>
        public static void TraverseChildControls(this Control control, Action<Control> handler, bool isRecursive = false)
        {
            List<Control> controls = GetChildControls(control, isRecursive);
            if (handler != null)
            {
                foreach (Control c in controls)
                {
                    handler.Invoke(c);
                }
            }
        }

        /// <summary>
        /// 向子控件共享单击事件委托
        /// </summary>
        /// <param name="control"></param>
        /// <param name="types"></param>
        public static void ShareClickEvent(this Control control, Type[] types = null)
        {
            /*
            // 方法一：为子控件添加回调事件，通过反射调用父容器的回调方法。此方法不易拓展，已弃用。
            TraverseChildControls(control, (childControl) =>
            {
                // 如果指定了共享的控件类型，则依照类型数组过滤；若未指定类型，则所有控件都通过；
                // 如果子控件未绑定 OnClick 事件，则共享Click事件
                if ((types == null || types.Contains(childControl.GetType())) && FindDelegateFromControl(childControl, "Click") == null)
                {
                    childControl.Click += (s, e) => { control.CallControlEvent("Click", e); };
                }
            }, true);
            */

            // 
            ShareEventDelegate(control,"Click");
        }

        /// <summary>
        /// 向子控件共享指定事件名的事件委托
        /// </summary>
        /// <param name="control">容器控件</param>
        /// <param name="eventName">事件名称</param>
        /// <param name="types">只想类型数组内包含的类型共享事件委托</param>
        public static void ShareEventDelegate(this Control control, string eventName, Type[] types = null)
        {
            // 获取当前容器中指定事件委托（通过事件名称）
            Delegate handler = FindDelegateFromControl(control, eventName);
            // 如果未找到事件委托（不存在或未绑定委托）则退出
            if (handler == null) return;
            // 递归遍历出所有的子控件，为子控件配置委托
            TraverseChildControls(control, (childControl) =>
            {
                // 如果指定了共享的控件类型，则依照类型数组过滤；若未指定类型，则所有控件都通过；
                // 如果子控件未绑定 eventName 事件，则共享 eventName 事件
                if ((types == null || types.Contains(childControl.GetType())) && FindDelegateFromControl(childControl, eventName) == null)
                {
                    AddDelegateToControlEventHandlerList(childControl, eventName, handler);
                }
            }, true);
        }


        /// <summary>
        /// 反射调用事件
        /// </summary>
        /// <param name="control"></param>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public static bool CallControlEvent(this Control control, string eventName, EventArgs e = null)
        {
            try
            {
                // 获取对象的类型      
                Type t = control.GetType();
                // 从类型中查找出符合条件的方法  
                MethodInfo m = t.GetMethod("On" + eventName, BindingFlags.NonPublic | BindingFlags.Instance);
                // 如果没有对应方法则返回false
                if (m == null) return false;
                //获得参数信息
                ParameterInfo[] para = m.GetParameters();
                //参数对象      
                object[] p = new object[1];
                if (e == null)
                    p[0] = Type.GetType(para[0].ParameterType.FullName).GetProperty("Empty");
                else
                    p[0] = e;
                //调用  
                m.Invoke(control, parameters: p);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 向控件事件列表中添加委托
        /// </summary>
        /// <param name="control"></param>
        /// <param name="eventName"></param>
        /// <param name="handler"></param>
        public static void AddDelegateToControlEventHandlerList(this Control control, string eventName, Delegate handler)
        {
            EventInfo ei = control.GetType().GetEvent(eventName);
            ei.AddEventHandler(control, handler);
        }

        /// <summary>
        /// 从控件中获取指定名称的事件委托
        /// </summary>
        /// <param name="control"></param>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public static Delegate FindDelegateFromControl(this Control control, string eventName)
        {

            EventHandlerList events = typeof(Control).GetProperty("Events", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(control) as EventHandlerList;
            FieldInfo key = typeof(Control).GetField("Event" + eventName, BindingFlags.Static | BindingFlags.NonPublic);

            if (key == null) return null;
            return events[key.GetValue(control)];
        }
    }
}
