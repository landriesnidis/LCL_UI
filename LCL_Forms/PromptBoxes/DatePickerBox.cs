using Landriesnidis.LCL_Controls.Controls.DatePickers;
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
    public partial class DatePickBox : BaseBox<DateTime>
    {
        [Browsable(true)]
        public int Year { get { return datePicker.Year; } set { datePicker.Year = value; } }

        [Browsable(true)]
        public int Month { get { return datePicker.Month; } set { datePicker.Month = value; } }

        [Browsable(true)]
        public string ButtonOKText { get { return btnOK.Text; } set { btnOK.Text = value; } }

        [Browsable(true)]
        public string ButtonTodayText { get { return btnToday.Text; } set { btnToday.Text = value; } }

        [Browsable(true)]
        public string Content { get { return labInfo.Text; } set { labInfo.Text = value; } }

        public DatePickBox()
        {
            InitializeComponent();
            datePicker.DatePicked += (s, e) =>
            {
                DateTime dt = ((DatePickedEventArgs)e).Date;
                result.Data = dt;
                btnOK.Enabled = true;
                labDate.Text = $"{dt.Year}-{dt.Month}-{dt.Day}  ";
            };
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            result.IsCancel = false;
            Close();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            datePicker.Year = dt.Year;
            datePicker.Month = dt.Month;
            btnOK.Enabled = true;
            result.Data = dt;
            labDate.Text = $"{dt.Year}-{dt.Month}-{dt.Day}  ";
        }

        private void labInfo_Paint(object sender, PaintEventArgs e)
        {
            int num = 0;
            num = (int)e.Graphics.MeasureString(labInfo.Text, labInfo.Font).Width / labInfo.Width;
            if (e.Graphics.MeasureString(labInfo.Text,labInfo.Font).Width % labInfo.Width != 0)
            {
                ++num;
            }
            labInfo.Height = num * (int)e.Graphics.MeasureString(labInfo.Text, labInfo.Font).Height;
        }
    }
}
