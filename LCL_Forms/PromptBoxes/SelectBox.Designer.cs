namespace Landriesnidis.LCL_UI.PromptBoxes
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
            this.panelContainer.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labContent
            // 
            this.labContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labContent.Size = new System.Drawing.Size(458, 54);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.cb);
            this.panelContainer.Size = new System.Drawing.Size(458, 379);
            this.panelContainer.Controls.SetChildIndex(this.labContent, 0);
            this.panelContainer.Controls.SetChildIndex(this.cb, 0);
            // 
            // panelBase
            // 
            this.panelBase.Size = new System.Drawing.Size(500, 482);
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(20, 430);
            // 
            // cb
            // 
            this.cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(0, 54);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(458, 325);
            this.cb.TabIndex = 1;
            // 
            // SelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 482);
            this.Name = "SelectBox";
            this.panelContainer.ResumeLayout(false);
            this.panelBase.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.CheckedListBox cb;
    }
}