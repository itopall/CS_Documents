namespace _03_VisualInheritance
{
    partial class Urun
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
            this.btnArttir = new System.Windows.Forms.Button();
            this.btnEksilt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArttir
            // 
            this.btnArttir.Location = new System.Drawing.Point(450, 222);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(154, 46);
            this.btnArttir.TabIndex = 4;
            this.btnArttir.Text = "+";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.btnArttir_Click);
            // 
            // btnEksilt
            // 
            this.btnEksilt.Location = new System.Drawing.Point(450, 285);
            this.btnEksilt.Name = "btnEksilt";
            this.btnEksilt.Size = new System.Drawing.Size(154, 46);
            this.btnEksilt.TabIndex = 4;
            this.btnEksilt.Text = "-";
            this.btnEksilt.UseVisualStyleBackColor = true;
            this.btnEksilt.Click += new System.EventHandler(this.btnEksilt_Click);
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 511);
            this.Controls.Add(this.btnEksilt);
            this.Controls.Add(this.btnArttir);
            this.Name = "Urun";
            this.Text = "Urun";
            this.Load += new System.EventHandler(this.Urun_Load);
            this.Controls.SetChildIndex(this.btnArttir, 0);
            this.Controls.SetChildIndex(this.btnEksilt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArttir;
        private System.Windows.Forms.Button btnEksilt;
    }
}