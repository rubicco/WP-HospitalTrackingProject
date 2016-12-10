namespace WindowsFormsApplication1.HospitalPages
{
    partial class HastaKabul
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kadinRadioButton = new System.Windows.Forms.RadioButton();
            this.erkekRadioButton = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.TCKimlikNoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.isTelTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cepTelTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.poliklinikComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sosyalGuvenceComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meslekTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.TCKimlikNoTextBox);
            this.panel1.Controls.Add(this.isTelTextBox);
            this.panel1.Controls.Add(this.cepTelTextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.poliklinikComboBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.sosyalGuvenceComboBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.adresTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.meslekTextBox);
            this.panel1.Controls.Add(this.soyadTextBox);
            this.panel1.Controls.Add(this.adTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 328);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kadinRadioButton);
            this.panel2.Controls.Add(this.erkekRadioButton);
            this.panel2.Location = new System.Drawing.Point(114, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 28);
            this.panel2.TabIndex = 26;
            // 
            // kadinRadioButton
            // 
            this.kadinRadioButton.AutoSize = true;
            this.kadinRadioButton.Location = new System.Drawing.Point(91, 4);
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
            this.label13.Location = new System.Drawing.Point(61, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Cinsiyet:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(406, 187);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(209, 20);
            this.emailTextBox.TabIndex = 24;
            // 
            // TCKimlikNoTextBox
            // 
            this.TCKimlikNoTextBox.Location = new System.Drawing.Point(114, 117);
            this.TCKimlikNoTextBox.Mask = "00000000000";
            this.TCKimlikNoTextBox.Name = "TCKimlikNoTextBox";
            this.TCKimlikNoTextBox.Size = new System.Drawing.Size(165, 20);
            this.TCKimlikNoTextBox.TabIndex = 23;
            this.TCKimlikNoTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // isTelTextBox
            // 
            this.isTelTextBox.Location = new System.Drawing.Point(114, 187);
            this.isTelTextBox.Mask = "(999) 000-0000";
            this.isTelTextBox.Name = "isTelTextBox";
            this.isTelTextBox.Size = new System.Drawing.Size(165, 20);
            this.isTelTextBox.TabIndex = 22;
            // 
            // cepTelTextBox
            // 
            this.cepTelTextBox.Location = new System.Drawing.Point(114, 152);
            this.cepTelTextBox.Mask = "(999) 000-0000";
            this.cepTelTextBox.Name = "cepTelTextBox";
            this.cepTelTextBox.Size = new System.Drawing.Size(165, 20);
            this.cepTelTextBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "E-mail Adresi:";
            // 
            // poliklinikComboBox
            // 
            this.poliklinikComboBox.FormattingEnabled = true;
            this.poliklinikComboBox.Items.AddRange(new object[] {
            "-",
            "SGK",
            "Bağ-Kur",
            "Emekli Sandığı"});
            this.poliklinikComboBox.Location = new System.Drawing.Point(406, 131);
            this.poliklinikComboBox.Name = "poliklinikComboBox";
            this.poliklinikComboBox.Size = new System.Drawing.Size(209, 21);
            this.poliklinikComboBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Poliklinik:";
            // 
            // sosyalGuvenceComboBox
            // 
            this.sosyalGuvenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sosyalGuvenceComboBox.FormattingEnabled = true;
            this.sosyalGuvenceComboBox.Items.AddRange(new object[] {
            "-",
            "SGK",
            "Bağ-Kur",
            "Emekli Sandığı"});
            this.sosyalGuvenceComboBox.Location = new System.Drawing.Point(114, 259);
            this.sosyalGuvenceComboBox.Name = "sosyalGuvenceComboBox";
            this.sosyalGuvenceComboBox.Size = new System.Drawing.Size(165, 21);
            this.sosyalGuvenceComboBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Adres:";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(406, 20);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.adresTextBox.Size = new System.Drawing.Size(209, 82);
            this.adresTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sosyal Güvence:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "İş Telefonu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Meslek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cep Telefonu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // meslekTextBox
            // 
            this.meslekTextBox.Location = new System.Drawing.Point(114, 224);
            this.meslekTextBox.Name = "meslekTextBox";
            this.meslekTextBox.Size = new System.Drawing.Size(165, 20);
            this.meslekTextBox.TabIndex = 5;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(114, 56);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(165, 20);
            this.soyadTextBox.TabIndex = 1;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(114, 20);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(165, 20);
            this.adTextBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 56);
            this.toolStrip1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(209, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasta Ekleme";
            // 
            // HastaKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "HastaKabul";
            this.Text = "HastaKabul";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton kadinRadioButton;
        private System.Windows.Forms.RadioButton erkekRadioButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox TCKimlikNoTextBox;
        private System.Windows.Forms.MaskedTextBox isTelTextBox;
        private System.Windows.Forms.MaskedTextBox cepTelTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox poliklinikComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sosyalGuvenceComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meslekTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}