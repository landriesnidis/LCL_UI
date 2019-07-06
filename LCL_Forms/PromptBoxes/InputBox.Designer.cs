namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    partial class InputBox
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
            this.btnClean = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.labContent = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.tbText);
            this.panelContainer.Controls.Add(this.labContent);
            this.panelContainer.Size = new System.Drawing.Size(458, 149);
            // 
            // panelBase
            // 
            this.panelBase.Size = new System.Drawing.Size(500, 252);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnClean);
            this.panelButtons.Controls.Add(this.btnOK);
            this.panelButtons.Location = new System.Drawing.Point(20, 200);
            this.panelButtons.Controls.SetChildIndex(this.btnOK, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnCancel, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnClean, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 0);
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
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClean.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClean.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnClean.Location = new System.Drawing.Point(217, 0);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(80, 35);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // tbText
            // 
            this.tbText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbText.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbText.Location = new System.Drawing.Point(5, 34);
            this.tbText.Margin = new System.Windows.Forms.Padding(10);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(453, 105);
            this.tbText.TabIndex = 1;
            // 
            // labContent
            // 
            this.labContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labContent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labContent.Location = new System.Drawing.Point(5, 0);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(453, 34);
            this.labContent.TabIndex = 2;
            this.labContent.Text = "Content";
            this.labContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 252);
            this.Name = "InputBox";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label labContent;
    }
}