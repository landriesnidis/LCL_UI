namespace Landriesnidis.LCL_Controls.Controls.Container
{
    partial class LCLTabControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCLTabControl));
            Landriesnidis.LCL_Controls.Controls.Comm.StateColorSet miniImageButtonColor1 = new Landriesnidis.LCL_Controls.Controls.Comm.StateColorSet();
            this.panelHead = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleBar1 = new Landriesnidis.LCL_Controls.Controls.Comm.TitleBar();
            this.btnMorePage = new Landriesnidis.LCL_Controls.Controls.Comm.MiniImageButton();
            this.panelHead.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.panelTitle);
            this.panelHead.Controls.Add(this.btnMorePage);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.MinimumSize = new System.Drawing.Size(0, 30);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(874, 30);
            this.panelHead.TabIndex = 2;
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = true;
            this.panelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitle.Controls.Add(this.titleBar1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(849, 30);
            this.panelTitle.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(874, 529);
            this.panelMain.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 3);
            this.panel1.TabIndex = 4;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar1.Location = new System.Drawing.Point(1, 1);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(1);
            this.titleBar1.MaximumSize = new System.Drawing.Size(0, 30);
            this.titleBar1.MinimumSize = new System.Drawing.Size(200, 30);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(200, 30);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.Title = "起始页";
            // 
            // btnMorePage
            // 
            this.btnMorePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMorePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMorePage.BackgroundImage")));
            this.btnMorePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMorePage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMorePage.Image = ((System.Drawing.Image)(resources.GetObject("btnMorePage.Image")));
            this.btnMorePage.Location = new System.Drawing.Point(849, 0);
            miniImageButtonColor1.LostFocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            miniImageButtonColor1.LostFocusForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            miniImageButtonColor1.MouseDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(152)))));
            miniImageButtonColor1.MouseDownForegroundColor = System.Drawing.Color.White;
            miniImageButtonColor1.MouseLeaveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            miniImageButtonColor1.MouseLeaveForegroundColor = System.Drawing.Color.White;
            miniImageButtonColor1.MouseMoveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            miniImageButtonColor1.MouseMoveForegroundColor = System.Drawing.Color.White;
            this.btnMorePage.MiniImageButtonColor = miniImageButtonColor1;
            this.btnMorePage.Name = "btnMorePage";
            this.btnMorePage.Size = new System.Drawing.Size(25, 30);
            this.btnMorePage.TabIndex = 2;
            // 
            // LCLTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHead);
            this.Name = "LCLTabControl";
            this.Size = new System.Drawing.Size(874, 562);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.FlowLayoutPanel panelTitle;
        private Comm.TitleBar titleBar1;
        private Comm.MiniImageButton btnMorePage;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
    }
}
