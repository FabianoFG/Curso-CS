
namespace Aula62
{
    partial class F_CheckedListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_selecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_adicionar = new System.Windows.Forms.TextBox();
            this.lb_titulo_novo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(120, 289);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_selecionados
            // 
            this.btn_selecionados.Location = new System.Drawing.Point(150, 12);
            this.btn_selecionados.Name = "btn_selecionados";
            this.btn_selecionados.Size = new System.Drawing.Size(136, 23);
            this.btn_selecionados.TabIndex = 1;
            this.btn_selecionados.Text = "Mostrar selecionados";
            this.btn_selecionados.UseVisualStyleBackColor = true;
            this.btn_selecionados.Click += new System.EventHandler(this.btn_selecionados_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(150, 42);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(136, 23);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar lista";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(150, 72);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(136, 23);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar lista";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(150, 158);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(136, 23);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar transporte";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_adicionar
            // 
            this.tb_adicionar.Location = new System.Drawing.Point(150, 132);
            this.tb_adicionar.Name = "tb_adicionar";
            this.tb_adicionar.Size = new System.Drawing.Size(136, 20);
            this.tb_adicionar.TabIndex = 5;
            // 
            // lb_titulo_novo
            // 
            this.lb_titulo_novo.AutoSize = true;
            this.lb_titulo_novo.Location = new System.Drawing.Point(147, 116);
            this.lb_titulo_novo.Name = "lb_titulo_novo";
            this.lb_titulo_novo.Size = new System.Drawing.Size(132, 13);
            this.lb_titulo_novo.TabIndex = 6;
            this.lb_titulo_novo.Text = "Escreva o novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 312);
            this.Controls.Add(this.lb_titulo_novo);
            this.Controls.Add(this.tb_adicionar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_selecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_selecionados;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_adicionar;
        private System.Windows.Forms.Label lb_titulo_novo;
    }
}