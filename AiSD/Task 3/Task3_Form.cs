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
using Utils;
using User_Interface;

namespace Task_3
{
    public partial class Task3_Form : Form
    {
       public List<Student> StudList = new List<Student>();
        public Task3_Form()
        {
            InitializeComponent();
        }

        private void Task3_Form_Load(object sender, EventArgs e)
        {
        }

        private void Random_btn_Click(object sender, EventArgs e)
        {
            Random_Student.RandomStd(Convert.ToInt32(RandNum_TextB.Text));
            StudList = Random_Student.RandomStd(Convert.ToInt32(RandNum_TextB.Text));
            DataGridViewUtils.ListStd_To_DGV(StudList, Student_DGV);
        }

        private void Write_btn_Click(object sender, EventArgs e)
        {
            if ((saveFileDialog1.ShowDialog() == DialogResult.OK))
            {
                BadStud s = new BadStud(StudList);
                IO_Student std = new IO_Student(openFileDialog1.FileName);
                std.Write(s.GetBadStudList());
            }
        }

        private void Read_btn_Click(object sender, EventArgs e)
        {
            if ((openFileDialog1.ShowDialog() == DialogResult.OK))
            {
                IO_Student std = new IO_Student(openFileDialog1.FileName);
                std.Read();
                StudList = std.List_Sudent;
                DataGridViewUtils.ListStd_To_DGV(StudList, Student_DGV);
            }
        }

        private void Func_btn_Click(object sender, EventArgs e)
        {
            BadStud s = new BadStud(StudList);
            DataGridViewUtils.ListStd_To_DGV(s.GetBadStudList(), Result_DGV); 
        }
    }
   
}
