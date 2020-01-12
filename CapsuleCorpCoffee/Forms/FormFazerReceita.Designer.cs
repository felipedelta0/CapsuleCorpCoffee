namespace CapsuleCorpCoffee.Forms
{
    partial class FormFazerReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFazerReceita));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReceitas = new System.Windows.Forms.ComboBox();
            this.cmbQuantidade = new System.Windows.Forms.ComboBox();
            this.btnFazer = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receita para Fazer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de Xícaras:";
            // 
            // cmbReceitas
            // 
            this.cmbReceitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceitas.FormattingEnabled = true;
            this.cmbReceitas.Location = new System.Drawing.Point(162, 12);
            this.cmbReceitas.Name = "cmbReceitas";
            this.cmbReceitas.Size = new System.Drawing.Size(161, 21);
            this.cmbReceitas.TabIndex = 0;
            // 
            // cmbQuantidade
            // 
            this.cmbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantidade.FormattingEnabled = true;
            this.cmbQuantidade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQuantidade.Location = new System.Drawing.Point(162, 48);
            this.cmbQuantidade.Name = "cmbQuantidade";
            this.cmbQuantidade.Size = new System.Drawing.Size(78, 21);
            this.cmbQuantidade.TabIndex = 1;
            // 
            // btnFazer
            // 
            this.btnFazer.Location = new System.Drawing.Point(95, 103);
            this.btnFazer.Name = "btnFazer";
            this.btnFazer.Size = new System.Drawing.Size(75, 23);
            this.btnFazer.TabIndex = 2;
            this.btnFazer.Text = "Fazer";
            this.btnFazer.UseVisualStyleBackColor = true;
            this.btnFazer.Click += new System.EventHandler(this.btnFazer_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(179, 103);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormFazerReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 138);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFazer);
            this.Controls.Add(this.cmbQuantidade);
            this.Controls.Add(this.cmbReceitas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFazerReceita";
            this.Text = "FormFazerReceita";
            this.Load += new System.EventHandler(this.FormFazerReceita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbReceitas;
        private System.Windows.Forms.ComboBox cmbQuantidade;
        private System.Windows.Forms.Button btnFazer;
        private System.Windows.Forms.Button btnSair;
    }
}