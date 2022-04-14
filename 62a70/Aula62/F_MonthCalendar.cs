using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62
{
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_pegardata_Click(object sender, EventArgs e)
        {
            tb_data1.Text = mcal_calendario.SelectionStart.ToShortDateString();
            tb_data2.Text = mcal_calendario.SelectionEnd.ToShortDateString();
            tb_datahoje.Text = mcal_calendario.TodayDate.ToShortDateString();
        }

        private void mcal_calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_data1.Text = mcal_calendario.SelectionStart.ToShortDateString();
            tb_data2.Text = mcal_calendario.SelectionEnd.ToShortDateString();
            tb_datahoje.Text = mcal_calendario.TodayDate.ToShortDateString();
        }
    }
}
