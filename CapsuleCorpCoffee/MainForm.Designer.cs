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
            this.btnConexao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConexao
            // 
            this.btnConexao.Location = new System.Drawing.Point(264, 153);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Size = new System.Drawing.Size(278, 115);
            this.btnConexao.TabIndex = 0;
            this.btnConexao.Text = "Testar Conexão";
            this.btnConexao.UseVisualStyleBackColor = true;
            this.btnConexao.Click += new System.EventHandler(this.btnConexao_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConexao);
            this.Name = "MainForm";
            this.Text = "Capsule Corp Coffee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConexao;
    }
}

