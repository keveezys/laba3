using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace zadanie
{
    partial class FormGraph
    {
        private TextBox txtNSize;
        private TextBox txtForecastYears;
        private Button btnCalculate;
        private Label lblWindowSize;
        private Label lblForecastYears;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //
            //  chart1 
            //
            chart1 = new Chart();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            //
            //  extra things
            //
            txtNSize = new TextBox();
            txtForecastYears = new TextBox();
            btnCalculate = new Button();
            lblWindowSize = new Label();
            lblForecastYears = new Label();
            //
            //  chart1 params 
            //
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Top;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Size = new Size(1600, 800);
            //
            //  textbox "n" params
            //
            txtNSize.Location = new Point(380, 810);
            txtNSize.Size = new Size(100, 30);
            txtNSize.Text = "";
            //
            //  textbox forecast params
            //
            txtForecastYears.Location = new Point(810, 810);
            txtForecastYears.Size = new Size(100, 30);
            txtForecastYears.Text = "";
            //
            //  lables
            //
            lblWindowSize.Text = "Размер окна N:";
            lblWindowSize.Location = new Point(20, 810);
            lblWindowSize.Size = new Size(350, 30);

            lblForecastYears.Text = "Лет прогноза:";
            lblForecastYears.Location = new Point(500, 810);
            lblForecastYears.Size = new Size(300, 30);
            //
            //  button for calculation
            //
            btnCalculate.Text = "Рассчитать";
            btnCalculate.Location = new Point(930, 810);
            btnCalculate.Size = new Size(150, 50);
            btnCalculate.Click += calculate_Click;
            //
            //  controls adding
            //
            Controls.Add(chart1);
            Controls.Add(txtNSize);
            Controls.Add(txtForecastYears);
            Controls.Add(lblWindowSize);
            Controls.Add(lblForecastYears);
            Controls.Add(btnCalculate);
            //
            //  form params
            //
            SuspendLayout();
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Name = "FormGraph";
            Text = "FormGraph";
            ResumeLayout(true);
            PerformLayout();
        }

        #endregion

        private Chart chart1;
    }
}