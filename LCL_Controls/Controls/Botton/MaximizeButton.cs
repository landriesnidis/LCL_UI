﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Botton
{
    [DefaultEvent("Click")]
    public partial class MaximizeButton : UserControl
    {
        public MaximizeButton()
        {
            InitializeComponent();
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = global::Landriesnidis.LCL_Controls.Properties.Resources.MaximizeButton_1;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Landriesnidis.LCL_Controls.Properties.Resources.MaximizeButton_0;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = global::Landriesnidis.LCL_Controls.Properties.Resources.MaximizeButton_2;
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = global::Landriesnidis.LCL_Controls.Properties.Resources.MaximizeButton_0;
        }
    }
}
