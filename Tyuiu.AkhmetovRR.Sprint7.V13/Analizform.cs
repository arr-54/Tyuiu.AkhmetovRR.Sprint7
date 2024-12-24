using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AkhmetovRR.Sprint7.V13.Lib;

namespace Tyuiu.AkhmetovRR.Sprint7.V13
{
    public partial class Analizform : Form
    {
        private string path;
        public Analizform()
        {
            InitializeComponent();
            FormMain formmain = new FormMain();
            this.path = formmain.GetPath();
            ShowData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Analizform_Load(object sender, EventArgs e)
        {

        }

        private void ShowData()
        {
            dGvnew_АхметовРР.Rows.Clear();
            dGvnew_АхметовРР.Columns.Clear();
            var lines = File.ReadAllLines(path, encoding: Encoding.UTF8);
            if (lines.Length > 0)
            {
                string[] headers = lines[0].Split(';');

                foreach (var header in headers)
                {
                    dGvnew_АхметовРР.Columns.Add(header, header);
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(";");
                    dGvnew_АхметовРР.Rows.Add(row);
                }
            }
        }

        private void btnkolichestvo_АхметовРР_Click(object sender, EventArgs e)
        {
            int rowscount = dGvnew_АхметовРР.Rows.Count - 1;
            MessageBox.Show("Количество: " + rowscount.ToString());
        }

        private void btnsum_АхметовРР_Click(object sender, EventArgs e)
        {
            long[] array = AnalizNaselenia();
            long sum = DataService.Sum(array);
            MessageBox.Show("Сумма населения всех стран: " + sum.ToString());
        }

        private void btnsrednee_АхметовРР_Click(object sender, EventArgs e)
        {
            long[] array = AnalizNaselenia();
            long srednee = DataService.Srednee(array);
            MessageBox.Show("Среднее значение населения: " + srednee.ToString());
        }
        private long[] AnalizNaselenia()
        {
            int rowcount = dGvnew_АхметовРР.RowCount;
            long[] array = new long[rowcount];
            for (int i = 0; i < rowcount; i++)
            {
                if (dGvnew_АхметовРР.Rows[i].Cells[4].Value != null)
                {
                    array[i] = Convert.ToInt64(dGvnew_АхметовРР.Rows[i].Cells[4].Value);
                }
                else
                {
                    array[i] = 0;
                }
            }
            return array;
        }

        private void btnmin_АхметовРР_Click(object sender, EventArgs e)
        {
            long[] array = AnalizNaselenia();
            long min = DataService.Minimalnoe(array);
            MessageBox.Show("Минимальное значение населения: " + min.ToString());
        }
        private void btnmax_АхметовРР_Click(object sender, EventArgs e)
        {
            long[] array = AnalizNaselenia();
            long max = DataService.Maxsimalnoe(array);
            MessageBox.Show("Максимальное значение населения: " + max.ToString());
        }

        private void btnmax_АхметовРР_Click_1(object sender, EventArgs e)
        {
            long[] array = AnalizNaselenia();
            long max = DataService.Maxsimalnoe(array);
            MessageBox.Show("Максимальное значение населения: " + max.ToString());
        }

        private Dictionary<string, long> GetPopulationData()
        {
            var data = new Dictionary<string, long>();
            var lines = File.ReadAllLines(path, Encoding.UTF8);
            if (lines.Length > 1)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    var columns = lines[i].Split(';');
                    string country = columns[0];
                    data[country] = Convert.ToInt64(columns[4]);
                }
            }
            return data;
        }

        private void btndiagr_АхметовРР_Click(object sender, EventArgs e)
        {
            chart_АхметовРР.Series.Clear();
            chart_АхметовРР.ChartAreas.Clear();
            var chartArea = new ChartArea("MainArea");
            chart_АхметовРР.ChartAreas.Add(chartArea);
            var series = new Series("Население стран")
            {
                ChartType = SeriesChartType.Pie
            };
            var populationData = GetPopulationData();
            foreach (var x in populationData)
            {
                series.Points.AddXY(x.Key, x.Value);
            }
            chart_АхметовРР.Series.Add(series);
        }

        private void btngist_АхметовРР_Click(object sender, EventArgs e)
        {
            chart_АхметовРР.Series.Clear();
            chart_АхметовРР.ChartAreas.Clear();
            var chartArea = new ChartArea("MainArea");
            chart_АхметовРР.ChartAreas.Add(chartArea);
            chartArea.AxisX.LabelStyle.Enabled = false;
            var populationData = GetPopulationData();
            var colors = new[] { Color.Red, Color.Blue, Color.Purple, Color.Orange, Color.Yellow, Color.Black, Color.Pink };
            int colorindex = 0;
            foreach (var x in populationData)
            {
                var series = new Series(x.Key)
                {
                    ChartType = SeriesChartType.Column,
                    Color = colors[colorindex],
                };
                if (colorindex + 1 < colors.Length)
                {
                    colorindex++;
                }
                else
                {
                    colorindex = 0;
                }
                series.Points.AddXY(x.Key, x.Value);
                chart_АхметовРР.Series.Add(series);
            }
        }

        private void grafic_АхметовРР_Enter(object sender, EventArgs e)
        {

        }

        private void btnfun_АхметовРР_Click(object sender, EventArgs e)
        {
            chart_АхметовРР.Series.Clear();
            chart_АхметовРР.ChartAreas.Clear();
            var chartArea = new ChartArea("MainArea");
            chart_АхметовРР.ChartAreas.Add(chartArea);
            chartArea.AxisX.LabelStyle.Enabled = false;
            var populationData = GetPopulationData();
            var series = new Series("Численность населения")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Blue,
                IsValueShownAsLabel = true
            };
            int index = 0;
            foreach (var x in populationData) 
            {
                series.Points.AddXY(index, x.Value);
                series.Points[index].Label = x.Key;
                index++;
            }
            chart_АхметовРР.Series.Add(series);
            chartArea.AxisX.CustomLabels.Clear();
            index = 0;
            foreach (var x in populationData) 
            {
                chartArea.AxisX.CustomLabels.Add(index, index + 1, x.Key);
                index++;
            }
        }
    }
}