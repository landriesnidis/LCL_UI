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
        public int Rate { get; set; } = 5;
        public int ReviseValue { get; set; } = 5;
        Timer timer = new Timer();

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
                if (Math.Abs(panel.Left - targetLocation) <= ReviseValue)
                {
                    panel.Left = targetLocation;
                    timer.Enabled = false;
                    PageChanged?.Invoke(this, new PageChangedEventArgs(pageIndex));
                    return;
                }
                panel.Left = panel.Left - (panel.Left - targetLocation) / Rate;
            };
        }

        public void AddPage(Control control)
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
        }

        public void RemovePage(Control control)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.Controls[0] == control)
                {
                    panel.Controls.Remove(c);
                    return;
                }

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
