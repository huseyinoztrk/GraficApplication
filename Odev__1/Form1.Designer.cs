namespace Odev__1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartName = new System.Windows.Forms.TextBox();
            this.veri1Y = new System.Windows.Forms.TextBox();
            this.veri2Y = new System.Windows.Forms.TextBox();
            this.veri3Y = new System.Windows.Forms.TextBox();
            this.veri4Y = new System.Windows.Forms.TextBox();
            this.veriEkle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.verisetsayisi = new System.Windows.Forms.Label();
            this.veriReset = new System.Windows.Forms.Button();
            this.veri1X = new System.Windows.Forms.TextBox();
            this.veri2X = new System.Windows.Forms.TextBox();
            this.veri3X = new System.Windows.Forms.TextBox();
            this.veri4X = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.yEksen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grafikBaslik1 = new System.Windows.Forms.Label();
            this.grafikBaslik2 = new System.Windows.Forms.Label();
            this.grafikBasligi = new System.Windows.Forms.TextBox();
            this.grafikBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Salmon;
            this.chart1.BorderlineColor = System.Drawing.Color.Firebrick;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.chart1.BorderlineWidth = 2;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(655, 34);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(811, 453);
            this.chart1.TabIndex = 50;
            this.chart1.Tag = "charts";
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seri İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veri 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veri 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Veri 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Veri 4";
            // 
            // chartName
            // 
            this.chartName.Location = new System.Drawing.Point(116, 111);
            this.chartName.Margin = new System.Windows.Forms.Padding(4);
            this.chartName.Name = "chartName";
            this.chartName.Size = new System.Drawing.Size(127, 22);
            this.chartName.TabIndex = 0;
            // 
            // veri1Y
            // 
            this.veri1Y.Location = new System.Drawing.Point(263, 158);
            this.veri1Y.Margin = new System.Windows.Forms.Padding(4);
            this.veri1Y.Name = "veri1Y";
            this.veri1Y.Size = new System.Drawing.Size(125, 22);
            this.veri1Y.TabIndex = 2;
            this.veri1Y.Tag = "veriler";
            // 
            // veri2Y
            // 
            this.veri2Y.Location = new System.Drawing.Point(263, 208);
            this.veri2Y.Margin = new System.Windows.Forms.Padding(4);
            this.veri2Y.Name = "veri2Y";
            this.veri2Y.Size = new System.Drawing.Size(125, 22);
            this.veri2Y.TabIndex = 4;
            this.veri2Y.Tag = "veriler";
            // 
            // veri3Y
            // 
            this.veri3Y.Location = new System.Drawing.Point(263, 258);
            this.veri3Y.Margin = new System.Windows.Forms.Padding(4);
            this.veri3Y.Name = "veri3Y";
            this.veri3Y.Size = new System.Drawing.Size(125, 22);
            this.veri3Y.TabIndex = 6;
            this.veri3Y.Tag = "veriler";
            // 
            // veri4Y
            // 
            this.veri4Y.Location = new System.Drawing.Point(263, 314);
            this.veri4Y.Margin = new System.Windows.Forms.Padding(4);
            this.veri4Y.Name = "veri4Y";
            this.veri4Y.Size = new System.Drawing.Size(125, 22);
            this.veri4Y.TabIndex = 8;
            this.veri4Y.Tag = "veriler";
            // 
            // veriEkle
            // 
            this.veriEkle.Location = new System.Drawing.Point(36, 442);
            this.veriEkle.Margin = new System.Windows.Forms.Padding(4);
            this.veriEkle.Name = "veriEkle";
            this.veriEkle.Size = new System.Drawing.Size(233, 41);
            this.veriEkle.TabIndex = 9;
            this.veriEkle.Text = "Verileri Ekle";
            this.veriEkle.UseVisualStyleBackColor = true;
            this.veriEkle.Click += new System.EventHandler(this.button1_Click);
            this.veriEkle.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.veriEkle.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // verisetsayisi
            // 
            this.verisetsayisi.AutoSize = true;
            this.verisetsayisi.Location = new System.Drawing.Point(448, 239);
            this.verisetsayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verisetsayisi.Name = "verisetsayisi";
            this.verisetsayisi.Size = new System.Drawing.Size(50, 16);
            this.verisetsayisi.TabIndex = 12;
            this.verisetsayisi.Text = "setsayi";
            // 
            // veriReset
            // 
            this.veriReset.Location = new System.Drawing.Point(363, 442);
            this.veriReset.Margin = new System.Windows.Forms.Padding(4);
            this.veriReset.Name = "veriReset";
            this.veriReset.Size = new System.Drawing.Size(248, 46);
            this.veriReset.TabIndex = 10;
            this.veriReset.Text = "Verileri Sıfırla";
            this.veriReset.UseVisualStyleBackColor = true;
            this.veriReset.Click += new System.EventHandler(this.veriReset_Click);
            this.veriReset.MouseEnter += new System.EventHandler(this.veriReset_MouseEnter);
            this.veriReset.MouseLeave += new System.EventHandler(this.veriReset_MouseLeave);
            // 
            // veri1X
            // 
            this.veri1X.Location = new System.Drawing.Point(116, 158);
            this.veri1X.Margin = new System.Windows.Forms.Padding(4);
            this.veri1X.Name = "veri1X";
            this.veri1X.Size = new System.Drawing.Size(125, 22);
            this.veri1X.TabIndex = 1;
            this.veri1X.Tag = "veriler";
            // 
            // veri2X
            // 
            this.veri2X.Location = new System.Drawing.Point(117, 208);
            this.veri2X.Margin = new System.Windows.Forms.Padding(4);
            this.veri2X.Name = "veri2X";
            this.veri2X.Size = new System.Drawing.Size(124, 22);
            this.veri2X.TabIndex = 3;
            this.veri2X.Tag = "veriler";
            // 
            // veri3X
            // 
            this.veri3X.Location = new System.Drawing.Point(116, 258);
            this.veri3X.Margin = new System.Windows.Forms.Padding(4);
            this.veri3X.Name = "veri3X";
            this.veri3X.Size = new System.Drawing.Size(127, 22);
            this.veri3X.TabIndex = 5;
            this.veri3X.Tag = "veriler";
            // 
            // veri4X
            // 
            this.veri4X.Location = new System.Drawing.Point(115, 314);
            this.veri4X.Margin = new System.Windows.Forms.Padding(4);
            this.veri4X.Name = "veri4X";
            this.veri4X.Size = new System.Drawing.Size(127, 22);
            this.veri4X.TabIndex = 7;
            this.veri4X.Tag = "veriler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Y ekseni";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "X ekseni";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Salmon;
            this.chart2.BorderlineColor = System.Drawing.Color.Firebrick;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.chart2.BorderlineWidth = 2;
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(655, 532);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(811, 396);
            this.chart2.TabIndex = 20;
            this.chart2.Tag = "charts";
            this.chart2.Text = "chart2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(968, 459);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "X Ekseni";
            // 
            // yEksen
            // 
            this.yEksen.AutoSize = true;
            this.yEksen.Location = new System.Drawing.Point(669, 239);
            this.yEksen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yEksen.Name = "yEksen";
            this.yEksen.Size = new System.Drawing.Size(60, 16);
            this.yEksen.TabIndex = 21;
            this.yEksen.Text = "Y Ekseni";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(968, 905);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "X Ekseni";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(669, 706);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Y Ekseni";
            // 
            // grafikBaslik1
            // 
            this.grafikBaslik1.AutoSize = true;
            this.grafikBaslik1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grafikBaslik1.Location = new System.Drawing.Point(968, 34);
            this.grafikBaslik1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grafikBaslik1.Name = "grafikBaslik1";
            this.grafikBaslik1.Size = new System.Drawing.Size(62, 23);
            this.grafikBaslik1.TabIndex = 21;
            this.grafikBaslik1.Text = "X Ekseni";
            // 
            // grafikBaslik2
            // 
            this.grafikBaslik2.AutoSize = true;
            this.grafikBaslik2.BackColor = System.Drawing.Color.Transparent;
            this.grafikBaslik2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grafikBaslik2.Location = new System.Drawing.Point(968, 532);
            this.grafikBaslik2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grafikBaslik2.Name = "grafikBaslik2";
            this.grafikBaslik2.Size = new System.Drawing.Size(62, 23);
            this.grafikBaslik2.TabIndex = 21;
            this.grafikBaslik2.Text = "X Ekseni";
            // 
            // grafikBasligi
            // 
            this.grafikBasligi.Location = new System.Drawing.Point(303, 578);
            this.grafikBasligi.Margin = new System.Windows.Forms.Padding(4);
            this.grafikBasligi.Name = "grafikBasligi";
            this.grafikBasligi.Size = new System.Drawing.Size(127, 22);
            this.grafikBasligi.TabIndex = 11;
            // 
            // grafikBaslik
            // 
            this.grafikBaslik.AutoSize = true;
            this.grafikBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grafikBaslik.Location = new System.Drawing.Point(148, 576);
            this.grafikBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grafikBaslik.Name = "grafikBaslik";
            this.grafikBaslik.Size = new System.Drawing.Size(125, 25);
            this.grafikBaslik.TabIndex = 1;
            this.grafikBaslik.Text = "Grafik Başlığı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1535, 966);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.yEksen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grafikBaslik2);
            this.Controls.Add(this.grafikBaslik1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.veri4X);
            this.Controls.Add(this.veri3X);
            this.Controls.Add(this.veri2X);
            this.Controls.Add(this.veri1X);
            this.Controls.Add(this.veriReset);
            this.Controls.Add(this.verisetsayisi);
            this.Controls.Add(this.veriEkle);
            this.Controls.Add(this.veri4Y);
            this.Controls.Add(this.veri3Y);
            this.Controls.Add(this.veri2Y);
            this.Controls.Add(this.veri1Y);
            this.Controls.Add(this.grafikBasligi);
            this.Controls.Add(this.chartName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grafikBaslik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRAFİK UYGULAMASI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox chartName;
        private System.Windows.Forms.TextBox veri1Y;
        private System.Windows.Forms.TextBox veri2Y;
        private System.Windows.Forms.TextBox veri3Y;
        private System.Windows.Forms.TextBox veri4Y;
        private System.Windows.Forms.Button veriEkle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label verisetsayisi;
        private System.Windows.Forms.Button veriReset;
        private System.Windows.Forms.TextBox veri4X;
        private System.Windows.Forms.TextBox veri3X;
        private System.Windows.Forms.TextBox veri2X;
        private System.Windows.Forms.TextBox veri1X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label yEksen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label grafikBaslik2;
        private System.Windows.Forms.Label grafikBaslik1;
        private System.Windows.Forms.TextBox grafikBasligi;
        private System.Windows.Forms.Label grafikBaslik;
    }
}

