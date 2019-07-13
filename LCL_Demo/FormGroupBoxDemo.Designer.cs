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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lclGroupBox1 = new Landriesnidis.LCL_Controls.Controls.Container.LCLGroupBox();
            this.titleBar2 = new Landriesnidis.LCL_Controls.Controls.Comm.TitleBar();
            this.titleBar1 = new Landriesnidis.LCL_Controls.Controls.Comm.TitleBar();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lclGroupBox1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 146);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 88);
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
            this.pictureBox1.Location = new System.Drawing.Point(47, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lclGroupBox1
            // 
            this.lclGroupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lclGroupBox1.Controls.Add(this.button2);
            this.lclGroupBox1.Location = new System.Drawing.Point(643, 45);
            this.lclGroupBox1.MinimumSize = new System.Drawing.Size(150, 30);
            this.lclGroupBox1.Name = "lclGroupBox1";
            this.lclGroupBox1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.lclGroupBox1.Size = new System.Drawing.Size(288, 271);
            this.lclGroupBox1.TabIndex = 6;
            this.lclGroupBox1.Title = null;
            this.lclGroupBox1.TitleBarArrowButton = true;
            this.lclGroupBox1.TitleBarArrowButtonContextMenu = null;
            this.lclGroupBox1.TitleBarCloseButton = true;
            this.lclGroupBox1.Click += new System.EventHandler(this.LclGroupBox1_Click);
            // 
            // titleBar2
            // 
            this.titleBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar2.Location = new System.Drawing.Point(424, 111);
            this.titleBar2.MaximumSize = new System.Drawing.Size(0, 30);
            this.titleBar2.MinimumSize = new System.Drawing.Size(200, 30);
            this.titleBar2.Name = "titleBar2";
            this.titleBar2.Size = new System.Drawing.Size(200, 30);
            this.titleBar2.TabIndex = 5;
            this.titleBar2.Title = "第二个";
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar1.Location = new System.Drawing.Point(194, 111);
            this.titleBar1.MaximumSize = new System.Drawing.Size(0, 30);
            this.titleBar1.MinimumSize = new System.Drawing.Size(200, 30);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(200, 30);
            this.titleBar1.TabIndex = 4;
            this.titleBar1.Title = "第一个";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 98);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormGroupBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 546);
            this.Controls.Add(this.lclGroupBox1);
            this.Controls.Add(this.titleBar2);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormGroupBoxDemo";
            this.Text = "FormGroupBoxDemo";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lclGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Landriesnidis.LCL_Controls.Controls.Comm.TitleBar titleBar1;
        private Landriesnidis.LCL_Controls.Controls.Comm.TitleBar titleBar2;
        private Landriesnidis.LCL_Controls.Controls.Container.LCLGroupBox lclGroupBox1;
        private System.Windows.Forms.Button button2;
    }
}