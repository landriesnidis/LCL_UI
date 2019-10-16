 namespace Landriesnidis.LCL_Forms.Base
{
    partial class LCLMainForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.Size = new System.Drawing.Size(800, 428);
            // 
            // panelContainer
            // 
            this.panelContainer.Size = new System.Drawing.Size(768, 374);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(664, 1);
            this.buttonGroup.MaximizeBox = true;
            this.buttonGroup.MinimizeBox = true;
            // 
            // labTitle
            // 
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Size = new System.Drawing.Size(768, 32);
            this.labTitle.Text = "LCLMainForm";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 8;
            // 
            // LCLMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Name = "LCLMainForm";
            this.Controls.SetChildIndex(this.statusStrip, 0);
            this.Controls.SetChildIndex(this.panelBase, 0);
            this.Controls.SetChildIndex(this.buttonGroup, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
    }
}