namespace CapsuleCorpCoffee.Forms
{
    partial class FormCapsulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapsulas));
            this.dgvCapsulas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForça = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapsulas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCapsulas
            // 
            this.dgvCapsulas.AllowUserToAddRows = false;
            this.dgvCapsulas.AllowUserToDeleteRows = false;
            this.dgvCapsulas.AllowUserToOrderColumns = true;
            this.dgvCapsulas.AllowUserToResizeRows = false;
            this.dgvCapsulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapsulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapsulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescricao,
            this.colForça});
            this.dgvCapsulas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCapsulas.Location = new System.Drawing.Point(12, 12);
            this.dgvCapsulas.MultiSelect = false;
            this.dgvCapsulas.Name = "dgvCapsulas";
            this.dgvCapsulas.ReadOnly = true;
            this.dgvCapsulas.RowHeadersVisible = false;
            this.dgvCapsulas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCapsulas.RowTemplate.ReadOnly = true;
            this.dgvCapsulas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCapsulas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCapsulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCapsulas.ShowCellErrors = false;
            this.dgvCapsulas.ShowCellToolTips = false;
            this.dgvCapsulas.ShowEditingIcon = false;
            this.dgvCapsulas.ShowRowErrors = false;
            this.dgvCapsulas.Size = new System.Drawing.Size(430, 241);
            this.dgvCapsulas.TabIndex = 0;
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
            // FormCapsulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 264);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvCapsulas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCapsulas";
            this.Text = "Cápsulas";
            this.Load += new System.EventHandler(this.FormCapsulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapsulas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapsulas;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForça;
    }
}