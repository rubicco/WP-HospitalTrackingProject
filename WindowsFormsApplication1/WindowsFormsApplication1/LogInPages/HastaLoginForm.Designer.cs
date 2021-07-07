namespace WindowsFormsApplication1.LogInPages
{
    partial class HastaLoginForm
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
            this.sorgulaButton = new System.Windows.Forms.Button();
            this.tcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sorgulaButton
            // 
            this.sorgulaButton.Location = new System.Drawing.Point(60, 89);
            this.sorgulaButton.Margin = new System.Windows.Forms.Padding(2);
            this.sorgulaButton.Name = "sorgulaButton";
            this.sorgulaButton.Size = new System.Drawing.Size(83, 54);
            this.sorgulaButton.TabIndex = 2;
            this.sorgulaButton.Text = "Sorgula";
            this.sorgulaButton.UseVisualStyleBackColor = true;
            this.sorgulaButton.Click += new System.EventHandler(this.sorgulaButton_Click);
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(89, 49);
            this.tcTextBox.Mask = "00000000000";
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(100, 20);
            this.tcTextBox.TabIndex = 30;
            this.tcTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "TC Numarası:";
            // 
            // HastaLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sorgulaButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HastaLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaLoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HastaLoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sorgulaButton;
        private System.Windows.Forms.MaskedTextBox tcTextBox;
        private System.Windows.Forms.Label label2;
    }
}