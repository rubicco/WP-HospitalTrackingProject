namespace WindowsFormsApplication1.HospitalPages
{
    partial class PoliklinikBilgileri
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
            this.hastaneTreeView = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.poliklinikSayisiLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.doktorSayisiLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.hastaSayisiLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hastaneTreeView
            // 
            this.hastaneTreeView.Location = new System.Drawing.Point(29, 26);
            this.hastaneTreeView.Name = "hastaneTreeView";
            this.hastaneTreeView.Size = new System.Drawing.Size(390, 305);
            this.hastaneTreeView.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliklinikSayisiLabel,
            this.doktorSayisiLabel,
            this.hastaSayisiLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(446, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // poliklinikSayisiLabel
            // 
            this.poliklinikSayisiLabel.Name = "poliklinikSayisiLabel";
            this.poliklinikSayisiLabel.Size = new System.Drawing.Size(12, 17);
            this.poliklinikSayisiLabel.Text = "-";
            // 
            // doktorSayisiLabel
            // 
            this.doktorSayisiLabel.Name = "doktorSayisiLabel";
            this.doktorSayisiLabel.Size = new System.Drawing.Size(12, 17);
            this.doktorSayisiLabel.Text = "-";
            // 
            // hastaSayisiLabel
            // 
            this.hastaSayisiLabel.Name = "hastaSayisiLabel";
            this.hastaSayisiLabel.Size = new System.Drawing.Size(12, 17);
            this.hastaSayisiLabel.Text = "-";
            // 
            // PoliklinikBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 377);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hastaneTreeView);
            this.Name = "PoliklinikBilgileri";
            this.Text = "Hastane Bilgileri";
            this.Load += new System.EventHandler(this.PoliklinikBilgileri_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView hastaneTreeView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel poliklinikSayisiLabel;
        private System.Windows.Forms.ToolStripStatusLabel doktorSayisiLabel;
        private System.Windows.Forms.ToolStripStatusLabel hastaSayisiLabel;
    }
}