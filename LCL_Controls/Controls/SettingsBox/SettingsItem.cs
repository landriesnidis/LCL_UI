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
    public partial class SettingsItem : UserControl
    {

        private Control mainControl;
        public SettingsItemType SettingsItemType { get; set; }

        private object realValue;

        public string Key { get; private set; }
        public string Meaning { get; private set; }
        public string Description { get; private set; }
        public event ShowDescriptionEventHandler OnShowDescription;

        public SettingsItem(SettingsItemType type, string key,string meaning = null, string description = null)
        {
            InitializeComponent();

            Key = key;
            SettingsItemType = type;
            Meaning = meaning;
            Description = description;

            labTitle.Text = Meaning == null ? Key : Meaning;

            switch (SettingsItemType)
            {
                case SettingsItemType.String:
                    SetMainControl(new TextBox());
                    break;
                case SettingsItemType.Boolean:
                    SetMainControl(CreateCheckBox());
                    break;
                case SettingsItemType.Integer:
                    SetMainControl(CreateNumberTextBox());
                    break;
                case SettingsItemType.Password:
                    SetMainControl(new TextBox());
                    ((TextBox)GetMainControl()).PasswordChar = '*';
                    break;
                case SettingsItemType.Image:
                    break;
                case SettingsItemType.File:
                    break;
                case SettingsItemType.None:
                    break;
                case SettingsItemType.StringList:
                    SetMainControl(new ItemControl_StringList());
                    break;
            }
        }

        // 设置主控件
        public void SetMainControl(Control control)
        {
            if(mainControl != null)
            {
                this.Controls.Remove(mainControl);
                // 还要删掉事件
                mainControl.GotFocus -= MainControl_GotFocus;
            }

            mainControl = control;
            Controls.Add(control);
            control.Top = labTitle.Top + labTitle.Height;
            control.Left = labTitle.Left;
            control.Width = labTitle.Width -1;
            control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            Height = labTitle.Height + control.Height + 10;

            mainControl.GotFocus += MainControl_GotFocus;
        }

        private void MainControl_GotFocus(object sender, EventArgs e)
        {
            OnShowDescription?.Invoke(this, new ShowDescriptionEventArgs(Meaning,Description));
        }

        public Control GetMainControl()
        {
            return mainControl;
        }

        /// <summary>
        /// 获取有效数据
        /// </summary>
        /// <returns></returns>
        public object GetValue()
        {
            TextBox tb; CheckBox cb;PictureBox pic;
            ItemControl_StringList strlst;
            switch (SettingsItemType)
            {

                case SettingsItemType.String:
                    tb = (TextBox)mainControl;
                    return tb.Text;
                case SettingsItemType.Boolean:
                    cb = (CheckBox)mainControl;
                    return cb.Checked;
                case SettingsItemType.Integer:
                    tb = (TextBox)mainControl;
                    return int.Parse(tb.Text);
                case SettingsItemType.Password:
                    tb = (TextBox)mainControl;
                    return tb.Text;
                case SettingsItemType.Image:
                    return realValue;
                case SettingsItemType.File:
                    return realValue;
                case SettingsItemType.None:
                    break;
                case SettingsItemType.StringList:
                    strlst = (ItemControl_StringList)mainControl;
                    return strlst.GetValue();
            }
            return null;
        }

        private CheckBox CreateCheckBox()
        {
            CheckBox cb = new CheckBox();
            cb.Text = "FALSE";
            cb.CheckedChanged += (s, e) =>
            {
                cb.Text = cb.Checked.ToString().ToUpper();
            };
            return cb;
        }

        private TextBox CreateNumberTextBox()
        {
            TextBox tb = new TextBox();
            tb.TextChanged += (s, e) =>
            {
                if(int.TryParse(tb.Text,out int n))
                {
                    realValue = tb.Text;
                }
                else
                {
                    tb.Text = realValue.ToString();
                }
            };
            return tb;
        }

        private void SettingsItem_Load(object sender, EventArgs e)
        {

        }
    }

    public enum SettingsItemType
    {
        None, String, StringList, Boolean,Integer,Password,Image,File
    }
}
