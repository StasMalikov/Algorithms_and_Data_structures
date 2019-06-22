using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_logic_3_;

namespace Task_6
{
    public partial class Task6_Form : Form
    {
        Business_logic_3_.
        MyQueue Q = new MyQueue();
        public Task6_Form()
        {
            InitializeComponent();
        }

        private void Read_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Work_with_Files f = new Work_with_Files(openFileDialog1.FileName);
                Q.InitQueue(f.IntLines.ToArray());
                Data_textbox.Lines = Q.GetstringQueue(Q);
                openFileDialog1.Dispose();
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Data_textbox.Clear();
            Result_textbox.Clear();
            Q.ClearQueue(Q);
        }

        private void Sort_btn_Click(object sender, EventArgs e)
        {
            Q.SortSame();
            Result_textbox.Lines = Q.GetstringQueue(Q);
        }
    }
}
