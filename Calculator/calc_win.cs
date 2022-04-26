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
    }
}
