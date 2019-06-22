using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_logic_3_;


namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyQueue Q = new MyQueue();
        private void button_rndQueue_Click(object sender, EventArgs e)
        {
            
            Q=MyQueue.RandomQueue(Q);
             textBox_Queue.Lines=Q.GetstringQueue(Q);
        }

        private void button_sortQueue_Click(object sender, EventArgs e)
        {
            Q.Delete();
            textBox_SortQueue.Lines = Q.GetstringQueue(Q);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Queue.Clear();
            textBox_SortQueue.Clear();
            Q.ClearQueue(Q);
        }

        private void textBox_Queue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
