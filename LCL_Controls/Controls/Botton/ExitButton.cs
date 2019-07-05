using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_UI.Controls.Botton
{
    [DefaultEvent("Click")]
    public partial class ExitButton : UserControl
    {
        public ExitButton()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = global::Landriesnidis.LCL_UI.Properties.Resources.ExitButton_1;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Landriesnidis.LCL_UI.Properties.Resources.ExitButton_0;
        }

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = global::Landriesnidis.LCL_UI.Properties.Resources.ExitButton_2;
        }

        private void ExitButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = global::Landriesnidis.LCL_UI.Properties.Resources.ExitButton_0;
        }
    }
}
