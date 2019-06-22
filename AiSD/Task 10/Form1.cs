using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using User_Interface;
using Business_logic_3_;

namespace Task_10
{
    public partial class Task_10_MainForm : Form
    {
        List<NodeGraph> GList = new List<NodeGraph>();
        public Task_10_MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void Task_10_MainForm_Load(object sender, EventArgs e)
        {
        }

        private void Random_btn_Click(object sender, EventArgs e) //тут есть баг с выводом последнего элемента
        {
            GList = RandomGNode.SetNotes();
            DataGridViewUtils.InitGridForArr(Inform_DGV, 40, false, true, false, true, false);
            DataGridViewUtils.GuardToDGV(GList, Inform_DGV);
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            GList = DataGridViewUtils.DGVRefreshNodeGraph(Inform_DGV,GList);
            DataGridViewUtils.GuardToDGV(GList ,Inform_DGV);
        }

        private void Check_min_btn_Click(object sender, EventArgs e)
        {
            Program.Check_Guard_Form = new Check_Guard_Form(GList);
            Program.Check_Guard_Form.Owner = this;
            Program.Check_Guard_Form.ShowDialog();

        }

        private void Draw_btn_Click(object sender, EventArgs e)
        {
            Graph g = new Graph(GList, Draw_Panel.Width, Draw_Panel.Height);
            Draw_Panel.CreateGraphics().DrawImage(g.DrawGraph(), 0, 0);
        }

        private void ShowWeight_btn_Click(object sender, EventArgs e)
        {
            Graph g = new Graph(GList, Draw_Panel.Width, Draw_Panel.Height);
            Draw_Panel.CreateGraphics().DrawImage(g.ShowWeight( g.DrawGraph()), 0, 0);
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Изменения в таблице производятся след. образом: \n" +
                "можно только добалять или удалять элементы, изменения в уже существующих " +
                "элементах не читаются. \n" +
                "2. После изменений в таблице надо нажать кнопку  ' Обновление данных'.\n " +
                "3. Смены в таблице разположены след. образом: \n" +
                "1 ячейка начало - следующая ячейка окончание смены - следущяя начало новой смены(возможно что в этот же день) и т.д." +
                "\n 4. Все смены в минутах и значения не должны превышать значение 850(иначе рисунок выйдет за края)" +
                "\n 5. Пустой квадрат означает что после окончания смены сторожа сразу его никто не сменяет."
                , "Help", MessageBoxButtons.OK);
        }
    }
}
