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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            cb_transportes.ResetText();
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            List<string> tr = new List<string>();

            cb_transportes.Items.Clear();

            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            cb_transportes.Items.AddRange(tr.ToArray());
            cb_transportes.ResetText();

        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_transporte.Text != "")
            {
                if (cb_transportes.FindString(tb_transporte.Text)<0)
                {
                    cb_transportes.Items.Add(tb_transporte.Text);
                }                
            }
        }
    }
}
