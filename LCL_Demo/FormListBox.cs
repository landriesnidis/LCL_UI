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
    public partial class FormListBox : Form
    {
        public FormListBox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            kvlb.Items.Add(new Landriesnidis.LCL_Controls.Controls.ListBox.KeyValueListItem(textBox1.Text, textBox2.Text));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            kvlb.Items.Clear();
        }
    }
}
