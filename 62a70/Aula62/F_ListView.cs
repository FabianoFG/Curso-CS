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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }
                
        private void Limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_quantidade.Clear();
            tb_preco.Clear();
            tb_id.Focus();
        }

        private void Obter()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_quantidade.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            Obter();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            string[] pr = new string[4];

            if (tb_id.Text == "")
            {
                MessageBox.Show("O campo ID não pode ficar vazio!");
                tb_id.Focus();
                return;
            }else if (tb_produto.Text == "")
            {
                MessageBox.Show("O campo produto não pode ficar vazio!");
                tb_produto.Focus();
                return;
            }
            else if (tb_quantidade.Text == "")
            {
                MessageBox.Show("O campo quantidade não pode ficar vazio!");
                tb_quantidade.Focus();
                return;
            }
            else if (tb_preco.Text == "")
            {
                MessageBox.Show("O campo preço não pode ficar vazio!");
                tb_preco.Focus();
                return;
            }

            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_quantidade.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem(pr);

            lv_produtos.Items.Add(l);

            Limpar();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (lv_produtos.SelectedIndices.Count>0)
            {
                lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Selecione um item a a ser removido.");
            }
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_produtos.SelectedItems.Count > 0)
            {
                Obter();
            }
        }
    }
}
