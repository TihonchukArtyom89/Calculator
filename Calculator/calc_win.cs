using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calc_win : Form
    {
        float first_operand, second_operand;
        int oper;
        bool sign = true;

        public calc_win()
        {

            InitializeComponent();
        }
        //рефакторинг позже: сделать функцию для набора цифр
        //апгрейд сделать кнопку которая стирает все написанное
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 5;
            }
            else
            {
                Monitor_txtbx.Text = "";
                Monitor_txtbx.Text += 5;
            }
        }

        private void dev_note_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 6;
            }
            else
            {
                Monitor_txtbx.Text = "";
                Monitor_txtbx.Text += 6;
            }
        }

        private void title_app_Click(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 7;
            }
            else
            {
                Monitor_txtbx.Text = "";
                Monitor_txtbx.Text += 7;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if(Monitor_txtbx.Text!="0")
            {
                Monitor_txtbx.Text += 0;
            }
            else
            {
                Monitor_txtbx.Text="";
                Monitor_txtbx.Text += 0;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 1;
            }
            else
            {
                Monitor_txtbx.Text = "";
                Monitor_txtbx.Text += 1;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 2;
            }
            else
            {
                Monitor_txtbx.Text = "";
                Monitor_txtbx.Text += 2;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 3;
            }
            else
            {
                Monitor_txtbx.Text = "";
                Monitor_txtbx.Text += 3;
            }
        }

        private void digits_Enter(object sender, EventArgs e)
        {

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 8;
            }
            else
            {
                Monitor_txtbx.Text = "";
                Monitor_txtbx.Text += 8;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 9;
            }
            else
            {
                Monitor_txtbx.Text = "";
                Monitor_txtbx.Text += 9;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += 4;
            }
            else
            {
                Monitor_txtbx.Text += 4;
            }
        }

        private void operators_Enter(object sender, EventArgs e)
        {

        }

        private void change_signe_btn_Click(object sender, EventArgs e)
        {
            if(sign==true)
            {
                Monitor_txtbx.Text = "-" + Monitor_txtbx.Text;
                sign = false;
            }
            else
            {
                Monitor_txtbx.Text = Monitor_txtbx.Text.Replace("-", "");
                sign = false;
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
