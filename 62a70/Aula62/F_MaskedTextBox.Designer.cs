
namespace Aula62
{
    partial class F_MaskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.cb_sotexto = new System.Windows.Forms.CheckBox();
            this.cb_mostrarsenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(12, 25);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(100, 20);
            this.mtb_senha.TabIndex = 0;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Location = new System.Drawing.Point(12, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(38, 13);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Senha";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Location = new System.Drawing.Point(12, 52);
            this.mtb_cep.Mask = "00000-000";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(100, 20);
            this.mtb_cep.TabIndex = 2;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(12, 79);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(100, 20);
            this.mtb_cpf.TabIndex = 3;
            this.mtb_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(213, 79);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // cb_sotexto
            // 
            this.cb_sotexto.AutoSize = true;
            this.cb_sotexto.Location = new System.Drawing.Point(119, 81);
            this.cb_sotexto.Name = "cb_sotexto";
            this.cb_sotexto.Size = new System.Drawing.Size(94, 17);
            this.cb_sotexto.TabIndex = 5;
            this.cb_sotexto.Text = "Somente texto";
            this.cb_sotexto.UseVisualStyleBackColor = true;
            // 
            // cb_mostrarsenha
            // 
            this.cb_mostrarsenha.AutoSize = true;
            this.cb_mostrarsenha.Location = new System.Drawing.Point(118, 27);
            this.cb_mostrarsenha.Name = "cb_mostrarsenha";
            this.cb_mostrarsenha.Size = new System.Drawing.Size(93, 17);
            this.cb_mostrarsenha.TabIndex = 6;
            this.cb_mostrarsenha.Text = "Mostrar senha";
            this.cb_mostrarsenha.UseVisualStyleBackColor = true;
            this.cb_mostrarsenha.CheckedChanged += new System.EventHandler(this.cb_mostrarsenha_CheckedChanged);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 221);
            this.Controls.Add(this.cb_mostrarsenha);
            this.Controls.Add(this.cb_sotexto);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.mtb_cep);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.mtb_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masked Text Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.CheckBox cb_sotexto;
        private System.Windows.Forms.CheckBox cb_mostrarsenha;
    }
}