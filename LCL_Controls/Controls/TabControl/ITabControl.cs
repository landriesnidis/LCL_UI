using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.TabControl
{
    interface ITabControl
    {
        /// <summary>
        /// 添加新的页面
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">内容控件</param>
        /// <param name="icon">图标</param>
        void AddPage(string title, Control content, Bitmap icon = null);


    }
}
