
namespace Aula62
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nó2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Nó7");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Nó3", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Nó5");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Nó6");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Nó4", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Nó0", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode13,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Nó9");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Nó8", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Nó1", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            this.tv_itens = new System.Windows.Forms.TreeView();
            this.btn_novaRaiz = new System.Windows.Forms.Button();
            this.btn_novoFilho = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.tb_raiz = new System.Windows.Forms.TextBox();
            this.tb_filho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tv_itens
            // 
            this.tv_itens.Location = new System.Drawing.Point(13, 13);
            this.tv_itens.Name = "tv_itens";
            treeNode11.Name = "Nó2";
            treeNode11.Text = "Nó2";
            treeNode12.Name = "Nó7";
            treeNode12.Text = "Nó7";
            treeNode13.Name = "Nó3";
            treeNode13.Text = "Nó3";
            treeNode14.Name = "Nó5";
            treeNode14.Text = "Nó5";
            treeNode15.Name = "Nó6";
            treeNode15.Text = "Nó6";
            treeNode16.Name = "Nó4";
            treeNode16.Text = "Nó4";
            treeNode17.Name = "Nó0";
            treeNode17.Text = "Nó0";
            treeNode18.Name = "Nó9";
            treeNode18.Text = "Nó9";
            treeNode19.Name = "Nó8";
            treeNode19.Text = "Nó8";
            treeNode20.Name = "Nó1";
            treeNode20.Text = "Nó1";
            this.tv_itens.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode20});
            this.tv_itens.Size = new System.Drawing.Size(157, 236);
            this.tv_itens.TabIndex = 0;
            // 
            // btn_novaRaiz
            // 
            this.btn_novaRaiz.Location = new System.Drawing.Point(177, 13);
            this.btn_novaRaiz.Name = "btn_novaRaiz";
            this.btn_novaRaiz.Size = new System.Drawing.Size(107, 23);
            this.btn_novaRaiz.TabIndex = 1;
            this.btn_novaRaiz.Text = "Nova raiz";
            this.btn_novaRaiz.UseVisualStyleBackColor = true;
            this.btn_novaRaiz.Click += new System.EventHandler(this.btn_novaRaiz_Click);
            // 
            // btn_novoFilho
            // 
            this.btn_novoFilho.Location = new System.Drawing.Point(176, 42);
            this.btn_novoFilho.Name = "btn_novoFilho";
            this.btn_novoFilho.Size = new System.Drawing.Size(108, 23);
            this.btn_novoFilho.TabIndex = 2;
            this.btn_novoFilho.Text = "Novo filho";
            this.btn_novoFilho.UseVisualStyleBackColor = true;
            this.btn_novoFilho.Click += new System.EventHandler(this.btn_novoFilho_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(177, 72);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(107, 23);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // tb_raiz
            // 
            this.tb_raiz.Location = new System.Drawing.Point(177, 102);
            this.tb_raiz.Name = "tb_raiz";
            this.tb_raiz.Size = new System.Drawing.Size(107, 20);
            this.tb_raiz.TabIndex = 4;
            // 
            // tb_filho
            // 
            this.tb_filho.Location = new System.Drawing.Point(177, 129);
            this.tb_filho.Name = "tb_filho";
            this.tb_filho.Size = new System.Drawing.Size(107, 20);
            this.tb_filho.TabIndex = 5;
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 261);
            this.Controls.Add(this.tb_filho);
            this.Controls.Add(this.tb_raiz);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_novoFilho);
            this.Controls.Add(this.btn_novaRaiz);
            this.Controls.Add(this.tv_itens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_TreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_itens;
        private System.Windows.Forms.Button btn_novaRaiz;
        private System.Windows.Forms.Button btn_novoFilho;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox tb_raiz;
        private System.Windows.Forms.TextBox tb_filho;
    }
}