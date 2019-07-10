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
    [DefaultEvent("Click")]
    public partial class MiniImageButton : UserControl
    {
        [Browsable(true)]
        public StateColorSet MiniImageButtonColor { get; set; } = new StateColorSet();

        private MiniImageButtonImage MiniImageButtonImage { get; set; } = new MiniImageButtonImage();

        [Bindable(true)]
        [Browsable(true)]
        [Localizable(true)]
        public Image Image { get { return BackgroundImage; } set { BackgroundImage = value; ComputingImage(); } }

        // private bool isMouseDown = false;
        private bool isInSide = false;

        public MiniImageButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算出按钮所需的所有图像
        /// </summary>
        private void ComputingImage()
        {
            Bitmap bitmap = (Bitmap)Image;
            MiniImageButtonImage.MouseMoveImage = ChangeBitmapColor(bitmap, MiniImageButtonColor.MouseMoveForegroundColor, MiniImageButtonColor.MouseMoveBackgroundColor);
            MiniImageButtonImage.MouseDownImage = ChangeBitmapColor(bitmap, MiniImageButtonColor.MouseDownForegroundColor, MiniImageButtonColor.MouseDownBackgroundColor);
            MiniImageButtonImage.MouseLeaveImage = ChangeBitmapColor(bitmap, MiniImageButtonColor.MouseLeaveForegroundColor, MiniImageButtonColor.MouseLeaveBackgroundColor);
            MiniImageButtonImage.LostFocusImage = ChangeBitmapColor(bitmap, MiniImageButtonColor.LostFocusForegroundColor, MiniImageButtonColor.LostFocusBackgroundColor);
        }

        public Bitmap ChangeBitmapColor(Bitmap bmp, Color foregroundColor, Color backgroundColor)
        {
            // 获取长宽，创建一个新的Bitmap副本
            int w = bmp.Width;
            int h = bmp.Height;
            Bitmap newBmp = new Bitmap(w, h);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    // 透明的地方全是背景色，非透明的地方全是前景色
                    newBmp.SetPixel(x, y, (bmp.GetPixel(x, y).A == 0) ? backgroundColor : foregroundColor);
                }
            }
            return newBmp;
        }

        private void MiniImageButton_Load(object sender, EventArgs e)
        {
            BackgroundImage = MiniImageButtonImage.MouseLeaveImage;
            BackColor = MiniImageButtonColor.MouseLeaveBackgroundColor;
        }

        private void MiniImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            // isMouseDown = true;
            BackgroundImage = MiniImageButtonImage.MouseDownImage;
            BackColor = MiniImageButtonColor.MouseDownBackgroundColor;
        }

        private void MiniImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            // isMouseDown = false;
            if (isInSide)
            {
                BackgroundImage = MiniImageButtonImage.MouseMoveImage;
                BackColor = MiniImageButtonColor.MouseMoveBackgroundColor;
            }
            else
            {
                BackgroundImage = MiniImageButtonImage.MouseLeaveImage;
                BackColor = MiniImageButtonColor.MouseLeaveBackgroundColor;
            }
        }

        private void MiniImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isInSide)
            {
                BackgroundImage = MiniImageButtonImage.MouseMoveImage;
                BackColor = MiniImageButtonColor.MouseMoveBackgroundColor;
            }
            isInSide = true;
        }

        private void MiniImageButton_MouseLeave(object sender, EventArgs e)
        {
            isInSide = false;
            BackgroundImage = MiniImageButtonImage.MouseLeaveImage;
            BackColor = MiniImageButtonColor.MouseLeaveBackgroundColor;
        }
    }

   

    class MiniImageButtonImage
    {
        public Image MouseMoveImage { get; set; }
        public Image MouseLeaveImage { get; set; }
        public Image MouseDownImage { get; set; }
        public Image LostFocusImage { get; set; }
    }
}
