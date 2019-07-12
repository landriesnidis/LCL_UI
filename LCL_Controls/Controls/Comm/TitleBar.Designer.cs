namespace Landriesnidis.LCL_Controls.Controls.Comm
{
    partial class TitleBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBar));
            this.labTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new Landriesnidis.LCL_Controls.Controls.Comm.MiniImageButton();
            this.btnArrow = new Landriesnidis.LCL_Controls.Controls.Comm.MiniImageButton();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(142, 30);
            this.labTitle.TabIndex = 2;
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.btnClose);
            this.flowLayoutPanel.Controls.Add(this.btnArrow);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(142, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 4, 5, 5);
            this.flowLayoutPanel.Size = new System.Drawing.Size(58, 30);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(31, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            // 
            // btnArrow
            // 
            this.btnArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArrow.BackgroundImage")));
            this.btnArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnArrow.Image")));
            this.btnArrow.Location = new System.Drawing.Point(8, 5);
            this.btnArrow.Margin = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(20, 20);
            this.btnArrow.TabIndex = 1;
            // 
            // cms
            // 
            this.cms.AutoSize = false;
            this.cms.BackColor = System.Drawing.Color.White;
            this.cms.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(211, 56);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.flowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(0, 30);
            this.MinimumSize = new System.Drawing.Size(200, 30);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(200, 30);
            this.Load += new System.EventHandler(this.TitleBar_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        public MiniImageButton btnClose;
        public MiniImageButton btnArrow;
        private System.Windows.Forms.ContextMenuStrip cms;
        public System.Windows.Forms.Label labTitle;
    }
}
