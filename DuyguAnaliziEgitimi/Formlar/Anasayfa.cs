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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void buttonYorumEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            YorumEkleme ye = new YorumEkleme();
            ye.Closed += (s, args) => this.Close();
            ye.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SayiGuncelle sg = new SayiGuncelle();
            sg.Closed += (s, args) => this.Close();
            sg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcelDuzenleme ed = new ExcelDuzenleme();
            ed.Closed += (s, args) => this.Close();
            ed.Show();
        }
    }
}
