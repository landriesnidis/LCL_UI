namespace LCL_Demo
{
    partial class FormGroupBoxDemo
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lclGroupBox1 = new Landriesnidis.LCL_Controls.Controls.Container.LCLGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new Landriesnidis.LCL_Controls.Controls.Container.LCLTabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.lclGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(90, 76);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.aToolStripMenuItem.Text = "A";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.bToolStripMenuItem.Text = "B";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.cToolStripMenuItem.Text = "C";
            // 
            // lclGroupBox1
            // 
            this.lclGroupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lclGroupBox1.Controls.Add(this.panel1);
            this.lclGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.lclGroupBox1.MinimumSize = new System.Drawing.Size(150, 30);
            this.lclGroupBox1.Name = "lclGroupBox1";
            this.lclGroupBox1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.lclGroupBox1.Size = new System.Drawing.Size(180, 178);
            this.lclGroupBox1.TabIndex = 0;
            this.lclGroupBox1.Title = "你好";
            this.lclGroupBox1.TitleBarArrowButton = true;
            this.lclGroupBox1.TitleBarArrowButtonContextMenu = this.contextMenuStrip1;
            this.lclGroupBox1.TitleBarCloseButton = true;
            this.lclGroupBox1.CloseButtonClick += new System.EventHandler(this.LclGroupBox1_CloseButtonClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 146);
            this.panel1.TabIndex = 1;
            // 
            // tabBar1
            // 
            this.tabControl.AutoSize = true;
            this.tabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControl.Location = new System.Drawing.Point(272, 34);
            this.tabControl.Name = "tabBar1";
            this.tabControl.Size = new System.Drawing.Size(680, 500);
            this.tabControl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LCL_Demo.Properties.Resources.CloseMiniButton;
            this.pictureBox1.Location = new System.Drawing.Point(47, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormGroupBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lclGroupBox1);
            this.Name = "FormGroupBoxDemo";
            this.Text = "FormGroupBoxDemo";
            this.contextMenuStrip1.ResumeLayout(false);
            this.lclGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Landriesnidis.LCL_Controls.Controls.Container .LCLGroupBox lclGroupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private Landriesnidis.LCL_Controls.Controls.Container.LCLTabControl tabControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}