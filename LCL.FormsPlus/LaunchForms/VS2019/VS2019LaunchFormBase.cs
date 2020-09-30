using Landriesnidis.LCL_Forms.Extensions;
using Landriesnidis.LCL_Forms.PromptBoxes;
using Landriesnidis.LCL_Forms.ToastBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_Studio.UI.Settings
{
    public partial class VS2019LaunchFormBase : Form
    {
        [Browsable(true)]
        public string FormTitle { get { return labFormTitle.Text; } set { labFormTitle.Text = value; Text = value; } }

        [Browsable(false)]
        public Control MainView { get { return panelMain.Controls[0]; } set { panelMain.Controls.Clear(); panelMain.Controls.Add(value); value.Dock = DockStyle.Fill; } }

        public VS2019LaunchFormBase()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // 配置窗体支持鼠标拖动的区域
            mouseMoveController.Form = this;
            mouseMoveController.AllowDoubleClickMaximization = true;
            mouseMoveController.Add(new Control[] { this, panelContent, panelTitle, labFormTitle });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void FormSeamlessJump(VS2019LaunchFormBase form)
        {
            form.SlowShow(
                pretreatmentCallback: () =>
                {
                    form.Size = Size;
                    form.Location = Location;
                    form.FormClosing += Form_FormClosing;
                },
                successCallback: () =>
                {
                    form.TopMost = true;
                    Hide();
                }
            );
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Form form = (Form)sender;

            this.SlowShow(
                pretreatmentCallback: () =>
                {
                    Size = form.Size;
                    Location = form.Location;
                    TopMost = true;
                },
                successCallback: () =>
                {
                    form.Hide();
                    form.Dispose();
                    form.FormClosing -= Form_FormClosing;
                    TopMost = false;
                }
            );
        }
    }
}
