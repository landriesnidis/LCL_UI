namespace Landriesnidis.LCL_Controls.Controls.SettingsBox
{
    partial class ItemControl_StringDictionary
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
            this.menuBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBack = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new Landriesnidis.LCL_Controls.Controls.Container.LCLGroupBox();
            this.panelAddItem = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.kvList = new Landriesnidis.LCL_Controls.Controls.ListBox.KeyValueListBox();
            this.slideBox = new Landriesnidis.LCL_Controls.Controls.Slide.SlideBox();
            this.menuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBox.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panelAddItem.SuspendLayout();
            this.menuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBox
            // 
            this.menuBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiClean,
            this.tsmiBack});
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(163, 76);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(162, 24);
            this.tsmiAdd.Text = "新增 (&Add)";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiClean
            // 
            this.tsmiClean.Name = "tsmiClean";
            this.tsmiClean.Size = new System.Drawing.Size(162, 24);
            this.tsmiClean.Text = "清空 (&Clean)";
            this.tsmiClean.Click += new System.EventHandler(this.tsmiClean_Click);
            // 
            // tsmiBack
            // 
            this.tsmiBack.Enabled = false;
            this.tsmiBack.Name = "tsmiBack";
            this.tsmiBack.Size = new System.Drawing.Size(162, 24);
            this.tsmiBack.Text = "返回 (&Back)";
            this.tsmiBack.Click += new System.EventHandler(this.tsmiBack_Click);
            // 
            // groupBox
            // 
            this.groupBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox.Controls.Add(this.panelAddItem);
            this.groupBox.Controls.Add(this.kvList);
            this.groupBox.Controls.Add(this.slideBox);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.groupBox.Size = new System.Drawing.Size(389, 277);
            this.groupBox.TabIndex = 0;
            this.groupBox.Title = null;
            this.groupBox.TitleBarArrowButton = true;
            this.groupBox.TitleBarArrowButtonContextMenu = this.menuBox;
            this.groupBox.TitleBarCloseButton = false;
            // 
            // panelAddItem
            // 
            this.panelAddItem.Controls.Add(this.label1);
            this.panelAddItem.Controls.Add(this.tbKey);
            this.panelAddItem.Controls.Add(this.label2);
            this.panelAddItem.Controls.Add(this.tbValue);
            this.panelAddItem.Controls.Add(this.btnOK);
            this.panelAddItem.Controls.Add(this.btnCancel);
            this.panelAddItem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelAddItem.Location = new System.Drawing.Point(210, 85);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(160, 180);
            this.panelAddItem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbKey.Location = new System.Drawing.Point(3, 23);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(150, 27);
            this.tbKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value:";
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbValue.Location = new System.Drawing.Point(3, 76);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(150, 27);
            this.tbValue.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOK.Location = new System.Drawing.Point(3, 109);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.Location = new System.Drawing.Point(3, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // kvList
            // 
            this.kvList.AutoScroll = true;
            this.kvList.ItemsPadding = new System.Windows.Forms.Padding(3);
            this.kvList.Location = new System.Drawing.Point(13, 53);
            this.kvList.Name = "kvList";
            this.kvList.ScrollBarWidth = 18;
            this.kvList.SearchBox = null;
            this.kvList.SearchBoxFilter = Landriesnidis.LCL_Controls.Controls.ListBox.KeyValueListBox.SearchBoxFilterItem.OnlyKey;
            this.kvList.Size = new System.Drawing.Size(148, 179);
            this.kvList.TabIndex = 2;
            // 
            // slideBox
            // 
            this.slideBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.slideBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideBox.Location = new System.Drawing.Point(0, 30);
            this.slideBox.Margin = new System.Windows.Forms.Padding(0);
            this.slideBox.Name = "slideBox";
            this.slideBox.Rate = 5;
            this.slideBox.ReviseValue = 5;
            this.slideBox.Size = new System.Drawing.Size(387, 245);
            this.slideBox.TabIndex = 1;
            // 
            // menuItem
            // 
            this.menuItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(211, 80);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(210, 24);
            this.tsmiDelete.Text = "删除 (&Delete)";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(210, 24);
            this.tsmiEdit.Text = "编辑 (&Edit)";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // ItemControl_StringDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.MinimumSize = new System.Drawing.Size(160, 210);
            this.Name = "ItemControl_StringDictionary";
            this.Size = new System.Drawing.Size(389, 277);
            this.menuBox.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.panelAddItem.ResumeLayout(false);
            this.panelAddItem.PerformLayout();
            this.menuItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Container.LCLGroupBox groupBox;
        private Slide.SlideBox slideBox;
        private ListBox.KeyValueListBox kvList;
        private System.Windows.Forms.FlowLayoutPanel panelAddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip menuBox;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiClean;
        private System.Windows.Forms.ToolStripMenuItem tsmiBack;
        private System.Windows.Forms.ContextMenuStrip menuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
    }
}
