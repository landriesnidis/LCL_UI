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
    public partial class FormSlideBox : Form
    {
        int i = 0;

        public FormSlideBox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn  = new Button();
            btn.Text = "Button" + i++;
            slideBox1.AddPage(btn);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int i;
            int.TryParse(textBox1.Text, out i);
            slideBox1.Jump(i);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            slideBox1.PreviousPage();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            slideBox1.NextPage();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            slideBox1.Rate = trackBar1.Value;
        }
    }
}
