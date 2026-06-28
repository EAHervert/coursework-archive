namespace ITSE_1430
{
    partial class XMLStateAbbEH
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
            this.label1 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.NameState = new System.Windows.Forms.Label();
            this.StateAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "State Abbreviation";
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(154, 33);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(100, 20);
            this.State.TabIndex = 1;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(31, 64);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(223, 26);
            this.Button.TabIndex = 2;
            this.Button.Text = "Find Name of State";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // NameState
            // 
            this.NameState.AutoSize = true;
            this.NameState.Location = new System.Drawing.Point(28, 113);
            this.NameState.Name = "NameState";
            this.NameState.Size = new System.Drawing.Size(41, 13);
            this.NameState.TabIndex = 3;
            this.NameState.Text = "Name: ";
            // 
            // StateAnswer
            // 
            this.StateAnswer.Location = new System.Drawing.Point(154, 106);
            this.StateAnswer.Name = "StateAnswer";
            this.StateAnswer.Size = new System.Drawing.Size(100, 20);
            this.StateAnswer.TabIndex = 4;
            // 
            // XMLStateAbbEH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.StateAnswer);
            this.Controls.Add(this.NameState);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label1);
            this.Name = "XMLStateAbbEH";
            this.Text = "U.S. States";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label NameState;
        private System.Windows.Forms.TextBox StateAnswer;
    }
}