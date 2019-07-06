using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    public partial class SelectBox : BaseBox<List<string>>
    {
        [Browsable(true)]
        public string Content { get { return labContent.Text; } set { labContent.Text = value; } }

        [Browsable(true)]
        public string ButtonOKText { get { return btnOK.Text; } set { btnOK.Text = value; } }

        [Browsable(true)]
        public string ButtonSelectAllText { get { return btnSelectAll.Text; } set { btnSelectAll.Text = value; } }

        [Browsable(true)]
        public string ButtonInvertText { get { return btnInvert.Text; } set { btnInvert.Text = value; } }

        [Browsable(true)]
        public bool AllowMultiSelection { get { return allowMultiSelection; } set { allowMultiSelection = value; ShowButtons(); } }
        private bool allowMultiSelection;

        public ICollection Items
        {
            get { return cb.Items; }
            set
            {
                cb.Items.Clear();
                foreach(var item in value)
                {
                    cb.Items.Add(item);
                }
            }
        }

        public SelectBox()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            result.IsCancel = false;
            List<string> data = new List<string>();
            foreach (var item in cb.CheckedItems)
            {
                data.Add(item.ToString());
            }
            result.Data = data;
            Close();
        }

        private void Cb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnOK.PerformClick();
            }
        }

        private void Cb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // 如果是单选模式
            if (!AllowMultiSelection)
            {
                for (int i = 0; i < cb.CheckedIndices.Count; i++)
                {
                    if (cb.CheckedIndices[i] != e.Index)
                    {
                        cb.SetItemChecked(cb.CheckedIndices[i], false);
                    }
                }
            }
            else
            {
                cb.SelectedIndex = -1;
            }
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!AllowMultiSelection)
            {
                if (cb.SelectedIndex!= -1)
                {
                    cb.SetItemChecked(cb.SelectedIndex, true);
                }
            }
            else
            {
                if (cb.SelectedIndex != -1)
                {
                    cb.SetItemChecked(cb.SelectedIndex, !cb.CheckedIndices.Contains(cb.SelectedIndex));
                }
            }
        }

        private void SelectBox_Load(object sender, EventArgs e)
        {
            ShowButtons();
        }

        private void ShowButtons()
        {
            btnInvert.Visible = AllowMultiSelection;
            btnSelectAll.Visible = AllowMultiSelection;
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cb.Items.Count; i++)
            {
                cb.SetItemChecked(i, true);
            }
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cb.Items.Count; i++)
            {
                cb.SetItemChecked(i, !cb.CheckedIndices.Contains(i));
            }
        }
    }
}
