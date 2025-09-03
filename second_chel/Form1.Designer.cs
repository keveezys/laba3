using System.Drawing;

namespace second_chel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.knopochkaGovorit = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "это сделал чел, который уже делал лабу, а исходники благополучно потерял,\nпоэтому тут" +
    " нет ничего, кроме этого лейбла,\nвот так вот сделал лютый ход.\nможете понажимать на" +
    " кнопочку, она что-то скажет";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 144);
            this.button1.TabIndex = 1;
            this.button1.Text = "кнопочка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // knopochkaGovorit
            // 
            this.knopochkaGovorit.Location = new System.Drawing.Point(48, 353);
            this.knopochkaGovorit.Name = "knopochkaGovorit";
            this.knopochkaGovorit.Size = new System.Drawing.Size(723, 61);
            this.knopochkaGovorit.TabIndex = 2;
            this.knopochkaGovorit.Text = "кнопочка сказала, что тот, кто не делает лабы вовремя, умирает на допсе";
            this.knopochkaGovorit.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.knopochkaGovorit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.RichTextBox knopochkaGovorit;
        private System.Windows.Forms.RichTextBox knopochkaGovorit;
    }
}

