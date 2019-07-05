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
    public partial class PasswordBox : BaseBox
    {
        [Browsable(true)]
        public string OKButtonText { get { return btnOK.Text; } set { btnOK.Text = value; } }

        [Browsable(true)]
        public string CleanButtonText { get { return btnClean.Text; } set { btnClean.Text = value; } }

        public PasswordBox()
        {
            InitializeComponent();
        }

        private void Psw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnOK.PerformClick();
            }
        }
    }
}
