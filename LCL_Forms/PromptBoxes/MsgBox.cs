using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    public partial class MsgBox : BaseBox<bool>
    {
        [Browsable(true)]
        public string Content { get { return labContent.Text; } set { labContent.Text = value; } }

        public MsgBox()
        {
            InitializeComponent();
        }
    }
}
