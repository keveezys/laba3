namespace zadanie
{
    partial class FormTable
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
            Table1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)Table1).BeginInit();
            SuspendLayout();
            // 
            // Table1
            // 
            Table1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table1.Location = new Point(12, 12);
            Table1.Name = "Table1";
            Table1.RowHeadersWidth = 82;
            Table1.Size = new Size(1121, 750);
            Table1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1139, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(362, 192);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // FormTable
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 768);
            Controls.Add(richTextBox1);
            Controls.Add(Table1);
            Name = "FormTable";
            Text = "FormTable";
            ((System.ComponentModel.ISupportInitialize)Table1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Table1;
        private RichTextBox richTextBox1;
    }
}