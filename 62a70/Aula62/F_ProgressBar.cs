using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Aula62
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb_valor.Text)>=pb_progresso.Minimum & int.Parse(tb_valor.Text)<=pb_progresso.Maximum)
            {
                pb_progresso.Value = int.Parse(tb_valor.Text);
            }
            
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            pb_progresso.Value = 0;
            for (int i=0;i<=pb_progresso.Maximum;i++)
            {
                pb_progresso.Value = i;
                Thread.Sleep(200);
                label1.Text = "Estado atual: "+ i.ToString() + "%";
                label1.Update();
            }
        }
    }
}
