namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    partial class PromptBox
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
            this.btnOK = new System.Windows.Forms.Button();
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
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnOK);
            this.panelButtons.Controls.SetChildIndex(this.btnOK, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnCancel, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 0);
            this.btnCancel.Text = "No";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOK.Location = new System.Drawing.Point(378, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 35);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Yes";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // labContent
            // 
            this.labContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labContent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labContent.Location = new System.Drawing.Point(0, 0);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(458, 97);
            this.labContent.TabIndex = 1;
            this.labContent.Text = "Content";
            this.labContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PromptBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.ButtonDefaultCancelText = "No";
            this.Name = "PromptBox";
            this.panelContainer.ResumeLayout(false);
            this.panelBase.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Label labContent;
    }
}