using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Landriesnidis.LCL_Controls.Controls.SettingsBox
{
    

    public partial class SettingsBox : UserControl
    {
        [Browsable(true)]
        [Description("属性项主控件获得焦点时返回相应属性的文本信息")]
        public event ShowDescriptionEventHandler OnShowDescription;

        private object data;

        public SettingsBox()
        {
            InitializeComponent();

            flp.ControlAdded += Flp_ControlAdded;
        }

        private void Flp_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Width = flp.Width - 2;
        }

        public void SetData(object data)
        {
            this.data = data;

            flp.Controls.Clear();

            foreach (PropertyInfo pi in data.GetType().GetProperties())
            {
                // 过滤标记无效的属性
                if (pi.IsDefined(typeof(InvalidSettingsAttribute), false))
                {
                    continue;
                }

                // 含义
                string meaning = null;
                // 详细信息
                string description = null;
                // 属性的数据
                object value = pi.GetValue(data, null);
                // 属性标注的类型
                SettingsItemType itemType = SettingsItemType.None;

                // 属性项基本信息
                if (pi.IsDefined(typeof(SettingsAttribute), false))
                {
                    SettingsAttribute attribute = (SettingsAttribute)pi.GetCustomAttribute(typeof(SettingsAttribute));
                    meaning = attribute.Meaning;
                    description = attribute.Description;
                    itemType = attribute.SettingsItemType;
                }

                SettingsItem item = null;

                switch (pi.PropertyType.Name)
                {
                    case "Boolean":
                        if (itemType == SettingsItemType.None) itemType = SettingsItemType.Boolean;
                        item = new SettingsItem(itemType, pi.Name, meaning, description);
                        ((CheckBox)item.GetMainControl()).Checked = (bool)value;
                        break;
                    case "Int32":
                        if (itemType == SettingsItemType.None) itemType = SettingsItemType.Integer;
                        item = new SettingsItem(itemType, pi.Name, meaning, description);
                        item.GetMainControl().LostFocus += (s, e) =>
                        {
                            bool b = int.TryParse(item.GetMainControl().Text, out int x);
                            if (!b)
                            {
                                item.Focus();
                            }
                        };
                        if (value == null) value = 0;
                        ((TextBox)item.GetMainControl()).Text = value.ToString();
                        break;
                    case "String":
                        if (itemType == SettingsItemType.None) itemType = SettingsItemType.String;
                        item = new SettingsItem(itemType, pi.Name, meaning, description);
                        if (value == null) value = "";
                        ((TextBox)item.GetMainControl()).Text = value.ToString();
                        break;
                    default:

                        break;
                }
                
                if (item!=null){

                    // 禁用标记锁定的属性
                    if (pi.IsDefined(typeof(LockSettingsAttribute), false))
                    {
                        item.GetMainControl().Enabled = false;
                    }

                    flp.Controls.Add(item);
                    item.OnShowDescription += Item_OnShowDescription;
                }
            }
        }

        private void Item_OnShowDescription(SettingsItem sender, ShowDescriptionEventArgs e)
        {
            OnShowDescription?.Invoke(sender, e);
        }

        public object SaveData()
        {
            foreach (Control c in flp.Controls)
            {
                if (c.GetType() == typeof(SettingsItem))
                {
                    SettingsItem item = (SettingsItem)c;
                    data.GetType().GetProperty(item.Key).SetValue(data, item.GetValue());
                }
            }
            return data;
        }

        private void Flp_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flp.Controls)
            {
                c.Width = flp.Width-3;
            }
        }
    }

    public delegate void ShowDescriptionEventHandler(SettingsItem sender, ShowDescriptionEventArgs e);

    [AttributeUsage(AttributeTargets.Property)]
    public class SettingsAttribute : Attribute
    {
        public string Meaning { get; private set; }
        public string Description { get; private set; }
        public SettingsItemType SettingsItemType { get; private set; }
        public SettingsAttribute(string meaning, string description, SettingsItemType itemType = SettingsItemType.None)
        {
            Meaning = meaning;
            Description = description;
            SettingsItemType = itemType;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class InvalidSettingsAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Property)]
    public class LockSettingsAttribute : Attribute { }

    public class ShowDescriptionEventArgs : EventArgs
    {
        public string Meaning { get; private set; }
        public string Description { get; private set; }

        public ShowDescriptionEventArgs(string meaning, string description)
        {
            Meaning = meaning;
            Description = description;
        }
    }

}
