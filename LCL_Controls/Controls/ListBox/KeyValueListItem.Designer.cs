namespace Landriesnidis.LCL_Controls.Controls.ListBox
{
    partial class KeyValueListItem
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
            this.labKey = new System.Windows.Forms.Label();
            this.labValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labKey
            // 
            this.labKey.AutoEllipsis = true;
            this.labKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.labKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.labKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labKey.Location = new System.Drawing.Point(0, 0);
            this.labKey.Name = "labKey";
            this.labKey.Size = new System.Drawing.Size(75, 31);
            this.labKey.TabIndex = 0;
            this.labKey.Text = "Key";
            this.labKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labValue
            // 
            this.labValue.AutoEllipsis = true;
            this.labValue.BackColor = System.Drawing.Color.White;
            this.labValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labValue.Location = new System.Drawing.Point(75, 0);
            this.labValue.Name = "labValue";
            this.labValue.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labValue.Size = new System.Drawing.Size(171, 31);
            this.labValue.TabIndex = 1;
            this.labValue.Text = "Value";
            this.labValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeyValueListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labValue);
            this.Controls.Add(this.labKey);
            this.Name = "KeyValueListItem";
            this.Size = new System.Drawing.Size(246, 31);
            this.SizeChanged += new System.EventHandler(this.DeviceListItem_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labKey;
        private System.Windows.Forms.Label labValue;
    }
}
