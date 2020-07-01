namespace Landriesnidis.LCL_Forms.PromptBoxes
{
    partial class DatePickBox
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
            this.datePicker = new Landriesnidis.LCL_Controls.Controls.DatePickers.DatePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.labDate = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 0);
            this.btnCancel.MaximumSize = new System.Drawing.Size(0, 28);
            this.btnCancel.MinimumSize = new System.Drawing.Size(45, 28);
            this.btnCancel.Size = new System.Drawing.Size(56, 28);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.labDate);
            this.panelButtons.Controls.Add(this.btnToday);
            this.panelButtons.Controls.Add(this.panel1);
            this.panelButtons.Controls.Add(this.btnOK);
            this.panelButtons.Location = new System.Drawing.Point(15, 258);
            this.panelButtons.Size = new System.Drawing.Size(268, 28);
            this.panelButtons.Controls.SetChildIndex(this.btnOK, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnCancel, 0);
            this.panelButtons.Controls.SetChildIndex(this.panel1, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnToday, 0);
            this.panelButtons.Controls.SetChildIndex(this.labDate, 0);
            // 
            // panelBase
            // 
            this.panelBase.Size = new System.Drawing.Size(300, 300);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.datePicker);
            this.panelContainer.Size = new System.Drawing.Size(268, 218);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(164, 1);
            // 
            // labTitle
            // 
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Size = new System.Drawing.Size(268, 32);
            this.labTitle.Text = "DatePickerBox";
            // 
            // panelContent
            // 
            this.panelContent.Size = new System.Drawing.Size(268, 218);
            // 
            // datePicker
            // 
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.Location = new System.Drawing.Point(4, 0);
            this.datePicker.Month = 1;
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(264, 218);
            this.datePicker.TabIndex = 0;
            this.datePicker.Year = 0;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOK.Location = new System.Drawing.Point(208, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labDate
            // 
            this.labDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDate.Location = new System.Drawing.Point(0, 0);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(89, 28);
            this.labDate.TabIndex = 8;
            this.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToday.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnToday.Location = new System.Drawing.Point(89, 0);
            this.btnToday.Margin = new System.Windows.Forms.Padding(0);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(60, 28);
            this.btnToday.TabIndex = 9;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(149, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 28);
            this.panel1.TabIndex = 10;
            // 
            // DatePickBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "DatePickBox";
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LCL_Controls.Controls.DatePickers.DatePicker datePicker;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Label panel1;
    }
}