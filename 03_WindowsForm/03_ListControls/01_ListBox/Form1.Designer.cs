namespace _01_ListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lstKelimeler = new System.Windows.Forms.ListBox();
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.btnSecileniGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(195, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "LİSTBOX ÖRNEĞİ;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kelime Giriniz:";
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(304, 207);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(458, 31);
            this.txtKelime.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(465, 256);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(297, 61);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(466, 323);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(297, 61);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lstKelimeler
            // 
            this.lstKelimeler.FormattingEnabled = true;
            this.lstKelimeler.ItemHeight = 25;
            this.lstKelimeler.Items.AddRange(new object[] {
            "Monitor",
            "Klavye",
            "Laptop",
            "Mouse"});
            this.lstKelimeler.Location = new System.Drawing.Point(304, 407);
            this.lstKelimeler.Name = "lstKelimeler";
            this.lstKelimeler.Size = new System.Drawing.Size(459, 404);
            this.lstKelimeler.TabIndex = 3;
            this.lstKelimeler.SelectedIndexChanged += new System.EventHandler(this.lstKelimeler_SelectedIndexChanged);
            // 
            // btnSecileniSil
            // 
            this.btnSecileniSil.Location = new System.Drawing.Point(467, 900);
            this.btnSecileniSil.Name = "btnSecileniSil";
            this.btnSecileniSil.Size = new System.Drawing.Size(297, 61);
            this.btnSecileniSil.TabIndex = 4;
            this.btnSecileniSil.Text = "Seçileni Sil";
            this.btnSecileniSil.UseVisualStyleBackColor = true;
            this.btnSecileniSil.Click += new System.EventHandler(this.btnSecileniSil_Click);
            // 
            // btnSecileniGoster
            // 
            this.btnSecileniGoster.Location = new System.Drawing.Point(466, 833);
            this.btnSecileniGoster.Name = "btnSecileniGoster";
            this.btnSecileniGoster.Size = new System.Drawing.Size(297, 61);
            this.btnSecileniGoster.TabIndex = 5;
            this.btnSecileniGoster.Text = "Seçileni Göster";
            this.btnSecileniGoster.UseVisualStyleBackColor = true;
            this.btnSecileniGoster.Click += new System.EventHandler(this.btnSecileniGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 1099);
            this.Controls.Add(this.btnSecileniSil);
            this.Controls.Add(this.btnSecileniGoster);
            this.Controls.Add(this.lstKelimeler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ListBox lstKelimeler;
        private System.Windows.Forms.Button btnSecileniSil;
        private System.Windows.Forms.Button btnSecileniGoster;
    }
}

