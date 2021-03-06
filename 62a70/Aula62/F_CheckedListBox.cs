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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            /*
            clb_transportes.Items.Add("Carro",false);
            clb_transportes.Items.Add("Avião", false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Ônibus", false);
            clb_transportes.Items.Add("Trem", false);
            */
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_adicionar.Text != "")
            {
                clb_transportes.Items.Add(tb_adicionar.Text);
                tb_adicionar.Clear();
                tb_adicionar.Focus();
            }
        }
    }
}
