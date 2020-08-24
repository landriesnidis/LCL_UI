using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Forms.WelcomeBoxes
{
    public partial class WelcomeBox : Form
    {
        public WelcomeBox()
        {
            InitializeComponent();
        }

        public static WelcomeBox ShowWelcomeDialog(Form nextForm, Image img, double delay = 3)
        {
            WelcomeBox box = new WelcomeBox();
            box.BackgroundImage = img;
            box.Size = img.Size;
            box.TopMost = true;
            box.Show();

            nextForm.FormClosed += (s, e) =>
            {
                box.Close();
            };
            nextForm.Opacity = 0;
            nextForm.Show();

            Timer timer = new Timer();
            timer.Interval = (int)(delay * 1000);
            timer.Tick += (s, e) =>
            {
                box.Hide();
                nextForm.Opacity = 1;
                timer.Enabled = false;
            };
            timer.Enabled = true;

            return box;
        }
    }
}
