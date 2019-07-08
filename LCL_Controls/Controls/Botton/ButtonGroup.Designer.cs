namespace Landriesnidis.LCL_Controls.Controls.Botton
{
    partial class ButtonGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonGroup));
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.exitButton1 = new Landriesnidis.LCL_Controls.Controls.Botton.ExitButton();
            this.maximizeButton1 = new Landriesnidis.LCL_Controls.Controls.Botton.MaximizeButton();
            this.minimizeButton1 = new Landriesnidis.LCL_Controls.Controls.Botton.MinimizeButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.exitButton1);
            this.panel.Controls.Add(this.maximizeButton1);
            this.panel.Controls.Add(this.minimizeButton1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(180, 42);
            this.panel.TabIndex = 0;
            // 
            // exitButton1
            // 
            this.exitButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton1.BackgroundImage")));
            this.exitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton1.Location = new System.Drawing.Point(120, 0);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(60, 42);
            this.exitButton1.TabIndex = 0;
            // 
            // maximizeButton1
            // 
            this.maximizeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizeButton1.BackgroundImage")));
            this.maximizeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton1.Location = new System.Drawing.Point(60, 0);
            this.maximizeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.maximizeButton1.Name = "maximizeButton1";
            this.maximizeButton1.Size = new System.Drawing.Size(60, 42);
            this.maximizeButton1.TabIndex = 1;
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton1.BackgroundImage")));
            this.minimizeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton1.Location = new System.Drawing.Point(0, 0);
            this.minimizeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(60, 42);
            this.minimizeButton1.TabIndex = 2;
            // 
            // ButtonGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ButtonGroup";
            this.Size = new System.Drawing.Size(180, 42);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private ExitButton exitButton1;
        private MaximizeButton maximizeButton1;
        private MinimizeButton minimizeButton1;
    }
}
