using Landriesnidis.LCL_Forms.Base;
using Landriesnidis.LCL_Forms.PromptBoxes;
using Landriesnidis.LCL_Forms.ToastBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCL_Forms
{
    public partial class FormDemo : Form
    {
        public FormDemo()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            BaseBox<bool> box = new BaseBox<bool>();
            box.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PasswordBox box = new PasswordBox();
            box.Text = "密码";
            box.Content = "请输入6位密码：";
            box.ButtonDefaultCancelText = "取消";
            box.ButtonCleanText = "清除";
            box.ButtonOKText = "确认";
            box.CheckFormat = (psw) =>
            {
                if (psw.Length>=6)
                {
                    return true;
                }
                return false;
            };
            box.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MsgBox box = new MsgBox();
            box.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PromptBox box = new PromptBox();
            box.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SelectBox box = new SelectBox();
            box.AllowMultiSelection = false;
            box.Items = new string[] { "选项1", "选项2", "选项3", "选项4", "选项5", "选项6"};
            box.CheckFormat = (list) =>
            {
                if (list.Count>0)
                {
                    return true;
                }
                return false;
            };
            box.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InputBox box = new InputBox();
            box.CheckFormat = (text) =>
            {
                if (text.Length>0)
                {
                    return true;
                }
                return false;
            };
            box.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var result = DialogBoxes.InputBox(tbTitle.Text, tbContent.Text, null);
            if (!result.IsCancel)
            {
                DialogBoxes.MsgBox(tbTitle.Text, $"刚才输入的内容是：{result.Data}", "好的");
            }
            else
            {
                DialogBoxes.MsgBox(tbTitle.Text, "您取消了输入。", "知道啦");
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var result = DialogBoxes.SelectBox(tbTitle.Text, tbContent.Text,new string[] { "土豆","洋葱","西红柿","玉米"},true,new string[]{ "确定","取消","全选","反选"});
            if (!result.IsCancel)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string s in result.Data) sb.Append(s+" ");
                DialogBoxes.MsgBox(tbTitle.Text, $"刚才勾选的项目是：{sb}", "好的");
            }
            else
            {
                DialogBoxes.MsgBox(tbTitle.Text, "您取消了选择。", "知道啦");
            }
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            var result = DialogBoxes.PromptBox(tbTitle.Text, tbContent.Text, new string[] { "同意", "残忍拒绝" });
            DialogBoxes.MsgBox(tbTitle.Text, $"你的选择结果是：{result.Data.ToString()}");
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            DialogBoxes.MsgBox(tbTitle.Text, tbContent.Text, "知道啦");
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            var result = DialogBoxes.PasswordBox(tbTitle.Text, tbContent.Text, new string[] { "确定", "取消", "清除" },(psw) => { return psw.Length >= 6; });
            if (!result.IsCancel)
            {
                DialogBoxes.MsgBox(tbTitle.Text, $"刚才输入的密码是：{result.Data}", "好的");
            }
            else
            {
                DialogBoxes.MsgBox(tbTitle.Text, "您取消了密码输入。", "知道啦");
            }
            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            var result = DialogBoxes.SelectBox(tbTitle.Text, tbContent.Text, new string[] { "土豆", "洋葱", "西红柿", "玉米" }, false, new string[] { "确定", "取消", "全选", "反选" },(items) => { return items.Count > 0; });
            if (!result.IsCancel)
            {
                DialogBoxes.MsgBox(tbTitle.Text, $"刚才勾选的项目是：{result.Data[0]}", "好的");
            }
            else
            {
                DialogBoxes.MsgBox(tbTitle.Text, "您取消了选择。", "知道啦");
            }
        }

        int toastCount = 0;
        private void Button13_Click(object sender, EventArgs e)
        {
            Toast.Show($"{tbToastContent.Text} - {toastCount}", 2000, tbToastContent);
            labToastCount.Text = ++toastCount + "";

        }
    }
}
