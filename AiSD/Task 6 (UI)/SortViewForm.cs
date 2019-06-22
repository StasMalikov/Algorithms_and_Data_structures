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
using System.Threading;

namespace Task_6__UI_
{
    public partial class SortViewForm : Form
    {
        public SortViewForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(Grid_Arr, 80, false, true, false, false, false);
            Grid_Arr.RowCount = 1;
            DataGridViewUtils.InitGridForArr(Grid_SortArr, 80, false, true, false, false, false);
            Grid_SortArr.RowCount = 1;
            this.WindowState = FormWindowState.Maximized;
        }

        private void SetArr_btn_Click(object sender, EventArgs e)
        {
            Program.SetArrForm = new SetArrForm();
            Program.SetArrForm.Owner = this;
            Program.SetArrForm.ShowDialog();        
        }

        private void SortArr_btn_Click(object sender, EventArgs e)
        {
            ArrSort s = new ArrSort(DataGridViewUtils.OutDGV(Grid_Arr));
            s.sort();
            DataGridViewUtils.FillDGV(Grid_SortArr,s.Arr);
        }

        private void Draw_btn_Click(object sender, EventArgs e)
        {
            SimpleDraw g = new SimpleDraw(DataGridViewUtils.OutDGV(Grid_Arr), ViewSort_panel.Width, ViewSort_panel.Height);
            g.BeginDraw();

            for (int i = 0; i < g.BitArr.Count; i++)
            {
                ViewSort_panel.CreateGraphics().DrawImage(g.BitArr[i], 0, 0);
                Thread.Sleep(650);
            } 
        }
    }
}
