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

        public KeyValueListBox()
        {
            Items = new AeList<KeyValueListItem>();
            Items.ItemAddedEvent += Items_ItemAddedEvent;
            Items.ItemInsertedEvent += Items_ItemInsertedEvent;
            Items.ItemRemovedEvent += Items_ItemRemovedEvent;
            Items.ItemsClearedEvent += Items_ItemsClearedEvent;

            InitializeComponent();
        }

        private void Items_ItemsClearedEvent(AeList<KeyValueListItem> list, EventArgs e)
        {
        }

        private void Items_ItemRemovedEvent(AeList<KeyValueListItem> list, ListItemsChangedEventArgs<KeyValueListItem> e)
        {
        }

        private void Items_ItemInsertedEvent(AeList<KeyValueListItem> list, ListItemsChangedEventArgs<KeyValueListItem> e)
        {
        }

        private void Items_ItemAddedEvent(AeList<KeyValueListItem> list, ListItemsChangedEventArgs<KeyValueListItem> e)
        {
        }
    }
}
