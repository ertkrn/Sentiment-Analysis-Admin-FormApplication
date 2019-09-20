using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DuyguAnaliziEgitimi.Formlar
{
    public partial class ExcelDuzenleme : Form
    {
        public ExcelDuzenleme()
        {
            InitializeComponent();
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Yorumlar";
            fdlg.InitialDirectory = @"d:\Ders Notları\Proje&Bitirme\Proje2 - bilvideo\Source\Python\classification\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }
            
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
            _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            int rowCount = Convert.ToInt32(numericBitis.Value) - Convert.ToInt32(numericBaslangic.Value);
            int colCount = xlRange.Columns.Count;
            progressBar3.Maximum = rowCount * colCount;
            string bosluk = " ";
            //progressBar2.Maximum = rowCount;
            try
            {
                for (int i = Convert.ToInt32(numericBaslangic.Value); i <= Convert.ToInt32(numericBitis.Value); i++)
                {
                    //progressBar1.Maximum = colCount;
                    for (int k = 1; k < colCount; k++)
                    {
                        if (xlRange.Cells[i, k].Value2 != null)
                        {
                            builder.Append(xlRange.Cells[i, k].Value2.ToString());
                            builder.Append(bosluk);
                            label4.Text = i.ToString() + ". Satırdaki " + k.ToString() + ". Sütun Dolu...";
                            //progressBar1.Increment(1);
                            xlWorksheet.Cells[i, k] = "";
                        }
                        labelSutun.Text = k.ToString();
                        progressBar3.Increment(1);
                    }
                    labelSatir.Text = i.ToString();
                    //progressBar1.Value = 0;
                    xlWorksheet.Cells[i, 1] = builder.ToString();
                    builder.Clear();
                    //progressBar2.Increment(1);
                }
                xlWorkbook.Activate();
                xlWorkbook.Save();
            }
            catch(Exception exc)
            {

            }
            //progressBar2.Value = 0;
            progressBar3.Value = 0;
            MessageBox.Show("Tamamlandı.");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
