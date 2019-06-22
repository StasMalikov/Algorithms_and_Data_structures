using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_logic_3_;
using Utils;

namespace Task_4_2s_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_recursion_Click(object sender, EventArgs e)
        {
            Recursion_1 f = new Recursion_1();
            int n = (f.RecurtionSumm(Convert.ToInt32(textBox_numb.Text),1));
            textBox_result.Text=Convert.ToString(n);
            textBox_steps.Lines = IOUtils.ConvertToStringArr_str(f.Lines);
        }
    }
}
