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
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.timerShake = new System.Windows.Forms.Timer(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.buttonGroup = new Landriesnidis.LCL_Controls.Controls.Botton.ButtonGroup();
            this.mmc = new Landriesnidis.LCL_Controls.Components.MouseMoveController(this.components);
            this.panelBase.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBase.Controls.Add(this.panelContent);
            this.panelBase.Controls.Add(this.panel1);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBase.Name = "panelBase";
            this.panelBase.Padding = new System.Windows.Forms.Padding(15, 8, 15, 12);
            this.panelBase.Size = new System.Drawing.Size(375, 160);
            this.panelBase.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelContainer);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(15, 40);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(343, 106);
            this.panelContent.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panelContainer.Size = new System.Drawing.Size(343, 106);
            this.panelContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labTitle);
            this.panel1.Controls.Add(this.pic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 32);
            this.panel1.TabIndex = 3;
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(30, 0);
            this.labTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(313, 32);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Title";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerShake
            // 
            this.timerShake.Interval = 30;
            this.timerShake.Tick += new System.EventHandler(this.TimerShake_Tick);
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic.Name = "pic";
            this.pic.Padding = new System.Windows.Forms.Padding(6, 10, 6, 3);
            this.pic.Size = new System.Drawing.Size(30, 32);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // buttonGroup
            // 
            this.buttonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGroup.AutoPosition = true;
            this.buttonGroup.AutoPositionOffset = 0;
            this.buttonGroup.AutoSize = true;
            this.buttonGroup.Location = new System.Drawing.Point(251, 1);
            this.buttonGroup.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGroup.MaximizeBox = false;
            this.buttonGroup.MinimizeBox = false;
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(135, 34);
            this.buttonGroup.TabIndex = 7;
            // 
            // mmc
            // 
            this.mmc.AllowDoubleClickMaximization = false;
            this.mmc.Form = this;
            // 
            // LCLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(375, 160);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.panelBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(375, 160);
            this.Name = "LCLForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.LCLForm_Load);
            this.panelBase.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private LCL_Controls.Components.MouseMoveController mmc;
        protected System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Timer timerShake;
        public System.Windows.Forms.Panel panelContainer;
        public LCL_Controls.Controls.Botton.ButtonGroup buttonGroup;
        protected System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic;
    }
}