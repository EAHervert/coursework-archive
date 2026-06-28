namespace ITSE_1430
{
    partial class GuessNummberEH
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
            this.Pick = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.Result = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.test = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pick
            // 
            this.Pick.AutoSize = true;
            this.Pick.Location = new System.Drawing.Point(43, 69);
            this.Pick.Name = "Pick";
            this.Pick.Size = new System.Drawing.Size(78, 26);
            this.Pick.TabIndex = 0;
            this.Pick.Text = "Pick a number.\r\nSee if you win.";
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.Location = new System.Drawing.Point(46, 166);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(31, 17);
            this.B1.TabIndex = 1;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(139, 166);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(185, 166);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(222, 166);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(307, 117);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(94, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "2";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Checked = true;
            this.test.ForeColor = System.Drawing.Color.White;
            this.test.Location = new System.Drawing.Point(16, 16);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(14, 13);
            this.test.TabIndex = 9;
            this.test.TabStop = true;
            this.test.UseVisualStyleBackColor = true;
            this.test.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hover over here for Hint.";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // GuessNummberEH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Pick);
            this.Name = "GuessNummberEH";
            this.Text = "GuessANumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pick;
        private System.Windows.Forms.RadioButton B1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton test;
        private System.Windows.Forms.Label label1;
    }
}