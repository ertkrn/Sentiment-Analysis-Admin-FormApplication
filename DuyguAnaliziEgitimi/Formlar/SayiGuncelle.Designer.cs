namespace DuyguAnaliziEgitimi.Formlar
{
    partial class SayiGuncelle
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
            this.labelOlumlu = new System.Windows.Forms.Label();
            this.labelOlumsuz = new System.Windows.Forms.Label();
            this.textBoxOlumlu = new System.Windows.Forms.TextBox();
            this.textBoxOlumsuz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(122, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olumlu Yorum Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(509, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Olumsuz Yorum Sayısı";
            // 
            // labelOlumlu
            // 
            this.labelOlumlu.AutoSize = true;
            this.labelOlumlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOlumlu.ForeColor = System.Drawing.Color.Blue;
            this.labelOlumlu.Location = new System.Drawing.Point(180, 107);
            this.labelOlumlu.Name = "labelOlumlu";
            this.labelOlumlu.Size = new System.Drawing.Size(25, 26);
            this.labelOlumlu.TabIndex = 0;
            this.labelOlumlu.Text = "0";
            // 
            // labelOlumsuz
            // 
            this.labelOlumsuz.AutoSize = true;
            this.labelOlumsuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOlumsuz.ForeColor = System.Drawing.Color.Red;
            this.labelOlumsuz.Location = new System.Drawing.Point(593, 107);
            this.labelOlumsuz.Name = "labelOlumsuz";
            this.labelOlumsuz.Size = new System.Drawing.Size(25, 26);
            this.labelOlumsuz.TabIndex = 0;
            this.labelOlumsuz.Text = "0";
            // 
            // textBoxOlumlu
            // 
            this.textBoxOlumlu.Location = new System.Drawing.Point(143, 169);
            this.textBoxOlumlu.Name = "textBoxOlumlu";
            this.textBoxOlumlu.Size = new System.Drawing.Size(100, 20);
            this.textBoxOlumlu.TabIndex = 1;
            // 
            // textBoxOlumsuz
            // 
            this.textBoxOlumsuz.Location = new System.Drawing.Point(557, 169);
            this.textBoxOlumsuz.Name = "textBoxOlumsuz";
            this.textBoxOlumsuz.Size = new System.Drawing.Size(100, 20);
            this.textBoxOlumsuz.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(345, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(12, 12);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(90, 39);
            this.buttonGeri.TabIndex = 3;
            this.buttonGeri.Text = "Geri Dön";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // SayiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOlumsuz);
            this.Controls.Add(this.textBoxOlumlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOlumsuz);
            this.Controls.Add(this.labelOlumlu);
            this.Controls.Add(this.label1);
            this.Name = "SayiGuncelle";
            this.Text = "SayiGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOlumlu;
        private System.Windows.Forms.Label labelOlumsuz;
        private System.Windows.Forms.TextBox textBoxOlumlu;
        private System.Windows.Forms.TextBox textBoxOlumsuz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGeri;
    }
}