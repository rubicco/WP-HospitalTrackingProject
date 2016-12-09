namespace WindowsFormsApplication1
{
    partial class MainPage
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
            System.Windows.Forms.Label label1;
            this.hastaneButton = new System.Windows.Forms.Button();
            this.doktorButton = new System.Windows.Forms.Button();
            this.hastaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label1.Location = new System.Drawing.Point(28, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(278, 73);
            label1.TabIndex = 9;
            label1.Text = "Hastane Takip Sistemine\r\nHoşgeldiniz!";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hastaneButton
            // 
            this.hastaneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hastaneButton.FlatAppearance.BorderSize = 3;
            this.hastaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaneButton.Location = new System.Drawing.Point(186, 85);
            this.hastaneButton.Name = "hastaneButton";
            this.hastaneButton.Size = new System.Drawing.Size(120, 120);
            this.hastaneButton.TabIndex = 0;
            this.hastaneButton.Text = "Hastane Girişi";
            this.hastaneButton.UseVisualStyleBackColor = true;
            this.hastaneButton.Click += new System.EventHandler(this.hastaneButton_Click);
            // 
            // doktorButton
            // 
            this.doktorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doktorButton.FlatAppearance.BorderSize = 3;
            this.doktorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorButton.Location = new System.Drawing.Point(186, 221);
            this.doktorButton.Name = "doktorButton";
            this.doktorButton.Size = new System.Drawing.Size(120, 120);
            this.doktorButton.TabIndex = 4;
            this.doktorButton.Text = "Doktor Girişi";
            this.doktorButton.UseVisualStyleBackColor = true;
            this.doktorButton.Click += new System.EventHandler(this.doktorButton_Click);
            // 
            // hastaButton
            // 
            this.hastaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hastaButton.FlatAppearance.BorderSize = 3;
            this.hastaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaButton.Location = new System.Drawing.Point(186, 363);
            this.hastaButton.Name = "hastaButton";
            this.hastaButton.Size = new System.Drawing.Size(120, 120);
            this.hastaButton.TabIndex = 5;
            this.hastaButton.Text = "Hasta Girişi";
            this.hastaButton.UseVisualStyleBackColor = true;
            this.hastaButton.Click += new System.EventHandler(this.hastaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.H_icon;
            this.pictureBox1.Location = new System.Drawing.Point(26, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.S_icon;
            this.pictureBox3.Location = new System.Drawing.Point(26, 363);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.D_icon;
            this.pictureBox2.Location = new System.Drawing.Point(26, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 510);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hastaButton);
            this.Controls.Add(this.doktorButton);
            this.Controls.Add(this.hastaneButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Takip Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hastaneButton;
        private System.Windows.Forms.Button doktorButton;
        private System.Windows.Forms.Button hastaButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

