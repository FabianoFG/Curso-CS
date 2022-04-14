
namespace Aula62
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.tb_lista_veiculos = new System.Windows.Forms.TextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_ValorNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedlistboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datetimepickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linklabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedtextboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthcalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericupdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiobuttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nicon_1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.treeviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(218, 47);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_veiculo.Location = new System.Drawing.Point(12, 47);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(200, 26);
            this.tb_veiculo.TabIndex = 1;
            // 
            // tb_lista_veiculos
            // 
            this.tb_lista_veiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lista_veiculos.Location = new System.Drawing.Point(12, 79);
            this.tb_lista_veiculos.Multiline = true;
            this.tb_lista_veiculos.Name = "tb_lista_veiculos";
            this.tb_lista_veiculos.ReadOnly = true;
            this.tb_lista_veiculos.Size = new System.Drawing.Size(281, 200);
            this.tb_lista_veiculos.TabIndex = 2;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(12, 24);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(174, 17);
            this.lb_titulo.TabIndex = 3;
            this.lb_titulo.Text = "Digite um nome de veículo";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(12, 285);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(280, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(15, 315);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(277, 23);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar Veículos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_ValorNum
            // 
            this.btn_ValorNum.Location = new System.Drawing.Point(15, 345);
            this.btn_ValorNum.Name = "btn_ValorNum";
            this.btn_ValorNum.Size = new System.Drawing.Size(277, 23);
            this.btn_ValorNum.TabIndex = 6;
            this.btn_ValorNum.Text = "Valor Var Num";
            this.btn_ValorNum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ValorNum.UseVisualStyleBackColor = true;
            this.btn_ValorNum.Click += new System.EventHandler(this.btn_ValorNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedlistboxToolStripMenuItem,
            this.comboboxToolStripMenuItem,
            this.datetimepickerToolStripMenuItem,
            this.linklabelToolStripMenuItem,
            this.listboxToolStripMenuItem,
            this.listviewToolStripMenuItem,
            this.maskedtextboxToolStripMenuItem,
            this.monthcalendarToolStripMenuItem,
            this.numericupdownToolStripMenuItem,
            this.pictureboxToolStripMenuItem,
            this.progressbarToolStripMenuItem,
            this.radiobuttonToolStripMenuItem,
            this.treeviewToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedlistboxToolStripMenuItem
            // 
            this.checkedlistboxToolStripMenuItem.Name = "checkedlistboxToolStripMenuItem";
            this.checkedlistboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedlistboxToolStripMenuItem.Text = "Checkedlistbox";
            this.checkedlistboxToolStripMenuItem.Click += new System.EventHandler(this.checkedlistboxToolStripMenuItem_Click);
            // 
            // comboboxToolStripMenuItem
            // 
            this.comboboxToolStripMenuItem.Name = "comboboxToolStripMenuItem";
            this.comboboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboboxToolStripMenuItem.Text = "Combobox";
            this.comboboxToolStripMenuItem.Click += new System.EventHandler(this.comboboxToolStripMenuItem_Click);
            // 
            // datetimepickerToolStripMenuItem
            // 
            this.datetimepickerToolStripMenuItem.Name = "datetimepickerToolStripMenuItem";
            this.datetimepickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datetimepickerToolStripMenuItem.Text = "Datetimepicker";
            this.datetimepickerToolStripMenuItem.Click += new System.EventHandler(this.datetimepickerToolStripMenuItem_Click);
            // 
            // linklabelToolStripMenuItem
            // 
            this.linklabelToolStripMenuItem.Name = "linklabelToolStripMenuItem";
            this.linklabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linklabelToolStripMenuItem.Text = "Linklabel";
            this.linklabelToolStripMenuItem.Click += new System.EventHandler(this.linklabelToolStripMenuItem_Click);
            // 
            // listboxToolStripMenuItem
            // 
            this.listboxToolStripMenuItem.Name = "listboxToolStripMenuItem";
            this.listboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listboxToolStripMenuItem.Text = "Listbox";
            this.listboxToolStripMenuItem.Click += new System.EventHandler(this.listboxToolStripMenuItem_Click);
            // 
            // listviewToolStripMenuItem
            // 
            this.listviewToolStripMenuItem.Name = "listviewToolStripMenuItem";
            this.listviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listviewToolStripMenuItem.Text = "Listview";
            this.listviewToolStripMenuItem.Click += new System.EventHandler(this.listviewToolStripMenuItem_Click);
            // 
            // maskedtextboxToolStripMenuItem
            // 
            this.maskedtextboxToolStripMenuItem.Name = "maskedtextboxToolStripMenuItem";
            this.maskedtextboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedtextboxToolStripMenuItem.Text = "Maskedtextbox";
            this.maskedtextboxToolStripMenuItem.Click += new System.EventHandler(this.maskedtextboxToolStripMenuItem_Click);
            // 
            // monthcalendarToolStripMenuItem
            // 
            this.monthcalendarToolStripMenuItem.Name = "monthcalendarToolStripMenuItem";
            this.monthcalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthcalendarToolStripMenuItem.Text = "Monthcalendar";
            this.monthcalendarToolStripMenuItem.Click += new System.EventHandler(this.monthcalendarToolStripMenuItem_Click);
            // 
            // numericupdownToolStripMenuItem
            // 
            this.numericupdownToolStripMenuItem.Name = "numericupdownToolStripMenuItem";
            this.numericupdownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numericupdownToolStripMenuItem.Text = "Numericupdown";
            this.numericupdownToolStripMenuItem.Click += new System.EventHandler(this.numericupdownToolStripMenuItem_Click);
            // 
            // pictureboxToolStripMenuItem
            // 
            this.pictureboxToolStripMenuItem.Name = "pictureboxToolStripMenuItem";
            this.pictureboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureboxToolStripMenuItem.Text = "Picturebox";
            this.pictureboxToolStripMenuItem.Click += new System.EventHandler(this.pictureboxToolStripMenuItem_Click);
            // 
            // progressbarToolStripMenuItem
            // 
            this.progressbarToolStripMenuItem.Name = "progressbarToolStripMenuItem";
            this.progressbarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progressbarToolStripMenuItem.Text = "Progressbar";
            this.progressbarToolStripMenuItem.Click += new System.EventHandler(this.progressbarToolStripMenuItem_Click);
            // 
            // radiobuttonToolStripMenuItem
            // 
            this.radiobuttonToolStripMenuItem.Name = "radiobuttonToolStripMenuItem";
            this.radiobuttonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radiobuttonToolStripMenuItem.Text = "Radiobutton";
            this.radiobuttonToolStripMenuItem.Click += new System.EventHandler(this.radiobuttonToolStripMenuItem_Click);
            // 
            // nicon_1
            // 
            this.nicon_1.ContextMenuStrip = this.MenuNotificacoes;
            this.nicon_1.Icon = ((System.Drawing.Icon)(resources.GetObject("nicon_1.Icon")));
            this.nicon_1.Text = "Curso CS";
            this.nicon_1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_restaurar,
            this.tsmi_mensagem,
            this.tsmi_fechar});
            this.MenuNotificacoes.Name = "MenuNotificacoes";
            this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // tsmi_restaurar
            // 
            this.tsmi_restaurar.Name = "tsmi_restaurar";
            this.tsmi_restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_restaurar.Text = "Restaurar";
            // 
            // tsmi_mensagem
            // 
            this.tsmi_mensagem.Name = "tsmi_mensagem";
            this.tsmi_mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmi_mensagem.Text = "Mensagem";
            // 
            // tsmi_fechar
            // 
            this.tsmi_fechar.Name = "tsmi_fechar";
            this.tsmi_fechar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_fechar.Text = "Fechar";
            // 
            // treeviewToolStripMenuItem
            // 
            this.treeviewToolStripMenuItem.Name = "treeviewToolStripMenuItem";
            this.treeviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.treeviewToolStripMenuItem.Text = "Treeview";
            this.treeviewToolStripMenuItem.Click += new System.EventHandler(this.treeviewToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 384);
            this.Controls.Add(this.btn_ValorNum);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.tb_lista_veiculos);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula62 - Componentes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_ValorNum;
        public System.Windows.Forms.TextBox tb_lista_veiculos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedlistboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datetimepickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linklabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedtextboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthcalendarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon nicon_1;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mensagem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fechar;
        private System.Windows.Forms.ToolStripMenuItem numericupdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiobuttonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeviewToolStripMenuItem;
    }
}

