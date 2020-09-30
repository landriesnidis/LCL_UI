namespace IoT_Studio.UI.Settings
{
    partial class DynamicListItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labContent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labTagText = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labContent);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(49, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panel1.Size = new System.Drawing.Size(427, 48);
            this.panel1.TabIndex = 0;
            // 
            // labContent
            // 
            this.labContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labContent.Location = new System.Drawing.Point(4, 26);
            this.labContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(419, 22);
            this.labContent.TabIndex = 1;
            this.labContent.Text = "Content";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labTagText);
            this.panel2.Controls.Add(this.labTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 26);
            this.panel2.TabIndex = 0;
            // 
            // labTagText
            // 
            this.labTagText.AutoSize = true;
            this.labTagText.Dock = System.Windows.Forms.DockStyle.Right;
            this.labTagText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTagText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labTagText.Location = new System.Drawing.Point(365, 0);
            this.labTagText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTagText.Name = "labTagText";
            this.labTagText.Size = new System.Drawing.Size(54, 17);
            this.labTagText.TabIndex = 1;
            this.labTagText.Text = "TagText";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(36, 17);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Title";
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic.Location = new System.Drawing.Point(4, 4);
            this.pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(45, 48);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // DynamicListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DynamicListItem";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(480, 56);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labTagText;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.PictureBox pic;
    }
}
