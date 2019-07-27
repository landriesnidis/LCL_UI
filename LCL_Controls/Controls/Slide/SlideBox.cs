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
        private int targetLocation = 0;
        private int pageIndex = -1;
        public int Rate { get; set; } = 10;
        public int ReviseValue { get; set; } = 3;
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
}
