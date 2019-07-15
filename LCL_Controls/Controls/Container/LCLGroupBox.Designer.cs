namespace Landriesnidis.LCL_Controls.Controls.Container
{
    partial class LCLGroupBox
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
            this.components = new System.ComponentModel.Container();
            this.titleBar = new Landriesnidis.LCL_Controls.Controls.Comm.TitleBar();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar.Location = new System.Drawing.Point(-1, -1);
            this.titleBar.MaximumSize = new System.Drawing.Size(0, 30);
            this.titleBar.MinimumSize = new System.Drawing.Size(150, 30);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(150, 30);
            this.titleBar.TabIndex = 0;
            this.titleBar.Title = null;
            // 
            // LCLGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.titleBar);
            this.MinimumSize = new System.Drawing.Size(150, 30);
            this.Name = "LCLGroupBox";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(425, 384);
            this.Load += new System.EventHandler(this.LCLGroupBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Comm.TitleBar titleBar;
    }
}
