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

namespace IoT_Studio.UI.Settings
{
    public partial class DynamicListItem : UserControl
    {
        [Browsable(true)]
        public string Title { get { return labTitle.Text; } set { labTitle.Text = value; } }
        [Browsable(true)]
        public string Content { get { return labContent.Text; } set { labContent.Text = value; } }
        [Browsable(true)]
        public string TagText { get { return labTagText.Text; } set { labTagText.Text = value; } }
        [Bindable(true)]
        [IODescriptionAttribute("PictureBoxImageDescr")]
        public Image Image { get { return pic.Image; } set { pic.Image = value; } }
        [Browsable(true)]
        public string ImageLocation { get { return pic.ImageLocation; } set { pic.ImageLocation = value; } }

        public DynamicListItem()
        {
            InitializeComponent();

            Control[] controls = new Control[] { pic, panel1,  panel2, labTagText, labTitle, labContent };
            foreach (Control c in controls)
            {
                c.MouseMove += All_MouseMove;
                c.MouseLeave += All_MouseLeave;
            }
        }

        private void All_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(201, 222, 245);
            this.Cursor = Cursors.Hand;
        }

        private void All_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251,251,251);
        }
    }
}
