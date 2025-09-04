using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;
using System.Xml.Serialization;

namespace zadanie
{
    public partial class FormGraph : System.Windows.Forms.Form
    {
        Dictionary<string, List<int>> _data = new Dictionary<string, List<int>>();
        List<int> _years = new List<int>();

        public FormGraph()
        {
            InitializeComponent();

            dataConverter(ref _data, ref _years);

            //movingAverageExtrapolation(years, data, n: 0, yearsToDraw: 0);
        }

        private Dictionary<string, List<int>> dataConverter(ref Dictionary<string, List<int>> coutryCount, ref List<int> years)
        {
            StreamReader reader = new StreamReader("..\\..\\..\\..\\zadanie\\data.txt");
            string[] table = reader.ReadToEnd().Split("\n");
            string[] headers = table[0].Split(";");

            for (int i = 1; i < table.Length; i++)
            {
                years.Add(Convert.ToInt32(table[i].Split(";")[0]));
            }

            tableSplitter(table, headers, ref coutryCount);

            foreach (string coutry in coutryCount.Keys)
            {
                graphLine(years, coutry, coutryCount[coutry]);
            }

            return coutryCount;
        }

        private void graphLine(List<int> years, string country, List<int> tourists)
        {
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Line;
            series1.BorderWidth = 4;
            series1.LegendText = country;
            series1.Name = country;

            for (int i = 0; i < years.Count; i++)
            {
                series1.Points.AddXY(years[i], tourists[i]);
            }

            chart1.Series.Add(series1);
        }

        private void extrapolationGraphLine(string country, int year, int dot)
        {
            foreach (Series series in chart1.Series)
            {
                if (series.Name == country + " экстраполяция")
                {
                    series.Points.AddXY(year, dot);
                    return;
                }
            }

            Series previous = new Series();

            foreach (Series series in chart1.Series)
            {
                if (series.Name.Equals(country))
                {
                    previous = series;
                    break;
                }
            }
            DataPoint previousPoint = previous.Points[previous.Points.Count - 1];
            int x = Convert.ToInt32(previousPoint.XValue), y = Convert.ToInt32(previousPoint.YValues[0]);

            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Line;
            series1.BorderWidth = 4;
            series1.LegendText = country + " экстраполяция";
            series1.Name = country + " экстраполяция";

            series1.Points.AddXY(x, y);
            series1.Points.AddXY(year, dot);
            chart1.Series.Add(series1);
        }

        private void extrapolationGraphClear()
        {
            List<Series> removeList = new List<Series>();

            foreach (Series series in chart1.Series)
            {
                if (series.Name.EndsWith("экстраполяция")) removeList.Add(series);
            }

            foreach (Series series in removeList)
            {
                chart1.Series.Remove(series);
            }
        }

        private void tableSplitter(string[] replacmentTable, string[] headers, ref Dictionary<string, List<int>> coutryCount)
        {
            for (int y = 1; y < replacmentTable.Length; y++)
            {
                for (int x = 1; x < replacmentTable[0].Split(";").Length; x++)
                {
                    string[] table = replacmentTable[y].Split(";");
                    string currentCountry = headers[x];

                    if (!coutryCount.ContainsKey(currentCountry)) coutryCount.Add(currentCountry, new List<int>() { Convert.ToInt32(table[x]) });
                    else coutryCount[currentCountry].Add(Convert.ToInt32(table[x]));
                }
            }
        }

        private void dictCopier(ref Dictionary<string, List<int>> oldDict, ref Dictionary<string, List<int>> newDict)
        {
            foreach (string key in oldDict.Keys)
            {
                newDict[key] = new List<int>(oldDict[key]);
            }
        }

        private void movingAverageExtrapolation(List<int> existingYears, Dictionary<string, List<int>> data, int n = 5, int yearsToDraw = 5)
        {
            if (n > existingYears.Count) n = existingYears.Count;
            if (yearsToDraw < 1 || n < 1) return;

            int lastYear = existingYears[existingYears.Count - 1];
            Console.WriteLine(lastYear);

            Dictionary<string, List<int>> updatingData = new Dictionary<string, List<int>>();
            dictCopier(ref data, ref updatingData);

            for (int i = 1; i <= yearsToDraw; i++)
            {
                foreach (string country in updatingData.Keys)
                {
                    int mid = 0;
                    List<int> values = updatingData[country];
                    for (int j = values.Count - 1; j >= values.Count - n; j--)
                    {
                        mid += updatingData[country][j];
                    }
                    mid /= n;

                    updatingData[country].Add(mid);

                    extrapolationGraphLine(country, lastYear + i, mid);
                    /*Series series1 = chart1.Series[country];
                    series1.Points.AddXY(lastYear + i, mid);*/

                }
            }
        }

        private void calculate_Click(object sender, System.EventArgs e)
        {
            extrapolationGraphClear();
            if (txtNSize.Text == "" || txtForecastYears.Text == "") return;
            movingAverageExtrapolation(_years, _data, n: Convert.ToInt32(txtNSize.Text), yearsToDraw: Convert.ToInt32(txtForecastYears.Text));
            foreach (string key in _data.Keys)
            {
                Console.WriteLine($"{key} {_data[key][_data[key].Count - 1]}");
            }
        }
    }
}
