using Landriesnidis.LCL_Forms.ToastBox;
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
            //lclGroupBox1.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lclTabControl1.AddPage("Test", new Button());
        }

        private void TabControl_PageAdded(object sender, Landriesnidis.LCL_Controls.Controls.Container.PageChangedEventArgs e)
        {
            Toast.Show($"创建新页面[{e.TabPage.TitleBar.Title}]");

        }

        private void TabControl_PageRemoved(object sender, Landriesnidis.LCL_Controls.Controls.Container.PageChangedEventArgs e)
        {
            Toast.Show($"已关闭页面[{e.TabPage.TitleBar.Title}]");
        }

        private void LclGroupBox1_CloseButtonClick_1(object sender, EventArgs e)
        {
           // lclGroupBox1.Dispose();
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {

        }

        private void FormGroupBoxDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
