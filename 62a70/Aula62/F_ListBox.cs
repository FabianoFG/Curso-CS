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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;
        }

        private void AtualizaLB(ListBox lb,List<string>l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um modelo de carro!");
                tb_carro.Focus();
            }
            else
            {
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                tb_carro.Focus();
                AtualizaLB(lb_carros, carros);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            AtualizaLB(lb_carros, carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            if (carros.Count > 0)
            {
                tb_carro.Text = carros[lb_carros.SelectedIndex];
            }
            else
            {
                MessageBox.Show("Não há carros para obter!");
            }
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AtualizaLB(lb_carros, carros);
        }
    }
}
