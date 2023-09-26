namespace verıturler
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
            this.btnHesaplama = new System.Windows.Forms.Button();
            this.txtsayı = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesaplama
            // 
            this.btnHesaplama.Location = new System.Drawing.Point(48, 50);
            this.btnHesaplama.Name = "btnHesaplama";
            this.btnHesaplama.Size = new System.Drawing.Size(75, 23);
            this.btnHesaplama.TabIndex = 0;
            this.btnHesaplama.Text = "Hesaplama";
            this.btnHesaplama.UseVisualStyleBackColor = true;
            this.btnHesaplama.Click += new System.EventHandler(this.btnHesaplama_Click);
            // 
            // txtsayı
            // 
            this.txtsayı.Location = new System.Drawing.Point(175, 53);
            this.txtsayı.Name = "txtsayı";
            this.txtsayı.Size = new System.Drawing.Size(100, 20);
            this.txtsayı.TabIndex = 1;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(340, 56);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(22, 13);
            this.lblsonuc.TabIndex = 2;
            this.lblsonuc.Text = ".....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 183);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtsayı);
            this.Controls.Add(this.btnHesaplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesaplama;
        private System.Windows.Forms.TextBox txtsayı;
        private System.Windows.Forms.Label lblsonuc;
    }
}

