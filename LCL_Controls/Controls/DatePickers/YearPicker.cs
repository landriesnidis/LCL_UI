using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Landriesnidis.LCL_Controls.Controls.Botton;

namespace Landriesnidis.LCL_Controls.Controls.DatePickers
{
    public partial class YearPicker : UserControl
    {
        public delegate void YearPickedEventHandler(YearPicker picker, YearPickedEventArgs e);
        /// <summary>
        /// 年份选择事件
        /// </summary>
        public YearPickedEventHandler YearPicked;

        [Browsable(true)]
        [Description("起始年")]
        public int StartYear { get { return startYear; } set { ChangeStartYear(value); startYear = value; } }
        private int startYear;

        [Browsable(true)]
        [Description("显示在表格中心的年份")]
        public int MiddleYear { get { return startYear+4; } set { StartYear = value-4; } }

        public int SelectedNumber { get; private set; }

        private SimpleButton[] btns = new SimpleButton[9];


        public YearPicker()
        {
            InitializeComponent();

            for (int i=0;i<btns.Length;i++)
            {
                SimpleButton btn = new SimpleButton() {
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(0, 122, 204),
                    MouseDownForegroundColor = Color.White,
                    MouseDownBackgroundColor = Color.FromArgb(82, 176, 239),
                    MouseUpForegroundColor = Color.FromArgb(0, 122, 204),
                    MouseUpBackgroundColor = Color.White,
                };
                btn.Click += (s,e) => {
                    int year = int.Parse(btn.Title);
                    SelectedNumber = year;
                    YearPicked?.Invoke(this, new YearPickedEventArgs() { Year = year }) ;
                };
                panel.Controls.Add(btn);
                btn.Margin = new Padding(0);
                btns[i] = btn;
            }

            // 设置初始年(默认年)
            SelectedNumber = DateTime.Now.Year;
            MiddleYear = DateTime.Now.Year;
            
            // 设置按钮事件
            TitleBar.LeftButtonClick += (s, e) => StartYear -= 9;
            TitleBar.RightButtonClick += (s, e) => StartYear += 9;
        }

        private void ChangeStartYear(int year)
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].Title = year + i + "";
            }
            TitleBar.Text = $"{year} - {year+8}";
        }
    }

    /// <summary>
    /// 年份选择事件参数
    /// </summary>
    public class YearPickedEventArgs : EventArgs
    {
        public int Year { get; set; }
    }
}
