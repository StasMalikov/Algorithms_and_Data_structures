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

namespace Task_2__2_semestr_
{
    public partial class Form1 : Form
    {
        List<Work_with_Files> listofElements = new List<Work_with_Files>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Work_with_Files f = new Work_with_Files(openFileDialog1.FileName);
                listofElements.Add(f);
                textBox1.Lines = f.Load_str_numb();
                openFileDialog1.Dispose();
            }
        }

        private void Load_button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Work_with_Files f = new Work_with_Files(openFileDialog1.FileName);
                listofElements.Add(f);
                textBox2.Lines = f.Load_str_numb();
                openFileDialog1.Dispose();
            }
        }

        private void Load_button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Work_with_Files f = new Work_with_Files(openFileDialog1.FileName);
                listofElements.Add(f);
                textBox3.Lines = f.Load_str_numb();
                openFileDialog1.Dispose();
            }
        }

        private void Sort_button_Click(object sender, EventArgs e)
        {
            Combine_elements s=new Combine_elements(listofElements);
            result_textBox.Lines = IOUtils.ConvertToStringArr(s.SummArrs());
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
          {
              Work_with_Files f = new Work_with_Files();
            f.SaveIntArr(result_textBox.Lines,saveFileDialog1.FileName);
           }
        }

        

       
    }
}
