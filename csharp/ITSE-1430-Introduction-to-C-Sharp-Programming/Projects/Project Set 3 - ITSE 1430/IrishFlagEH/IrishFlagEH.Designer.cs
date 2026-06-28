namespace ITSE_1430
{
    partial class IrishFlagEH
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
            this.Flag = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Flag
            // 
            this.Flag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flag.Location = new System.Drawing.Point(0, 0);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(1284, 961);
            this.Flag.TabIndex = 0;
            this.Flag.Paint += new System.Windows.Forms.PaintEventHandler(this.Flag_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(969, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // IrishFlagEH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Flag);
            this.Name = "IrishFlagEH";
            this.Text = "Flag of Ireland";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Flag;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}