using Landriesnidis.LCL_Controls.Controls.Container;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Slide
{
    public partial class RollerShutter : UserControl, IRollerShutter
    {

        private List<LCLGroupBox> list = new List<LCLGroupBox>();

        [Browsable(true)]
        public bool ReverseControls { get; set; }

        public RollerShutter()
        {
            InitializeComponent();
        }

        public LCLGroupBox Add()
        {
            return FormatBox();
        }

        public LCLGroupBox Add(LCLGroupBox groupBox)
        {
            return FormatBox(groupBox);
        }

        public LCLGroupBox FormatBox(LCLGroupBox box = null)
        {
            box = box ?? new LCLGroupBox();
            box.titleBar.btnClose.Visible = false;
            box.Dock = DockStyle.Top;
            box.Height = 0;
            box.ArrowButtonClick += (s, e) =>
            {
                RefreshBoxesHeight(box);
            };
            box.titleBar.labTitle.DoubleClick += (s, e) =>
            {
                RefreshBoxesHeight(box);
            };

            // 使GroupBox内的控件倒序
            if(ReverseControls) box.ControlAdded += (s, e) =>{ e.Control.BringToFront(); };

            box.Visible = true;
            list.Add(box);
            panel.Controls.Add(box);
            box.BringToFront();
            return box;
        }

        private LCLGroupBox OpenedGroupBox=null;
        private void RefreshBoxesHeight(LCLGroupBox mainBox)
        {
            // 如果是已经展开的则关闭
            if (OpenedGroupBox == mainBox)
            {
                mainBox.Height = 0;
                OpenedGroupBox = null;
                return;
            }

            int max = 0;
            foreach (Control c in mainBox.Controls)
            {
                int temp = c.Top + c.Height;
                if (temp > max) max = temp;
            }
            mainBox.Height = 10 + max;

            foreach (var b in list)
            {
                if (b != mainBox) b.Height = 0;
            }

            OpenedGroupBox = mainBox;
        }
    }

    public interface IRollerShutter
    {
        LCLGroupBox Add();
        LCLGroupBox Add(LCLGroupBox groupBox);

        
    }
}
