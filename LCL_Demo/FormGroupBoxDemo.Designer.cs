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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupBoxDemo));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lclTabControl1 = new Landriesnidis.LCL_Controls.Controls.Container.LCLTabControl();
            this.lclGroupBox1 = new Landriesnidis.LCL_Controls.Controls.Container.LCLGroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.miniImageButton1 = new Landriesnidis.LCL_Controls.Controls.Comm.MiniImageButton();
            this.exitButton1 = new Landriesnidis.LCL_Controls.Controls.Botton.ExitButton();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(498, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lclTabControl1
            // 
            this.lclTabControl1.AutoSize = true;
            this.lclTabControl1.Location = new System.Drawing.Point(278, 22);
            this.lclTabControl1.Name = "lclTabControl1";
            this.lclTabControl1.Size = new System.Drawing.Size(674, 387);
            this.lclTabControl1.TabIndex = 10;
            // 
            // lclGroupBox1
            // 
            this.lclGroupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lclGroupBox1.Controls.Add(this.button4);
            this.lclGroupBox1.Controls.Add(this.button2);
            this.lclGroupBox1.Location = new System.Drawing.Point(151, 431);
            this.lclGroupBox1.MinimumSize = new System.Drawing.Size(150, 30);
            this.lclGroupBox1.Name = "lclGroupBox1";
            this.lclGroupBox1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.lclGroupBox1.Size = new System.Drawing.Size(221, 210);
            this.lclGroupBox1.TabIndex = 8;
            this.lclGroupBox1.Title = "最后一个";
            this.lclGroupBox1.TitleBarArrowButton = true;
            this.lclGroupBox1.TitleBarArrowButtonContextMenu = null;
            this.lclGroupBox1.TitleBarCloseButton = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 41);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // miniImageButton1
            // 
            this.miniImageButton1.AllowNoFocusResponseMouseEvent = true;
            this.miniImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.miniImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("miniImageButton1.BackgroundImage")));
            this.miniImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("miniImageButton1.Image")));
            this.miniImageButton1.Location = new System.Drawing.Point(47, 367);
            this.miniImageButton1.Name = "miniImageButton1";
            this.miniImageButton1.Size = new System.Drawing.Size(78, 67);
            this.miniImageButton1.TabIndex = 6;
            this.miniImageButton1.Click += new System.EventHandler(this.MiniImageButton1_Click);
            // 
            // exitButton1
            // 
            this.exitButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton1.BackgroundImage")));
            this.exitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton1.Location = new System.Drawing.Point(151, 367);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(60, 42);
            this.exitButton1.TabIndex = 5;
            this.exitButton1.Click += new System.EventHandler(this.ExitButton1_Click);
            // 
            // FormGroupBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 546);
            this.Controls.Add(this.lclTabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lclGroupBox1);
            this.Controls.Add(this.miniImageButton1);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormGroupBoxDemo";
            this.Text = "FormGroupBoxDemo";
            this.Load += new System.EventHandler(this.FormGroupBoxDemo_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lclGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Landriesnidis.LCL_Controls.Controls.Botton.ExitButton exitButton1;
        private Landriesnidis.LCL_Controls.Controls.Comm.MiniImageButton miniImageButton1;
        private Landriesnidis.LCL_Controls.Controls.Container.LCLGroupBox lclGroupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Landriesnidis.LCL_Controls.Controls.Container.LCLTabControl lclTabControl1;
    }
}