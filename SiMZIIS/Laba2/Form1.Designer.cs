namespace Laba2
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
            this.OpenTextBox = new System.Windows.Forms.RichTextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.FindKeyButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.DecryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.FindKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenTextBox
            // 
            this.OpenTextBox.Location = new System.Drawing.Point(12, 12);
            this.OpenTextBox.Name = "OpenTextBox";
            this.OpenTextBox.Size = new System.Drawing.Size(214, 179);
            this.OpenTextBox.TabIndex = 0;
            this.OpenTextBox.Text = "Open text";
            this.OpenTextBox.Click += new System.EventHandler(this.Flush);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 222);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(214, 73);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // FindKeyButton
            // 
            this.FindKeyButton.Location = new System.Drawing.Point(445, 301);
            this.FindKeyButton.Name = "FindKeyButton";
            this.FindKeyButton.Size = new System.Drawing.Size(343, 69);
            this.FindKeyButton.TabIndex = 3;
            this.FindKeyButton.Text = "FindKey";
            this.FindKeyButton.UseVisualStyleBackColor = true;
            this.FindKeyButton.Click += new System.EventHandler(this.FindKeyButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(445, 222);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(219, 73);
            this.DecryptButton.TabIndex = 4;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Location = new System.Drawing.Point(300, 12);
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(219, 194);
            this.EncryptedTextBox.TabIndex = 5;
            this.EncryptedTextBox.Text = "Encrypted text";
            // 
            // DecryptedTextBox
            // 
            this.DecryptedTextBox.Location = new System.Drawing.Point(576, 12);
            this.DecryptedTextBox.Name = "DecryptedTextBox";
            this.DecryptedTextBox.Size = new System.Drawing.Size(212, 194);
            this.DecryptedTextBox.TabIndex = 6;
            this.DecryptedTextBox.Text = "Decrypted text";
            // 
            // FindKeyTextBox
            // 
            this.FindKeyTextBox.Location = new System.Drawing.Point(445, 376);
            this.FindKeyTextBox.Name = "FindKeyTextBox";
            this.FindKeyTextBox.Size = new System.Drawing.Size(343, 227);
            this.FindKeyTextBox.TabIndex = 7;
            this.FindKeyTextBox.Text = "Find key array";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(12, 197);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(214, 20);
            this.KeyTextBox.TabIndex = 8;
            this.KeyTextBox.Text = "Input key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 620);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.FindKeyTextBox);
            this.Controls.Add(this.DecryptedTextBox);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.FindKeyButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.OpenTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox KeyTextBox;

        private System.Windows.Forms.RichTextBox EncryptedTextBox;
        private System.Windows.Forms.RichTextBox DecryptedTextBox;
        private System.Windows.Forms.RichTextBox FindKeyTextBox;

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button FindKeyButton;

        private System.Windows.Forms.RichTextBox OpenTextBox;

        #endregion
    }
}