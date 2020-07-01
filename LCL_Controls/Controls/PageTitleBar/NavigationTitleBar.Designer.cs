using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Controls.PageTitleBar
{
    partial class NavigationTitleBar
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
            this.LeftButton = new Landriesnidis.LCL_Controls.Controls.Button.MiniImageButton();
            this.RightButton = new Landriesnidis.LCL_Controls.Controls.Button.MiniImageButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(400, 35);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.LeftButton.AllowNoFocusResponseMouseEvent = true;
            this.LeftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftButton.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.android_title_bar_arrow;
            this.LeftButton.Location = new System.Drawing.Point(0, 0);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(Height, Height);
            this.LeftButton.TabIndex = 1;


            this.RightButton.AllowNoFocusResponseMouseEvent = true;
            this.RightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightButton.Image = global::Landriesnidis.LCL_Controls.Properties.Resources.android_title_bar_arrow_right;
            this.RightButton.Location = new System.Drawing.Point(465, 0);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(Height, Height);
            this.RightButton.TabIndex = 2;

            // 
            // AndroidTitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Name = "NavigationTitleBar";
            this.Size = new System.Drawing.Size(400, 35);
            this.Resize += new System.EventHandler(this.NavigationTitleBar_Resize);
            this.ResumeLayout(false);
        }

        #endregion
        protected Button.MiniImageButton LeftButton;
        protected Button.MiniImageButton RightButton;
        public Label TitleLabel;
    }
}
