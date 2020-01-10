namespace CapsuleCorpCoffee.Controles
{
    partial class ItemParaReceita
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCapsula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cápsula";
            // 
            // cmbCapsula
            // 
            this.cmbCapsula.FormattingEnabled = true;
            this.cmbCapsula.Location = new System.Drawing.Point(55, 2);
            this.cmbCapsula.Name = "cmbCapsula";
            this.cmbCapsula.Size = new System.Drawing.Size(121, 21);
            this.cmbCapsula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.HidePromptOnLeave = true;
            this.txtQuantidade.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtQuantidade.Location = new System.Drawing.Point(279, 3);
            this.txtQuantidade.Mask = "0";
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PromptChar = ' ';
            this.txtQuantidade.Size = new System.Drawing.Size(26, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.ValidatingType = typeof(int);
            // 
            // ItemParaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCapsula);
            this.Controls.Add(this.label1);
            this.Name = "ItemParaReceita";
            this.Size = new System.Drawing.Size(314, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCapsula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtQuantidade;
    }
}
