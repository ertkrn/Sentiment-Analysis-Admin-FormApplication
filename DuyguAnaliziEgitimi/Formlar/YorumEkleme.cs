using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using proje1.BusinessLayer;
using proje1.Entities;
using System.Text.RegularExpressions;
using DuyguAnaliziEgitimi.Formlar;

namespace DuyguAnaliziEgitimi
{
    public partial class YorumEkleme : Form
    {
        public YorumlarYonetici yy = new YorumlarYonetici();
        public YorumSayYonetici ysy = new YorumSayYonetici();
        public Yorumlar yorum = new Yorumlar();
        public YorumSay yorumsay = new YorumSay();

        public YorumEkleme()
        {
            InitializeComponent();
            try
            {
                Task t1 = Task.Run(() =>
                {
                    yorumsay = ysy.Find(x => x.Id == 1);
                    labelOlumlu.Text = yorumsay.olumluSayisi.ToString();
                    labelOlumsuz.Text = yorumsay.olumsuzSayisi.ToString();
                });
                Task.WaitAll(t1);
            }
            catch (Exception)
            {

            }
        }

        private void readfile_Click(object sender, EventArgs e)
        {
            string fname = "";
            string[] splits;
            int number=0;
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Yorumlar";
            fdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.Filter = "XML files (*.xml)|*.xml|CSV files (*.csv)|*.csv";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }
            if (fname != "")
            {
                yorumsay = ysy.Find(x => x.Id == 1);
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
                _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                int olumluSayisi = Convert.ToInt32(yorumsay.olumluSayisi);
                int toplamYorumSayisi = Convert.ToInt32(yorumsay.olumluSayisi + yorumsay.olumsuzSayisi);
                if (radioOlumlu.Checked)
                {
                    progressBar1.Maximum = Convert.ToInt32(toplamYorumSayisi - olumluSayisi + 1);
                    Range line = (Range)xlWorksheet.Rows[olumluSayisi + 1];
                    line.Insert();
                    xlWorksheet.Cells[olumluSayisi + 1, 1] = (olumluSayisi).ToString() + (char)34 + " " + richTextBox1.Text;
                    for (int i = olumluSayisi + 2; i <= toplamYorumSayisi + 1; i++)
                    {
                        splits = new string[5];
                        splits = Regex.Split(xlRange.Cells[i, 1].Value2.ToString(), @"" + (char)34 + "");
                        number = Convert.ToInt32(splits[0]) + 1;
                        xlWorksheet.Cells[i, 1] = number.ToString() + (char)34 + splits[1];
                        progressBar1.Increment(1);
                    }
                    yorumsay.olumluSayisi = yorumsay.olumluSayisi + 1;
                    ysy.Update(yorumsay);
                    labelOlumlu.Text = yorumsay.olumluSayisi.ToString();
                    xlWorkbook.Activate();
                    xlWorkbook.Save();
                    progressBar1.Value = 0;
                    MessageBox.Show("Tamamlandı.");
                }
                else if (radioOlumsuz.Checked)
                {
                    progressBar1.Maximum = 100;
                    if (xlRange.Cells[toplamYorumSayisi, 1] != null && xlRange.Cells[toplamYorumSayisi, 1].Value2 != null)
                    {
                        progressBar1.Increment(10);
                        //xlRange.Cells[toplamYorumSayisi + 1, 1].Value2 = toplamYorumSayisi.ToString() + (char)34 + " " + richTextBox1.Text;
                        xlWorksheet.Cells[toplamYorumSayisi + 1, 1] = toplamYorumSayisi.ToString() + (char)34 + " " + richTextBox1.Text;
                        progressBar1.Increment(10);
                        xlWorkbook.Activate();
                        progressBar1.Increment(10);
                        xlWorkbook.Save();
                        progressBar1.Increment(10);
                        yorum.yorumlar = toplamYorumSayisi.ToString() + (char)34 + " " + richTextBox1.Text;
                        progressBar1.Increment(10);
                        yorumsay.olumsuzSayisi = yorumsay.olumsuzSayisi + 1;
                        progressBar1.Increment(10);
                        ysy.Update(yorumsay);
                        progressBar1.Increment(40);
                        //progressBar1.Increment(1);
                    }
                    labelOlumsuz.Text = yorumsay.olumsuzSayisi.ToString();
                    progressBar1.Value = 0;
                    MessageBox.Show("Tamamlandı.");
                    //yorumsay = ysy.Find(x => x.Id == 1);
                    //yorumsay.olumsuzSayisi = 9997;
                    //ysy.Update(yorumsay);
                }

                //cleanup  
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:  
                //  never use two dots, all COM objects must be referenced and released individually  
                //  ex: [somthing].[something].[something] is bad  

                //release com objects to fully kill excel process from running in the background  
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release  
                xlWorkbook.Close(true);
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release  
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            else
            {
                MessageBox.Show("Dosya seçiniz...");
            }
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa aa = new Anasayfa();
            aa.Closed += (s, args) => this.Close();
            aa.Show();
        }
    }
}
