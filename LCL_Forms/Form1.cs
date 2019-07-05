using Landriesnidis.LCL_UI.PromptBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCL_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            BaseBox box = new BaseBox();
            box.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PasswordBox box = new PasswordBox();
            box.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MsgBox box = new MsgBox();
            box.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PromptBox box = new PromptBox();
            box.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SelectBox box = new SelectBox();
            box.ShowDialog();
        }
    }
}
