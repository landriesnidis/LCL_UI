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
    public partial class InputBox : BaseBox<string>
    {
        [Browsable(true)]
        public string Content { get { return labContent.Text; } set { labContent.Text = value; } }

        [Browsable(true)]
        public string ButtonOKText { get { return btnOK.Text; } set { btnOK.Text = value; } }

        [Browsable(true)]
        public string ButtonCleanText { get { return btnClean.Text; } set { btnClean.Text = value; } }

        public InputBox()
        {
            InitializeComponent();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            tbText.Text = null;
            tbText.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            result.IsCancel = false;
            result.Data = tbText.Text;
            Close();
        }
    }
}
