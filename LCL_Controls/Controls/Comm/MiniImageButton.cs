using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Comm
{
    public partial class MiniImageButton : UserControl
    {
        private Bitmap bitmap;
        private bool isInSide = false;

        public MiniImageButton()
        {
            InitializeComponent();

             bitmap = (Bitmap)pic.Image;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isInSide)
            {

                pic.Image = Image.FromHbitmap(RePic(bitmap, bitmap.Width,bitmap.Height).GetHbitmap());
            }
            isInSide = true;
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            isInSide = false;

            pic.Image = Image.FromHbitmap(bitmap.GetHbitmap());
        }

        /// <summary>
        /// 将图片进行反色处理
        /// </summary>
        /// <param name="mybm">原始图片</param>
        /// <param name="width">原始图片的长度</param>
        /// <param name="height">原始图片的高度</param>
        /// <returns>被反色后的图片</returns>
        public Bitmap RePic(Bitmap mybm, int width, int height)
        {
            Bitmap bm = new Bitmap(width, height);//初始化一个记录处理后的图片的对象
            int x, y, resultR, resultG, resultB;
            Color pixel;

            for (x = 0; x < width; x++)
            {
                for (y = 0; y < height; y++)
                {
                    pixel = mybm.GetPixel(x, y);//获取当前坐标的像素值
                    resultR = 255 - pixel.R;//反红
                    resultG = 255 - pixel.G;//反绿
                    resultB = 255 - pixel.B;//反蓝
                    bm.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));//绘图
                }
            }

            return bm;//返回经过反色处理后的图片
        }
    }
}
