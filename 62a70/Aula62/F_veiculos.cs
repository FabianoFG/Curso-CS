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
    public partial class F_veiculos : Form
    {
        F_Principal fp;
        public F_veiculos(string v,F_Principal f)
        {
            InitializeComponent();
            tb_lista_veiculos.Text = v;
            f.num = 10;
            fp = f;
        }

        private void F_veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_lista_veiculos.Text = tb_lista_veiculos.Text;
        }
    }
}
