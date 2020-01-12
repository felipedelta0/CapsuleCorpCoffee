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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.capsulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCapsulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarReceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTiposCapsulas = new System.Windows.Forms.Button();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capsulasToolStripMenuItem,
            this.receitasToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
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
            this.tiposDeCapsulasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiposDeCapsulasToolStripMenuItem.Text = "Tipos de Cápsulas";
            this.tiposDeCapsulasToolStripMenuItem.Click += new System.EventHandler(this.tiposDeCapsulasToolStripMenuItem_Click);
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarReceitaToolStripMenuItem});
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.receitasToolStripMenuItem.Text = "Receitas";
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
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            this.gerenciarToolStripMenuItem.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnTiposCapsulas
            // 
            this.btnTiposCapsulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposCapsulas.Location = new System.Drawing.Point(12, 27);
            this.btnTiposCapsulas.Name = "btnTiposCapsulas";
            this.btnTiposCapsulas.Size = new System.Drawing.Size(365, 97);
            this.btnTiposCapsulas.TabIndex = 2;
            this.btnTiposCapsulas.Text = "Tipos de Cápsulas";
            this.btnTiposCapsulas.UseVisualStyleBackColor = true;
            this.btnTiposCapsulas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReceitas
            // 
            this.btnReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceitas.Location = new System.Drawing.Point(12, 130);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Size = new System.Drawing.Size(365, 97);
            this.btnReceitas.TabIndex = 3;
            this.btnReceitas.Text = "Receitas";
            this.btnReceitas.UseVisualStyleBackColor = true;
            this.btnReceitas.Click += new System.EventHandler(this.btnReceitas_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(12, 233);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(365, 97);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 341);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnReceitas);
            this.Controls.Add(this.btnTiposCapsulas);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem capsulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCapsulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarReceitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnTiposCapsulas;
        private System.Windows.Forms.Button btnReceitas;
        private System.Windows.Forms.Button btnEstoque;
    }
}

