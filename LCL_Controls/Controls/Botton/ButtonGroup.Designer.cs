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
            this.exitButton = new Landriesnidis.LCL_Controls.Controls.Botton.ExitButton();
            this.maximizeButton = new Landriesnidis.LCL_Controls.Controls.Botton.MaximizeButton();
            this.minimizeButton = new Landriesnidis.LCL_Controls.Controls.Botton.MinimizeButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.exitButton);
            this.panel.Controls.Add(this.maximizeButton);
            this.panel.Controls.Add(this.minimizeButton);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(180, 42);
            this.panel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(120, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 42);
            this.exitButton.TabIndex = 0;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizeButton.BackgroundImage")));
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton.Location = new System.Drawing.Point(60, 0);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(60, 42);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.Location = new System.Drawing.Point(0, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(60, 42);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ButtonGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ButtonGroup";
            this.Size = new System.Drawing.Size(180, 42);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private ExitButton exitButton;
        private MinimizeButton minimizeButton;
        private MaximizeButton maximizeButton;
    }
}
