using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChel_Click(object sender, EventArgs e)
        {
            new second_chel.Form1().ShowDialog();
            
        }

        private void buttonArtem_Click(object sender, EventArgs e)
        {
            new zadanie.FormStart().ShowDialog();
        }
    }
}
