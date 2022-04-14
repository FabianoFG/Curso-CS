
namespace Aula62
{
    partial class F_LinkLabel
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.ll_canal = new System.Windows.Forms.LinkLabel();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.ll_calc = new System.Windows.Forms.LinkLabel();
            this.ll_multiploslinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(13, 13);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(83, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Digite seu nome";
            // 
            // ll_canal
            // 
            this.ll_canal.AutoSize = true;
            this.ll_canal.Location = new System.Drawing.Point(16, 74);
            this.ll_canal.Name = "ll_canal";
            this.ll_canal.Size = new System.Drawing.Size(25, 13);
            this.ll_canal.TabIndex = 1;
            this.ll_canal.TabStop = true;
            this.ll_canal.Text = "Site";
            this.ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_canal_LinkClicked);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(16, 30);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // ll_calc
            // 
            this.ll_calc.AutoSize = true;
            this.ll_calc.Location = new System.Drawing.Point(53, 74);
            this.ll_calc.Name = "ll_calc";
            this.ll_calc.Size = new System.Drawing.Size(63, 13);
            this.ll_calc.TabIndex = 3;
            this.ll_calc.TabStop = true;
            this.ll_calc.Text = "Calculadora";
            this.ll_calc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calc_LinkClicked);
            // 
            // ll_multiploslinks
            // 
            this.ll_multiploslinks.AutoSize = true;
            this.ll_multiploslinks.Location = new System.Drawing.Point(16, 116);
            this.ll_multiploslinks.Name = "ll_multiploslinks";
            this.ll_multiploslinks.Size = new System.Drawing.Size(126, 13);
            this.ll_multiploslinks.TabIndex = 4;
            this.ll_multiploslinks.TabStop = true;
            this.ll_multiploslinks.Text = "Google - Canal - Youtube";
            this.ll_multiploslinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiploslinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 215);
            this.Controls.Add(this.ll_multiploslinks);
            this.Controls.Add(this.ll_calc);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.ll_canal);
            this.Controls.Add(this.lb_nome);
            this.Name = "F_LinkLabel";
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.LinkLabel ll_canal;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.LinkLabel ll_calc;
        private System.Windows.Forms.LinkLabel ll_multiploslinks;
    }
}