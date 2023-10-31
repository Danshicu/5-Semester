namespace Laba4
{
    partial class Form1
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
            this.PrimitiveElementBox = new System.Windows.Forms.TextBox();
            this.MainNumberBox = new System.Windows.Forms.TextBox();
            this.SecretBox = new System.Windows.Forms.TextBox();
            this.GeneratePrimitiveButton = new System.Windows.Forms.Button();
            this.GenerateSecretButton = new System.Windows.Forms.Button();
            this.SecondKeyBox = new System.Windows.Forms.TextBox();
            this.FirstKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrimitiveElementBox
            // 
            this.PrimitiveElementBox.Location = new System.Drawing.Point(231, 31);
            this.PrimitiveElementBox.Name = "PrimitiveElementBox";
            this.PrimitiveElementBox.Size = new System.Drawing.Size(179, 20);
            this.PrimitiveElementBox.TabIndex = 0;
            this.PrimitiveElementBox.Text = "Primitive";
            // 
            // MainNumberBox
            // 
            this.MainNumberBox.Location = new System.Drawing.Point(12, 31);
            this.MainNumberBox.Name = "MainNumberBox";
            this.MainNumberBox.Size = new System.Drawing.Size(179, 20);
            this.MainNumberBox.TabIndex = 1;
            this.MainNumberBox.Text = "P";
            // 
            // SecretBox
            // 
            this.SecretBox.Location = new System.Drawing.Point(479, 82);
            this.SecretBox.Name = "SecretBox";
            this.SecretBox.Size = new System.Drawing.Size(233, 20);
            this.SecretBox.TabIndex = 2;
            this.SecretBox.Text = "Secret";
            // 
            // GeneratePrimitiveButton
            // 
            this.GeneratePrimitiveButton.Location = new System.Drawing.Point(12, 79);
            this.GeneratePrimitiveButton.Name = "GeneratePrimitiveButton";
            this.GeneratePrimitiveButton.Size = new System.Drawing.Size(179, 23);
            this.GeneratePrimitiveButton.TabIndex = 3;
            this.GeneratePrimitiveButton.Text = "Generate primitive";
            this.GeneratePrimitiveButton.UseMnemonic = false;
            this.GeneratePrimitiveButton.UseVisualStyleBackColor = true;
            this.GeneratePrimitiveButton.Click += new System.EventHandler(this.GeneratePrimitiveButton_Click);
            // 
            // GenerateSecretButton
            // 
            this.GenerateSecretButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateSecretButton.Location = new System.Drawing.Point(231, 79);
            this.GenerateSecretButton.Name = "GenerateSecretButton";
            this.GenerateSecretButton.Size = new System.Drawing.Size(179, 23);
            this.GenerateSecretButton.TabIndex = 4;
            this.GenerateSecretButton.Text = "GenerateSecret";
            this.GenerateSecretButton.UseVisualStyleBackColor = true;
            this.GenerateSecretButton.Click += new System.EventHandler(this.GenerateSecretButton_Click);
            // 
            // SecondKeyBox
            // 
            this.SecondKeyBox.Location = new System.Drawing.Point(612, 31);
            this.SecondKeyBox.Name = "SecondKeyBox";
            this.SecondKeyBox.Size = new System.Drawing.Size(100, 20);
            this.SecondKeyBox.TabIndex = 6;
            this.SecondKeyBox.Text = "Second key";
            // 
            // FirstKeyBox
            // 
            this.FirstKeyBox.Location = new System.Drawing.Point(479, 31);
            this.FirstKeyBox.Name = "FirstKeyBox";
            this.FirstKeyBox.Size = new System.Drawing.Size(100, 20);
            this.FirstKeyBox.TabIndex = 7;
            this.FirstKeyBox.Text = "First key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FirstKeyBox);
            this.Controls.Add(this.SecondKeyBox);
            this.Controls.Add(this.GenerateSecretButton);
            this.Controls.Add(this.GeneratePrimitiveButton);
            this.Controls.Add(this.SecretBox);
            this.Controls.Add(this.MainNumberBox);
            this.Controls.Add(this.PrimitiveElementBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button GeneratePrimitiveButton;
        private System.Windows.Forms.Button GenerateSecretButton;
        private System.Windows.Forms.TextBox SecondKeyBox;
        private System.Windows.Forms.TextBox FirstKeyBox;

        private System.Windows.Forms.TextBox PrimitiveElementBox;
        private System.Windows.Forms.TextBox MainNumberBox;
        private System.Windows.Forms.TextBox SecretBox;

        #endregion
    }
}