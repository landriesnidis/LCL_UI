using Landriesnidis.LCL_Forms.Base;
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

    public partial class BaseBox<T> : LCLForm
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

        [Browsable(true)]
        public string ButtonDefaultCancelText { get { return btnCancel.Text; } set { btnCancel.Text = value; } }

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

        private void BaseBox_Load(object sender, EventArgs e)
        {
            // 将按钮控件所在的panelButtons置于底层
            // 这部分必须要用代码控制，因为panelButtons会遮盖到的panelContainer在父类，无法在可视化设计界面上修改。
            panelButtons.SendToBack();

            foreach(Control ctl in panelButtons.Controls)
            {
                if(ctl.GetType() == typeof(Button))
                {
                    Button btn = (Button)ctl;
                    btn.AutoSize = true;
                    int heigt = panelButtons.Height;
                    int width = (int)(heigt * 1.618);
                    btn.MaximumSize = new System.Drawing.Size(0, heigt);
                    btn.MinimumSize = new System.Drawing.Size(width, heigt);
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
