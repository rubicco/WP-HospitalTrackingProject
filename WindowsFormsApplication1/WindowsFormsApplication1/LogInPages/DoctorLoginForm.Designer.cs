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
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // girisButton
            // 
            this.girisButton.FlatAppearance.BorderSize = 3;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Location = new System.Drawing.Point(147, 162);
            this.girisButton.Margin = new System.Windows.Forms.Padding(4);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(133, 41);
            this.girisButton.TabIndex = 9;
            this.girisButton.Text = "GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parolaTextBox.Location = new System.Drawing.Point(147, 103);
            this.parolaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(133, 22);
            this.parolaTextBox.TabIndex = 6;
            this.parolaTextBox.UseSystemPasswordChar = true;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(147, 37);
            this.kullaniciAdiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(133, 22);
            this.kullaniciAdiTextBox.TabIndex = 5;
            // 
            // DoctorLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 265);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
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
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
    }
}