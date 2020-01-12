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
    public partial class FormReceitas : Form
    {
        public FormReceitas()
        {
            InitializeComponent();
        }

        private void FormReceitas_Load(object sender, EventArgs e)
        {
            AtualizarView();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastrarReceita formEditor = new CadastrarReceita();

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                dgvReceitas.Rows.Add(item.ID.ToString(), item.Descricao, item.MostrarCapsulas, item.QuantidadeTotalCapsulas);
            }
        }

        private int PegarItemID()
        {
            int itemID;
            Int32.TryParse(dgvReceitas.SelectedRows[0].Cells[0].Value.ToString(), out itemID);
            return itemID;
        }

        private void btnFazer_Click(object sender, EventArgs e)
        {
            int itemID = PegarItemID();

            if (itemID > 0)
            {
                Receita receita = new Receita(itemID);
                Dictionary<ReceitaItem, List<Estoque>> estoqueItems = new Dictionary<ReceitaItem, List<Estoque>>();

                foreach (ReceitaItem item in receita.Items)
                {
                    estoqueItems.Add(item, Estoque.PegarEstoquePorItemQuantidade(item));
                }

                if (ChecarQuantidades(estoqueItems))
                {
                    FazerReceita(receita, estoqueItems);
                    ChamarAvaliacao(receita);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não existe itens suficientes em estoque para fazer essa receita.", "Estoque insuficiente.");
                    return;
                }
            }
        }

        public void ChamarAvaliacao(Receita receita)
        {
            FormAvaliacao form = new FormAvaliacao(receita);
            DialogResult retorno = form.ShowDialog();
        }

        private bool ChecarQuantidades(Dictionary<ReceitaItem, List<Estoque>> listagem)
        {
            foreach (KeyValuePair<ReceitaItem, List<Estoque>> etapa in listagem)
            {
                int quantidade = 0;

                foreach (Estoque est in etapa.Value)
                {
                    quantidade += est.Quantidade;
                }

                if (quantidade < etapa.Key.Quantidade)
                    return false;
            }
            return true;
        }

        private void FazerReceita(Receita receita, Dictionary<ReceitaItem, List<Estoque>> estoqueItens)
        {

            foreach (ReceitaItem item in receita.Items)
            {
                int faltante = item.Quantidade;
                List<Estoque> lista = estoqueItens[item];
                foreach (Estoque itemEstoque in lista)
                {
                    faltante = itemEstoque.AbaixaEstoque(Math.Abs(faltante));
                    if (faltante == 0)
                        break;
                }
            }
        }
    }
}
