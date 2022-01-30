namespace _01_Tag
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
            this.btnRenkAyarla = new System.Windows.Forms.Button();
            this.btnMesajVer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRenkAyarla
            // 
            this.btnRenkAyarla.Location = new System.Drawing.Point(512, 391);
            this.btnRenkAyarla.Name = "btnRenkAyarla";
            this.btnRenkAyarla.Size = new System.Drawing.Size(378, 101);
            this.btnRenkAyarla.TabIndex = 0;
            this.btnRenkAyarla.Text = "Renk Ayarla";
            this.btnRenkAyarla.UseVisualStyleBackColor = true;
            this.btnRenkAyarla.Click += new System.EventHandler(this.btnRenkAyarla_Click);
            // 
            // btnMesajVer
            // 
            this.btnMesajVer.Location = new System.Drawing.Point(512, 511);
            this.btnMesajVer.Name = "btnMesajVer";
            this.btnMesajVer.Size = new System.Drawing.Size(378, 101);
            this.btnMesajVer.TabIndex = 0;
            this.btnMesajVer.Text = "Mesaj Ver";
            this.btnMesajVer.UseVisualStyleBackColor = true;
            this.btnMesajVer.Click += new System.EventHandler(this.btnMesajVer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 31);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 1095);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMesajVer);
            this.Controls.Add(this.btnRenkAyarla);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenkAyarla;
        private System.Windows.Forms.Button btnMesajVer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

