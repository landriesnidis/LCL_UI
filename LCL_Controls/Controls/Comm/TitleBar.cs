using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Comm
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();

            miniImageButtonArrow.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Arrow;
            miniImageButtonClose.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Close;
        }
    }
}
