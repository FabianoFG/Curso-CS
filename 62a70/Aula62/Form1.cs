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
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um nome de veículo!");
                tb_veiculo.Focus();
                return;
            }

            tb_lista_veiculos.Text += tb_veiculo.Text + ",";
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_lista_veiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_veiculos f_veiculos = new F_veiculos(tb_lista_veiculos.Text,this);
            f_veiculos.ShowDialog();
        }

        private void btn_ValorNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkedlistboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void datetimepickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void linklabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_linklabel = new F_LinkLabel();
            f_linklabel.ShowDialog();
        }

        private void listboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_listbox = new F_ListBox();
            f_listbox.ShowDialog();
        }

        private void listviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_listview = new F_ListView();
            f_listview.ShowDialog();
        }

        private void maskedtextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_maskedtextbox = new F_MaskedTextBox();
            f_maskedtextbox.ShowDialog();
        }

        private void monthcalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_monthcalendar = new F_MonthCalendar();
            f_monthcalendar.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "tsmi_fechar")
            {
                this.Close();
            }else if (e.ClickedItem.Name.ToString() == "tsmi_restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }else if (e.ClickedItem.Name.ToString() == "tsmi_mensagem")
            {
                MessageBox.Show("Cursor de C#");
            }
        }

        private void numericupdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_numericupdown = new F_NumericUpDown();
            f_numericupdown.ShowDialog();
        }

        private void pictureboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_picturebox = new F_PictureBox();
            f_picturebox.ShowDialog();
        }

        private void progressbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_progressbar = new F_ProgressBar();
            f_progressbar.ShowDialog();
        }

        private void radiobuttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_RadioButton f_radiobutton = new F_RadioButton();
            f_radiobutton.ShowDialog();
        }

        private void treeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TreeView f_treeview = new F_TreeView();
            f_treeview.ShowDialog();
        }
    }
}
