namespace WindowsFormsApplication1.HospitalPages
{
    partial class DoktorSil
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
            this.doktorSilmeIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.silButton = new System.Windows.Forms.Button();
            this.silmeTreeView = new System.Windows.Forms.TreeView();
            this.araButton = new System.Windows.Forms.Button();
            this.doktorSilmeIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doktorSilmeIDTextBox
            // 
            this.doktorSilmeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorSilmeIDTextBox.Location = new System.Drawing.Point(198, 27);
            this.doktorSilmeIDTextBox.Mask = "000000";
            this.doktorSilmeIDTextBox.Name = "doktorSilmeIDTextBox";
            this.doktorSilmeIDTextBox.Size = new System.Drawing.Size(128, 45);
            this.doktorSilmeIDTextBox.TabIndex = 20;
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(332, 27);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(138, 339);
            this.silButton.TabIndex = 19;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = true;
            // 
            // silmeTreeView
            // 
            this.silmeTreeView.Location = new System.Drawing.Point(18, 165);
            this.silmeTreeView.Name = "silmeTreeView";
            this.silmeTreeView.Size = new System.Drawing.Size(308, 201);
            this.silmeTreeView.TabIndex = 18;
            // 
            // araButton
            // 
            this.araButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.Location = new System.Drawing.Point(18, 99);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(308, 60);
            this.araButton.TabIndex = 17;
            this.araButton.Text = "ARA";
            this.araButton.UseVisualStyleBackColor = true;
            // 
            // doktorSilmeIDLabel
            // 
            this.doktorSilmeIDLabel.AutoSize = true;
            this.doktorSilmeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorSilmeIDLabel.Location = new System.Drawing.Point(12, 35);
            this.doktorSilmeIDLabel.Name = "doktorSilmeIDLabel";
            this.doktorSilmeIDLabel.Size = new System.Drawing.Size(138, 31);
            this.doktorSilmeIDLabel.TabIndex = 16;
            this.doktorSilmeIDLabel.Text = "Doktor ID:";
            // 
            // DoktorSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.doktorSilmeIDTextBox);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.silmeTreeView);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.doktorSilmeIDLabel);
            this.Name = "DoktorSil";
            this.Text = "DoktorSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox doktorSilmeIDTextBox;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.TreeView silmeTreeView;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Label doktorSilmeIDLabel;
    }
}