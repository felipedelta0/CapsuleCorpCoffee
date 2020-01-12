namespace CapsuleCorpCoffee.Forms
{
    partial class FormReceitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceitas));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiposCapsulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeCapsulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFazer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receitas Cadastradas";
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.AllowUserToAddRows = false;
            this.dgvReceitas.AllowUserToDeleteRows = false;
            this.dgvReceitas.AllowUserToOrderColumns = true;
            this.dgvReceitas.AllowUserToResizeRows = false;
            this.dgvReceitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.coLReceita,
            this.colTiposCapsulas,
            this.colQuantidadeCapsulas});
            this.dgvReceitas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReceitas.Location = new System.Drawing.Point(16, 32);
            this.dgvReceitas.MultiSelect = false;
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.ReadOnly = true;
            this.dgvReceitas.RowHeadersVisible = false;
            this.dgvReceitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvReceitas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReceitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceitas.ShowCellErrors = false;
            this.dgvReceitas.ShowCellToolTips = false;
            this.dgvReceitas.ShowEditingIcon = false;
            this.dgvReceitas.ShowRowErrors = false;
            this.dgvReceitas.Size = new System.Drawing.Size(555, 252);
            this.dgvReceitas.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // coLReceita
            // 
            this.coLReceita.HeaderText = "Receita";
            this.coLReceita.Name = "coLReceita";
            this.coLReceita.ReadOnly = true;
            // 
            // colTiposCapsulas
            // 
            this.colTiposCapsulas.HeaderText = "Tipos Cápsulas";
            this.colTiposCapsulas.Name = "colTiposCapsulas";
            this.colTiposCapsulas.ReadOnly = true;
            // 
            // colQuantidadeCapsulas
            // 
            this.colQuantidadeCapsulas.HeaderText = "Quantidade Cápsulas";
            this.colQuantidadeCapsulas.Name = "colQuantidadeCapsulas";
            this.colQuantidadeCapsulas.ReadOnly = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(586, 109);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(586, 138);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(586, 261);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFazer
            // 
            this.btnFazer.Location = new System.Drawing.Point(586, 32);
            this.btnFazer.Name = "btnFazer";
            this.btnFazer.Size = new System.Drawing.Size(75, 23);
            this.btnFazer.TabIndex = 6;
            this.btnFazer.Text = "Fazer";
            this.btnFazer.UseVisualStyleBackColor = true;
            this.btnFazer.Click += new System.EventHandler(this.btnFazer_Click);
            // 
            // FormReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 298);
            this.Controls.Add(this.btnFazer);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvReceitas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReceitas";
            this.Text = "Gerenciar Receitas";
            this.Load += new System.EventHandler(this.FormReceitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiposCapsulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeCapsulas;
        private System.Windows.Forms.Button btnFazer;
    }
}