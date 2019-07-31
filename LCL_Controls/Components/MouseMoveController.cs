using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Components
{
    public partial class MouseMoveController : Component
    {
        [Browsable(true)]
        public bool AllowDoubleClickMaximization { get; set; } = false;

        [Browsable(true)]
        public Form Form { get; set; }

        private List<Control> Controls { get; set; } = new List<Control>();
        private Dictionary<object, Point> dictMouseDowmPoint = new Dictionary<object, Point>();
        private bool leftFlag = false;

        public MouseMoveController()
        {
            InitializeComponent();
        }

        public MouseMoveController(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        /// <summary>
        /// 添加一个控件
        /// </summary>
        /// <param name="control">控件(或窗体)对象</param>
        public void Add(Control control)
        {
            InitControlEvents(control);
        }

        /// <summary>
        /// 添加一组控件
        /// </summary>
        /// <param name="controls">控件(或窗体)对象的集合</param>
        public void Add(ICollection<Control> controls)
        {
            InitAllControlsEvents(controls);
        }

        /// <summary>
        /// 移除一个控件
        /// </summary>
        /// <param name="control">控件(或窗体)对象</param>
        /// <returns></returns>
        public bool Remove(Control control)
        {
            dictMouseDowmPoint.Remove(control);
            return Controls.Remove(control);
        }

        /// <summary>
        /// 清除所有受控的控件
        /// </summary>
        public void Clear()
        {
            dictMouseDowmPoint.Clear();
            Controls.Clear();
        }


        private void InitControlEvents(Control control)
        {
            control.MouseDown += (obj, args) => {
                if (args.Button == MouseButtons.Left)
                {
                    Point mouseSet = Control.MousePosition;
                    if (dictMouseDowmPoint.ContainsKey(obj))
                    {
                        dictMouseDowmPoint[obj] = new Point(-(mouseSet.X - Form.Location.X), -(mouseSet.Y - Form.Location.Y));
                    }
                    else
                    {
                        dictMouseDowmPoint.Add(obj, new Point(-(mouseSet.X - Form.Location.X), -(mouseSet.Y - Form.Location.Y)));
                    }
                    leftFlag = true;
                }
            };
            control.MouseMove += (obj, args) => {
                if (leftFlag)
                {
                    Point mouseSet = Control.MousePosition;
                    mouseSet.Offset(dictMouseDowmPoint[obj].X, dictMouseDowmPoint[obj].Y);
                    Form.Location = mouseSet;
                }
            };
            control.MouseUp += (obj, args) => {
                if (leftFlag)
                {
                    leftFlag = false;
                }
            };
            control.DoubleClick += (obj, args) => {
                if (AllowDoubleClickMaximization)
                {
                    if (Form.WindowState == FormWindowState.Maximized)
                    {
                        Form.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        Form.WindowState = FormWindowState.Maximized;
                    }
                }
            };
        }

        private void InitAllControlsEvents(ICollection<Control> controls)
        {
            foreach (Control control in controls)
            {
                InitControlEvents(control);
            }
        }
    }
}
