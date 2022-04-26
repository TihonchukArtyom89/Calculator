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
        float first_operand=float.NaN, second_operand= float.NaN;//числа над которыми совершаются действия
        int oper;//код операции
        bool sign = true,floated=false;

        public calc_win()
        {

            InitializeComponent();
        }


        public void enter_digit(int digit)
        {//разобраться с операциями и подсчётом результата
            if (Monitor_txtbx.Text != "0")
            {
                Monitor_txtbx.Text += digit;
            }
            else
            {
                Monitor_txtbx.Clear();
                Monitor_txtbx.Text += digit;
            }
        }

        private void dev_note_Click(object sender, EventArgs e)
        {

        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            enter_digit(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            enter_digit(6);
        }

        private void title_app_Click(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            enter_digit(7);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            enter_digit(0);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            enter_digit(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            enter_digit(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            enter_digit(3);
        }

        private void digits_Enter(object sender, EventArgs e)
        {

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            enter_digit(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            enter_digit(9);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            enter_digit(4);
        }

        private void operators_Enter(object sender, EventArgs e)
        {

        }

        private void change_signe_btn_Click(object sender, EventArgs e)
        {
            if (sign == true)
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

        private void clear_entry_btn_Click(object sender, EventArgs e)
        {
            Monitor_txtbx.Text = "0";
            first_operand = float.NaN;
            second_operand = float.NaN;
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            first_operand = float.Parse(Monitor_txtbx.Text);
            Monitor_txtbx.Clear();
            oper = 2;
            sign = true;
        }

        private void float_btn_Click(object sender, EventArgs e)
        {//реализовать добавление только одной запятой в одном операнде(числе)
            if (floated.Equals(false))
            {
                Monitor_txtbx.Text += ",";
                floated = true;
            }
        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void multiplication_btn_Click(object sender, EventArgs e)
        {
            first_operand = float.Parse(Monitor_txtbx.Text);
            Monitor_txtbx.Clear();
            oper = 3;
            sign = true;
        }

        private void division_btn_Click(object sender, EventArgs e)
        {
            first_operand = float.Parse(Monitor_txtbx.Text);
            Monitor_txtbx.Clear();
            oper = 4;
            sign = true;
        }

        public void calculate()
        {
            switch (oper)
            {
                case 1:
                    second_operand = first_operand + float.Parse(Monitor_txtbx.Text);
                    Monitor_txtbx.Text = second_operand.ToString();
                    MessageBox.Show("first_operand" + first_operand + "\n" + "second_operand" + second_operand);
                    break;
                case 2:
                    second_operand = first_operand - float.Parse(Monitor_txtbx.Text);
                    Monitor_txtbx.Text = second_operand.ToString();
                    break;
                case 3:
                    second_operand = first_operand * float.Parse(Monitor_txtbx.Text);
                    Monitor_txtbx.Text = second_operand.ToString();
                    break;
                case 4:
                    if (float.Parse(Monitor_txtbx.Text) != 0)
                    {
                        second_operand = first_operand / float.Parse(Monitor_txtbx.Text);
                        Monitor_txtbx.Text = second_operand.ToString();
                    }
                    else
                    {
                        Monitor_txtbx.Text = "Ошибка! На ноль делить нельзя";

                    }
                    break;
                default:
                    Monitor_txtbx.Text = "Ошибка! Нет такой операции.";
                    break;
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {//нужна функция подсчёта calculate
            first_operand = float.Parse(Monitor_txtbx.Text);
            Monitor_txtbx.Clear();
            oper = 1;
            sign = true;
        }
    }
} 
