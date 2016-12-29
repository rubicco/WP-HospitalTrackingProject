namespace WindowsFormsApplication1.LogInPages
{
    partial class DoctorLoginForm
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
            this.girisButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // girisButton
            // 
            this.girisButton.FlatAppearance.BorderSize = 3;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Location = new System.Drawing.Point(110, 132);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(100, 33);
            this.girisButton.TabIndex = 9;
            this.girisButton.Text = "GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC Numarası:";
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parolaTextBox.Location = new System.Drawing.Point(110, 84);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parolaTextBox.TabIndex = 6;
            this.parolaTextBox.UseSystemPasswordChar = true;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(110, 29);
            this.kullaniciAdiTextBox.Mask = "00000000000";
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.kullaniciAdiTextBox.TabIndex = 28;
            this.kullaniciAdiTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // DoctorLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 215);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parolaTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoctorLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Girişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorLoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.MaskedTextBox kullaniciAdiTextBox;
    }
}