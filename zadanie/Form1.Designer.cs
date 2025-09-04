using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace zadanie
{
    partial class FormStart
    {
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
            buttonTable = new Button();
            buttonGraph = new Button();
            SuspendLayout();
            // 
            // buttonTable
            // 
            buttonTable.Location = new Point(125, 30);
            buttonTable.Name = "buttonTable";
            buttonTable.Size = new Size(310, 100);
            buttonTable.TabIndex = 0;
            buttonTable.Text = "Таблица туристского потока";
            buttonTable.UseVisualStyleBackColor = true;
            buttonTable.Click += buttonTable_Click;
            // 
            // buttonGraph
            // 
            buttonGraph.Location = new Point(125, 180);
            buttonGraph.Name = "buttonGraph";
            buttonGraph.Size = new Size(310, 100);
            buttonGraph.TabIndex = 1;
            buttonGraph.Text = "График туристского потока с экстраполяцией";
            buttonGraph.UseVisualStyleBackColor = true;
            buttonGraph.Click += buttonGraph_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 309);
            Controls.Add(buttonGraph);
            Controls.Add(buttonTable);
            Name = "FormStart";
            Text = "Tourist's flow Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTable;
        private Button buttonGraph;
    }
}