namespace Landriesnidis.LCL_Controls.Controls.SettingsBox
{
    partial class ItemControl_StringList
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
            this.lbStringList = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStringList
            // 
            this.lbStringList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStringList.FormattingEnabled = true;
            this.lbStringList.ItemHeight = 15;
            this.lbStringList.Location = new System.Drawing.Point(0, 0);
            this.lbStringList.Name = "lbStringList";
            this.lbStringList.Size = new System.Drawing.Size(250, 224);
            this.lbStringList.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.Location = new System.Drawing.Point(170, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 26);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "移除";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(90, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(90, 25);
            this.tb.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tb);
            this.panel.Controls.Add(this.btnAdd);
            this.panel.Controls.Add(this.btnRemove);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 224);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.MaximumSize = new System.Drawing.Size(0, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 26);
            this.panel.TabIndex = 0;
            // 
            // ItemControl_StringList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbStringList);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemControl_StringList";
            this.Size = new System.Drawing.Size(250, 250);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ListBox lbStringList;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Panel panel;
    }
}
