namespace WindowsFormsApplication1.HospitalPages
{
    partial class HastaSilme
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
            this.TCKimlikNoHastaSilmeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.silButton = new System.Windows.Forms.Button();
            this.silmeTreeView = new System.Windows.Forms.TreeView();
            this.araButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TCKimlikNoHastaSilmeTextBox
            // 
            this.TCKimlikNoHastaSilmeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCKimlikNoHastaSilmeTextBox.Location = new System.Drawing.Point(210, 18);
            this.TCKimlikNoHastaSilmeTextBox.Mask = "00000000000";
            this.TCKimlikNoHastaSilmeTextBox.Name = "TCKimlikNoHastaSilmeTextBox";
            this.TCKimlikNoHastaSilmeTextBox.Size = new System.Drawing.Size(212, 45);
            this.TCKimlikNoHastaSilmeTextBox.TabIndex = 15;
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(441, 22);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(138, 335);
            this.silButton.TabIndex = 14;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = true;
            // 
            // silmeTreeView
            // 
            this.silmeTreeView.Location = new System.Drawing.Point(30, 156);
            this.silmeTreeView.Name = "silmeTreeView";
            this.silmeTreeView.Size = new System.Drawing.Size(392, 201);
            this.silmeTreeView.TabIndex = 13;
            // 
            // araButton
            // 
            this.araButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.Location = new System.Drawing.Point(30, 90);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(392, 60);
            this.araButton.TabIndex = 12;
            this.araButton.Text = "ARA";
            this.araButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(24, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 31);
            this.label12.TabIndex = 11;
            this.label12.Text = "TC Kimlik No:";
            // 
            // HastaSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 387);
            this.Controls.Add(this.TCKimlikNoHastaSilmeTextBox);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.silmeTreeView);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.label12);
            this.Name = "HastaSilme";
            this.Text = "HastaSilme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TCKimlikNoHastaSilmeTextBox;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.TreeView silmeTreeView;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Label label12;
    }
}