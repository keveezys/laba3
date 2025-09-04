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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            FormTable frm = new FormTable();
            frm.ShowDialog();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            FormGraph frm = new FormGraph();
            frm.ShowDialog();
        }
    }
}
