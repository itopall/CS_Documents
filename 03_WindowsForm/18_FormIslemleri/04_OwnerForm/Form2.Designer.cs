namespace _04_OwnerForm
{
    partial class Form2
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
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOwnerVarMi = new System.Windows.Forms.Label();
            this.btnMesaj = new System.Windows.Forms.Button();
            this.txtGelenMesaj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYukari
            // 
            this.btnYukari.Location = new System.Drawing.Point(276, 104);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(146, 48);
            this.btnYukari.TabIndex = 0;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(276, 158);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(146, 48);
            this.btnAsagi.TabIndex = 0;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(124, 133);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(146, 48);
            this.btnSol.TabIndex = 0;
            this.btnSol.Text = "Sol";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(428, 133);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(146, 48);
            this.btnSag.TabIndex = 0;
            this.btnSag.Text = "Sağ";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sahip Form Var Mı:";
            // 
            // lblOwnerVarMi
            // 
            this.lblOwnerVarMi.AutoSize = true;
            this.lblOwnerVarMi.Location = new System.Drawing.Point(238, 26);
            this.lblOwnerVarMi.Name = "lblOwnerVarMi";
            this.lblOwnerVarMi.Size = new System.Drawing.Size(152, 25);
            this.lblOwnerVarMi.TabIndex = 2;
            this.lblOwnerVarMi.Text = "lblOwnerVarMi";
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(243, 296);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(200, 48);
            this.btnMesaj.TabIndex = 0;
            this.btnMesaj.Text = "Mesajı Göster";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // txtGelenMesaj
            // 
            this.txtGelenMesaj.Location = new System.Drawing.Point(124, 350);
            this.txtGelenMesaj.Name = "txtGelenMesaj";
            this.txtGelenMesaj.Size = new System.Drawing.Size(450, 31);
            this.txtGelenMesaj.TabIndex = 3;
            this.txtGelenMesaj.TextChanged += new System.EventHandler(this.txtGelenMesaj_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 445);
            this.Controls.Add(this.txtGelenMesaj);
            this.Controls.Add(this.lblOwnerVarMi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnMesaj);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukari);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOwnerVarMi;
        private System.Windows.Forms.Button btnMesaj;
        private System.Windows.Forms.TextBox txtGelenMesaj;
    }
}