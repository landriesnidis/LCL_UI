using Landriesnidis.LCL_Forms.PromptBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.PromptBoxes
{

    public partial class BaseBox<T> : Box
    {
        /// <summary>
        /// 返回数据格式校验委托
        /// </summary>
        /// <param name="data">返回的数据</param>
        /// <returns>格式校验结果</returns>
        public delegate bool CheckFormatHandler(T data);
    
        /// <summary>
        /// 格式校验委托函数
        /// </summary>
        public CheckFormatHandler CheckFormat;

        /// <summary>
        /// 返回结果
        /// </summary>
        public BoxResult<T> Result { get { return result; } }
        protected BoxResult<T> result = new BoxResult<T>();

        public BaseBox()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            result.IsCancel = true;
            result.Data = default;
            Close();
        }

        /// <summary>
        /// 当窗体被关闭时检查返回数据结果是否正确，如果有误拦截关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckFormat!=null && !result.IsCancel && result.Data!=null)
            {
                if (!CheckFormat(result.Data))
                {
                    e.Cancel = true;
                    Shake();
                }
            }
        }
    }

    public class BoxResult<T>
    {
        public bool IsCancel { get; set; } = false;
        public T Data { get; set; }
    }
}
