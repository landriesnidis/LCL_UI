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
    public partial class ControlVisibleAdapter : Component
    {
        public void Associate(Control control,ToolStripMenuItem item)
        {
            item.CheckOnClick = true;
            control.VisibleChanged += (s, e) =>
            {
                item.Checked = control.Visible;
            };
            item.CheckedChanged += (s,e) =>
            {
                control.Visible = item.Checked;
            };
        }

        public ControlVisibleAdapter()
        {
            InitializeComponent();
        }

        public ControlVisibleAdapter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
