using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormAvaliacao : Form
    {
        public Avaliacao Avaliacao;

        public FormAvaliacao(Receita receita)
        {
            InitializeComponent();
            Avaliacao = new Avaliacao();
            Avaliacao.Receita = receita.ID;
            lblReceita.Text += receita.Descricao;
        }

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
    }
}
