namespace Landriesnidis.LCL_Controls.Controls.PageTitleBar
{
    partial class AndroidTitleBar
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
            this.labTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "label1";
            this.labTitle.Size = new System.Drawing.Size(400, 35);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Title";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AndroidTitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labTitle);
            this.Name = "AndroidTitleBar";
            this.Size = new System.Drawing.Size(400, 35);
            this.Resize += new System.EventHandler(this.AndroidTitleBar_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        
    }
}
