namespace CapsuleCorpCoffee.Forms
{
    partial class FormTiposCapsulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiposCapsulas));
            this.dgvTipoCapsulas = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForça = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCapsulas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoCapsulas
            // 
            this.dgvTipoCapsulas.AllowUserToAddRows = false;
            this.dgvTipoCapsulas.AllowUserToDeleteRows = false;
            this.dgvTipoCapsulas.AllowUserToOrderColumns = true;
            this.dgvTipoCapsulas.AllowUserToResizeRows = false;
            this.dgvTipoCapsulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoCapsulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCapsulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescricao,
            this.colForça});
            this.dgvTipoCapsulas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTipoCapsulas.Location = new System.Drawing.Point(12, 12);
            this.dgvTipoCapsulas.MultiSelect = false;
            this.dgvTipoCapsulas.Name = "dgvTipoCapsulas";
            this.dgvTipoCapsulas.ReadOnly = true;
            this.dgvTipoCapsulas.RowHeadersVisible = false;
            this.dgvTipoCapsulas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTipoCapsulas.RowTemplate.ReadOnly = true;
            this.dgvTipoCapsulas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoCapsulas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTipoCapsulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoCapsulas.ShowCellErrors = false;
            this.dgvTipoCapsulas.ShowCellToolTips = false;
            this.dgvTipoCapsulas.ShowEditingIcon = false;
            this.dgvTipoCapsulas.ShowRowErrors = false;
            this.dgvTipoCapsulas.Size = new System.Drawing.Size(430, 241);
            this.dgvTipoCapsulas.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(448, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(448, 41);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(448, 230);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Cápsula";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colForça
            // 
            this.colForça.HeaderText = "Força Da Bebida";
            this.colForça.Name = "colForça";
            this.colForça.ReadOnly = true;
            // 
            // FormTiposCapsulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 264);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvTipoCapsulas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTiposCapsulas";
            this.Text = "Tipos de Cápsulas";
            this.Load += new System.EventHandler(this.TiposCapsulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCapsulas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoCapsulas;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForça;
    }
}