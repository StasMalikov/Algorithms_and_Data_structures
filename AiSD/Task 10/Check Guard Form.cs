using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Interface;
using Business_logic_3_;

namespace Task_10
{
    public partial class Check_Guard_Form : Form
    {
        List<NodeGraph> GList = new List<NodeGraph>();
        public Check_Guard_Form(List<NodeGraph> list)
        {
            InitializeComponent();
            GList = list;
        }

        private void Action_btn_Click(object sender, EventArgs e)
        {
                GraphFunctions g = new GraphFunctions();
                if (g.CheckGuard(GList,Convert.ToInt32(end_textBox.Text)))
                {
                    result_label.Text = "ДА";
                BadAreas_textbox.Clear();
                BadAreas_textbox.Visible = false;

            }
                else
                {
                    BadAreas_textbox.Clear();
                    result_label.Text = "НЕТ";
                    BadAreas_textbox.Visible=true;
                    BadAreas_textbox.Lines = g.DictionaryToStringArray(g.CheckBadGuardAreas
                        (GList, Convert.ToInt32(end_textBox.Text))).ToArray();
                }
        }
    }
}
