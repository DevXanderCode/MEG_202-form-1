namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.input = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(357, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Mat No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(360, 116);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(256, 20);
            this.input.TabIndex = 1;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(360, 183);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(256, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 493);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button submitBtn;
    }
}

