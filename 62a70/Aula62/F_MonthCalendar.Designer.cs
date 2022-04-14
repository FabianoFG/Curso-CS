
namespace Aula62
{
    partial class F_MonthCalendar
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
            this.mcal_calendario = new System.Windows.Forms.MonthCalendar();
            this.btn_pegardata = new System.Windows.Forms.Button();
            this.tb_data1 = new System.Windows.Forms.TextBox();
            this.tb_data2 = new System.Windows.Forms.TextBox();
            this.tb_datahoje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mcal_calendario
            // 
            this.mcal_calendario.Location = new System.Drawing.Point(13, 13);
            this.mcal_calendario.MaxSelectionCount = 31;
            this.mcal_calendario.Name = "mcal_calendario";
            this.mcal_calendario.TabIndex = 0;
            this.mcal_calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcal_calendario_DateChanged);
            // 
            // btn_pegardata
            // 
            this.btn_pegardata.Location = new System.Drawing.Point(253, 13);
            this.btn_pegardata.Name = "btn_pegardata";
            this.btn_pegardata.Size = new System.Drawing.Size(100, 23);
            this.btn_pegardata.TabIndex = 1;
            this.btn_pegardata.Text = "Pegar data";
            this.btn_pegardata.UseVisualStyleBackColor = true;
            this.btn_pegardata.Click += new System.EventHandler(this.btn_pegardata_Click);
            // 
            // tb_data1
            // 
            this.tb_data1.Location = new System.Drawing.Point(253, 43);
            this.tb_data1.Name = "tb_data1";
            this.tb_data1.Size = new System.Drawing.Size(100, 20);
            this.tb_data1.TabIndex = 2;
            // 
            // tb_data2
            // 
            this.tb_data2.Location = new System.Drawing.Point(253, 70);
            this.tb_data2.Name = "tb_data2";
            this.tb_data2.Size = new System.Drawing.Size(100, 20);
            this.tb_data2.TabIndex = 3;
            // 
            // tb_datahoje
            // 
            this.tb_datahoje.Location = new System.Drawing.Point(253, 97);
            this.tb_datahoje.Name = "tb_datahoje";
            this.tb_datahoje.Size = new System.Drawing.Size(100, 20);
            this.tb_datahoje.TabIndex = 4;
            // 
            // F_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 211);
            this.Controls.Add(this.tb_datahoje);
            this.Controls.Add(this.tb_data2);
            this.Controls.Add(this.tb_data1);
            this.Controls.Add(this.btn_pegardata);
            this.Controls.Add(this.mcal_calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_MonthCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Month Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcal_calendario;
        private System.Windows.Forms.Button btn_pegardata;
        private System.Windows.Forms.TextBox tb_data1;
        private System.Windows.Forms.TextBox tb_data2;
        private System.Windows.Forms.TextBox tb_datahoje;
    }
}