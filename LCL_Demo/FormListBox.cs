using Landriesnidis.LCL_Controls.Controls.ListBox;
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
            KeyValueListItem item = new KeyValueListItem(textBox1.Text, textBox2.Text);
            item.AllowEdit = checkBox1.Checked;
            kvlb.Items.Add(item);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            kvlb.Items.Clear();
        }
    }
}
