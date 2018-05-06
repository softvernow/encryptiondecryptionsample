namespace encryptionsample
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTextToBeEncrypted = new System.Windows.Forms.RichTextBox();
            this.btnDecryptText = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncryptedtext = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncryptText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 31);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTextToBeEncrypted
            // 
            this.txtTextToBeEncrypted.Location = new System.Drawing.Point(132, 9);
            this.txtTextToBeEncrypted.Name = "txtTextToBeEncrypted";
            this.txtTextToBeEncrypted.Size = new System.Drawing.Size(460, 139);
            this.txtTextToBeEncrypted.TabIndex = 16;
            this.txtTextToBeEncrypted.Text = "";
            // 
            // btnDecryptText
            // 
            this.btnDecryptText.Location = new System.Drawing.Point(171, 343);
            this.btnDecryptText.Name = "btnDecryptText";
            this.btnDecryptText.Size = new System.Drawing.Size(126, 31);
            this.btnDecryptText.TabIndex = 15;
            this.btnDecryptText.Text = "Start Decryption";
            this.btnDecryptText.UseVisualStyleBackColor = true;
            this.btnDecryptText.Click += new System.EventHandler(this.btnDecryptText_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(466, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 31);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Encrypted Text:";
            // 
            // txtEncryptedtext
            // 
            this.txtEncryptedtext.Location = new System.Drawing.Point(132, 167);
            this.txtEncryptedtext.Name = "txtEncryptedtext";
            this.txtEncryptedtext.Size = new System.Drawing.Size(460, 152);
            this.txtEncryptedtext.TabIndex = 12;
            this.txtEncryptedtext.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Text To Be Encrypted:";
            // 
            // btnEncryptText
            // 
            this.btnEncryptText.Location = new System.Drawing.Point(15, 343);
            this.btnEncryptText.Name = "btnEncryptText";
            this.btnEncryptText.Size = new System.Drawing.Size(126, 31);
            this.btnEncryptText.TabIndex = 10;
            this.btnEncryptText.Text = "Start Encryption";
            this.btnEncryptText.UseVisualStyleBackColor = true;
            this.btnEncryptText.Click += new System.EventHandler(this.btnEncryptText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 393);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTextToBeEncrypted);
            this.Controls.Add(this.btnDecryptText);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEncryptedtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncryptText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox txtTextToBeEncrypted;
        private System.Windows.Forms.Button btnDecryptText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtEncryptedtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncryptText;
    }
}

