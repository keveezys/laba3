using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie
{
    public partial class FormTable : Form
    {
        StreamReader reader = new StreamReader("..\\..\\..\\..\\zadanie\\data.txt");
        public FormTable()
        {
            InitializeComponent();
            tableCreator();
            tableDataReader();
            tableValues();
        }

        private void tableCreator()
        {
            string[] columnNames = reader.ReadLine().Split(";");
            int columnId = 0;
            foreach (string columnName in columnNames)
            {
                Table1.Columns.Add(columnId.ToString(), columnName);
            }
        }

        private void tableDataReader()
        {
            string[] table = reader.ReadToEnd().Split("\n");
            foreach (string tableLine in table)
            {
                Table1.Rows.Add(tableLine.Split(";"));
            }
        }

        private void tableValues()
        {
            Dictionary<string, int> countries = new Dictionary<string, int>();
            for (int x = 0; x < Table1.Rows.Count; x++)
            {
                for (int y = 1; y < Table1.Columns.Count; y++)
                {
                    string currentCountry = Table1.Columns[y].HeaderText;
                    if (!countries.ContainsKey(currentCountry))
                        countries.Add(currentCountry, 0);
                    countries[currentCountry] += Convert.ToInt32(Table1[y, x].Value);
                }
            }

            int maxValue = 0, minValue = (int)Math.Pow(10, 8);
            string maxValueCountry = "", minValueCountry = "";
            foreach (string key in countries.Keys)
            {
                if (maxValue < countries[key])
                {
                    maxValue = countries[key];
                    maxValueCountry = key;
                }
                if (minValue > countries[key])
                {
                    minValue = countries[key];
                    minValueCountry = key;
                }

            }

            richTextBox1.Text = $"Минимум - {minValueCountry} - {minValue}; \nМаксимум - {maxValueCountry} - {maxValue}";
        }
    }
}
