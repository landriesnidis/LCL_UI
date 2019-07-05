using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_UI.PromptBoxes
{
    public partial class PromptBox : MsgBox
    {
        [Browsable(true)]
        public string OKButtonText { get { return btnOK.Text; } set { btnOK.Text = value; } }

        public PromptBox()
        {
            InitializeComponent();
        }
    }
}
