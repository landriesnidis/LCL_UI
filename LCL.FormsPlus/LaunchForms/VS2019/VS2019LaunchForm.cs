using Landriesnidis.LCL_Forms.PromptBoxes;
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

namespace IoT_Studio.UI.Settings
{
    public partial class VS2019LaunchForm : VS2019LaunchFormBase, IVS2019LaunchForm
    {
        [Browsable(true)]
        public string FormTitle { get { return labFormTitle.Text; } set { labFormTitle.Text = value; Text = value; } }

        [Browsable(true)]
        public string DynamicListTitle { get { return labDynamicListTitle.Text; } set { labDynamicListTitle.Text = value; } }

        [Browsable(true)]
        public string StaticListTitle { get { return labStaticListTitle.Text; } set { labStaticListTitle.Text = value; } }

        [Browsable(true)]
        public StaticListItem[] StaticListItems { get { if (staticListItems == null) staticListItems = new StaticListItem[] { sliStaticListItem1, sliStaticListItem2, sliStaticListItem3, sliStaticListItem4 }; return staticListItems; } }
        private StaticListItem[] staticListItems;

        [Browsable(true)]
        public string LinkText { get { return labLinkText.Text; } set { labLinkText.Text = value; } }

        [Browsable(true)]
        [Description("当链接文本被单击时触发")]
        public event EventHandler LinkTextClick;


        public VS2019LaunchForm()
        {
            InitializeComponent();

            // 事件处理
            // 链接文本的单击事件转发到窗体的 LinkTextClick 事件上
            labLinkText.Click += (s, e) => LinkTextClick.Invoke(s,e);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // 配置窗体支持鼠标拖动的区域
            mouseMoveController.Form = this;
            mouseMoveController.Add(new Control[] { this, panelContent, panelTitle, labFormTitle });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 在动态列表中添加一个条项目
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(DynamicListItem item)
        {
            item.Visible = false;
            panelDynamicList.Controls.Add(item);
            item.Dock = DockStyle.Top;
            item.Visible = true;
        }

        /// <summary>
        /// 在动态列表中创建一条项目
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="tagText"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public DynamicListItem AddItem(string title, string content, string tagText, Image image)
        {
            DynamicListItem item = new DynamicListItem() { Title = title, Content = content, TagText = tagText, Image = image };
            AddItem(item);
            return item;
        }
    }

    public interface IVS2019LaunchForm
    {
        void AddItem(DynamicListItem item);
        DynamicListItem AddItem(string title, string content, string tagText, Image image);
    }
}
