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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_definirvalor_Click(object sender, EventArgs e)
        {            
            if (Decimal.Parse(tb_valor.Text)>=nud_valor.Minimum && Decimal.Parse(tb_valor.Text)<=nud_valor.Maximum)
            {
                nud_valor.Value = Decimal.Parse(tb_valor.Text);
            }
            else
            {
                MessageBox.Show("O valor deve ser entre " + nud_valor.Minimum + " e "+ nud_valor.Maximum + "!");
            }
            
        }
    }
}
