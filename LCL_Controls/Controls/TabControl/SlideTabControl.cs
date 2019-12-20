using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.TabControl
{
    public partial class SlideTabControl : UserControl, ITabControl<ToolStripItem>
    {
        public SlideTabControl()
        {
            InitializeComponent();
        }

        public event ITabControl<ToolStripItem>.PageChangedEventHandler PageChanged;

        public Dictionary<ToolStripItem, Control> Pages = new Dictionary<ToolStripItem, Control>();

        public int CurrentIndex { get; private set; }

        public ToolStripItem AddPage(string title, Control content, Image icon = null)
        {
            ToolStripItem item = tsTitle.Items.Add(title, icon);
            Pages.Add(item, content);
            slideBox.AddPage(content);

            if (tsTitle.Items.Count == 1) Jump(0);

            return item;
        }

        public void Jump(string title)
        {
            foreach (ToolStripItem item in tsTitle.Items)
            {
                PerformItemClicked(item);
            }
        }

        public void Jump(Control content)
        {
            foreach (var kv in Pages)
            {
                if (content == kv.Value)
                {
                    PerformItemClicked(kv.Key);
                    return;
                }
            }
        }

        public void Jump(int index)
        {
            if (index < tsTitle.Items.Count)
            {
                PerformItemClicked(tsTitle.Items[index]);
            }
        }

        public void NextPage()
        {
            Jump(CurrentIndex+1);
        }

        public void PreviousPage()
        {
            if(CurrentIndex>0) Jump(CurrentIndex -1);
        }

        public Control RemovePage(string title)
        {
            foreach (ToolStripItem item in tsTitle.Items)
            {
                if(item.Text == title)
                {
                    Control control = Pages[item];
                    tsTitle.Items.Remove(item);
                    return control;
                }
            }
            return null;
        }

        public void RemovePage(Control content)
        {
            foreach(var kv in Pages)
            {
                if(content == kv.Value)
                {
                    tsTitle.Items.Remove(kv.Key);
                    return;
                }
            }
        }

        public void RemovePage(int index)
        {
            if (index < tsTitle.Items.Count)
            {
                tsTitle.Items.RemoveAt(index);
            }
        }

        private void TsTitle_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            e.Item.Click += Item_Click;
            e.Item.MouseDown += Item_MouseDown;
            string name = e.Item.Text;
            int c = 1;
            while (HasCheckSameName(e.Item))
            {
                e.Item.Text = $"{name} {++c}";
            }
        }

        private bool HasCheckSameName(ToolStripItem newItem)
        {
            foreach (ToolStripItem item in tsTitle.Items)
            {
                if(newItem != item && newItem.Text == item.Text)
                {
                    return true;
                }
            }
            return false;
        }

        ToolStripItem ActiveContextMenuTitleItem;
        private void Item_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ActiveContextMenuTitleItem = (ToolStripItem)sender;
                cmsTitleItem.Show(Control.MousePosition);
            }
        }

        private void TsTitle_ItemRemoved(object sender, ToolStripItemEventArgs e)
        {
            e.Item.Click -= Item_Click;

            slideBox.RemovePage(Pages[e.Item]);
            Pages.Remove(e.Item);
        }

        private void TsTitle_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = tsTitle.Items.IndexOf(e.ClickedItem);
            slideBox.Jump(index);
            CurrentIndex = index;
            PageChanged?.Invoke(sender, new PageChangedEventArgs(CurrentIndex));

            foreach (ToolStripItem item in tsTitle.Items)
            {
                if (item == e.ClickedItem)
                {
                    item.BackColor = stateColorSet.GotFocusBackgroundColor;
                    item.ForeColor = stateColorSet.GotFocusForegroundColor;
                }
                else
                {
                    item.BackColor = stateColorSet.MouseLeaveBackgroundColor;
                    item.ForeColor = stateColorSet.MouseLeaveForegroundColor;
                }
            }
        }

        private void PerformItemClicked(ToolStripItem item)
        {
            TsTitle_ItemClicked(tsTitle, new ToolStripItemClickedEventArgs(item));
        }

        private void Item_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in tsTitle.Items)
            {
                if (item == sender)
                {
                    item.BackColor = stateColorSet.GotFocusBackgroundColor;
                    item.ForeColor = stateColorSet.GotFocusForegroundColor;
                }
                else
                {
                    item.BackColor = stateColorSet.LostFocusBackgroundColor;
                    item.ForeColor = stateColorSet.LostFocusForegroundColor;
                }
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            RemovePage(tsTitle.Items.IndexOf(ActiveContextMenuTitleItem));
        }

        private void tsmiCloseAll_Click(object sender, EventArgs e)
        {
            tsTitle.Items.Clear();
            Pages.Clear();
        }

        private void tsmiPreviousPage_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void tsmiNextPage_Click(object sender, EventArgs e)
        {
            NextPage();
        }
    }
}
