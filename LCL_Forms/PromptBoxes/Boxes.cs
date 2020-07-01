using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    public class DialogBoxes
    {
        /// <summary>
        /// 输入框
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">详细内容</param>
        /// <param name="buttonNames">按钮名称</param>
        /// <param name="handler">数据格式检查委托</param>
        /// <returns></returns>
        public static BoxResult<string> InputBox(string title, string content = default, string[] buttonNames = null, InputBox.CheckFormatHandler handler = null)
        {
            return InputBox(title, content, "", buttonNames, handler);
        }

        /// <summary>
        /// 输入框
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">详细内容</param>
        /// <param name="defaultValue">输入框默认值</param>
        /// <param name="buttonNames">按钮名称</param>
        /// <param name="handler">数据格式检查委托</param>
        /// <returns></returns>
        public static BoxResult<string> InputBox(string title, string content = default, string defaultValue = "", string[] buttonNames = null, InputBox.CheckFormatHandler handler = null)
        {
            InputBox box = new InputBox();
            box.Text = title;
            box.Content = content;
            box.CheckFormat = handler;
            box.InputText = defaultValue;
            try
            {
                box.ButtonOKText = buttonNames[0];
                box.ButtonDefaultCancelText = buttonNames[1];
                box.ButtonCleanText = buttonNames[2];
            }
            catch { }
            box.ShowDialog();
            return box.Result;
        }

        /// <summary>
        /// 消息框
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">详细内容</param>
        /// <param name="buttonNames">按钮名称</param>
        /// <returns></returns>
        public static BoxResult<bool> MsgBox(string title, string content = default, string buttonName = null)
        {
            MsgBox box = new MsgBox();
            box.Text = title;
            box.Content = content;
            if(buttonName!=null) box.ButtonDefaultCancelText = buttonName;
            box.ShowDialog();
            return box.Result;
        }

        /// <summary>
        /// 密码框
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">详细内容</param>
        /// <param name="buttonNames">按钮名称</param>
        /// <param name="handler">数据格式检查委托</param>
        /// <returns></returns>
        public static BoxResult<string> PasswordBox(string title, string content = default, string[] buttonNames = null, PasswordBox.CheckFormatHandler handler = null)
        {
            PasswordBox box = new PasswordBox();
            box.Text = title;
            box.Content = content;
            box.CheckFormat = handler;
            try
            {
                box.ButtonOKText = buttonNames[0];
                box.ButtonDefaultCancelText = buttonNames[1];
                box.ButtonCleanText = buttonNames[2];
            }
            catch { }
            box.ShowDialog();
            return box.Result;
        }

        /// <summary>
        /// 提示框(选择True或False)
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">详细内容</param>
        /// <param name="buttonNames">按钮名称</param>
        /// <returns></returns>
        public static BoxResult<bool> PromptBox(string title, string content = default, string[] buttonNames = null)
        {
            PromptBox box = new PromptBox();
            box.Text = title;
            box.Content = content;
            try
            {
                box.ButtonOKText = buttonNames[0];
                box.ButtonDefaultCancelText = buttonNames[1];
            }
            catch { }
            box.ShowDialog();
            return box.Result;
        }
        /// <summary>
        /// 选择框
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">详细内容</param>
        /// <param name="items">选项集合</param>
        /// <param name="allowMultiSelection">是否可多选</param>
        /// <param name="buttonNames">按钮名称</param>
        /// <param name="handler">数据格式检查委托</param>
        /// <returns></returns>
        public static BoxResult<List<string>> SelectBox(string title, string content = default, ICollection items = null,bool allowMultiSelection = false, string[] buttonNames = null, SelectBox.CheckFormatHandler handler = null)
        {
            SelectBox box = new SelectBox();
            box.Text = title;
            box.Content = content;
            if (items != null) box.Items = items;
            box.AllowMultiSelection = allowMultiSelection;
            try
            {
                box.ButtonOKText = buttonNames[0];
                box.ButtonDefaultCancelText = buttonNames[1];
                box.ButtonSelectAllText = buttonNames[2];
                box.ButtonInvertText = buttonNames[3];
            }
            catch { }
            box.CheckFormat = handler;
            box.ShowDialog();
            return box.Result;
        }

        /// <summary>
        /// 时间选择框
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="year">默认年份</param>
        /// <param name="month">默认月份</param>
        /// <param name="buttonNames">按钮名称</param>
        /// <param name="handler">数据格式检查委托</param>
        /// <returns></returns>
        public static BoxResult<DateTime> DatePickBox(string title, int? year=null, int? month=null, string[] buttonNames = null, DatePickBox.CheckFormatHandler handler = null)
        {
            DatePickBox box = new DatePickBox();
            box.Text = title;
            box.CheckFormat = handler;
            box.Year = year??2020;
            box.Month = month??1;
            try
            {
                box.ButtonOKText = buttonNames[0];
                box.ButtonDefaultCancelText = buttonNames[1];
                box.ButtonTodayText = buttonNames[2];
            }
            catch { }
            box.ShowDialog();
            return box.Result;
        }
    }
}
