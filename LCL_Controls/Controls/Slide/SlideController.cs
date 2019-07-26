using Landriesnidis.LCL_Controls.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.Slide
{
    public class SlideController
    {
        public int ReviseValue { get; set; } = 10;
        public int Rate { get; set; } = 2;
        public Control CurrentPage { get { return CurrentPage; } set { if (Controls.Contains(value)) { Controls.Add(value); } CurrentPage = value; timer.Enabled = true; } }
        private Control CurrentLeftPage { get { return CurrentLeftPage; } set { CurrentLeftPage = value; CurrentLeftPage.Visible = true; } }
        private Control CurrentRightPage { get { return CurrentRightPage; } set { CurrentRightPage = value; CurrentRightPage.Visible = true; } }

        public AeList<Control> Controls { get; set; }
        private Timer timer;

        public SlideController(SlideBox box)
        {
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;

            Controls.ItemAddedEvent += Controls_ItemAddedEvent;
        }

        private void Controls_ItemAddedEvent(AeList<Control> list, ListItemsChangedEventArgs<Control> e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(CurrentPage.Left) <= ReviseValue)
            {
                CurrentPage.Left = 0;
                TimerStop();
                return;
            }
            CurrentPage.Left = CurrentPage.Left - (CurrentPage.Left - 0) / Rate;
            if (CurrentLeftPage != null) CurrentLeftPage.Left = CurrentPage.Left - CurrentLeftPage.Width - 1;
            if (CurrentRightPage != null) CurrentRightPage.Left = CurrentPage.Left + CurrentPage.Width + 1;
        }

        public void JumpToPreviousPage()
        {
            int num = GetCurrentPageIndex() - 1;
            Jump(num);
        }

        public void JumpToNextPage()
        {
            int num = GetCurrentPageIndex() - 1;
            Jump(num);
        }

        public void Jump(int pageNum)
        {
            if (pageNum < 0 && pageNum >= Controls.Count) return;

            int index = GetCurrentPageIndex();
            if (index == pageNum) return;
            
            if (index < pageNum)    // 向后翻
            {
                CurrentLeftPage = CurrentPage;
                CurrentRightPage = (pageNum + 1 >= Controls.Count) ? null : Controls[pageNum+1];
            }
            else                    // 向前翻
            {
                CurrentRightPage = CurrentPage;
                CurrentLeftPage = (pageNum - 1 <0) ? null : Controls[pageNum -1];
            }
            CurrentPage = Controls[pageNum];
        }

        private int GetCurrentPageIndex()
        {
            for (int i=0;i<=Controls.Count;i++)
            {
                if (CurrentPage == Controls[i]) return i;
            }
            return -1;
        }

        private void TimerStop()
        {
            timer.Enabled = false;
            CurrentLeftPage = null;
            CurrentRightPage = null;
            foreach(Control c in Controls)
            {
                c.Visible = c == CurrentPage;
            }
        }
    }
}
