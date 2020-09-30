using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.Extensions
{
    public static class FormExtensions
    {
        public static void SlowShow(this Form form, Action pretreatmentCallback = null, Action successCallback = null)
        {
            // 设置为透明并加载
            form.Opacity = 0.00;
            form.Show();
            //执行预处理回调
            pretreatmentCallback?.Invoke();
            // 创建任务
            Task task = new Task(() =>
            {
                double opacity = form.Opacity;
                while (form.Opacity < 1)
                {
                    Thread.Sleep(10);
                    opacity = form.Opacity + 0.05;
                    form.Invoke(new EventHandler(delegate
                    {
                        form.Opacity = opacity > 1 ? 1 : opacity;
                    }));
                }
            });
            // 如果有完成回调则设置完成执行回调
            if (successCallback != null)
            {
                task.GetAwaiter().OnCompleted(successCallback);
            }
            // 启动任务
            task.Start();
        }

        public static void SeamlessJump(this Form form, Form nextForm)
        {
            nextForm.SlowShow(
                pretreatmentCallback: () =>
                {
                    nextForm.Size = form.Size;
                    nextForm.Location = form.Location;
                    nextForm.FormClosing += (sender, e) =>
                    {
                        e.Cancel = true;
                        Form closingForm = (Form)sender;

                        form.SlowShow(
                            pretreatmentCallback: () =>
                            {
                                form.Size = closingForm.Size;
                                form.Location = closingForm.Location;
                                form.TopMost = true;
                            },
                            successCallback: () =>
                            {
                                closingForm.Hide();
                                closingForm.Dispose();
                                form.TopMost = false;
                            }
                        );
                    };
                },
                successCallback: () =>
                {
                    nextForm.TopMost = true;
                    form.Hide();
                }
            );
        }
    }
}
