
namespace Aula62
{
    partial class F_NumericUpDown
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
            this.nud_valor = new System.Windows.Forms.NumericUpDown();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_definirvalor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_valor
            // 
            this.nud_valor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_valor.Location = new System.Drawing.Point(13, 13);
            this.nud_valor.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_valor.Name = "nud_valor";
            this.nud_valor.Size = new System.Drawing.Size(120, 20);
            this.nud_valor.TabIndex = 0;
            this.nud_valor.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(140, 12);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 1;
            this.tb_valor.Text = "0";
            // 
            // btn_definirvalor
            // 
            this.btn_definirvalor.Location = new System.Drawing.Point(246, 9);
            this.btn_definirvalor.Name = "btn_definirvalor";
            this.btn_definirvalor.Size = new System.Drawing.Size(75, 23);
            this.btn_definirvalor.TabIndex = 2;
            this.btn_definirvalor.Text = "Definir valor";
            this.btn_definirvalor.UseVisualStyleBackColor = true;
            this.btn_definirvalor.Click += new System.EventHandler(this.btn_definirvalor_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 219);
            this.Controls.Add(this.btn_definirvalor);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.nud_valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeric Up Down";
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_valor;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_definirvalor;
    }
}