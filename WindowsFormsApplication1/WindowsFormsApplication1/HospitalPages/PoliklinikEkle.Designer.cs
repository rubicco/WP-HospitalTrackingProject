namespace WindowsFormsApplication1.HospitalPages
{
    partial class PoliklinikEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.poliklinikAdiTextBox = new System.Windows.Forms.TextBox();
            this.poliklinikBolumuTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.poliklinikIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölümü:";
            // 
            // poliklinikAdiTextBox
            // 
            this.poliklinikAdiTextBox.Location = new System.Drawing.Point(93, 45);
            this.poliklinikAdiTextBox.Name = "poliklinikAdiTextBox";
            this.poliklinikAdiTextBox.Size = new System.Drawing.Size(142, 20);
            this.poliklinikAdiTextBox.TabIndex = 2;
            // 
            // poliklinikBolumuTextBox
            // 
            this.poliklinikBolumuTextBox.Location = new System.Drawing.Point(93, 85);
            this.poliklinikBolumuTextBox.Name = "poliklinikBolumuTextBox";
            this.poliklinikBolumuTextBox.Size = new System.Drawing.Size(142, 20);
            this.poliklinikBolumuTextBox.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(353, 56);
            this.toolStrip1.TabIndex = 8;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.poliklinikIDTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.poliklinikAdiTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.poliklinikBolumuTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 121);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(92, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Poliklinik Ekleme";
            // 
            // poliklinikIDTextBox
            // 
            this.poliklinikIDTextBox.Location = new System.Drawing.Point(93, 6);
            this.poliklinikIDTextBox.Name = "poliklinikIDTextBox";
            this.poliklinikIDTextBox.Size = new System.Drawing.Size(142, 20);
            this.poliklinikIDTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Poliklinik ID:";
            // 
            // PoliklinikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PoliklinikEkle";
            this.Text = "PoliklinikEkle";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poliklinikAdiTextBox;
        private System.Windows.Forms.TextBox poliklinikBolumuTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poliklinikIDTextBox;
        private System.Windows.Forms.Label label4;
    }
}