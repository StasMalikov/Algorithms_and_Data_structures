using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Business_logic_3_;
using Utils;

namespace Std1
{
    public partial class Form1 : Form
    {

        // private DataGridView Datagrid = new DataGridView();

        private void Form1_Load(object sender, EventArgs e)
        {
           // DataGridViewUtils.InitGridForArr(DGV_data, 50, true, true, true, true, true);
            //DGV_data.RowCount = 1;
            //dataGrid.Rows[0].Cells[0].Value = 12;
            //dataGrid.ColumnCount = 5;
            //dataGrid.Columns.Add("FIO", "FIO");
            //dataGrid.Columns["adr"].Width = 200;

            //dataGrid.Columns.Add("DateTime", "DateTime");
            //dataGrid.Columns["DateTime"].Width = 50;

            //dataGrid.Columns.Add("Kurs", "Kurs");
            //dataGrid.Columns["Kurs"].Width = 30;

            //dataGrid.Columns.Add("Group", "Group");
            //dataGrid.Columns["Group"].Width = 30;

            //dataGrid.Columns.Add("Marks", "Marks");
            //dataGrid.Columns["Marks"].Width = 300;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            Random_Student rnd = new Random_Student();
            rnd.Randomstd(Convert.ToInt32( textBox_numOfStd.Text));
        }
    }
}
