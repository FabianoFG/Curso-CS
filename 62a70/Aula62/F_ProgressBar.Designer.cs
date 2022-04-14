
namespace Aula62
{
    partial class F_ProgressBar
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
            this.pb_progresso = new System.Windows.Forms.ProgressBar();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_definir = new System.Windows.Forms.Button();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_progresso
            // 
            this.pb_progresso.Location = new System.Drawing.Point(13, 184);
            this.pb_progresso.Name = "pb_progresso";
            this.pb_progresso.Size = new System.Drawing.Size(536, 23);
            this.pb_progresso.TabIndex = 0;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(13, 13);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 1;
            // 
            // btn_definir
            // 
            this.btn_definir.Location = new System.Drawing.Point(120, 9);
            this.btn_definir.Name = "btn_definir";
            this.btn_definir.Size = new System.Drawing.Size(75, 23);
            this.btn_definir.TabIndex = 2;
            this.btn_definir.Text = "Definir valor";
            this.btn_definir.UseVisualStyleBackColor = true;
            this.btn_definir.Click += new System.EventHandler(this.btn_definir_Click);
            // 
            // btn_preencher
            // 
            this.btn_preencher.Location = new System.Drawing.Point(201, 9);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(75, 23);
            this.btn_preencher.TabIndex = 3;
            this.btn_preencher.Text = "Preencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado atual: 0%";
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.btn_definir);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.pb_progresso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress Bar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_progresso;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_definir;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.Label label1;
    }
}