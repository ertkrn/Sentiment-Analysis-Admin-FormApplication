namespace DuyguAnaliziEgitimi.Formlar
{
    partial class Anasayfa
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
            this.buttonYorumEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonYorumEkle
            // 
            this.buttonYorumEkle.Location = new System.Drawing.Point(88, 79);
            this.buttonYorumEkle.Name = "buttonYorumEkle";
            this.buttonYorumEkle.Size = new System.Drawing.Size(117, 115);
            this.buttonYorumEkle.TabIndex = 0;
            this.buttonYorumEkle.Text = "Yorum Ekle";
            this.buttonYorumEkle.UseVisualStyleBackColor = true;
            this.buttonYorumEkle.Click += new System.EventHandler(this.buttonYorumEkle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 115);
            this.button2.TabIndex = 0;
            this.button2.Text = "Olumlu ve Olumsuz Yorum Sayılarını Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 115);
            this.button3.TabIndex = 0;
            this.button3.Text = "CSV dosyasını düzene sok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonYorumEkle);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonYorumEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}