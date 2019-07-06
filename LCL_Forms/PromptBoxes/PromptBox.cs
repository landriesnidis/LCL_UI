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
    public partial class PromptBox : BaseBox<bool>
    {
        [Browsable(true)]
        public string Content { get { return labContent.Text; } set { labContent.Text = value; } }

        [Browsable(true)]
        public string ButtonOKText { get { return btnOK.Text; } set { btnOK.Text = value; } }

        public PromptBox()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            result.IsCancel = false;
            result.Data = false;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            result.IsCancel = false;
            result.Data = true;
            Close();
        }
    }
}
