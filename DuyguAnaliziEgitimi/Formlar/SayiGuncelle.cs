using proje1.BusinessLayer;
using proje1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuyguAnaliziEgitimi.Formlar
{
    public partial class SayiGuncelle : Form
    {
        public YorumSayYonetici ysy = new YorumSayYonetici();
        public YorumSay yorumsay = new YorumSay();
        public SayiGuncelle()
        {
            InitializeComponent();
            yorumsay = ysy.Find(x => x.Id == 1);
            labelOlumlu.Text = yorumsay.olumluSayisi.ToString();
            labelOlumsuz.Text = yorumsay.olumsuzSayisi.ToString();
            textBoxOlumlu.Text = yorumsay.olumluSayisi.ToString();
            textBoxOlumsuz.Text = yorumsay.olumsuzSayisi.ToString();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa aa = new Anasayfa();
            aa.Closed += (s, args) => this.Close();
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxOlumlu.Text != "" && textBoxOlumsuz.Text != "")
            {
                yorumsay.Id = 1;
                yorumsay.olumluSayisi = Convert.ToInt64(textBoxOlumlu.Text);
                yorumsay.olumsuzSayisi = Convert.ToInt64(textBoxOlumsuz.Text);
                ysy.Update(yorumsay);
            }
        }
    }
}
