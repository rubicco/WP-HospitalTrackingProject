namespace WindowsFormsApplication1.HospitalPages
{
    partial class DoktorDuzenle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.unvanTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bransTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kadinRadioButton = new System.Windows.Forms.RadioButton();
            this.erkekRadioButton = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.TCKimlikNoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.isTelTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cepTelTextBox = new System.Windows.Forms.MaskedTextBox();
            this.poliklinikComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TCinputMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.doktorDogumTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doktor Düzenleme";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 56);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.AutoSize = false;
            this.saveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = global::WindowsFormsApplication1.Properties.Resources.save;
            this.saveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(53, 53);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.doktorDogumTarihiDateTimePicker);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.unvanTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bransTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TCKimlikNoTextBox);
            this.panel1.Controls.Add(this.isTelTextBox);
            this.panel1.Controls.Add(this.cepTelTextBox);
            this.panel1.Controls.Add(this.poliklinikComboBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.adresTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.soyadTextBox);
            this.panel1.Controls.Add(this.adTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 279);
            this.panel1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(347, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Unvan:";
            // 
            // unvanTextBox
            // 
            this.unvanTextBox.Enabled = false;
            this.unvanTextBox.Location = new System.Drawing.Point(406, 184);
            this.unvanTextBox.Name = "unvanTextBox";
            this.unvanTextBox.Size = new System.Drawing.Size(209, 20);
            this.unvanTextBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(352, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Branş:";
            // 
            // bransTextBox
            // 
            this.bransTextBox.Enabled = false;
            this.bransTextBox.Location = new System.Drawing.Point(406, 152);
            this.bransTextBox.Name = "bransTextBox";
            this.bransTextBox.Size = new System.Drawing.Size(209, 20);
            this.bransTextBox.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kadinRadioButton);
            this.panel2.Controls.Add(this.erkekRadioButton);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(114, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 28);
            this.panel2.TabIndex = 26;
            // 
            // kadinRadioButton
            // 
            this.kadinRadioButton.AutoSize = true;
            this.kadinRadioButton.Enabled = false;
            this.kadinRadioButton.Location = new System.Drawing.Point(113, 4);
            this.kadinRadioButton.Name = "kadinRadioButton";
            this.kadinRadioButton.Size = new System.Drawing.Size(52, 17);
            this.kadinRadioButton.TabIndex = 1;
            this.kadinRadioButton.TabStop = true;
            this.kadinRadioButton.Text = "Kadın";
            this.kadinRadioButton.UseVisualStyleBackColor = true;
            // 
            // erkekRadioButton
            // 
            this.erkekRadioButton.AutoSize = true;
            this.erkekRadioButton.Enabled = false;
            this.erkekRadioButton.Location = new System.Drawing.Point(15, 4);
            this.erkekRadioButton.Name = "erkekRadioButton";
            this.erkekRadioButton.Size = new System.Drawing.Size(53, 17);
            this.erkekRadioButton.TabIndex = 0;
            this.erkekRadioButton.TabStop = true;
            this.erkekRadioButton.Text = "Erkek";
            this.erkekRadioButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(61, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Cinsiyet:";
            // 
            // TCKimlikNoTextBox
            // 
            this.TCKimlikNoTextBox.Enabled = false;
            this.TCKimlikNoTextBox.Location = new System.Drawing.Point(114, 117);
            this.TCKimlikNoTextBox.Mask = "00000000000";
            this.TCKimlikNoTextBox.Name = "TCKimlikNoTextBox";
            this.TCKimlikNoTextBox.Size = new System.Drawing.Size(187, 20);
            this.TCKimlikNoTextBox.TabIndex = 23;
            this.TCKimlikNoTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // isTelTextBox
            // 
            this.isTelTextBox.Enabled = false;
            this.isTelTextBox.Location = new System.Drawing.Point(114, 187);
            this.isTelTextBox.Mask = "(999) 000-0000";
            this.isTelTextBox.Name = "isTelTextBox";
            this.isTelTextBox.Size = new System.Drawing.Size(187, 20);
            this.isTelTextBox.TabIndex = 22;
            // 
            // cepTelTextBox
            // 
            this.cepTelTextBox.Enabled = false;
            this.cepTelTextBox.Location = new System.Drawing.Point(114, 152);
            this.cepTelTextBox.Mask = "(999) 000-0000";
            this.cepTelTextBox.Name = "cepTelTextBox";
            this.cepTelTextBox.Size = new System.Drawing.Size(187, 20);
            this.cepTelTextBox.TabIndex = 21;
            // 
            // poliklinikComboBox
            // 
            this.poliklinikComboBox.Enabled = false;
            this.poliklinikComboBox.FormattingEnabled = true;
            this.poliklinikComboBox.Items.AddRange(new object[] {
            "-",
            "SGK",
            "Bağ-Kur",
            "Emekli Sandığı"});
            this.poliklinikComboBox.Location = new System.Drawing.Point(406, 117);
            this.poliklinikComboBox.Name = "poliklinikComboBox";
            this.poliklinikComboBox.Size = new System.Drawing.Size(209, 21);
            this.poliklinikComboBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(338, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Poliklinik:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(352, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Adres:";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Enabled = false;
            this.adresTextBox.Location = new System.Drawing.Point(406, 20);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.adresTextBox.Size = new System.Drawing.Size(209, 82);
            this.adresTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(39, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "İş Telefonu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(28, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cep Telefonu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(31, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(62, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(79, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Enabled = false;
            this.soyadTextBox.Location = new System.Drawing.Point(114, 56);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(187, 20);
            this.soyadTextBox.TabIndex = 1;
            // 
            // adTextBox
            // 
            this.adTextBox.Enabled = false;
            this.adTextBox.Location = new System.Drawing.Point(114, 20);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(187, 20);
            this.adTextBox.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(354, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "NOT: Sadece düzenlemek istediklerinizi yazıp \'Kaydet\' butonuna tıklayınız.";
            // 
            // TCinputMaskedTextBox
            // 
            this.TCinputMaskedTextBox.Location = new System.Drawing.Point(170, 78);
            this.TCinputMaskedTextBox.Mask = "00000000000";
            this.TCinputMaskedTextBox.Name = "TCinputMaskedTextBox";
            this.TCinputMaskedTextBox.Size = new System.Drawing.Size(81, 20);
            this.TCinputMaskedTextBox.TabIndex = 27;
            this.TCinputMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(269, 75);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(75, 23);
            this.guncelleButton.TabIndex = 26;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Doktorun TC numarasını giriniz:";
            // 
            // doktorDogumTarihiDateTimePicker
            // 
            this.doktorDogumTarihiDateTimePicker.CustomFormat = "dd/mm/yyyy";
            this.doktorDogumTarihiDateTimePicker.Enabled = false;
            this.doktorDogumTarihiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.doktorDogumTarihiDateTimePicker.Location = new System.Drawing.Point(114, 218);
            this.doktorDogumTarihiDateTimePicker.Name = "doktorDogumTarihiDateTimePicker";
            this.doktorDogumTarihiDateTimePicker.Size = new System.Drawing.Size(187, 20);
            this.doktorDogumTarihiDateTimePicker.TabIndex = 32;
            this.doktorDogumTarihiDateTimePicker.Value = new System.DateTime(2016, 12, 27, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(28, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Doğum Tarihi:";
            // 
            // DoktorDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 449);
            this.Controls.Add(this.TCinputMaskedTextBox);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "DoktorDuzenle";
            this.Text = "DoktorDuzenle";
            this.Load += new System.EventHandler(this.DoktorDuzenle_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox unvanTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bransTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton kadinRadioButton;
        private System.Windows.Forms.RadioButton erkekRadioButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox TCKimlikNoTextBox;
        private System.Windows.Forms.MaskedTextBox isTelTextBox;
        private System.Windows.Forms.MaskedTextBox cepTelTextBox;
        private System.Windows.Forms.ComboBox poliklinikComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox TCinputMaskedTextBox;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker doktorDogumTarihiDateTimePicker;
        private System.Windows.Forms.Label label15;
    }
}