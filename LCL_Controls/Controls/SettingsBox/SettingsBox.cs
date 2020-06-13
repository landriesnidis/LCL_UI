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
using Landriesnidis.LCL_Controls.Controls.ListBox;

namespace Landriesnidis.LCL_Controls.Controls.SettingsBox
{
    

    public partial class SettingsBox : UserControl
    {
        [Browsable(true)]
        [Description("属性项主控件获得焦点时返回相应属性的文本信息")]
        public event ShowDescriptionEventHandler OnShowDescription;

        [Browsable(true)]
        public int ScrollBarWidth { get; set; } = 20;

        private object data;

        public SettingsBox()
        {
            InitializeComponent();
        }

        public void SetData(object data)
        {
            if (data == null) return;

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

                if (pi.PropertyType == typeof(bool))
                {
                    if (itemType == SettingsItemType.None) itemType = SettingsItemType.Boolean;
                    item = new SettingsItem(itemType, pi.Name, meaning, description);
                    ((CheckBox)item.GetMainControl()).Checked = (bool)value;
                }
                else if (pi.PropertyType == typeof(int))
                {
                    if (itemType == SettingsItemType.None) itemType = SettingsItemType.Integer;
                    item = new SettingsItem(itemType, pi.Name, meaning, description);
                    item.GetMainControl().LostFocus += (s, e) =>
                    {
                        bool b = int.TryParse(item.GetMainControl().Text, out int x);
                        if (!b)
                        {
                            item.Focus();
                        }
                        else
                        {
                            value = x;
                        }
                    };
                    if (value == null) value = 0;
                    ((TextBox)item.GetMainControl()).Text = value.ToString();
                }
                else if (pi.PropertyType == typeof(double))
                {
                    if (itemType == SettingsItemType.None) itemType = SettingsItemType.Double;
                    item = new SettingsItem(itemType, pi.Name, meaning, description);
                    item.GetMainControl().LostFocus += (s, e) =>
                    {
                        bool b = double.TryParse(item.GetMainControl().Text, out double x);
                        if (!b)
                        {
                            item.Focus();
                        }
                        else
                        {
                            value = x;
                        }
                    };
                    if (value == null) value = 0;
                    ((TextBox)item.GetMainControl()).Text = value.ToString();
                }
                else if(pi.PropertyType == typeof(string))
                {
                    if (itemType == SettingsItemType.None) itemType = SettingsItemType.String;
                    item = new SettingsItem(itemType, pi.Name, meaning, description);
                    if (value == null) value = "";
                    ((TextBox)item.GetMainControl()).Text = value.ToString();
                }
                else if (pi.PropertyType == typeof(List<string>))
                {
                    if (itemType == SettingsItemType.None) itemType = SettingsItemType.StringList;
                    item = new SettingsItem(itemType, pi.Name, meaning, description);
                    if (value == null) value = new List<string>();

                    if (itemType == SettingsItemType.StringList)
                    {
                        ItemControl_StringList ctrl = ((ItemControl_StringList)item.GetMainControl());
                        ctrl.AddItems((List<string>)value);
                        ctrl.Height = 200;
                    }
                    else if (itemType == SettingsItemType.Select)
                    {
                        ComboBox ctrl = ((ComboBox)item.GetMainControl());
                        string[] arr = ((List<string>)value).ToArray();
                        ctrl.Items.AddRange(arr);
                        ctrl.Text = arr[0];
                    }
                    
                }
                else if (pi.PropertyType == typeof(List<KeyValueItem>))
                {
                    if (itemType == SettingsItemType.None) itemType = SettingsItemType.StringDictionary;
                    item = new SettingsItem(itemType, pi.Name, meaning, description);
                    if (value == null) value = new List<KeyValueItem>();
                    ItemControl_StringDictionary ctrl = ((ItemControl_StringDictionary)item.GetMainControl());
                    ctrl.SetData((List<KeyValueItem>)value);
                    ctrl.Height = 200;
                }
                else
                {

                }
                
                if (item!=null){

                    // 禁用标记锁定的属性
                    if (pi.IsDefined(typeof(LockSettingsAttribute), false))
                    {
                        item.GetMainControl().Enabled = false;
                    }
                    item .Width = flp.Width - 10;
                    item.OnShowDescription += Item_OnShowDescription;
                    flp.Controls.Add(item);
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

        private void SettingsBox_Resize(object sender, EventArgs e)
        {
            flp.Width = this.Width - ScrollBarWidth;
            foreach (Control c in flp.Controls)
            {
                c.Width = flp.Width - 10;
            }
        }
    }

    /// <summary>
    /// 显示详情委托
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ShowDescriptionEventHandler(SettingsItem sender, ShowDescriptionEventArgs e);

    /// <summary>
    /// 配置属性项的基本信息
    /// </summary>
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

    /// <summary>
    /// 不参与显示的属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class InvalidSettingsAttribute : Attribute { }

    /// <summary>
    /// 不可编辑的属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class LockSettingsAttribute : Attribute { }

    /// <summary>
    /// 显示详情事件参数
    /// </summary>
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

    /*
    public interface IRequestInputOperation
    {
        string InputString(string title, string content = default, string defaultValue = default);
    }
    */
}
