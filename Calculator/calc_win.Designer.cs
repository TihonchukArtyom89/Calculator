
namespace Calculator
{
    partial class calc_win
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
            this.dev_note = new System.Windows.Forms.Label();
            this.title_app = new System.Windows.Forms.Label();
            this.digits = new System.Windows.Forms.GroupBox();
            this.operators = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // dev_note
            // 
            this.dev_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dev_note.AutoSize = true;
            this.dev_note.Location = new System.Drawing.Point(199, 303);
            this.dev_note.Name = "dev_note";
            this.dev_note.Size = new System.Drawing.Size(145, 13);
            this.dev_note.TabIndex = 0;
            this.dev_note.Text = "Тихончук Артём 07.04.2022";
            // 
            // title_app
            // 
            this.title_app.AutoSize = true;
            this.title_app.Location = new System.Drawing.Point(12, 9);
            this.title_app.Name = "title_app";
            this.title_app.Size = new System.Drawing.Size(165, 13);
            this.title_app.TabIndex = 1;
            this.title_app.Text = "Графический калькулятор 0.01";
            // 
            // digits
            // 
            this.digits.Location = new System.Drawing.Point(15, 96);
            this.digits.Name = "digits";
            this.digits.Size = new System.Drawing.Size(200, 185);
            this.digits.TabIndex = 2;
            this.digits.TabStop = false;
            this.digits.Text = "Цифры";
            // 
            // operators
            // 
            this.operators.Location = new System.Drawing.Point(221, 96);
            this.operators.Name = "operators";
            this.operators.Size = new System.Drawing.Size(123, 185);
            this.operators.TabIndex = 3;
            this.operators.TabStop = false;
            this.operators.Text = "Операторы";
            // 
            // calc_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 325);
            this.Controls.Add(this.operators);
            this.Controls.Add(this.digits);
            this.Controls.Add(this.title_app);
            this.Controls.Add(this.dev_note);
            this.Name = "calc_win";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dev_note;
        private System.Windows.Forms.Label title_app;
        private System.Windows.Forms.GroupBox digits;
        private System.Windows.Forms.GroupBox operators;
    }
}

