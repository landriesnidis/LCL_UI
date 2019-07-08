namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    partial class SelectBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb = new System.Windows.Forms.CheckedListBox();
            this.labContent = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 0);
            this.btnCancel.MaximumSize = new System.Drawing.Size(0, 35);
            this.btnCancel.MinimumSize = new System.Drawing.Size(56, 35);
            this.btnCancel.Size = new System.Drawing.Size(67, 35);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSelectAll);
            this.panelButtons.Controls.Add(this.btnInvert);
            this.panelButtons.Controls.Add(this.panel1);
            this.panelButtons.Controls.Add(this.btnOK);
            this.panelButtons.Location = new System.Drawing.Point(20, 398);
            this.panelButtons.Controls.SetChildIndex(this.btnOK, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnCancel, 0);
            this.panelButtons.Controls.SetChildIndex(this.panel1, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnInvert, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnSelectAll, 0);
            // 
            // panelBase
            // 
            this.panelBase.Size = new System.Drawing.Size(500, 450);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.cb);
            this.panelContainer.Controls.Add(this.labContent);
            this.panelContainer.Size = new System.Drawing.Size(458, 347);
            // 
            // cb
            // 
            this.cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(5, 51);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(453, 296);
            this.cb.TabIndex = 1;
            this.cb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Cb_ItemCheck);
            this.cb.SelectedIndexChanged += new System.EventHandler(this.Cb_SelectedIndexChanged);
            this.cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_KeyDown);
            // 
            // labContent
            // 
            this.labContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labContent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labContent.Location = new System.Drawing.Point(5, 0);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(453, 51);
            this.labContent.TabIndex = 2;
            this.labContent.Text = "Content";
            this.labContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOK.Location = new System.Drawing.Point(378, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 35);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.AutoSize = true;
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectAll.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSelectAll.Location = new System.Drawing.Point(141, 0);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(80, 35);
            this.btnSelectAll.TabIndex = 8;
            this.btnSelectAll.Text = "All";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnInvert.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInvert.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnInvert.Location = new System.Drawing.Point(221, 0);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(80, 35);
            this.btnInvert.TabIndex = 9;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = false;
            this.btnInvert.Click += new System.EventHandler(this.BtnInvert_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(301, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 35);
            this.panel1.TabIndex = 11;
            // 
            // SelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Name = "SelectBox";
            this.Load += new System.EventHandler(this.SelectBox_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.CheckedListBox cb;
        protected System.Windows.Forms.Label labContent;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Button btnInvert;
        protected System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Panel panel1;
    }
}