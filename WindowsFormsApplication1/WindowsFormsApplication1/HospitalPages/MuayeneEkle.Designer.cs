namespace WindowsFormsApplication1.HospitalPages
{
    partial class MuayeneEkle
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.muayeneEkleTCKimlikTextBox = new System.Windows.Forms.MaskedTextBox();
            this.muayeneEklePoliklinikComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.muayeneDoktorListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.muayeneTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.muayeneSikayetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Muayene Ekleme";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 56);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.AutoSize = false;
            this.saveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::WindowsFormsApplication1.Properties.Resources.save;
            this.saveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(53, 53);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // muayeneEkleTCKimlikTextBox
            // 
            this.muayeneEkleTCKimlikTextBox.Location = new System.Drawing.Point(128, 26);
            this.muayeneEkleTCKimlikTextBox.Mask = "00000000000";
            this.muayeneEkleTCKimlikTextBox.Name = "muayeneEkleTCKimlikTextBox";
            this.muayeneEkleTCKimlikTextBox.Size = new System.Drawing.Size(209, 20);
            this.muayeneEkleTCKimlikTextBox.TabIndex = 23;
            this.muayeneEkleTCKimlikTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // muayeneEklePoliklinikComboBox
            // 
            this.muayeneEklePoliklinikComboBox.FormattingEnabled = true;
            this.muayeneEklePoliklinikComboBox.Location = new System.Drawing.Point(128, 211);
            this.muayeneEklePoliklinikComboBox.Name = "muayeneEklePoliklinikComboBox";
            this.muayeneEklePoliklinikComboBox.Size = new System.Drawing.Size(209, 21);
            this.muayeneEklePoliklinikComboBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Poliklinik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC Kimlik No:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.muayeneDoktorListBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.muayeneTarihiDateTimePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.muayeneSikayetTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.muayeneEkleTCKimlikTextBox);
            this.panel1.Controls.Add(this.muayeneEklePoliklinikComboBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(35, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 350);
            this.panel1.TabIndex = 6;
            // 
            // muayeneDoktorListBox
            // 
            this.muayeneDoktorListBox.FormattingEnabled = true;
            this.muayeneDoktorListBox.Location = new System.Drawing.Point(128, 100);
            this.muayeneDoktorListBox.Name = "muayeneDoktorListBox";
            this.muayeneDoktorListBox.ScrollAlwaysVisible = true;
            this.muayeneDoktorListBox.Size = new System.Drawing.Size(209, 95);
            this.muayeneDoktorListBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Doktor:";
            // 
            // muayeneTarihiDateTimePicker
            // 
            this.muayeneTarihiDateTimePicker.Location = new System.Drawing.Point(128, 67);
            this.muayeneTarihiDateTimePicker.Name = "muayeneTarihiDateTimePicker";
            this.muayeneTarihiDateTimePicker.Size = new System.Drawing.Size(209, 20);
            this.muayeneTarihiDateTimePicker.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Muayene Tarihi:";
            // 
            // muayeneSikayetTextBox
            // 
            this.muayeneSikayetTextBox.Location = new System.Drawing.Point(128, 247);
            this.muayeneSikayetTextBox.Multiline = true;
            this.muayeneSikayetTextBox.Name = "muayeneSikayetTextBox";
            this.muayeneSikayetTextBox.Size = new System.Drawing.Size(209, 76);
            this.muayeneSikayetTextBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Şikayet:";
            // 
            // MuayeneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "MuayeneEkle";
            this.Text = "Muayene Ekle";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.MaskedTextBox muayeneEkleTCKimlikTextBox;
        private System.Windows.Forms.ComboBox muayeneEklePoliklinikComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker muayeneTarihiDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox muayeneSikayetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox muayeneDoktorListBox;
    }
}