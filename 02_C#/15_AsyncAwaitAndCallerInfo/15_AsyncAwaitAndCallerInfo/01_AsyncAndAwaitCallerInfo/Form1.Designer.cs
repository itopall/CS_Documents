namespace _01_AsyncAndAwaitCallerInfo
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
            this.btnStartCall = new System.Windows.Forms.Button();
            this.btnCallerInfo = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartCall
            // 
            this.btnStartCall.Location = new System.Drawing.Point(322, 50);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(196, 59);
            this.btnStartCall.TabIndex = 0;
            this.btnStartCall.Text = "Çağrıyı Başlat";
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
            // 
            // btnCallerInfo
            // 
            this.btnCallerInfo.Location = new System.Drawing.Point(346, 354);
            this.btnCallerInfo.Name = "btnCallerInfo";
            this.btnCallerInfo.Size = new System.Drawing.Size(172, 56);
            this.btnCallerInfo.TabIndex = 0;
            this.btnCallerInfo.Text = "Caller Info";
            this.btnCallerInfo.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(122, 134);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(635, 201);
            this.txtMessage.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnCallerInfo);
            this.Controls.Add(this.btnStartCall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartCall;
        private System.Windows.Forms.Button btnCallerInfo;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

