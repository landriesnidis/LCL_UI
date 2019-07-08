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
            this.panelButtons.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(402, 0);
            this.btnCancel.MaximumSize = new System.Drawing.Size(0, 35);
            this.btnCancel.MinimumSize = new System.Drawing.Size(56, 35);
            this.btnCancel.Size = new System.Drawing.Size(56, 35);
            this.btnCancel.Text = "OK";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.labContent);
            this.panelContainer.Size = new System.Drawing.Size(458, 97);
            // 
            // labContent
            // 
            this.labContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labContent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labContent.Location = new System.Drawing.Point(5, 0);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(453, 97);
            this.labContent.TabIndex = 0;
            this.labContent.Text = "Content";
            this.labContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonDefaultCancelText = "OK";
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Name = "MsgBox";
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label labContent;
    }
}