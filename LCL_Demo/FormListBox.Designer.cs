﻿namespace LCL_Demo
{
    partial class FormListBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kvlb = new Landriesnidis.LCL_Controls.Controls.ListBox.KeyValueListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Key";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(443, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // kvlb
            // 
            this.kvlb.AutoScroll = true;
            this.kvlb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kvlb.Dock = System.Windows.Forms.DockStyle.Left;
            this.kvlb.Location = new System.Drawing.Point(0, 0);
            this.kvlb.Name = "kvlb";
            this.kvlb.ScrollBarWidth = 18;
            this.kvlb.Size = new System.Drawing.Size(369, 450);
            this.kvlb.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(443, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Allow Edit";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kvlb);
            this.Name = "FormListBox";
            this.Text = "FormListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Landriesnidis.LCL_Controls.Controls.ListBox.KeyValueListBox kvlb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}