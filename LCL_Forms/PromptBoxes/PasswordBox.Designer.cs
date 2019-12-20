namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    partial class PasswordBox
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
            this.psw = new System.Windows.Forms.TextBox();
            this.labContent = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 0);
            this.btnCancel.MaximumSize = new System.Drawing.Size(0, 28);
            this.btnCancel.MinimumSize = new System.Drawing.Size(42, 28);
            this.btnCancel.Size = new System.Drawing.Size(56, 28);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnClean);
            this.panelButtons.Controls.Add(this.btnOK);
            this.panelButtons.Controls.SetChildIndex(this.btnOK, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnCancel, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnClean, 0);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.psw);
            this.panelContainer.Controls.Add(this.labContent);
            this.panelContainer.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelContainer.Size = new System.Drawing.Size(343, 78);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(179, 1);
            // 
            // labTitle
            // 
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Size = new System.Drawing.Size(343, 32);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOK.Location = new System.Drawing.Point(283, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 28);
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
            this.btnClean.Location = new System.Drawing.Point(167, 0);
            this.btnClean.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(60, 28);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // psw
            // 
            this.psw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psw.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.psw.Location = new System.Drawing.Point(3, 27);
            this.psw.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.psw.Name = "psw";
            this.psw.PasswordChar = '●';
            this.psw.Size = new System.Drawing.Size(340, 23);
            this.psw.TabIndex = 1;
            this.psw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Psw_KeyDown);
            // 
            // labContent
            // 
            this.labContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labContent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labContent.Location = new System.Drawing.Point(3, 0);
            this.labContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(340, 27);
            this.labContent.TabIndex = 2;
            this.labContent.Text = "Content";
            this.labContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 160);
            this.MinimumSize = new System.Drawing.Size(211, 102);
            this.Name = "PasswordBox";
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.Label labContent;
    }
}