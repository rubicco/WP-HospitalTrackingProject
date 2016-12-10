namespace WindowsFormsApplication1.HospitalPages
{
    partial class HospitalMainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTabPage = new System.Windows.Forms.TabPage();
            this.doktorListTabPage = new System.Windows.Forms.TabPage();
            this.doktorEkleButton = new System.Windows.Forms.Button();
            this.doktorSilButton = new System.Windows.Forms.Button();
            this.doktorDuzenleButton = new System.Windows.Forms.Button();
            this.hastaKabulTabPage = new System.Windows.Forms.TabPage();
            this.hastaKabulButton = new System.Windows.Forms.Button();
            this.hastaSilmeButton = new System.Windows.Forms.Button();
            this.hastaDuzenleButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.hastaSayisiStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.poliklinikEkleButton = new System.Windows.Forms.Button();
            this.poliklinikSilButton = new System.Windows.Forms.Button();
            this.poliklinikButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.poliklinikTabPage.SuspendLayout();
            this.doktorListTabPage.SuspendLayout();
            this.hastaKabulTabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem,
            this.doktorİşlemleriToolStripMenuItem,
            this.poliklinikİşlemleriToolStripMenuItem1,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "hospitalMainPageMenuStrip";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEkleToolStripMenuItem,
            this.hastaSilmeToolStripMenuItem,
            this.hastaDüzenleToolStripMenuItem});
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            // 
            // hastaEkleToolStripMenuItem
            // 
            this.hastaEkleToolStripMenuItem.Name = "hastaEkleToolStripMenuItem";
            this.hastaEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hastaEkleToolStripMenuItem.Text = "Hasta Kabul";
            this.hastaEkleToolStripMenuItem.Click += new System.EventHandler(this.hastaEkleToolStripMenuItem_Click);
            // 
            // hastaSilmeToolStripMenuItem
            // 
            this.hastaSilmeToolStripMenuItem.Name = "hastaSilmeToolStripMenuItem";
            this.hastaSilmeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hastaSilmeToolStripMenuItem.Text = "Hasta Silme";
            this.hastaSilmeToolStripMenuItem.Click += new System.EventHandler(this.hastaSilmeToolStripMenuItem_Click);
            // 
            // hastaDüzenleToolStripMenuItem
            // 
            this.hastaDüzenleToolStripMenuItem.Name = "hastaDüzenleToolStripMenuItem";
            this.hastaDüzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hastaDüzenleToolStripMenuItem.Text = "Hasta Düzenle";
            this.hastaDüzenleToolStripMenuItem.Click += new System.EventHandler(this.hastaDüzenleToolStripMenuItem_Click);
            // 
            // doktorİşlemleriToolStripMenuItem
            // 
            this.doktorİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorEkleToolStripMenuItem,
            this.doktorSilToolStripMenuItem,
            this.doktorDüzenleToolStripMenuItem});
            this.doktorİşlemleriToolStripMenuItem.Name = "doktorİşlemleriToolStripMenuItem";
            this.doktorİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.doktorİşlemleriToolStripMenuItem.Text = "Doktor İşlemleri";
            // 
            // doktorEkleToolStripMenuItem
            // 
            this.doktorEkleToolStripMenuItem.Name = "doktorEkleToolStripMenuItem";
            this.doktorEkleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.doktorEkleToolStripMenuItem.Text = "Doktor Ekle";
            this.doktorEkleToolStripMenuItem.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem_Click);
            // 
            // doktorSilToolStripMenuItem
            // 
            this.doktorSilToolStripMenuItem.Name = "doktorSilToolStripMenuItem";
            this.doktorSilToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.doktorSilToolStripMenuItem.Text = "Doktor Sil";
            this.doktorSilToolStripMenuItem.Click += new System.EventHandler(this.doktorSilToolStripMenuItem_Click);
            // 
            // poliklinikİşlemleriToolStripMenuItem1
            // 
            this.poliklinikİşlemleriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliklinikEkleToolStripMenuItem1,
            this.poliklinikÇıkarToolStripMenuItem});
            this.poliklinikİşlemleriToolStripMenuItem1.Name = "poliklinikİşlemleriToolStripMenuItem1";
            this.poliklinikİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(114, 20);
            this.poliklinikİşlemleriToolStripMenuItem1.Text = "Poliklinik İşlemleri";
            // 
            // poliklinikEkleToolStripMenuItem1
            // 
            this.poliklinikEkleToolStripMenuItem1.Name = "poliklinikEkleToolStripMenuItem1";
            this.poliklinikEkleToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.poliklinikEkleToolStripMenuItem1.Text = "Poliklinik Ekle";
            this.poliklinikEkleToolStripMenuItem1.Click += new System.EventHandler(this.poliklinikEkleToolStripMenuItem1_Click);
            // 
            // poliklinikÇıkarToolStripMenuItem
            // 
            this.poliklinikÇıkarToolStripMenuItem.Name = "poliklinikÇıkarToolStripMenuItem";
            this.poliklinikÇıkarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.poliklinikÇıkarToolStripMenuItem.Text = "Poliklinik Çıkar";
            this.poliklinikÇıkarToolStripMenuItem.Click += new System.EventHandler(this.poliklinikÇıkarToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // doktorDüzenleToolStripMenuItem
            // 
            this.doktorDüzenleToolStripMenuItem.Name = "doktorDüzenleToolStripMenuItem";
            this.doktorDüzenleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.doktorDüzenleToolStripMenuItem.Text = "Doktor Düzenle";
            this.doktorDüzenleToolStripMenuItem.Click += new System.EventHandler(this.doktorDüzenleToolStripMenuItem_Click);
            // 
            // poliklinikTabPage
            // 
            this.poliklinikTabPage.Controls.Add(this.groupBox1);
            this.poliklinikTabPage.Controls.Add(this.poliklinikButton);
            this.poliklinikTabPage.Controls.Add(this.poliklinikSilButton);
            this.poliklinikTabPage.Controls.Add(this.poliklinikEkleButton);
            this.poliklinikTabPage.Location = new System.Drawing.Point(4, 22);
            this.poliklinikTabPage.Name = "poliklinikTabPage";
            this.poliklinikTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.poliklinikTabPage.Size = new System.Drawing.Size(567, 120);
            this.poliklinikTabPage.TabIndex = 3;
            this.poliklinikTabPage.Text = "Poliklinik İşlemleri";
            this.poliklinikTabPage.UseVisualStyleBackColor = true;
            // 
            // doktorListTabPage
            // 
            this.doktorListTabPage.Controls.Add(this.doktorDuzenleButton);
            this.doktorListTabPage.Controls.Add(this.doktorSilButton);
            this.doktorListTabPage.Controls.Add(this.doktorEkleButton);
            this.doktorListTabPage.Location = new System.Drawing.Point(4, 22);
            this.doktorListTabPage.Name = "doktorListTabPage";
            this.doktorListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.doktorListTabPage.Size = new System.Drawing.Size(567, 120);
            this.doktorListTabPage.TabIndex = 2;
            this.doktorListTabPage.Text = "Doktor İşlemleri";
            this.doktorListTabPage.UseVisualStyleBackColor = true;
            // 
            // doktorEkleButton
            // 
            this.doktorEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorEkleButton.Location = new System.Drawing.Point(34, 36);
            this.doktorEkleButton.Name = "doktorEkleButton";
            this.doktorEkleButton.Size = new System.Drawing.Size(117, 62);
            this.doktorEkleButton.TabIndex = 0;
            this.doktorEkleButton.Text = "Doktor Ekle";
            this.doktorEkleButton.UseVisualStyleBackColor = true;
            this.doktorEkleButton.Click += new System.EventHandler(this.doktorEkleButton_Click);
            // 
            // doktorSilButton
            // 
            this.doktorSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorSilButton.Location = new System.Drawing.Point(220, 36);
            this.doktorSilButton.Name = "doktorSilButton";
            this.doktorSilButton.Size = new System.Drawing.Size(117, 62);
            this.doktorSilButton.TabIndex = 1;
            this.doktorSilButton.Text = "Doktor Sil";
            this.doktorSilButton.UseVisualStyleBackColor = true;
            this.doktorSilButton.Click += new System.EventHandler(this.doktorSilButton_Click);
            // 
            // doktorDuzenleButton
            // 
            this.doktorDuzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorDuzenleButton.Location = new System.Drawing.Point(403, 36);
            this.doktorDuzenleButton.Name = "doktorDuzenleButton";
            this.doktorDuzenleButton.Size = new System.Drawing.Size(117, 62);
            this.doktorDuzenleButton.TabIndex = 2;
            this.doktorDuzenleButton.Text = "Doktor Düzenle";
            this.doktorDuzenleButton.UseVisualStyleBackColor = true;
            this.doktorDuzenleButton.Click += new System.EventHandler(this.doktorDuzenleButton_Click);
            // 
            // hastaKabulTabPage
            // 
            this.hastaKabulTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hastaKabulTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hastaKabulTabPage.Controls.Add(this.hastaDuzenleButton);
            this.hastaKabulTabPage.Controls.Add(this.hastaSilmeButton);
            this.hastaKabulTabPage.Controls.Add(this.hastaKabulButton);
            this.hastaKabulTabPage.Location = new System.Drawing.Point(4, 22);
            this.hastaKabulTabPage.Name = "hastaKabulTabPage";
            this.hastaKabulTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hastaKabulTabPage.Size = new System.Drawing.Size(567, 120);
            this.hastaKabulTabPage.TabIndex = 0;
            this.hastaKabulTabPage.Text = "Hasta İşlemleri";
            this.hastaKabulTabPage.UseVisualStyleBackColor = true;
            // 
            // hastaKabulButton
            // 
            this.hastaKabulButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaKabulButton.Location = new System.Drawing.Point(29, 27);
            this.hastaKabulButton.Name = "hastaKabulButton";
            this.hastaKabulButton.Size = new System.Drawing.Size(111, 62);
            this.hastaKabulButton.TabIndex = 3;
            this.hastaKabulButton.Text = "HASTA KABUL";
            this.hastaKabulButton.UseVisualStyleBackColor = true;
            this.hastaKabulButton.Click += new System.EventHandler(this.hastaKabulButton_Click);
            // 
            // hastaSilmeButton
            // 
            this.hastaSilmeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaSilmeButton.Location = new System.Drawing.Point(220, 27);
            this.hastaSilmeButton.Name = "hastaSilmeButton";
            this.hastaSilmeButton.Size = new System.Drawing.Size(111, 62);
            this.hastaSilmeButton.TabIndex = 4;
            this.hastaSilmeButton.Text = "HASTA SİLME";
            this.hastaSilmeButton.UseVisualStyleBackColor = true;
            this.hastaSilmeButton.Click += new System.EventHandler(this.hastaSilmeButton_Click);
            // 
            // hastaDuzenleButton
            // 
            this.hastaDuzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaDuzenleButton.Location = new System.Drawing.Point(406, 27);
            this.hastaDuzenleButton.Name = "hastaDuzenleButton";
            this.hastaDuzenleButton.Size = new System.Drawing.Size(111, 62);
            this.hastaDuzenleButton.TabIndex = 5;
            this.hastaDuzenleButton.Text = "HASTA DÜZENLE";
            this.hastaDuzenleButton.UseVisualStyleBackColor = true;
            this.hastaDuzenleButton.Click += new System.EventHandler(this.hastaDuzenleButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hastaKabulTabPage);
            this.tabControl1.Controls.Add(this.doktorListTabPage);
            this.tabControl1.Controls.Add(this.poliklinikTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 146);
            this.tabControl1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaSayisiStatusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // hastaSayisiStatusStripLabel
            // 
            this.hastaSayisiStatusStripLabel.Name = "hastaSayisiStatusStripLabel";
            this.hastaSayisiStatusStripLabel.Size = new System.Drawing.Size(12, 17);
            this.hastaSayisiStatusStripLabel.Text = "-";
            // 
            // poliklinikEkleButton
            // 
            this.poliklinikEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poliklinikEkleButton.Location = new System.Drawing.Point(19, 33);
            this.poliklinikEkleButton.Name = "poliklinikEkleButton";
            this.poliklinikEkleButton.Size = new System.Drawing.Size(127, 61);
            this.poliklinikEkleButton.TabIndex = 0;
            this.poliklinikEkleButton.Text = "Poliklinik Ekle";
            this.poliklinikEkleButton.UseVisualStyleBackColor = true;
            this.poliklinikEkleButton.Click += new System.EventHandler(this.poliklinikEkleButton_Click);
            // 
            // poliklinikSilButton
            // 
            this.poliklinikSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poliklinikSilButton.Location = new System.Drawing.Point(220, 34);
            this.poliklinikSilButton.Name = "poliklinikSilButton";
            this.poliklinikSilButton.Size = new System.Drawing.Size(127, 61);
            this.poliklinikSilButton.TabIndex = 1;
            this.poliklinikSilButton.Text = "Poliklinik Sil";
            this.poliklinikSilButton.UseVisualStyleBackColor = true;
            this.poliklinikSilButton.Click += new System.EventHandler(this.poliklinikSilButton_Click);
            // 
            // poliklinikButton
            // 
            this.poliklinikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poliklinikButton.Location = new System.Drawing.Point(390, 91);
            this.poliklinikButton.Name = "poliklinikButton";
            this.poliklinikButton.Size = new System.Drawing.Size(157, 23);
            this.poliklinikButton.TabIndex = 2;
            this.poliklinikButton.Text = "Hasta Sayısını Göster";
            this.poliklinikButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(390, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bekleyen/Tedavi Olan";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(26, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bekleyen Hasta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(26, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tedavi Olmuş";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // HospitalMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 211);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HospitalMainPage";
            this.Text = "HospitalMainPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HospitalMainPage_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.poliklinikTabPage.ResumeLayout(false);
            this.doktorListTabPage.ResumeLayout(false);
            this.hastaKabulTabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poliklinikEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poliklinikÇıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorDüzenleToolStripMenuItem;
        private System.Windows.Forms.TabPage poliklinikTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button poliklinikButton;
        private System.Windows.Forms.Button poliklinikSilButton;
        private System.Windows.Forms.Button poliklinikEkleButton;
        private System.Windows.Forms.TabPage doktorListTabPage;
        private System.Windows.Forms.Button doktorDuzenleButton;
        private System.Windows.Forms.Button doktorSilButton;
        private System.Windows.Forms.Button doktorEkleButton;
        private System.Windows.Forms.TabPage hastaKabulTabPage;
        private System.Windows.Forms.Button hastaDuzenleButton;
        private System.Windows.Forms.Button hastaSilmeButton;
        private System.Windows.Forms.Button hastaKabulButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel hastaSayisiStatusStripLabel;
    }
}