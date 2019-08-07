using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.SettingsBox
{
    public partial class ItemControl_StringList : UserControl
    {
        public ItemControl_StringList()
        {
            InitializeComponent();

            btnRemove.Click += BtnRemove_Click;
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lbStringList.Items.RemoveAt(lbStringList.SelectedIndex);
            }
            catch { }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lbStringList.Items.Add(tb.Text);
        }

        public void AddItems(List<string> lst)
        {
            foreach(string s in lst)
            {
                lbStringList.Items.Add(s);
            }
        }

        public List<string> GetValue()
        {
            List<string> lst = new List<string>();
            foreach (string s in lbStringList.Items)
            {
                lst.Add(s);
            }
            return lst;
        }
    }
}
