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
    public partial class FormDemoMenu : Form
    {
        public FormDemoMenu()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMsgBoxDemo());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenForm(new FormGroupBoxDemo());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenForm(new FormListBox());
        }
    }
}
