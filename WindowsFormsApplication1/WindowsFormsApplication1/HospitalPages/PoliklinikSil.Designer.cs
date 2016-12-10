namespace WindowsFormsApplication1.HospitalPages
{
    partial class PoliklinikSil
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
            this.poliklinikSilmeIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.silButton = new System.Windows.Forms.Button();
            this.silmeTreeView = new System.Windows.Forms.TreeView();
            this.araButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poliklinikSilmeIDTextBox
            // 
            this.poliklinikSilmeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.poliklinikSilmeIDTextBox.Location = new System.Drawing.Point(198, 15);
            this.poliklinikSilmeIDTextBox.Mask = "00000";
            this.poliklinikSilmeIDTextBox.Name = "poliklinikSilmeIDTextBox";
            this.poliklinikSilmeIDTextBox.Size = new System.Drawing.Size(111, 45);
            this.poliklinikSilmeIDTextBox.TabIndex = 25;
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(326, 15);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(138, 339);
            this.silButton.TabIndex = 24;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = true;
            // 
            // silmeTreeView
            // 
            this.silmeTreeView.Location = new System.Drawing.Point(18, 153);
            this.silmeTreeView.Name = "silmeTreeView";
            this.silmeTreeView.Size = new System.Drawing.Size(291, 201);
            this.silmeTreeView.TabIndex = 23;
            // 
            // araButton
            // 
            this.araButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.Location = new System.Drawing.Point(18, 87);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(291, 60);
            this.araButton.TabIndex = 22;
            this.araButton.Text = "ARA";
            this.araButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(12, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 31);
            this.label12.TabIndex = 21;
            this.label12.Text = "Poliklinik ID:";
            // 
            // PoliklinikSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 380);
            this.Controls.Add(this.poliklinikSilmeIDTextBox);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.silmeTreeView);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.label12);
            this.Name = "PoliklinikSil";
            this.Text = "PoliklinikSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox poliklinikSilmeIDTextBox;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.TreeView silmeTreeView;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Label label12;
    }
}