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
    public partial class SimpleButton : UserControl
    {
        [Browsable(true)]
        public string Title { get { return labButtonText.Text; } set { labButtonText.Text = value; } }

        [Browsable(true)]
        public Color MouseDownForegroundColor { get; set; } = Color.White;
        [Browsable(true)]
        public Color MouseDownBackgroundColor { get; set; } = Color.FromArgb(82, 176, 239);
        [Browsable(true)]
        public Color MouseUpForegroundColor { get; set; } = Color.White;
        [Browsable(true)]
        public Color MouseUpBackgroundColor { get; set; } = Color.FromArgb(0, 122, 204);

        public SimpleButton()
        {
            InitializeComponent();
            labButtonText.ForeColor = MouseUpForegroundColor;
            labButtonText.BackColor = MouseUpBackgroundColor;

            labButtonText.Text = Name;
        }

        private void labButtonText_MouseDown(object sender, MouseEventArgs e)
        {
            labButtonText.ForeColor = MouseDownForegroundColor;
            labButtonText.BackColor = MouseDownBackgroundColor;
        }

        private void labButtonText_MouseUp(object sender, MouseEventArgs e)
        {
            labButtonText.ForeColor = MouseUpForegroundColor;
            labButtonText.BackColor = MouseUpBackgroundColor;
        }
    }
}
