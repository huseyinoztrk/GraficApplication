using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Odev__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.RemoveAt(0);
            chart2.Series.RemoveAt(0);
            
        }


        private bool KontrolFonksiyonu()
        {
            //Seri kontrolü nested şeklinde yapıldı
            /*Bu şekilde de yapılabilir
             * if (seri1.Text == null && seri1.Text == "" )
             * {
             *      errorProvider1.SetError(seri1, "Seri ismi girin!");
             *      return false;
             * }
             *Diğer koşullar
             *
             *
             *return true;
             * 
             *
             */

            if (!chart1.Series.IsUniqueName(chartName.Text)) {
                errorProvider1.SetError(chartName, "Seri ismi bulunmakta!");
                return false;
            }

            //Verilerin girileceği kısımdaki koşullar aşağıda verilmiştir.
            if (chartName.Text != null || chartName.Text != "" )
            {
                if (double.TryParse(veri1Y.Text, out double a) && double.TryParse(veri1X.Text, out double b))
                {
                    if (double.TryParse(veri2Y.Text, out double c) && double.TryParse(veri2X.Text, out double d))
                    {
                        if (double.TryParse(veri3Y.Text, out double e) && double.TryParse(veri3X.Text, out double f))
                        {
                            if (double.TryParse(veri4Y.Text, out double g) && double.TryParse(veri4X.Text, out double h))
                            {
                                return true;
                            }
                            else
                                errorProvider1.SetError(veri4Y, "Geçerli bir sayı girin");
                        }
                        else
                            errorProvider1.SetError(veri3Y, "Geçerli bir sayı girin");
                    }
                    else
                        errorProvider1.SetError(veri2Y, "Geçerli bir sayı girin");
                }
                else
                    errorProvider1.SetError(veri1Y, "Geçerli bir sayı girin");
            }
            else
                errorProvider1.SetError(chartName, "Seri ismi girin!");
            
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KontrolFonksiyonu();
            errorProvider1.Clear();
            
            if (chart1.Series.Count < 4)
            {
                if (KontrolFonksiyonu())
                {   
                    Series seri_1 = new Series();
                    Series seri_2 = new Series();
                    grafikBaslik1.Text = grafikBaslik2.Text = grafikBasligi.Text;

                    //Seri tipi kontrolü buradan
                    seri_1.ChartType = SeriesChartType.Point;
                    seri_1.Name = chartName.Text;
                    seri_1.Points.AddXY(Convert.ToDouble(veri1X.Text), Convert.ToDouble(veri1Y.Text));
                    seri_1.Points.AddXY(Convert.ToDouble(veri2X.Text), Convert.ToDouble(veri2Y.Text));
                    seri_1.Points.AddXY(Convert.ToDouble(veri3X.Text), Convert.ToDouble(veri3Y.Text));
                    seri_1.Points.AddXY(Convert.ToDouble(veri4X.Text), Convert.ToDouble(veri4Y.Text));
                    seri_2.ChartType = SeriesChartType.Column;
                    seri_2.Name = chartName.Text;
                    seri_2.Points.AddXY(Convert.ToDouble(veri1X.Text), Convert.ToDouble(veri1Y.Text));
                    seri_2.Points.AddXY(Convert.ToDouble(veri2X.Text), Convert.ToDouble(veri2Y.Text));
                    seri_2.Points.AddXY(Convert.ToDouble(veri3X.Text), Convert.ToDouble(veri3Y.Text));
                    seri_2.Points.AddXY(Convert.ToDouble(veri4X.Text), Convert.ToDouble(veri4Y.Text));
                    //seri_1.Points.add
                    chart1.Series.Add(seri_1);
                    chart2.Series.Add(seri_2);

                }
                verisetsayisi.Text = Convert.ToString(chart1.Series.Count);
            }
            else
                //istenenden fazla veri girilmesi engellendi
                errorProvider1.SetError(veriReset, "En fazla 4 veri seti olabilmekte!");
        }

        private void veriReset_Click(object sender, EventArgs e)
        {
            //verileri tablodan silen fonksiyon
            while (chart1.Series.Count > 0) 
            { 
            chart1.Series.RemoveAt(0);
                while (chart2.Series.Count > 0)
                {
                    chart2.Series.RemoveAt(0);
                }
            }

            //Verileri Temizle butonuna basılınca sol kısımdaki textboxları temizleyen kısım
            chartName.Text = "";
            veri1X.Text = "";
            veri1Y.Text = "";
            veri2X.Text = "";
            veri2Y.Text = "";
            veri3X.Text = "";
            veri3Y.Text = "";
            veri4X.Text = "";
            veri4Y.Text = "";
            grafikBasligi.Text = "";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
            //arayüzde menüde renk değişimlerini sağlayan fonksiyon
        {
            veriEkle.BackColor = Color.Red;
        }

        private void veriReset_MouseEnter(object sender, EventArgs e)
        {
            veriReset.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            veriEkle.BackColor = Color.White;
        }

        private void veriReset_MouseLeave(object sender, EventArgs e)
        {
            veriReset.BackColor = Color.White;
        }

    }
}
