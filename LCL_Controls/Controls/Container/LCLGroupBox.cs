using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Landriesnidis.LCL_Controls.Controls.Container
{
    [DefaultEvent("CloseButtonClick")]
    [DefaultProperty("Title")]
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class LCLGroupBox : UserControl
    {
        [Browsable(true)]
        [Description("标题")]
        public string Title { get { return title; } set { titleBar.Title = value; title = value; } }
        private string title;

        [Browsable(true)]
        [Description("是否启用标题箭头按钮")]
        public bool TitleBarArrowButton { get { return titleBar.btnArrow.Visible; } set { titleBar.btnArrow.Visible = value; } }

        [Browsable(true)]
        [Description("是否启用标题关闭按钮")]
        public bool TitleBarCloseButton { get { return titleBar.btnClose.Visible; } set { titleBar.btnClose.Visible = value; } }

        [Browsable(true)]
        [Description("标题栏箭头按钮绑定对应快捷菜单")]
        public ContextMenuStrip TitleBarArrowButtonContextMenu { get; set; }

        [Browsable(true)]
        [Description("标题关闭按钮单击事件")]
        public event EventHandler CloseButtonClick;

        public LCLGroupBox()
        {
            InitializeComponent();

            // 为箭头按钮添加快捷菜单
            titleBar.btnArrow.Click += (s, e) =>
            {
                if (TitleBarArrowButtonContextMenu != null)
                {
                    TitleBarArrowButtonContextMenu.Show(titleBar, titleBar.Width - TitleBarArrowButtonContextMenu.Width, titleBar.Height);
                }
            };
            // 为关闭键添加单击事件
            titleBar.btnClose.Click += (s, e) =>
            {
                CloseButtonClick?.Invoke(this, e);
            };
            
            
            this.ControlAdded += (s, e) =>
            {
                titleBar.FocusListener.AddChildControl(e.Control);
            };

            this.ControlRemoved += (s, e) =>
            {
                titleBar.FocusListener.RemoveChildControl(e.Control);
            };
            
        }

        private void LCLGroupBox_Load(object sender, EventArgs e)
        {
            this.Padding = new System.Windows.Forms.Padding(0, titleBar.Height, 0, 0);

            titleBar.Title = title;
            titleBar.Top = 0;
            titleBar.Left = 0;
            titleBar.Width = Width;
        }
    }
}
