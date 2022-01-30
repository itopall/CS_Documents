namespace _02_UserControl
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
            this.harfButton1 = new _01_MyUserControl.HarfButton();
            this.myCombobox1 = new _01_MyUserControl.MyCombobox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // harfButton1
            // 
            this.harfButton1.Location = new System.Drawing.Point(40, 45);
            this.harfButton1.Name = "harfButton1";
            this.harfButton1.Size = new System.Drawing.Size(558, 71);
            this.harfButton1.TabIndex = 0;
            // 
            // myCombobox1
            // 
            this.myCombobox1.Location = new System.Drawing.Point(40, 208);
            this.myCombobox1.Name = "myCombobox1";
            this.myCombobox1.SetLabelText = "Statuler";
            this.myCombobox1.Size = new System.Drawing.Size(448, 41);
            this.myCombobox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "SelectedText\'i Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myCombobox1);
            this.Controls.Add(this.harfButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private _01_MyUserControl.HarfButton harfButton1;
        private _01_MyUserControl.MyCombobox myCombobox1;
        private System.Windows.Forms.Button button1;
    }
}

