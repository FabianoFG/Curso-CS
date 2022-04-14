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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (cb_sotexto.Checked)
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }else
            {
                mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = mtb_cpf.Text;
            MessageBox.Show(msg);
        }

        private void cb_mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarsenha.Checked)
            {
                mtb_senha.PasswordChar ='\0';
            }
            else
            {
                mtb_senha.PasswordChar = '*';
            }
        }
    }
}
