﻿using CapsuleCorpCoffeeBUS.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using CapsuleCorpCoffeeBUS;
using System;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormAvaliacao : Form
    {
        #region Propriedades, Variáveis e Atributos

        private AvaliacaoBUS avaliacaoBUS;
        private Receita receita;

        #endregion

        #region Construtores
        public FormAvaliacao(Receita receita)
        {
            InitializeComponent();

            this.avaliacaoBUS = FactoryBUS.CreateAvaliacaoBUS();
            this.receita = receita;

            lblReceita.Text += $" {receita.Descricao}";
            cmbNota.SelectedIndex = 0;
        }
        #endregion

        #region Eventos
        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            Avaliacao avaliacao = ConstruirObjeto();

            if (avaliacaoBUS.ValidarCampos(avaliacao))
            {
                if (avaliacaoBUS.Salvar(avaliacao))
                    MessageBox.Show("Sua avaliação foi salva com sucesso! Obrigado!", "Sucesso");
                else
                    MessageBox.Show("Erro ao salvar avaliação. Obrigado pela atenção.", "Finalizado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor validar os campos e tentar novamente.", "Campos Inválidos");
                return;
            }
        }
        #endregion

        #region Métodos
        private Avaliacao ConstruirObjeto()
        {
            Avaliacao avaliacao = new Avaliacao();

            int.TryParse(cmbNota.Text.ToString(), out int nota);

            avaliacao.Nota = nota;
            avaliacao.Receita = receita.ID;
            avaliacao.Usuario = txtUsuario.Text.ToString().Trim();
            avaliacao.Comentario = txtComentario.Text.ToString().Trim();

            return avaliacao;
        }

        #endregion
    }
}
