namespace Laba3
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
            this.CipherModeBox = new System.Windows.Forms.ComboBox();
            this.InputPictureBox = new System.Windows.Forms.PictureBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.DecryptedPictureBox = new System.Windows.Forms.PictureBox();
            this.EncryptedPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CipherModeBox
            // 
            this.CipherModeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CipherModeBox.FormattingEnabled = true;
            this.CipherModeBox.Location = new System.Drawing.Point(850, 22);
            this.CipherModeBox.Name = "CipherModeBox";
            this.CipherModeBox.Size = new System.Drawing.Size(180, 21);
            this.CipherModeBox.TabIndex = 0;
            this.CipherModeBox.Text = "Cipher mode";
            // 
            // InputPictureBox
            // 
            this.InputPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InputPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InputPictureBox.Location = new System.Drawing.Point(35, 84);
            this.InputPictureBox.Name = "InputPictureBox";
            this.InputPictureBox.Size = new System.Drawing.Size(480, 480);
            this.InputPictureBox.TabIndex = 1;
            this.InputPictureBox.TabStop = false;
            this.InputPictureBox.WaitOnLoad = true;
            this.InputPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputPictureBox_DragDrop);
            this.InputPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputPictureBox_DragEnter);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(35, 600);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(480, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(700, 600);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(480, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // DecryptedPictureBox
            // 
            this.DecryptedPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DecryptedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DecryptedPictureBox.Location = new System.Drawing.Point(1340, 84);
            this.DecryptedPictureBox.Name = "DecryptedPictureBox";
            this.DecryptedPictureBox.Size = new System.Drawing.Size(480, 480);
            this.DecryptedPictureBox.TabIndex = 4;
            this.DecryptedPictureBox.TabStop = false;
            // 
            // EncryptedPictureBox
            // 
            this.EncryptedPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EncryptedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EncryptedPictureBox.Location = new System.Drawing.Point(700, 84);
            this.EncryptedPictureBox.Name = "EncryptedPictureBox";
            this.EncryptedPictureBox.Size = new System.Drawing.Size(480, 480);
            this.EncryptedPictureBox.TabIndex = 5;
            this.EncryptedPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 639);
            this.Controls.Add(this.EncryptedPictureBox);
            this.Controls.Add(this.DecryptedPictureBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.InputPictureBox);
            this.Controls.Add(this.CipherModeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptedPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox InputPictureBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.PictureBox DecryptedPictureBox;
        private System.Windows.Forms.PictureBox EncryptedPictureBox;

        private System.Windows.Forms.ComboBox CipherModeBox;

        #endregion
    }
}