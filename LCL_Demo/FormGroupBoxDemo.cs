using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCL_Demo
{
    public partial class FormGroupBoxDemo : Form
    {
        public FormGroupBoxDemo()
        {
            InitializeComponent();
        }

        private void LclGroupBox1_CloseButtonClick(object sender, EventArgs e)
        {
            lclGroupBox1.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl.AddPage("Test", pictureBox1);
        }
    }
}
