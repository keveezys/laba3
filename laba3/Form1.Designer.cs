namespace laba3
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
            this.buttonArtem = new System.Windows.Forms.Button();
            this.buttonChel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArtem
            // 
            this.buttonArtem.Location = new System.Drawing.Point(89, 50);
            this.buttonArtem.Name = "buttonArtem";
            this.buttonArtem.Size = new System.Drawing.Size(141, 49);
            this.buttonArtem.TabIndex = 0;
            this.buttonArtem.Text = "Артем";
            this.buttonArtem.UseVisualStyleBackColor = true;
            // 
            // buttonChel
            // 
            this.buttonChel.Location = new System.Drawing.Point(89, 154);
            this.buttonChel.Name = "buttonChel";
            this.buttonChel.Size = new System.Drawing.Size(141, 49);
            this.buttonChel.TabIndex = 1;
            this.buttonChel.Text = "Чел";
            this.buttonChel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 276);
            this.Controls.Add(this.buttonChel);
            this.Controls.Add(this.buttonArtem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonArtem;
        private System.Windows.Forms.Button buttonChel;
    }
}

