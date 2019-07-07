using System;

namespace Landriesnidis.LCL_Forms.Base
{
    partial class LCLForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCLForm));
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnExit = new Landriesnidis.LCL_Controls.Controls.Botton.ExitButton();
            this.mmc = new Landriesnidis.LCL_Controls.Components.MouseMoveController(this.components);
            this.timerShake = new System.Windows.Forms.Timer(this.components);
            this.panelBase.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBase.Controls.Add(this.panelContent);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Padding = new System.Windows.Forms.Padding(20, 10, 20, 15);
            this.panelBase.Size = new System.Drawing.Size(500, 200);
            this.panelBase.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelContainer);
            this.panelContent.Controls.Add(this.labTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(20, 10);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(458, 173);
            this.panelContent.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelContainer.Size = new System.Drawing.Size(458, 132);
            this.panelContainer.TabIndex = 2;
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(458, 41);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Title";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(439, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 42);
            this.btnExit.TabIndex = 6;
            // 
            // mmc
            // 
            this.mmc.Form = null;
            // 
            // timerShake
            // 
            this.timerShake.Interval = 30;
            this.timerShake.Tick += new System.EventHandler(this.TimerShake_Tick);
            // 
            // LCLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "LCLForm";
            this.Text = "BaseForm";
            this.panelBase.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labTitle;
        private LCL_Controls.Components.MouseMoveController mmc;
        protected System.Windows.Forms.Panel panelBase;
        protected LCL_Controls.Controls.Botton.ExitButton btnExit;
        private System.Windows.Forms.Timer timerShake;
        public System.Windows.Forms.Panel panelContainer;
    }
}