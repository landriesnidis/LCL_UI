using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.ListBox
{
    public partial class KeyValueListItem : UserControl
    {

        [Browsable(true)]
        public string Key { get { return labKey.Text; }set { labKey.Text = value; } }

        [Browsable(true)]
        public string Value { get { return labValue.Text; } set { labValue.Text = value; } }

        [Browsable(true)]
        public Color KeyBackColor { get { return labKey.BackColor; } set { labKey.BackColor = value; } }

        [Browsable(true)]
        public Color KeyForeColor { get { return labKey.ForeColor; } set { labKey.ForeColor = value; } }

        [Browsable(true)]
        public Color ValueBackColor { get { return labValue.BackColor; } set { labValue.BackColor = value; } }

        [Browsable(true)]
        public Color ValueForeColor { get { return labValue.ForeColor; } set { labValue.ForeColor = value; } }

        [Browsable(true)]
        public event EventHandler ValueChanged;

        public KeyValueListItem()
        {
            InitializeComponent();

            this.Load += (s,e) =>
            {
                this.Width = Parent.Width;
                this.Margin = new Padding(0);
            };

            labValue.TextChanged += (s, e) =>
            {
                ValueChanged?.Invoke(s, e);
            };

            labKey.Click += Labels_Click;
            labValue.Click += Labels_Click;
        }

        private void Labels_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        public KeyValueListItem(string key,string value = ""):this()
        {
            Key = key;
            Value = value;
        }

        private void DeviceListItem_SizeChanged(object sender, EventArgs e)
        {
            labKey.Width = this.Width / 3;
        }
    }
}
