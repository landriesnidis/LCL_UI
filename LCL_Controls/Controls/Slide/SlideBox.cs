using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Slide
{
    public partial class SlideBox : UserControl
    {
        public delegate void PageChangedEventHandler(object sender, PageChangedEventArgs e);

        public event PageChangedEventHandler PageChanged;

        private int targetLocation = 0;
        private int pageIndex = -1;

        public int PageIndex { get { return pageIndex; } }

        [Browsable(true)]
        [Description("翻页时移动的速率，当Rate = 1时，无翻页动画效果，Rate值越大翻页越慢")]
        public int Rate { get; set; } = 5;

        [Browsable(true)]
        [Description("翻页时最小的移动速度(像素单位)")]
        public int ReviseValue { get; set; } = 5;
        Timer timer = new Timer();

        public int PageCount { get { return panel.Controls.Count; } }

        public SlideBox()
        {
            InitializeComponent();

            panel.Size = Size;
            panel.Left = panel.Top = 0;
            panel.AutoScroll = false;
            panel.AutoSize = true;

            this.ControlAdded += (s, e) => {
                AddPage(e.Control);
            };

            this.Resize += (s, e) =>
            {
                panel.Size = Size;
                if(pageIndex!=-1)panel.Controls[pageIndex].Size = Size;
            };
            this.SizeChanged += (s, e) =>
            {
                foreach (Control c in panel.Controls)
                {
                    c.Size = Size;
                }
            };

            timer.Enabled = false;
            timer.Interval = 10;
            timer.Tick += (s, e) =>
            {
                // 当前位置与目标位置相差距离小于最小移动距离时，结束运动
                if (Math.Abs(panel.Left - targetLocation) <= ReviseValue)
                {
                    panel.Left = targetLocation;
                    timer.Enabled = false;
                    PageChanged?.Invoke(this, new PageChangedEventArgs(pageIndex));
                    return;
                }
                int v = (panel.Left - targetLocation) / Rate;
                if (Math.Abs(v) < ReviseValue) v = ReviseValue * (v < 0 ? -1 : 1);
                panel.Left = panel.Left - v;
            };
        }

        public int AddPage(Control control)
        {
            Panel p = new Panel();
            p.Size = Size;
            p.Visible = true;
            p.Margin = new System.Windows.Forms.Padding(0);
            p.Padding = new System.Windows.Forms.Padding(0);
            p.Controls.Add(control);
            p.ControlRemoved += (s, e) =>
            {
                // 当控件移除时，SlideBox和Page之间的Panel也需要移除
                if (p.Controls.Count == 0) panel.Controls.Remove(p);
            };
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(p);

            if (pageIndex == -1) pageIndex = 0;

            // 返回当前页面的
            return PageCount - 1;
        }



        public void RemovePage(Control control)
        {
            int i = 0;
            foreach (Control c in panel.Controls)
            {
                if (c.Controls[0] == control)
                {
                    //panel.Controls.Remove(c);
                    RemovePageAt(i);
                    return;
                }
                i++;
            }
        }

        public Control GetPage(int pageNum)
        {
            // SlideBox和Page之间有一层普通Panel
            return panel.Controls[pageNum].Controls[0];
        }

        public void RemovePageAt(int pageNum)
        {
            panel.Controls.RemoveAt(pageNum);
            if(pageNum<= pageIndex)
            {
                pageIndex--;
                panel.Left = - panel.Controls[pageIndex].Left;
            }
        }

        public void Jump(int pageNum)
        {
            if (pageNum < 0 || pageNum >= panel.Controls.Count) return;
            pageIndex = pageNum;

            targetLocation = - panel.Controls[pageNum].Left;
            timer.Enabled = true;
        }

        public void NextPage()
        {
            Jump(pageIndex+1);
        }

        public void PreviousPage()
        {
            Jump(pageIndex - 1);
        }
    }

    public class PageChangedEventArgs : EventArgs
    {
        public int PageIndex { get; set; }

        public PageChangedEventArgs(int pageIndex)
        {
            PageIndex = pageIndex;
        }
    }
}
