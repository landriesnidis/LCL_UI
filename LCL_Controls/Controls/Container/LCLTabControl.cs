using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Landriesnidis.LCL_Controls.Controls.Comm;
using System.Collections;

namespace Landriesnidis.LCL_Controls.Controls.Container
{
    public partial class LCLTabControl : UserControl
    {
        public TabPageCollection Pages { get; set; }

        public LCLTabControl()
        {
            InitializeComponent();

            Pages = new TabPageCollection(panelTitle,panelMain);

            btnMorePage.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Arrow;
        }

        public void AddPage(TabPage page)
        {
            Pages.Add(page);
        }

        public void AddPage(string title,Control control)
        {
            TabPage page = new TabPage();
            page.ContentControl = control;
            page.TitleBar = new TitleBar();
            page.TitleBar.Title = title;
            Pages.Add(page);
        }
    }

    public class TabPageCollection : ICollection<TabPage>
    {
        private FlowLayoutPanel headPanel;
        private Panel mainPanel;

        private List<TabPage> tabPages = new List<TabPage>();

        int ICollection<TabPage>.Count => throw new NotImplementedException();

        bool ICollection<TabPage>.IsReadOnly => throw new NotImplementedException();

        public TabPageCollection(Panel headPanel,Panel mainPanel)
        {
            this.headPanel = (FlowLayoutPanel)headPanel;
            this.mainPanel = mainPanel;
        }

        public int Count()
        {
            return tabPages.Count;
        }

        public bool IsReadOnly()
        {
            return false;
        }

        public void Add(TabPage item)
        {
            tabPages.Add(item);

            headPanel.Controls.Add(item.TitleBar);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(item.ContentControl);
            item.ContentControl.Dock = DockStyle.Fill;

            item.TitleBar.btnClose.Click += (s,e)=>{
                MessageBox.Show("btnClose.Click");

                Remove(item);
            };

            item.TitleBar.labTitle.Click += (s, e) => {
                MessageBox.Show("labTitle.Click");

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(item.ContentControl);
            };
        }

        public void Clear()
        {
            headPanel.Controls.Clear();
            mainPanel.Controls.Clear();

            tabPages.Clear();
        }

        public bool Contains(TabPage item)
        {
            return tabPages.Contains(item);
        }

        public void CopyTo(TabPage[] array, int arrayIndex)
        {
            tabPages.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TabPage> GetEnumerator()
        {
            return tabPages.GetEnumerator();
        }

        public bool Remove(TabPage item)
        {
            item.ContentControl.Dispose();
            headPanel.Controls.Remove(item.TitleBar);
            return tabPages.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return tabPages.GetEnumerator();
        }
    }

    public class TabPage
    {
        public TitleBar TitleBar { get; set; }
        public Control ContentControl { get; set; }
    }
}
