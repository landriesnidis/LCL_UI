﻿using System;
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
using Landriesnidis.LCL_Controls.Components;

namespace Landriesnidis.LCL_Controls.Controls.Container
{
    public delegate void PageAddedHandler(object sender, PageChangedEventArgs e);
    public delegate void PageRemovedHandler(object sender, PageChangedEventArgs e);


    public partial class LCLTabControl : UserControl
    {
        [Browsable(true)]
        public TabPageCollection Pages { get; set; }

        [Browsable(true)]
        public event PageAddedHandler PageAdded;
        [Browsable(true)]
        public event PageRemovedHandler PageRemoved;

        //BackColorSupport backColorSupport;
        FocusListener focusListener;

        public LCLTabControl()
        {
            InitializeComponent();

            Pages = new TabPageCollection(this, panelTitle, panelMain);

            btnMorePage.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.MiniImageButton_Arrow;

            //backColorSupport = new BackColorSupport(this);
            focusListener = new FocusListener(this);
            /*
            // 
            // backColorSupport
            // 
            this.backColorSupport.ParentControl = this.panelTitle;
            this.backColorSupport.RespondGotFocusEvent = false;
            this.backColorSupport.RespondLostFocusEvent = false;
            this.backColorSupport.RespondMouseDownEvent = false;
            this.backColorSupport.RespondMouseLeaveEvent = true;
            this.backColorSupport.RespondMouseMoveEvent = true;
            this.backColorSupport.StateColorSet = this.stateColorSet;
            this.backColorSupport.TargetTypes = null;
            // 
            // focusListener
            // 
            this.focusListener.AllowUseClickEvent = true;
            this.focusListener.ParentControl = this.panelTitle;

            backColorSupport.TargetTypes = new Type[] { typeof(TitleBar),typeof(Label) };
            
            PageAdded += (s, e)=>{
                backColorSupport.AddChildControl(e.TabPage.TitleBar);
                RefreshPagesMenu();
            };
            PageRemoved += (s, e) => {
                backColorSupport.RemoveChildControl(e.TabPage.TitleBar);
                RefreshPagesMenu();
            };
            */

            // 为箭头按钮添加快捷菜单
            btnMorePage.Click += (s, e) =>
            {
                cmsPagesMenu.Show(btnMorePage, btnMorePage.Width - cmsPagesMenu.Width, cmsPagesMenu.Height);
            };

            cmsPagesMenu.Opening += (s, e) =>
            {
                cmsPagesMenu.Items.Clear();

                foreach (Control c in panelTitle.Controls)
                {
                    TitleBar tb = (TitleBar)c;
                    if (c.Top != 1)
                    {
                        var item = new ToolStripButton();
                        item.Text = tb.Title;
                        cmsPagesMenu.Items.Add(item);
                    }
                }
            };
        }

        private void RefreshPagesMenu()
        {

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

            page.TitleBar.FocusListener.AddChildControl(control);

            Pages.Add(page);
        }

        public void PerformPageAdded(object sender, PageChangedEventArgs e)
        {
            PageAdded?.Invoke(this, e);
        }

        public void PerformPageRemoved(object sender, PageChangedEventArgs e)
        {
            PageRemoved?.Invoke(this, e);
        }
    }

    public class TabPageCollection : ICollection<TabPage>
    {
        private FlowLayoutPanel headPanel;
        private Panel mainPanel;
        private LCLTabControl tabControl;

        private List<TabPage> tabPages = new List<TabPage>();

        int ICollection<TabPage>.Count => throw new NotImplementedException();

        bool ICollection<TabPage>.IsReadOnly => throw new NotImplementedException();

        public TabPageCollection(LCLTabControl tabControl, Panel headPanel,Panel mainPanel)
        {
            this.tabControl = tabControl;
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
                Remove(item);
            };

            item.TitleBar.labTitle.Click += (s, e) => {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(item.ContentControl);
            };

            tabControl.PerformPageAdded(tabControl,new PageChangedEventArgs(item));
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

            bool b = tabPages.Remove(item);

            if (b)
            {
                tabControl.PerformPageRemoved(tabControl, new PageChangedEventArgs(item));
            }
            return b;
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

    public class PageChangedEventArgs : EventArgs
    {
        public TabPage TabPage { get; set; }

        public PageChangedEventArgs(TabPage tabPage)
        {
            TabPage = tabPage;
        }
    }
}
