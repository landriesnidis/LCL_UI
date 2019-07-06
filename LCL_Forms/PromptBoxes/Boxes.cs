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
        public static BoxResult<string> InputBox(string title,string content = default,string[] buttonNames = null, InputBox.CheckFormatHandler handler = null)
        {
            InputBox box = new InputBox();
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
        public static BoxResult<bool> MsgBox(string title, string content = default, string buttonName = null)
        {
            MsgBox box = new MsgBox();
            box.Text = title;
            box.Content = content;
            if(buttonName!=null) box.ButtonDefaultCancelText = buttonName;
            box.ShowDialog();
            return box.Result;
        }
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
    }
}
