
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
            this.digits_grp = new System.Windows.Forms.GroupBox();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.operators_grp = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.result_btn = new System.Windows.Forms.Button();
            this.change_signe_btn = new System.Windows.Forms.Button();
            this.clear_entry_btn = new System.Windows.Forms.Button();
            this.float_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.division_btn = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.multiplication_btn = new System.Windows.Forms.Button();
            this.button_grp = new System.Windows.Forms.GroupBox();
            this.monitor_grp = new System.Windows.Forms.GroupBox();
            this.Monitor_txtbx = new System.Windows.Forms.TextBox();
            this.digits_grp.SuspendLayout();
            this.operators_grp.SuspendLayout();
            this.button_grp.SuspendLayout();
            this.monitor_grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dev_note
            // 
            this.dev_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dev_note.AutoSize = true;
            this.dev_note.Location = new System.Drawing.Point(244, 430);
            this.dev_note.Name = "dev_note";
            this.dev_note.Size = new System.Drawing.Size(145, 13);
            this.dev_note.TabIndex = 0;
            this.dev_note.Text = "Тихончук Артём 07.04.2022";
            this.dev_note.Click += new System.EventHandler(this.dev_note_Click);
            // 
            // title_app
            // 
            this.title_app.AutoSize = true;
            this.title_app.Location = new System.Drawing.Point(12, 9);
            this.title_app.Name = "title_app";
            this.title_app.Size = new System.Drawing.Size(165, 13);
            this.title_app.TabIndex = 1;
            this.title_app.Text = "Графический калькулятор 0.01";
            this.title_app.Click += new System.EventHandler(this.title_app_Click);
            // 
            // digits_grp
            // 
            this.digits_grp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.digits_grp.Controls.Add(this.btn_9);
            this.digits_grp.Controls.Add(this.btn_8);
            this.digits_grp.Controls.Add(this.btn_7);
            this.digits_grp.Controls.Add(this.btn_2);
            this.digits_grp.Controls.Add(this.btn6);
            this.digits_grp.Controls.Add(this.btn_5);
            this.digits_grp.Controls.Add(this.btn_4);
            this.digits_grp.Controls.Add(this.btn_3);
            this.digits_grp.Controls.Add(this.btn_1);
            this.digits_grp.Controls.Add(this.btn_0);
            this.digits_grp.Location = new System.Drawing.Point(11, 19);
            this.digits_grp.Name = "digits_grp";
            this.digits_grp.Size = new System.Drawing.Size(172, 272);
            this.digits_grp.TabIndex = 2;
            this.digits_grp.TabStop = false;
            this.digits_grp.Text = "Цифры";
            this.digits_grp.Enter += new System.EventHandler(this.digits_Enter);
            // 
            // btn_9
            // 
            this.btn_9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_9.Location = new System.Drawing.Point(111, 28);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(43, 55);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_8.Location = new System.Drawing.Point(62, 28);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(43, 55);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_7.Location = new System.Drawing.Point(15, 28);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(43, 55);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_2
            // 
            this.btn_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_2.Location = new System.Drawing.Point(62, 150);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(43, 55);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6.Location = new System.Drawing.Point(111, 89);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(43, 55);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_5.Location = new System.Drawing.Point(62, 89);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(43, 55);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_4.Location = new System.Drawing.Point(13, 89);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(43, 55);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_3.Location = new System.Drawing.Point(111, 150);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(43, 55);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_1
            // 
            this.btn_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_1.Location = new System.Drawing.Point(15, 150);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(43, 55);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_0
            // 
            this.btn_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_0.Location = new System.Drawing.Point(15, 211);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(139, 55);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // operators_grp
            // 
            this.operators_grp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.operators_grp.Controls.Add(this.button10);
            this.operators_grp.Controls.Add(this.button11);
            this.operators_grp.Controls.Add(this.button12);
            this.operators_grp.Controls.Add(this.result_btn);
            this.operators_grp.Controls.Add(this.change_signe_btn);
            this.operators_grp.Controls.Add(this.clear_entry_btn);
            this.operators_grp.Controls.Add(this.float_btn);
            this.operators_grp.Controls.Add(this.button5);
            this.operators_grp.Controls.Add(this.division_btn);
            this.operators_grp.Controls.Add(this.plus_btn);
            this.operators_grp.Controls.Add(this.minus_btn);
            this.operators_grp.Controls.Add(this.multiplication_btn);
            this.operators_grp.Location = new System.Drawing.Point(189, 19);
            this.operators_grp.Name = "operators_grp";
            this.operators_grp.Size = new System.Drawing.Size(179, 272);
            this.operators_grp.TabIndex = 3;
            this.operators_grp.TabStop = false;
            this.operators_grp.Text = "Операторы";
            this.operators_grp.Enter += new System.EventHandler(this.operators_Enter);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button10.Location = new System.Drawing.Point(117, 28);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(43, 55);
            this.button10.TabIndex = 21;
            this.button10.Text = "N/A";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.Location = new System.Drawing.Point(117, 89);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(43, 55);
            this.button11.TabIndex = 20;
            this.button11.Text = "N/A";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button12.Location = new System.Drawing.Point(117, 150);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 55);
            this.button12.TabIndex = 19;
            this.button12.Text = "N/A";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // result_btn
            // 
            this.result_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.result_btn.Location = new System.Drawing.Point(70, 28);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(43, 55);
            this.result_btn.TabIndex = 18;
            this.result_btn.Text = "=";
            this.result_btn.UseVisualStyleBackColor = true;
            // 
            // change_signe_btn
            // 
            this.change_signe_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.change_signe_btn.Location = new System.Drawing.Point(70, 89);
            this.change_signe_btn.Name = "change_signe_btn";
            this.change_signe_btn.Size = new System.Drawing.Size(43, 55);
            this.change_signe_btn.TabIndex = 17;
            this.change_signe_btn.Text = "+/-";
            this.change_signe_btn.UseVisualStyleBackColor = true;
            this.change_signe_btn.Click += new System.EventHandler(this.change_signe_btn_Click);
            // 
            // clear_entry_btn
            // 
            this.clear_entry_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clear_entry_btn.Location = new System.Drawing.Point(70, 150);
            this.clear_entry_btn.Name = "clear_entry_btn";
            this.clear_entry_btn.Size = new System.Drawing.Size(43, 55);
            this.clear_entry_btn.TabIndex = 16;
            this.clear_entry_btn.Text = "CE";
            this.clear_entry_btn.UseVisualStyleBackColor = true;
            this.clear_entry_btn.Click += new System.EventHandler(this.clear_entry_btn_Click);
            // 
            // float_btn
            // 
            this.float_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.float_btn.Location = new System.Drawing.Point(70, 211);
            this.float_btn.Name = "float_btn";
            this.float_btn.Size = new System.Drawing.Size(43, 55);
            this.float_btn.TabIndex = 15;
            this.float_btn.Text = ",";
            this.float_btn.UseVisualStyleBackColor = true;
            this.float_btn.Click += new System.EventHandler(this.float_btn_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(117, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 55);
            this.button5.TabIndex = 14;
            this.button5.Text = "N/A";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // division_btn
            // 
            this.division_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.division_btn.Location = new System.Drawing.Point(21, 211);
            this.division_btn.Name = "division_btn";
            this.division_btn.Size = new System.Drawing.Size(43, 55);
            this.division_btn.TabIndex = 13;
            this.division_btn.Text = "/";
            this.division_btn.UseVisualStyleBackColor = true;
            // 
            // plus_btn
            // 
            this.plus_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.plus_btn.Location = new System.Drawing.Point(21, 28);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(43, 55);
            this.plus_btn.TabIndex = 12;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.minus_btn.Location = new System.Drawing.Point(21, 89);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(43, 55);
            this.minus_btn.TabIndex = 11;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // multiplication_btn
            // 
            this.multiplication_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.multiplication_btn.Location = new System.Drawing.Point(21, 150);
            this.multiplication_btn.Name = "multiplication_btn";
            this.multiplication_btn.Size = new System.Drawing.Size(43, 55);
            this.multiplication_btn.TabIndex = 10;
            this.multiplication_btn.Text = "*";
            this.multiplication_btn.UseVisualStyleBackColor = true;
            // 
            // button_grp
            // 
            this.button_grp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_grp.Controls.Add(this.digits_grp);
            this.button_grp.Controls.Add(this.operators_grp);
            this.button_grp.Location = new System.Drawing.Point(12, 123);
            this.button_grp.Name = "button_grp";
            this.button_grp.Size = new System.Drawing.Size(379, 297);
            this.button_grp.TabIndex = 4;
            this.button_grp.TabStop = false;
            this.button_grp.Text = "Кнопки";
            // 
            // monitor_grp
            // 
            this.monitor_grp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monitor_grp.Controls.Add(this.Monitor_txtbx);
            this.monitor_grp.Location = new System.Drawing.Point(15, 35);
            this.monitor_grp.Name = "monitor_grp";
            this.monitor_grp.Size = new System.Drawing.Size(376, 72);
            this.monitor_grp.TabIndex = 5;
            this.monitor_grp.TabStop = false;
            this.monitor_grp.Text = "Экран";
            // 
            // Monitor_txtbx
            // 
            this.Monitor_txtbx.Location = new System.Drawing.Point(6, 19);
            this.Monitor_txtbx.Multiline = true;
            this.Monitor_txtbx.Name = "Monitor_txtbx";
            this.Monitor_txtbx.Size = new System.Drawing.Size(364, 47);
            this.Monitor_txtbx.TabIndex = 0;
            this.Monitor_txtbx.Text = "0";
            // 
            // calc_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 452);
            this.Controls.Add(this.monitor_grp);
            this.Controls.Add(this.button_grp);
            this.Controls.Add(this.title_app);
            this.Controls.Add(this.dev_note);
            this.Name = "calc_win";
            this.Text = "Calculator";
            this.digits_grp.ResumeLayout(false);
            this.operators_grp.ResumeLayout(false);
            this.button_grp.ResumeLayout(false);
            this.monitor_grp.ResumeLayout(false);
            this.monitor_grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dev_note;
        private System.Windows.Forms.Label title_app;
        private System.Windows.Forms.GroupBox digits_grp;
        private System.Windows.Forms.GroupBox operators_grp;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.GroupBox button_grp;
        private System.Windows.Forms.GroupBox monitor_grp;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button result_btn;
        private System.Windows.Forms.Button change_signe_btn;
        private System.Windows.Forms.Button clear_entry_btn;
        private System.Windows.Forms.Button float_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button division_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button multiplication_btn;
        private System.Windows.Forms.TextBox Monitor_txtbx;
    }
}

