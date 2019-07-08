using Landriesnidis.LCL_Forms.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.ToastBox
{
    public class Toast
    {
        private static Queue<ToastMsg> QueueMsg = new Queue<ToastMsg>();
        private static bool IsBusy = false;

        public static void Show(string content,int delay = 2000, Control context = null)
        {
            QueueMsg.Enqueue(new ToastMsg(content, delay, context));

            if (!IsBusy)
            {
                IsBusy = true;
                if (QueueMsg.Count>0)
                {
                    ShowNextMsg();
                }
                else
                {
                    IsBusy = false;
                }
            }
        }

        private static void ShowNextMsg()
        {
            if (QueueMsg.Count <= 0)
            {
                IsBusy = false;
                return;
            }
            ToastMsg tm = QueueMsg.Dequeue();
            ToastForm tf = new ToastForm(tm.Content, tm.Delay, tm.Context);
            tf.TopMost = true;
            tf.Show();
            tf.FormClosed += (s, e) =>
            {
                ShowNextMsg();
            };
        }

        class ToastMsg
        {
            public string Content { get; set; }
            public int Delay { get; set; }
            public Control Context { get; set; }

            public ToastMsg(string content, int delay, Control context)
            {
                Content = content;
                Delay = delay;
                Context = context;
            }
        }
    }
}
