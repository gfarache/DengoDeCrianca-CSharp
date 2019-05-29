namespace DengoDeCrianca
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orcamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criançaToolStripMenuItem,
            this.orcamentoToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.historicoToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criançaToolStripMenuItem
            // 
            this.criançaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.criançaToolStripMenuItem.Name = "criançaToolStripMenuItem";
            this.criançaToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.criançaToolStripMenuItem.Text = "Criança";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // orcamentoToolStripMenuItem
            // 
            this.orcamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarOrçamentoToolStripMenuItem});
            this.orcamentoToolStripMenuItem.Name = "orcamentoToolStripMenuItem";
            this.orcamentoToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.orcamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // gerarOrçamentoToolStripMenuItem
            // 
            this.gerarOrçamentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarOrçamentoToolStripMenuItem.Name = "gerarOrçamentoToolStripMenuItem";
            this.gerarOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gerarOrçamentoToolStripMenuItem.Text = "Gerar Orçamento";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.relatorioToolStripMenuItem.Text = "Relatório";
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.historicoToolStripMenuItem.Text = "Histórico";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 300);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Dengo de Criança";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orcamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarOrçamentoToolStripMenuItem;
    }
}

