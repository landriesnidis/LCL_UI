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
        public AeList<KeyValueListItem> Items;

        [Browsable(true)]
        public int ScrollBarWidth = 18;

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
                c.Width = flowPanel.Width;
                c.Margin = new Padding(0);
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
                ChangeControlsWidth(isUseScrollBar);
            };
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
    }
}
