using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormAvaliacao : Form
    {
        #region Propriedades, Variáveis e Atributos
        public Avaliacao Avaliacao;
        #endregion

        #region Construtores
        public FormAvaliacao(Receita receita)
        {
            InitializeComponent();
            Avaliacao = new Avaliacao();
            Avaliacao.Receita = receita.ID;
            lblReceita.Text += receita.Descricao;
        }
        #endregion

        #region Eventos
        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            int nota;
            Int32.TryParse(cmbNota.Text.ToString(), out nota);
            Avaliacao.Nota = nota;
            Avaliacao.Usuario = txtUsuario.Text.ToString().Trim();
            Avaliacao.Comentario = txtComentario.Text.ToString().Trim();

            if (ValidarCampos())
            {
                Avaliacao.Salvar();
                MessageBox.Show("Sua avaliação foi salva com sucesso! Obrigado!", "Sucesso");
                this.Close();
            }
        }
        #endregion

        #region Métodos
        private bool ValidarCampos()
        {
            if (Avaliacao.Nota < 1 || Avaliacao.Nota > 5)
            {
                MessageBox.Show("Nota Inválida.", "Erro");
                return false;
            }

            if (Avaliacao.Receita < 0)
            {
                MessageBox.Show("Receita Inválida.", "Erro");
                return false;
            }

            return true;
        }
        #endregion
    }
}
