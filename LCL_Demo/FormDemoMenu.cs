using IoT_Studio.UI.Settings;
using Landriesnidis.LCL_Controls.Extensions.ControlExtensions;
using Landriesnidis.LCL_Forms.PromptBoxes;
using LCL_Demo.Properties;
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

        private void Button5_Click(object sender, EventArgs e)
        {
            OpenForm(new FormSlideBox());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 创建窗体对象
            VS2019LaunchForm form = new VS2019LaunchForm();
            // 创建10条项目
            for (int i = 1; i <= 10; ++i)
            {
                // 获取动态项目条对象
                var item = form.AddItem("Item " + i, "Text that describes options for the functionality of this card.", DateTime.Now.Date.ToLongDateString(), Resources.status_unknow);
                // 设置单击事件
                item.Click += (s, args) => DialogBoxes.MsgBox("Info",$"{item.Title} has been clicked.");
                // 将单击事件共享到所有子控件
                item.SharedClickEvent(); 
                // 选择性的共享单击事件
                // item.SharedClickEvent(new Type[] { typeof(PictureBox), typeof(Label)});
            }
            OpenForm(form);
        }
    }
}
