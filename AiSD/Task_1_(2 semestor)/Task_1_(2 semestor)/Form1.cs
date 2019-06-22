using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_logic_3_;


namespace Task_1__2_semestor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_LoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Work_with_Files_task_1 f = new Work_with_Files_task_1(openFileDialog1.FileName);
               textBox_ShowText.Lines = f.Lines;
                openFileDialog1.Dispose();
            }
        }

        private void button_FindParagraph_Click(object sender, EventArgs e)
        {
            Work_with_Files_task_1 p = new Work_with_Files_task_1(openFileDialog1.FileName);
            label_paragraph.Text = Convert.ToString(p.Find_paragraph());
        }
    }
}
