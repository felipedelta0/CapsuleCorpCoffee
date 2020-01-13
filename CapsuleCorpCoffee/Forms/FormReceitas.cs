using CapsuleCorpCoffee.Camadas;
using CapsuleCorpCoffee.Camadas.Business;
using CapsuleCorpCoffee.Camadas.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormReceitas : Form
    {
        #region Propriedades, Variáveis e Atributos

        private ReceitaBUS receitaBUS;
        private CapsulaReceitaBUS capsulaReceitaBUS;

        #endregion

        #region Construtores
        public FormReceitas()
        {
            InitializeComponent();

            this.receitaBUS = FactoryBUS.CreateReceitaBUS();
            this.capsulaReceitaBUS = FactoryBUS.CreateCapsulaReceitaBUS();
        }
        #endregion

        #region Eventos
        private void FormReceitas_Load(object sender, EventArgs e)
        {
            AtualizarView();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.AbrirFormEditor();

            AtualizarView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int itemID = PegarItemID();

            if (itemID > 0)
            {
                Receita receita = this.receitaBUS.SelecionarPorID(itemID);

                if (MessageBox.Show($"Tem certeza que deseja apagar a receita de {receita.Descricao}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ApagarItemsReceita(receita.ID);

                    string receitaDesc = receita.Descricao;

                    bool exclusao = this.receitaBUS.Excluir(receita);

                    if (exclusao)
                        MessageBox.Show($"Receita de {receitaDesc} excluída com sucesso!");
                    else
                        MessageBox.Show($"Erro ao excluir receita de {receitaDesc}.");

                    AtualizarView();
                }
                else
                {
                    return;
                }
            }
        }

        // REWORK
        private void btnFazer_Click(object sender, EventArgs e)
        {
            //FormFazerReceita form = new FormFazerReceita();
            //DialogResult retorno = form.ShowDialog();
            //AtualizarView();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos

        private void AbrirFormEditor()
        {
            FormEditorReceita formEditor = new FormEditorReceita();

            formEditor.ShowDialog();
        }

        private void AtualizarView()
        {
            int index = PegarIndexDeSelecao();

            List<Receita> receitas = this.receitaBUS.Listar();

            MontarView(receitas);

            if (receitas.Count > 0)
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
                //double notaMedia = Avaliacao.ObterMedia(item.ID);
                //dgvReceitas.Rows.Add(item.ID, item.Descricao, item.MostrarCapsulas, item.QuantidadeTotalCapsulas, notaMedia > -1 ? notaMedia.ToString("N2") : "");

                dgvReceitas.Rows.Add(item.ID, item.Descricao, "AAAAAAAAAAA", 42, "000");
            }
        }

        private int PegarItemID()
        {
            int itemID;
            Int32.TryParse(dgvReceitas.SelectedRows[0].Cells[0].Value.ToString(), out itemID);
            return itemID;
        }

        private void ApagarItemsReceita(int receita)
        {
            List<CapsulaReceita> capsulas = capsulaReceitaBUS.ListarPorReceita(receita);

            foreach (CapsulaReceita capsula in capsulas)
                capsulaReceitaBUS.Excluir(capsula);
        }
        #endregion
    }
}
