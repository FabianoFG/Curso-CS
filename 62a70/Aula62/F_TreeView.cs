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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void btn_novaRaiz_Click(object sender, EventArgs e)
        {
            if (tb_raiz.Text != "")
            {
                tv_itens.Nodes.Add(tb_raiz.Text);
                tb_raiz.Clear();
            }
            else
            {
                MessageBox.Show("Digite um nome para o nó!");
            }
              
        }

        private void btn_novoFilho_Click(object sender, EventArgs e)
        {
            tv_itens.Nodes.Add(tb_filho.Text);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
