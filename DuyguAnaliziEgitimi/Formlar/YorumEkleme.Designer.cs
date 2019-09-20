namespace DuyguAnaliziEgitimi
{
    partial class YorumEkleme
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
            this.readfile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioOlumlu = new System.Windows.Forms.RadioButton();
            this.radioOlumsuz = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOlumlu = new System.Windows.Forms.Label();
            this.labelOlumsuz = new System.Windows.Forms.Label();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readfile
            // 
            this.readfile.Location = new System.Drawing.Point(531, 173);
            this.readfile.Name = "readfile";
            this.readfile.Size = new System.Drawing.Size(235, 39);
            this.readfile.TabIndex = 0;
            this.readfile.Text = "Yorumu dahil et";
            this.readfile.UseVisualStyleBackColor = true;
            this.readfile.Click += new System.EventHandler(this.readfile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(337, 28);
            this.progressBar1.Maximum = 20000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 172);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // radioOlumlu
            // 
            this.radioOlumlu.AutoSize = true;
            this.radioOlumlu.Checked = true;
            this.radioOlumlu.Location = new System.Drawing.Point(531, 100);
            this.radioOlumlu.Name = "radioOlumlu";
            this.radioOlumlu.Size = new System.Drawing.Size(90, 17);
            this.radioOlumlu.TabIndex = 4;
            this.radioOlumlu.TabStop = true;
            this.radioOlumlu.Text = "Olumlu Yorum";
            this.radioOlumlu.UseVisualStyleBackColor = true;
            // 
            // radioOlumsuz
            // 
            this.radioOlumsuz.AutoSize = true;
            this.radioOlumsuz.Location = new System.Drawing.Point(657, 99);
            this.radioOlumsuz.Name = "radioOlumsuz";
            this.radioOlumsuz.Size = new System.Drawing.Size(98, 17);
            this.radioOlumsuz.TabIndex = 5;
            this.radioOlumsuz.Text = "Olumsuz Yorum";
            this.radioOlumsuz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(101, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Olumlu Yorum Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(101, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Olumsuz Yorum Sayısı :";
            // 
            // labelOlumlu
            // 
            this.labelOlumlu.AutoSize = true;
            this.labelOlumlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOlumlu.ForeColor = System.Drawing.Color.Blue;
            this.labelOlumlu.Location = new System.Drawing.Point(274, 24);
            this.labelOlumlu.Name = "labelOlumlu";
            this.labelOlumlu.Size = new System.Drawing.Size(15, 15);
            this.labelOlumlu.TabIndex = 6;
            this.labelOlumlu.Text = "0";
            // 
            // labelOlumsuz
            // 
            this.labelOlumsuz.AutoSize = true;
            this.labelOlumsuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOlumsuz.ForeColor = System.Drawing.Color.Red;
            this.labelOlumsuz.Location = new System.Drawing.Point(274, 57);
            this.labelOlumsuz.Name = "labelOlumsuz";
            this.labelOlumsuz.Size = new System.Drawing.Size(15, 15);
            this.labelOlumsuz.TabIndex = 6;
            this.labelOlumsuz.Text = "0";
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(5, 11);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(90, 39);
            this.buttonGeri.TabIndex = 8;
            this.buttonGeri.Text = "Geri Dön";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // YorumEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOlumsuz);
            this.Controls.Add(this.labelOlumlu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioOlumsuz);
            this.Controls.Add(this.radioOlumlu);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.readfile);
            this.Name = "YorumEkleme";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readfile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioOlumlu;
        private System.Windows.Forms.RadioButton radioOlumsuz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOlumlu;
        private System.Windows.Forms.Label labelOlumsuz;
        private System.Windows.Forms.Button buttonGeri;
    }
}

