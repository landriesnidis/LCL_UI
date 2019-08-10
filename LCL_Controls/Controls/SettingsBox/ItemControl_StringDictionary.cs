using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Landriesnidis.LCL_Controls.Controls.ListBox;

namespace Landriesnidis.LCL_Controls.Controls.SettingsBox
{
    public partial class ItemControl_StringDictionary : UserControl
    {
        private KeyValueListItem editingItem;

        public ItemControl_StringDictionary()
        {
            InitializeComponent();

            slideBox.AddPage(kvList);
            slideBox.AddPage(panelAddItem);

            slideBox.PageChanged += (s, e) =>
            {
                tsmiBack.Enabled = e.PageIndex != 0;
                if (e.PageIndex == 1) tbKey.Focus();
            };

            kvList.Items.ItemAddedEvent += (s, e) =>
            {
                e.Item.AllowEdit = true;
                e.Item.EditButtonClick += (s1, e1) =>
                {
                    editingItem = e.Item;
                    menuItem.Show((Control)s1, 0, 0);
                };
            };
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            editingItem = null;
            tbKey.Text = "";
            tbValue.Text = "";
            slideBox.Jump(1);
        }

        private void tsmiClean_Click(object sender, EventArgs e)
        {
            kvList.Items.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(editingItem == null)
            {
                kvList.Items.Add(new KeyValueListItem(tbKey.Text, tbValue.Text));
            }
            else
            {
                editingItem.Key = tbKey.Text;
                editingItem.Value = tbValue.Text;
            }
            slideBox.Jump(0);
        }

        public Dictionary<string, string> GetDictionary()
        {
            return kvList.ToDictionary();
        }

        public List<KeyValueItem> GetKeyValueList()
        {
            List<KeyValueItem> kvl = new List<KeyValueItem>();
            foreach(var kv in GetDictionary())
            {
                kvl.Add(new KeyValueItem(kv.Key, kv.Value));
            }
            return kvl;
        }

        public List<KeyValueItem> GetValue()
        {
            return GetKeyValueList();
        }

        public void SetData(List<KeyValueItem> lst)
        {
            kvList.Items.Clear();
            foreach (var kv in lst)
            {
                try
                {
                    kvList.Items.Add(new KeyValueListItem(kv.Key, kv.Value));
                }
                catch { }
            }
        }

        public void SetDictionary(Dictionary<string, string> dict)
        {
            kvList.Items.Clear();
            kvList.Input(dict);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            slideBox.Jump(0);
        }

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            slideBox.Jump(0);
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (editingItem != null)
            {
                tbKey.Text = editingItem.Key;
                tbValue.Text = editingItem.Value;
                slideBox.Jump(1);
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            kvList.Items.Remove(editingItem);
            editingItem = null;
        }
    }

    [Serializable]
    public class KeyValueItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public KeyValueItem()
        {

        }
        public KeyValueItem(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
    /*
    public class KeyValueList : List<KeyValueItem>
    {

    }
    */
}
