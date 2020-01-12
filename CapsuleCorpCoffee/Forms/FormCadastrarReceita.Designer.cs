namespace CapsuleCorpCoffee.Forms
{
    partial class FormCadastrarReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarReceita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuantidadeItens = new System.Windows.Forms.ComboBox();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowControles = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEscolher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbQuantidadeItens);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnEscolher
            // 
            this.btnEscolher.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEscolher.Location = new System.Drawing.Point(191, 26);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(75, 21);
            this.btnEscolher.TabIndex = 1;
            this.btnEscolher.Text = "Pronto";
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione quantos tipos de cápsulas irão compor a receita:";
            // 
            // cmbQuantidadeItens
            // 
            this.cmbQuantidadeItens.FormattingEnabled = true;
            this.cmbQuantidadeItens.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbQuantidadeItens.Location = new System.Drawing.Point(64, 26);
            this.cmbQuantidadeItens.Name = "cmbQuantidadeItens";
            this.cmbQuantidadeItens.Size = new System.Drawing.Size(121, 21);
            this.cmbQuantidadeItens.TabIndex = 0;
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.Location = new System.Drawing.Point(110, 5);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(201, 20);
            this.txtNomeReceita.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Receita:";
            // 
            // flowControles
            // 
            this.flowControles.AutoSize = true;
            this.flowControles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowControles.BackColor = System.Drawing.SystemColors.Control;
            this.flowControles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowControles.Location = new System.Drawing.Point(3, 59);
            this.flowControles.Name = "flowControles";
            this.flowControles.Size = new System.Drawing.Size(0, 0);
            this.flowControles.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.txtNomeReceita);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Location = new System.Drawing.Point(1, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 64);
            this.panel2.TabIndex = 2;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(3, 34);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Limpar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(246, 34);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(127, 34);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastrarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowControles);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 610);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 39);
            this.Name = "FormCadastrarReceita";
            this.Text = "Cadastrar Nova Receita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbQuantidadeItens;
        private System.Windows.Forms.FlowLayoutPanel flowControles;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.Label label2;
    }
}