using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MeuEditorDeTexto
{
    public partial class Form1 : Form
    {
        StringReader Leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Novo()
        {
            /*
            var titulo= "Aviso";
            var texto= "Deseja salvar o documento atual?\nAlterações não salvas serão perdidas!";
            var result=MessageBox.Show(texto,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Salvar();
            }
            */
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName,FileMode.OpenOrCreate,FileAccess.Write);
                    StreamWriter curso_streamwriter = new StreamWriter(arquivo);
                    curso_streamwriter.Flush();
                    curso_streamwriter.BaseStream.Seek(0,SeekOrigin.Begin);
                    curso_streamwriter.Write(this.richTextBox1.Text);
                    curso_streamwriter.Flush();
                    curso_streamwriter.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message,"Erro ao gravar!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.InitialDirectory = @"c://";
            //openFileDialog1.Filter = "(*.txt)|*.txt"; // pode ser definido em propriedades
            if(this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                    StreamReader curso_streamreader = new StreamReader(arquivo);
                    curso_streamreader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Clear();
                    string linha=curso_streamreader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = curso_streamreader.ReadLine();
                    }
                    curso_streamreader.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro de leitura!"+ex.Message,"Erro ao ler",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            richTextBox1.Paste();
        }
        private void Recortar()
        {
            richTextBox1.Cut();
        }
        private void Negrito()
        {
            string fonte_nome = null;
            float fonte_tamanho = 0;
            bool n,i,s = false;

            fonte_nome = richTextBox1.Font.Name;
            fonte_tamanho = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Regular);

            if (n == false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold);
                }
            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Italic);
                }
            }
        }
        private void Italico()
        {
            string fonte_nome = null;
            float fonte_tamanho = 0;
            bool n, i, s = false;

            fonte_nome = richTextBox1.Font.Name;
            fonte_tamanho = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Regular);

            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Italic | FontStyle.Bold);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold);
                }
            }
        }
        private void Sublinhado()
        {
            string fonte_nome = null;
            float fonte_tamanho = 0;
            bool n, i, s = false;

            fonte_nome = richTextBox1.Font.Name;
            fonte_tamanho = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Regular);

            if (s == false)
            {
                if (i == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Underline | FontStyle.Italic);
                }
                else if (i == false & n == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Underline);
                }
            }
            else
            {
                if (i == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Italic | FontStyle.Bold);
                }
                else if (i == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Bold);
                }
                else if (i == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(fonte_nome, fonte_tamanho, FontStyle.Italic);
                }
            }
        }
        private void AlEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void AlCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void AlJustificado()
        {
            
        }
        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            Leitura = new StringReader(texto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recortar();
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlEsquerda();
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            AlEsquerda();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlDireita();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            AlDireita();
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlCentro();
        }

        private void btn_centro_Click(object sender, EventArgs e)
        {
            AlCentro();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhas_pagina = 0;
            float posY = 0;
            int cont = 0;
            float margem_esquerda = e.MarginBounds.Left - 50;
            float margem_superior = e.MarginBounds.Top - 50;
            if (margem_esquerda > 5)
            {
                margem_esquerda = 20;
            }
            if (margem_superior > 5)
            {
                margem_superior = 20;
            }
            string linha = null;
            Font fonte = richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhas_pagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = Leitura.ReadLine();
            while (cont < linhas_pagina)
            {
                posY = margem_superior + cont * fonte.GetHeight(e.Graphics);
                e.Graphics.DrawString(linha, fonte, pincel, margem_esquerda, posY, new StringFormat());
                cont++;
                linha = Leitura.ReadLine();
            }

            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
