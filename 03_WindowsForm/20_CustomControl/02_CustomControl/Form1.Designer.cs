namespace _02_CustomControl
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
            this.bigCharTextbox1 = new _01_MyCustomControls.BigCharTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorButton1 = new _01_MyCustomControls.ColorButton();
            this.SuspendLayout();
            // 
            // bigCharTextbox1
            // 
            this.bigCharTextbox1.CharStyle = _01_MyCustomControls.BigCharTextbox.CharType.Upper;
            this.bigCharTextbox1.Location = new System.Drawing.Point(196, 92);
            this.bigCharTextbox1.Name = "bigCharTextbox1";
            this.bigCharTextbox1.Size = new System.Drawing.Size(230, 31);
            this.bigCharTextbox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim:";
            // 
            // colorButton1
            // 
            this.colorButton1.Location = new System.Drawing.Point(257, 139);
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Renk = System.Drawing.Color.Lime;
            this.colorButton1.Size = new System.Drawing.Size(169, 41);
            this.colorButton1.TabIndex = 2;
            this.colorButton1.Text = "colorButton1";
            this.colorButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 428);
            this.Controls.Add(this.colorButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigCharTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _01_MyCustomControls.BigCharTextbox bigCharTextbox1;
        private System.Windows.Forms.Label label1;
        private _01_MyCustomControls.ColorButton colorButton1;
    }
}

