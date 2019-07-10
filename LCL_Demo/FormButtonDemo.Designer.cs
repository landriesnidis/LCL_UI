namespace LCL_Forms
{
    partial class FormDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labToastCount = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.tbToastContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGroup1 = new Landriesnidis.LCL_Controls.Controls.Botton.ButtonGroup();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbContent);
            this.groupBox2.Controls.Add(this.tbTitle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(283, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 297);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boxes封装";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(79, 62);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(228, 25);
            this.tbContent.TabIndex = 4;
            this.tbContent.Text = "详细说明";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(79, 31);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(228, 25);
            this.tbTitle.TabIndex = 3;
            this.tbTitle.Text = "标题栏";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(611, 194);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(192, 57);
            this.button10.TabIndex = 13;
            this.button10.Text = "MsgBox";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(201, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(192, 57);
            this.button12.TabIndex = 17;
            this.button12.Text = "SelectBox(单选)";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(399, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(192, 57);
            this.button8.TabIndex = 15;
            this.button8.Text = "SelectBox(多选)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 66);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 57);
            this.button7.TabIndex = 16;
            this.button7.Text = "InputBox";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(201, 66);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(192, 57);
            this.button9.TabIndex = 14;
            this.button9.Text = "PromptBox";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(399, 66);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(192, 57);
            this.button11.TabIndex = 12;
            this.button11.Text = "PasswordBox";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labToastCount);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.tbToastContent);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(283, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 125);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toast";
            // 
            // labToastCount
            // 
            this.labToastCount.AutoSize = true;
            this.labToastCount.Location = new System.Drawing.Point(292, 29);
            this.labToastCount.Name = "labToastCount";
            this.labToastCount.Size = new System.Drawing.Size(15, 15);
            this.labToastCount.TabIndex = 15;
            this.labToastCount.Text = "0";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(313, 24);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(86, 25);
            this.button13.TabIndex = 14;
            this.button13.Text = "显示";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // tbToastContent
            // 
            this.tbToastContent.Location = new System.Drawing.Point(79, 24);
            this.tbToastContent.Name = "tbToastContent";
            this.tbToastContent.Size = new System.Drawing.Size(207, 25);
            this.tbToastContent.TabIndex = 5;
            this.tbToastContent.Text = "Toast中的信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Content";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGroup1.AutoPosition = true;
            this.buttonGroup1.AutoPositionOffset = -16;
            this.buttonGroup1.AutoSize = true;
            this.buttonGroup1.Location = new System.Drawing.Point(746, 1);
            this.buttonGroup1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGroup1.MaximizeBox = true;
            this.buttonGroup1.MinimizeBox = true;
            this.buttonGroup1.Name = "buttonGroup1";
            this.buttonGroup1.Size = new System.Drawing.Size(180, 42);
            this.buttonGroup1.TabIndex = 9;
            this.buttonGroup1.ExitButtonClick += new System.EventHandler(this.ButtonGroup1_ExitButtonClick);
            this.buttonGroup1.MaximizeButtonClick += new System.EventHandler(this.ButtonGroup1_MaximizeButtonClick);
            this.buttonGroup1.MinimizeButtonClick += new System.EventHandler(this.ButtonGroup1_MinimizeButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "BaseBox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "MsgBox";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "PasswordBox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 57);
            this.button4.TabIndex = 9;
            this.button4.Text = "PromptBox";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 57);
            this.button5.TabIndex = 10;
            this.button5.Text = "SelectBox";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(33, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 57);
            this.button6.TabIndex = 11;
            this.button6.Text = "InputBox";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 428);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实例方式启动";
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGroup1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormDemo";
            this.Text = "LCL UI Demo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbToastContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label labToastCount;
        private Landriesnidis.LCL_Controls.Controls.Botton.ButtonGroup buttonGroup1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

