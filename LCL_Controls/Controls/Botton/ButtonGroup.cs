using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Botton
{
    [DefaultEvent("ExitButtonClick")]
    public partial class ButtonGroup : UserControl
    {
        [Browsable(true)]
        public bool MaximizeBox { get { return maximizeButton.Visible; } set { maximizeButton.Visible = value; } }
        [Browsable(true)]
        public bool MinimizeBox { get { return minimizeButton.Visible; } set { minimizeButton.Visible = value; } }

        public event EventHandler ExitButtonClick;
        public event EventHandler MaximizeButtonClick;
        public event EventHandler MinimizeButtonClick;

        public ButtonGroup()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClick?.Invoke(sender, e);
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            MaximizeButtonClick?.Invoke(sender, e);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MinimizeButtonClick?.Invoke(sender, e);
        }
    }
}
