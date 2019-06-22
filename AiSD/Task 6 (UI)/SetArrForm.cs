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
using User_Interface;
using Utils;


namespace Task_6__UI_
{
    public partial class SetArrForm : Form
    {
        public SetArrForm()
        {
            InitializeComponent();
        }

        private void SetArr_button_Click(object sender, EventArgs e)
        {            
            SortViewForm frm = (SortViewForm)this.Owner;
            DataGridViewUtils.FillDGV(frm.Grid_Arr, ArrSort.SetRandomArr(Convert.ToInt32(ArrLength_textBox.Text)));
            Program.SetArrForm.Close();
        }
    }
}
