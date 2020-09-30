using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Landriesnidis.LCL_Controls.Extensions.ControlExtensions;

namespace IoT_Studio.UI.Settings
{
    [DefaultEvent("Click")]
    public partial class StaticListItem : UserControl
    {
        [Browsable(true)]
        public string Title { get { return labTitle.Text; } set { labTitle.Text = value; } }
        [Browsable(true)]
        public string Content { get { return labContent.Text; } set { labContent.Text = value; } }
        [Bindable(true)]
        [IODescriptionAttribute("PictureBoxImageDescr")]
        public Image Image { get { return pic.Image; } set { pic.Image = value; } }
        [Browsable(true)]
        public string ImageLocation { get { return pic.ImageLocation; } set { pic.ImageLocation = value; } }

        public StaticListItem()
        {
            InitializeComponent();

            // 整体背景色变化
            Control[] controls = new Control[] { panel1, pic, panel2, panel3, labTitle, labContent };
            foreach(Control c in controls)
            {
                c.MouseMove += All_MouseMove;
                c.MouseLeave += All_MouseLeave;
                // 统一单击事件
                c.Click += All_Click;
            }

            // 所有控件的单击事件都指向容器控件
            // this.TraverseChildControls((control) => { control.Click += (s, e) => { this.CallControlEvent("Click", e); }; }, true);

        }

        private void All_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void All_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(201,222,245);
        }

        private void All_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(238, 235, 235);
        }
    }
}
