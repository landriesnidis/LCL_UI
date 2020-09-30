namespace IoT_Studio.UI.Settings
{
    partial class VS2019LaunchFormBase
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.labFormTitle = new System.Windows.Forms.Label();
            this.buttonGroup = new Landriesnidis.LCL_Controls.Controls.Botton.ButtonGroup();
            this.mouseMoveController = new Landriesnidis.LCL_Controls.Components.MouseMoveController(this.components);
            this.panelContent.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.panelMain);
            this.panelContent.Controls.Add(this.panelTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(40, 35, 40, 35);
            this.panelContent.Size = new System.Drawing.Size(900, 625);
            this.panelContent.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(40, 102);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelMain.Size = new System.Drawing.Size(818, 486);
            this.panelMain.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labFormTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTitle.Location = new System.Drawing.Point(40, 35);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(818, 67);
            this.panelTitle.TabIndex = 1;
            // 
            // labFormTitle
            // 
            this.labFormTitle.AutoSize = true;
            this.labFormTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFormTitle.Location = new System.Drawing.Point(2, 0);
            this.labFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labFormTitle.Name = "labFormTitle";
            this.labFormTitle.Size = new System.Drawing.Size(238, 46);
            this.labFormTitle.TabIndex = 0;
            this.labFormTitle.Text = "Launch Form";
            // 
            // buttonGroup
            // 
            this.buttonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGroup.AutoPosition = false;
            this.buttonGroup.AutoPositionOffset = 0;
            this.buttonGroup.AutoSize = true;
            this.buttonGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGroup.Location = new System.Drawing.Point(764, 1);
            this.buttonGroup.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGroup.MaximizeBox = true;
            this.buttonGroup.MinimizeBox = true;
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(135, 34);
            this.buttonGroup.TabIndex = 1;
            // 
            // mouseMoveController
            // 
            this.mouseMoveController.AllowDoubleClickMaximization = false;
            this.mouseMoveController.Form = null;
            // 
            // VS2019LaunchFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 625);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 625);
            this.Name = "VS2019LaunchFormBase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panelContent.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelContent;
        public Landriesnidis.LCL_Controls.Components.MouseMoveController mouseMoveController;
        public Landriesnidis.LCL_Controls.Controls.Botton.ButtonGroup buttonGroup;
        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.FlowLayoutPanel panelTitle;
        public System.Windows.Forms.Label labFormTitle;
    }
}