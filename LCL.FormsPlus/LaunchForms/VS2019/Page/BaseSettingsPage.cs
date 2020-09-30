using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Landriesnidis.LCL_Controls.Controls.Slide;
using Landriesnidis.LCL_Controls.Components.Broadcast;

namespace IoT_Studio.UI.Settings.Page
{
    public partial class BaseSettingsPage : UserControl
    {
        protected static BroadcastPublisher BroadcastPublisher { get; set; } = new BroadcastPublisher();

        private SlideBox box;

        public BaseSettingsPage()
        {
            InitializeComponent();
        }

        public BaseSettingsPage(SlideBox box)
        {
            InitializeComponent();
            this.box = box;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            box.Jump(0);
        }

        private void BaseSettingsPage_Load(object sender, EventArgs e)
        {
            panelLeft.Width = Width / 2;
            panelLeft.SizeChanged += (s, args) =>
            {
                panelLeft.Width = Width / 2;
            };
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        }
    }
}