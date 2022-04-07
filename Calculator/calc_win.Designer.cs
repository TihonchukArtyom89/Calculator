
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
            this.operators_grp = new System.Windows.Forms.GroupBox();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.button_grp = new System.Windows.Forms.GroupBox();
            this.monitor_grp = new System.Windows.Forms.GroupBox();
            this.digits_grp.SuspendLayout();
            this.button_grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dev_note
            // 
            this.dev_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dev_note.AutoSize = true;
            this.dev_note.Location = new System.Drawing.Point(199, 336);
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
            this.digits_grp.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.digits_grp.Location = new System.Drawing.Point(11, 39);
            this.digits_grp.Name = "digits_grp";
            this.digits_grp.Size = new System.Drawing.Size(143, 151);
            this.digits_grp.TabIndex = 2;
            this.digits_grp.TabStop = false;
            this.digits_grp.Text = "Цифры";
            this.digits_grp.Enter += new System.EventHandler(this.digits_Enter);
            // 
            // operators_grp
            // 
            this.operators_grp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.operators_grp.Location = new System.Drawing.Point(160, 39);
            this.operators_grp.Name = "operators_grp";
            this.operators_grp.Size = new System.Drawing.Size(166, 151);
            this.operators_grp.TabIndex = 3;
            this.operators_grp.TabStop = false;
            this.operators_grp.Text = "Операторы";
            this.operators_grp.Enter += new System.EventHandler(this.operators_Enter);
            // 
            // btn_0
            // 
            this.btn_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_0.Location = new System.Drawing.Point(17, 115);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(107, 23);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_1.Location = new System.Drawing.Point(17, 86);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(32, 23);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_3
            // 
            this.btn_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_3.Location = new System.Drawing.Point(92, 86);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(32, 23);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_4.Location = new System.Drawing.Point(17, 57);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(32, 23);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_5.Location = new System.Drawing.Point(55, 57);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(32, 23);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6.Location = new System.Drawing.Point(93, 57);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(32, 23);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn_2
            // 
            this.btn_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_2.Location = new System.Drawing.Point(54, 86);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(32, 23);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_9
            // 
            this.btn_9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_9.Location = new System.Drawing.Point(93, 28);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(32, 23);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_8.Location = new System.Drawing.Point(55, 28);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(32, 23);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_7.Location = new System.Drawing.Point(17, 28);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(32, 23);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // button_grp
            // 
            this.button_grp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_grp.Controls.Add(this.digits_grp);
            this.button_grp.Controls.Add(this.operators_grp);
            this.button_grp.Location = new System.Drawing.Point(12, 123);
            this.button_grp.Name = "button_grp";
            this.button_grp.Size = new System.Drawing.Size(332, 199);
            this.button_grp.TabIndex = 4;
            this.button_grp.TabStop = false;
            this.button_grp.Text = "Кнопки";
            // 
            // monitor_grp
            // 
            this.monitor_grp.Location = new System.Drawing.Point(15, 35);
            this.monitor_grp.Name = "monitor_grp";
            this.monitor_grp.Size = new System.Drawing.Size(329, 72);
            this.monitor_grp.TabIndex = 5;
            this.monitor_grp.TabStop = false;
            this.monitor_grp.Text = "Экран";
            // 
            // calc_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 358);
            this.Controls.Add(this.monitor_grp);
            this.Controls.Add(this.button_grp);
            this.Controls.Add(this.title_app);
            this.Controls.Add(this.dev_note);
            this.Name = "calc_win";
            this.Text = "Calculator";
            this.digits_grp.ResumeLayout(false);
            this.button_grp.ResumeLayout(false);
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
    }
}

