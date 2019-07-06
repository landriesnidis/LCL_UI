namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    partial class MsgBox
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
            this.labContent = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.labContent);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.Text = "OK";
            // 
            // labContent
            // 
            this.labContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labContent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labContent.Location = new System.Drawing.Point(0, 0);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(458, 97);
            this.labContent.TabIndex = 0;
            this.labContent.Text = "Content";
            this.labContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.ButtonDefaultCancelText = "OK";
            this.Name = "MsgBox";
            this.panelContainer.ResumeLayout(false);
            this.panelBase.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label labContent;
    }
}