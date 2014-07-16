namespace Gaps
{
    partial class InputBox
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radTxt = new System.Windows.Forms.RadioButton();
            this.radNum = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.Checked = false;
            this.dtPicker.CustomFormat = "";
            this.dtPicker.Location = new System.Drawing.Point(72, 13);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(116, 70);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick a date";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radTxt
            // 
            this.radTxt.AutoSize = true;
            this.radTxt.Checked = true;
            this.radTxt.Location = new System.Drawing.Point(116, 39);
            this.radTxt.Name = "radTxt";
            this.radTxt.Size = new System.Drawing.Size(46, 17);
            this.radTxt.TabIndex = 4;
            this.radTxt.TabStop = true;
            this.radTxt.Text = "Text";
            this.radTxt.UseVisualStyleBackColor = true;
            // 
            // radNum
            // 
            this.radNum.AutoSize = true;
            this.radNum.Location = new System.Drawing.Point(197, 39);
            this.radNum.Name = "radNum";
            this.radNum.Size = new System.Drawing.Size(67, 17);
            this.radNum.TabIndex = 5;
            this.radNum.TabStop = true;
            this.radNum.Text = "Numbers";
            this.radNum.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insert SIM #\'s as";
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radNum);
            this.Controls.Add(this.radTxt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaps Date Dialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radTxt;
        private System.Windows.Forms.RadioButton radNum;
        private System.Windows.Forms.Label label2;
    }
}