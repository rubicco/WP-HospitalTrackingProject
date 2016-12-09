namespace WindowsFormsApplication1.DoctorPages
{
    partial class DoctorMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMainPage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bransGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iletisimGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kimlikGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.bransGroupBox.SuspendLayout();
            this.iletisimGroupBox.SuspendLayout();
            this.kimlikGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.bransGroupBox);
            this.tabPage1.Controls.Add(this.iletisimGroupBox);
            this.tabPage1.Controls.Add(this.kimlikGroupBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doktor Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.editToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(696, 58);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bransGroupBox
            // 
            this.bransGroupBox.Controls.Add(this.label10);
            this.bransGroupBox.Controls.Add(this.label9);
            this.bransGroupBox.Controls.Add(this.label8);
            this.bransGroupBox.Location = new System.Drawing.Point(23, 420);
            this.bransGroupBox.Name = "bransGroupBox";
            this.bransGroupBox.Size = new System.Drawing.Size(395, 133);
            this.bransGroupBox.TabIndex = 9;
            this.bransGroupBox.TabStop = false;
            this.bransGroupBox.Text = "Branş Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ünvan:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Poliklinik:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Branş:";
            // 
            // iletisimGroupBox
            // 
            this.iletisimGroupBox.Controls.Add(this.label4);
            this.iletisimGroupBox.Controls.Add(this.label6);
            this.iletisimGroupBox.Controls.Add(this.label7);
            this.iletisimGroupBox.Location = new System.Drawing.Point(23, 217);
            this.iletisimGroupBox.Name = "iletisimGroupBox";
            this.iletisimGroupBox.Size = new System.Drawing.Size(395, 187);
            this.iletisimGroupBox.TabIndex = 8;
            this.iletisimGroupBox.TabStop = false;
            this.iletisimGroupBox.Text = "İletişim Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cep Telefonu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "İş Telefonu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            // 
            // kimlikGroupBox
            // 
            this.kimlikGroupBox.Controls.Add(this.label1);
            this.kimlikGroupBox.Controls.Add(this.label2);
            this.kimlikGroupBox.Controls.Add(this.label3);
            this.kimlikGroupBox.Location = new System.Drawing.Point(18, 77);
            this.kimlikGroupBox.Name = "kimlikGroupBox";
            this.kimlikGroupBox.Size = new System.Drawing.Size(400, 116);
            this.kimlikGroupBox.TabIndex = 7;
            this.kimlikGroupBox.TabStop = false;
            this.kimlikGroupBox.Text = "Kimlik Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.AutoSize = false;
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = global::WindowsFormsApplication1.Properties.Resources.edit;
            this.editToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(53, 53);
            this.editToolStripButton.Text = "editToolStripButton";
            // 
            // DoctorMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 621);
            this.Controls.Add(this.tabControl1);
            this.Name = "DoctorMainPage";
            this.Text = "Doktor Anasayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorMainPage_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.bransGroupBox.ResumeLayout(false);
            this.bransGroupBox.PerformLayout();
            this.iletisimGroupBox.ResumeLayout(false);
            this.iletisimGroupBox.PerformLayout();
            this.kimlikGroupBox.ResumeLayout(false);
            this.kimlikGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox kimlikGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox bransGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox iletisimGroupBox;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
    }
}