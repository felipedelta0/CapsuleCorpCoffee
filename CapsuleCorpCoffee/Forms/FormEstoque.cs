using CapsuleCorpCoffeeBUS.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using CapsuleCorpCoffeeBUS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormEstoque : Form
    {
        #region Propriedades, Variáveis e Atributos

        private EstoqueBUS estoqueBUS;
        private CapsulaBUS capsulaBUS;

        #endregion

        #region Construtores
        public FormEstoque()
        {
            InitializeComponent();

            estoqueBUS = FactoryBUS.CreateEstoqueBUS();
            capsulaBUS = FactoryBUS.CreateCapsulaBUS();
        }
        #endregion

        #region Eventos
        private void FormEstoque_Load(object sender, EventArgs e)
        {
            AtualizarView();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int estoqueID = PegarItemID();

            if (estoqueID > 0)
            {
                Estoque estoque = estoqueBUS.SelecionarPorID(estoqueID);

                AbrirFormEditor(estoque);

                AtualizarView();
            }
            else
            {
                MessageBox.Show("Nenhum item de estoque selecionado.", "Erro");
                return;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AbrirFormEditor();

            AtualizarView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int itemID = PegarItemID();

            if (itemID > 0)
            {
                Estoque item = estoqueBUS.SelecionarPorID(itemID);

                if (MessageBox.Show($"Tem certeza que deseja apagar todos os {item.Quantidade.ToString()} itens dessa cápsula do estoque?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Capsula capsula = capsulaBUS.SelecionarPorID(item.Capsula);

                    bool exclusao = estoqueBUS.Excluir(item);

                    if (exclusao)
                        MessageBox.Show($"Estoque de {capsula.Descricao} foi excluído com sucesso!");
                    else
                        MessageBox.Show($"Erro ao excluir estoque de {capsula.Descricao}.");

                    AtualizarView();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nenhum item de estoque selecionado.", "Erro");
                return;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos

        private void AbrirFormEditor(Estoque estoque = null)
        {
            FormEditorEstoque formEditor;

            if (estoque == null)
                formEditor = new FormEditorEstoque();
            else
                formEditor = new FormEditorEstoque(estoque);

            formEditor.ShowDialog();
        }

        private void AtualizarView()
        {
            int index = PegarIndexDeSelecao();

            List<Estoque> estoque = estoqueBUS.Listar();

            MontarView(estoque);

            if (estoque.Count > 0)
                dgvEstoque.Rows[index].Selected = true;
        }

        private int PegarIndexDeSelecao()
        {
            return dgvEstoque.SelectedRows.Count > 0 ? (dgvEstoque.SelectedRows[0].Index > 0 ? dgvEstoque.SelectedRows[0].Index - 1 : 0) : 0;
        }

        private void MontarView(List<Estoque> estoque)
        {
            dgvEstoque.Rows.Clear();

            foreach (Estoque item in estoque)
            {
                Capsula capsula = capsulaBUS.SelecionarPorID(item.Capsula);

                dgvEstoque.Rows.Add(item.ID, capsula.Descricao, item.Validade.ToString("dd/MM/yyyy"), item.Quantidade);
            }
        }

        private int PegarItemID()
        {
            int itemID;
            if (dgvEstoque.SelectedRows.Count > 0)
                Int32.TryParse(dgvEstoque.SelectedRows[0].Cells[0].Value.ToString(), out itemID);
            else
                itemID = -1;

            return itemID;
        }
        #endregion
    }
}
