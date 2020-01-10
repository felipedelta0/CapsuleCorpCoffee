namespace CapsuleCorpCoffee
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConexao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.capsulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCapsulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerReceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarReceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConexao
            // 
            this.btnConexao.Location = new System.Drawing.Point(657, 411);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Size = new System.Drawing.Size(142, 38);
            this.btnConexao.TabIndex = 0;
            this.btnConexao.Text = "Testar Conexão";
            this.btnConexao.UseVisualStyleBackColor = true;
            this.btnConexao.Click += new System.EventHandler(this.btnConexao_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capsulasToolStripMenuItem,
            this.receitasToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // capsulasToolStripMenuItem
            // 
            this.capsulasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeCapsulasToolStripMenuItem});
            this.capsulasToolStripMenuItem.Name = "capsulasToolStripMenuItem";
            this.capsulasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.capsulasToolStripMenuItem.Text = "Cápsulas";
            // 
            // tiposDeCapsulasToolStripMenuItem
            // 
            this.tiposDeCapsulasToolStripMenuItem.Name = "tiposDeCapsulasToolStripMenuItem";
            this.tiposDeCapsulasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tiposDeCapsulasToolStripMenuItem.Text = "Tipos de Cápsulas";
            this.tiposDeCapsulasToolStripMenuItem.Click += new System.EventHandler(this.tiposDeCapsulasToolStripMenuItem_Click);
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerReceitaToolStripMenuItem,
            this.cadastrarReceitaToolStripMenuItem});
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.receitasToolStripMenuItem.Text = "Receitas";
            // 
            // fazerReceitaToolStripMenuItem
            // 
            this.fazerReceitaToolStripMenuItem.Name = "fazerReceitaToolStripMenuItem";
            this.fazerReceitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fazerReceitaToolStripMenuItem.Text = "Fazer Receita";
            this.fazerReceitaToolStripMenuItem.Click += new System.EventHandler(this.fazerReceitaToolStripMenuItem_Click);
            // 
            // cadastrarReceitaToolStripMenuItem
            // 
            this.cadastrarReceitaToolStripMenuItem.Name = "cadastrarReceitaToolStripMenuItem";
            this.cadastrarReceitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarReceitaToolStripMenuItem.Text = "Criar Receita";
            this.cadastrarReceitaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarReceitaToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            this.gerenciarToolStripMenuItem.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConexao);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Capsule Corp Coffee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConexao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem capsulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCapsulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerReceitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarReceitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

