namespace _02_Combobox
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
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.btnSecileniGoster = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKelimeler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSecileniSil
            // 
            this.btnSecileniSil.Location = new System.Drawing.Point(407, 589);
            this.btnSecileniSil.Name = "btnSecileniSil";
            this.btnSecileniSil.Size = new System.Drawing.Size(297, 61);
            this.btnSecileniSil.TabIndex = 12;
            this.btnSecileniSil.Text = "Seçileni Sil";
            this.btnSecileniSil.UseVisualStyleBackColor = true;
            this.btnSecileniSil.Click += new System.EventHandler(this.btnSecileniSil_Click);
            // 
            // btnSecileniGoster
            // 
            this.btnSecileniGoster.Location = new System.Drawing.Point(406, 522);
            this.btnSecileniGoster.Name = "btnSecileniGoster";
            this.btnSecileniGoster.Size = new System.Drawing.Size(297, 61);
            this.btnSecileniGoster.TabIndex = 13;
            this.btnSecileniGoster.Text = "Seçileni Göster";
            this.btnSecileniGoster.UseVisualStyleBackColor = true;
            this.btnSecileniGoster.Click += new System.EventHandler(this.btnSecileniGoster_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(405, 366);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(297, 61);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(404, 299);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(297, 61);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(243, 250);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(458, 31);
            this.txtKelime.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kelime Giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "COMBOBOX ÖRNEĞİ;";
            // 
            // cmbKelimeler
            // 
            this.cmbKelimeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKelimeler.FormattingEnabled = true;
            this.cmbKelimeler.Items.AddRange(new object[] {
            "Klavye",
            "Mouse",
            "Laptop",
            "Monitör"});
            this.cmbKelimeler.Location = new System.Drawing.Point(243, 453);
            this.cmbKelimeler.Name = "cmbKelimeler";
            this.cmbKelimeler.Size = new System.Drawing.Size(460, 33);
            this.cmbKelimeler.TabIndex = 14;
            this.cmbKelimeler.SelectedIndexChanged += new System.EventHandler(this.cmbKelimeler_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 807);
            this.Controls.Add(this.cmbKelimeler);
            this.Controls.Add(this.btnSecileniSil);
            this.Controls.Add(this.btnSecileniGoster);
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

        private System.Windows.Forms.Button btnSecileniSil;
        private System.Windows.Forms.Button btnSecileniGoster;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKelimeler;
    }
}

