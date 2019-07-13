using Landriesnidis.LCL_Controls.Components.Comm;
using Landriesnidis.LCL_Controls.Controls.Container;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Landriesnidis.LCL_Controls.Components.FocusListenManager;

namespace Landriesnidis.LCL_Controls.Components
{
    public delegate void ControlAddedHandler(object sender, PageChangedEventArgs e);

    public partial class FocusListener : UIComponent, IFocusBroadcast
    {
        [Browsable(true)]
        [Description("对于不支持获得焦点的控件，允许通过Click事件获取焦点")]
        public bool AllowUseClickEvent { get; set; } = true;

        [Browsable(true)]
        [Description("子控件集中有控件获得了焦点")]
        public event EventHandler GotFocus;
        [Browsable(true)]
        [Description("子控件集中有控件失去了焦点")]
        public event EventHandler LostFocus;

        // 当前监听的主对象的最后焦点获取状态
        private bool isOnFocus = false;

        // 最后一个获得焦点的子控件
        private Control lastOnFocusControl = null;

        public FocusListener(Control parent):base(parent)
        {
            Init();
        }

        public FocusListener(IContainer container):base(container)
        {
            Init();
        }

        ~FocusListener()
        {
            FocusListenManager.RemoveListener(this);
        }

        private void Init()
        {
            // 加入焦点监听管理器
            FocusListenManager.AddListener(this);

            // 用事件监听子控件集合的添加或移除
            this.AddingChildControl += FocusListener_AddingChildControl;
            this.RemovingChildControl += FocusListener_RemovingChildControl;
        }

        private void FocusListener_AddingChildControl(object sender, ChildControlListAddingEventArgs e)
        {
            Control c = e.Control;
            try
            {
                // 只有支持Tab获取焦点的控件才可以使用自带的焦点事件
                // 其他的需要使用别的事件替代(单击事件)
                if (c.TabStop)
                {
                    c.GotFocus += ChildControl_GotFocus;
                    c.LostFocus += ChildControl_LostFocus;
                }
                else
                {
                    // 是否允许使用Click获取焦点
                    if (AllowUseClickEvent)
                    {
                        c.Click += (s,args) =>
                        {
                            c.Focus();
                        };
                        
                    }
                }
            }
            catch { }
        }

        private void FocusListener_RemovingChildControl(object sender, ChildControlListRemovedEventArgs e)
        {
            e.Control.GotFocus -= ChildControl_GotFocus;
            e.Control.LostFocus -= ChildControl_LostFocus;
        }

        private void ChildControl_GotFocus(object sender, EventArgs e)
        {
           Debug.WriteLine($"[{this.GetType().ToString()}]ChildControl_GotFocus - sender:{((Control)sender).Name}");

            // 回调事件
            GotFocus?.Invoke(sender, e);

            // 修改获得焦点时的记录
            isOnFocus = true;
            lastOnFocusControl = (Control)sender;

            // 得到焦点后，除了要自身响应焦点事件外，还需要通知所有FocusListener
            FocusListenManager.Broadcast(FocusEvent.Got, this, (Control)sender);
        }

        private void ChildControl_LostFocus(object sender, EventArgs e)
        {
            Debug.WriteLine($"[{this.GetType().ToString()}]ChildControl_LostFocus - sender:{((Control)sender).Name}");

            // 回调事件
            LostFocus?.Invoke(sender, e);

            // 修改获得焦点时的记录
            isOnFocus = false;

            // 失去焦点后，除了要自身响应焦点事件外，还需要通知所有FocusListener
            FocusListenManager.Broadcast(FocusEvent.Lost, this, (Control)sender);
        }


        public void OnBroadcast(FocusEvent @event, FocusListener context, Control eventControl)
        {
            // 判断是不是其他监听器的消息（广播转发的时候其实已经过滤了，这句判断可以不加）
            if (context != this)
            {
                switch (@event)
                {
                    case FocusEvent.Got:
                        // 如果是其他监听器下的控件获得了焦点，且焦点最后的状态记录为true，则主动执行失去焦点的事件函数
                        if(isOnFocus)ChildControl_LostFocus(lastOnFocusControl, new EventArgs());
                        break;
                    case FocusEvent.Lost:

                        break;
                }
            }
        }
    }

    public class FocusListenManager
    {
        private static FocusListenManager manager = null;

        static FocusListenManager()
        {
            manager = new FocusListenManager();
        }

        public static FocusListenManager Instance { get { return manager; } }


        public Collection<FocusListener> FocusListeners { get; } = new Collection<FocusListener>();

        /// <summary>
        /// 添加监听器
        /// </summary>
        /// <param name="listener"></param>
        public static void AddListener(FocusListener listener)
        {
            Instance.FocusListeners.Add(listener);
        }

        public static void RemoveListener(FocusListener listener)
        {
            Instance.FocusListeners.Remove(listener);
        }

        /// <summary>
        /// 广播事件
        /// </summary>
        /// <param name="event">事件类型</param>
        /// <param name="context">发布广播的监听器</param>
        /// <param name="eventControl">触发事件的控件</param>
        public static void Broadcast(FocusEvent @event, FocusListener context, Control eventControl)
        {
            foreach (FocusListener listener in Instance.FocusListeners)
            {
                if(listener != null && listener != context)
                {
                    listener.OnBroadcast(@event, context, eventControl);
                }
            }
        }

        /// <summary>
        /// 焦点事件
        /// </summary>
        public enum FocusEvent
        {
            Got,Lost
        }

        /// <summary>
        /// 焦点广播接口
        /// </summary>
        public interface IFocusBroadcast
        {
            /// <summary>
            /// 广播事件
            /// </summary>
            /// <param name="event">事件类型</param>
            /// <param name="context">发布广播的监听器</param>
            /// <param name="eventControl">触发事件的控件</param>
            void OnBroadcast(FocusEvent @event, FocusListener context, Control eventControl);
        }
    }
}
