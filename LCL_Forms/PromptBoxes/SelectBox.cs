using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace Landriesnidis.LCL_UI.PromptBoxes
{
    public partial class SelectBox : PromptBox
    {
        public ObjectCollection Items { get { return cb.Items; } }

        public SelectBox()
        {
            InitializeComponent();
        }
    }
}
