using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormReceitas : Form
    {
        #region Construtores
        public FormReceitas()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void FormReceitas_Load(object sender, EventArgs e)
        {
            AtualizarView();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastrarReceita formEditor = new FormCadastrarReceita();

            DialogResult res = formEditor.ShowDialog();

            AtualizarView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int itemID = PegarItemID();

            if (itemID > 0)
            {
                Receita receita = new Receita(itemID);

                if (MessageBox.Show($"Tem certeza que deseja apagar a receita de {receita.Descricao}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (ReceitaItem item in receita.Items)
                        item.Excluir();

                    string receitaDesc = receita.Descricao;

                    bool exclusao = receita.Excluir();

                    if (exclusao)
                        MessageBox.Show($"Receita de {receitaDesc} excluída com sucesso!");

                    AtualizarView();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnFazer_Click(object sender, EventArgs e)
        {
            FormFazerReceita form = new FormFazerReceita();
            DialogResult retorno = form.ShowDialog();
            AtualizarView();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos
        private void AtualizarView()
        {
            int index = PegarIndexDeSelecao();

            List<Receita> receitas = new List<Receita>();
            receitas = Receita.ListarReceitas();

            MontarView(receitas);
            dgvReceitas.Rows[index].Selected = true;
        }

        private int PegarIndexDeSelecao()
        {
            return dgvReceitas.SelectedRows.Count > 0 ? (dgvReceitas.SelectedRows[0].Index > 0 ? dgvReceitas.SelectedRows[0].Index - 1 : 0) : 0;
        }

        private void MontarView(List<Receita> receitas)
        {
            dgvReceitas.Rows.Clear();

            foreach (Receita item in receitas)
            {
                double notaMedia = Avaliacao.ObterMedia(item.ID);
                dgvReceitas.Rows.Add(item.ID, item.Descricao, item.MostrarCapsulas, item.QuantidadeTotalCapsulas, notaMedia > -1 ? notaMedia.ToString("N2") : "");
            }
        }

        private int PegarItemID()
        {
            int itemID;
            Int32.TryParse(dgvReceitas.SelectedRows[0].Cells[0].Value.ToString(), out itemID);
            return itemID;
        }
        #endregion
    }
}
