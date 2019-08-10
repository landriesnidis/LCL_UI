using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Landriesnidis.LCL_Controls.Utils;

namespace Landriesnidis.LCL_Controls.Controls.ListBox
{
    public partial class KeyValueListBox : UserControl
    {
        [Browsable(true)]
        public int ScrollBarWidth { get; set; } = 18;

        //[Browsable(true)]
        public AeList<KeyValueListItem> Items { get; set; }

        [Browsable(true)]
        public Padding ItemsPadding { get; set; } = new Padding(3);

        [Browsable(true)]
        [Description("关联用以信息筛选的控件(控件的Text属性)")]
        public Control SearchBox { get { return searchBox; } set { SearchBoxChange(value); } }
        private Control searchBox { get; set; }

        [Browsable(true)]
        [Description("检索时的匹配的内容(Key/Value/Key&Value)")]
        public SearchBoxFilterItem SearchBoxFilter { get; set; }

        private bool isUseScrollBar = false;

        public KeyValueListBox()
        {
            Items = new AeList<KeyValueListItem>();
            Items.ItemAddedEvent += Items_ItemAddedEvent;
            Items.ItemInsertedEvent += Items_ItemInsertedEvent;
            Items.ItemRemovedEvent += Items_ItemRemovedEvent;
            Items.ItemsClearedEvent += Items_ItemsClearedEvent;

            InitializeComponent();

            flowPanel.ControlAdded += (s, e) =>
            {
                Control c = e.Control;
                c.Width = flowPanel.Width-1;
                c.Margin = ItemsPadding;
                if (c.Height + c.Top >= Height)
                {
                    isUseScrollBar = true;
                    ChangeControlsWidth(isUseScrollBar);
                }
            };

            flowPanel.ControlRemoved += (s,e) =>
            {
                // 如果控件通过其他方式移除(非Items中移除)，需要在Items中将其移除
                Items.Remove((KeyValueListItem)e.Control);
                var controls = flowPanel.Controls;
                int count = controls.Count;

                if (count == 0) return;
                Control c = controls[count - 1] ;
                if (c.Height + c.Top >= Height)
                {
                    isUseScrollBar = false;
                    ChangeControlsWidth(isUseScrollBar);
                }
            };

            flowPanel.SizeChanged += (s, e) =>
            {
                var controls = flowPanel.Controls;
                int count = controls.Count;

                if (count == 0) return;
                Control c = controls[count - 1];
                isUseScrollBar = (c.Height + c.Top >= Height);
                ChangeControlsWidth(isUseScrollBar);
            };
        }

        private void SearchBoxChange(Control newControl)
        {
            if (searchBox != null)
            {
                searchBox.TextChanged -= SearchBox_TextChanged;
            }

            if (searchBox != null && newControl == null)
            {
                searchBox.TextChanged -= SearchBox_TextChanged;
            }

            if (newControl == null)
            {
                searchBox = null;
                return;
            }

            searchBox = newControl;
            searchBox.TextChanged += SearchBox_TextChanged;

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox == null) return;

            if (searchBox.Text == "")
            {
                foreach (var item in Items)
                {
                    item.Visible = true;
                }
                return;
            }

            switch (SearchBoxFilter)
            {
                case SearchBoxFilterItem.OnlyKey:
                    foreach (var item in Items)
                    {
                        item.Visible = item.Key.Contains(searchBox.Text);
                    }
                    break;
                case SearchBoxFilterItem.OnlyValue:
                    foreach (var item in Items)
                    {
                        item.Visible = item.Value.Contains(searchBox.Text);
                    }
                    break;
                case SearchBoxFilterItem.KeyAndValue:
                    foreach (var item in Items)
                    {
                        item.Visible = item.Key.Contains(searchBox.Text) || item.Value.Contains(searchBox.Text);
                    }
                    break;
            }
        }

        public Dictionary<string,string> ToDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (KeyValueListItem item in Items)
            {
                try
                {
                    dict.Add(item.Key, item.Value);
                }
                catch { }
            }
            return dict;
        }

        public void Input(Dictionary<string, string> dict)
        {
            foreach (var kv in dict)
            {
                try
                {
                    Items.Add(new KeyValueListItem(kv.Key, kv.Value));
                }
                catch { }
            }
        }

        public KeyValueListItem GetItem(string key)
        {
            foreach(KeyValueListItem item in Items)
            {
                if (item.Key == key)
                {
                    return item;
                }
            }
            return null;
        }

        private void ChangeControlsWidth(bool isUseScrollBar)
        {
            foreach (Control c in flowPanel.Controls)
            {
                c.Width = flowPanel.Width - (isUseScrollBar?ScrollBarWidth:0);
            }
        }

        private void Items_ItemsClearedEvent(AeList<KeyValueListItem> list, EventArgs e)
        {
            flowPanel.Controls.Clear();
        }

        private void Items_ItemRemovedEvent(AeList<KeyValueListItem> list, ListItemsChangedEventArgs<KeyValueListItem> e)
        {
            flowPanel.Controls.Remove(e.Item);
        }

        private void Items_ItemInsertedEvent(AeList<KeyValueListItem> list, ListItemsChangedEventArgs<KeyValueListItem> e)
        {
            // 不能做插入操作，当添加处理
            Items_ItemAddedEvent(list, e);
        }

        private void Items_ItemAddedEvent(AeList<KeyValueListItem> list, ListItemsChangedEventArgs<KeyValueListItem> e)
        {
            flowPanel.Controls.Add(e.Item);
        }

        public enum SearchBoxFilterItem
        {
            OnlyKey,OnlyValue,KeyAndValue
        }
    }
}
