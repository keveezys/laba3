using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second_chel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool knopochka_clicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!knopochka_clicked)
            {
                knopochka_clicked = true;
                knopochkaGovorit.Visible = true;
            }
            else
            {
                knopochkaGovorit.Visible = false;
                knopochka_clicked = false;
            }
        }
    }
}
