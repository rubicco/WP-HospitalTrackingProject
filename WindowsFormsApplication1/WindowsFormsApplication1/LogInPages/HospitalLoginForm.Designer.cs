namespace WindowsFormsApplication1.LogInPages
{
    partial class HospitalLoginForm
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
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciAdiTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(120, 41);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.kullaniciAdiTextBox.TabIndex = 0;
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parolaTextBox.Location = new System.Drawing.Point(120, 94);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parolaTextBox.TabIndex = 1;
            this.parolaTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola:";
            // 
            // girisButton
            // 
            this.girisButton.FlatAppearance.BorderSize = 3;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Location = new System.Drawing.Point(120, 142);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(100, 33);
            this.girisButton.TabIndex = 4;
            this.girisButton.Text = "GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // HospitalLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 233);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HospitalLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Girişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HospitalLoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisButton;
    }
}