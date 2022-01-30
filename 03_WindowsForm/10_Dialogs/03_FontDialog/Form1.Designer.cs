namespace _03_FontDialog
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFontDuzenle = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFontDuzenle
            // 
            this.btnFontDuzenle.Location = new System.Drawing.Point(41, 32);
            this.btnFontDuzenle.Name = "btnFontDuzenle";
            this.btnFontDuzenle.Size = new System.Drawing.Size(198, 52);
            this.btnFontDuzenle.TabIndex = 0;
            this.btnFontDuzenle.Text = "Font Düzenle";
            this.btnFontDuzenle.UseVisualStyleBackColor = true;
            this.btnFontDuzenle.Click += new System.EventHandler(this.btnFontDuzenle_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(41, 110);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(719, 363);
            this.txtWord.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 538);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnFontDuzenle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFontDuzenle;
        private System.Windows.Forms.TextBox txtWord;
    }
}

