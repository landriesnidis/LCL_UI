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
    public partial class BaseBox : Form
    {
        [Browsable(true)]
        public new string Text { get { return labTitle.Text; } set { labTitle.Text = value; } }

        [Browsable(true)]
        public string DefaultButtonText { get { return btnCancel.Text; } set { btnCancel.Text = value; } }

        public BaseBox()
        {
            InitializeComponent();

            mmc.Form = this;
            mmc.Add(new Control[] { labTitle,panelBase });
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
