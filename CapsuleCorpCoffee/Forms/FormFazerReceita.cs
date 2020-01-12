using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormFazerReceita : Form
    {
        #region Propriedades, Váriaveis e Atributos
        public Receita Receita = new Receita();
        public int Quantidade;
        #endregion

        #region Construtores
        public FormFazerReceita()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void FormFazerReceita_Load(object sender, EventArgs e)
        {
            List<Receita> receitas = Receita.ListarReceitas();

            cmbReceitas.Items.Clear();
            cmbReceitas.DataSource = receitas;
            cmbReceitas.DisplayMember = "Descricao";
            cmbReceitas.SelectedIndex = 0;
        }

        private void btnFazer_Click(object sender, EventArgs e)
        {
            Int32.TryParse(cmbQuantidade.Text.ToString(), out Quantidade);
            Receita = (Receita)cmbReceitas.SelectedItem;

            if (ValidarCampos())
            {
                FazerReceita();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos
        private void FazerReceita()
        {
            if (ValidarCampos())
            {
                Dictionary<ReceitaItem, List<Estoque>> estoqueItems = new Dictionary<ReceitaItem, List<Estoque>>();

                foreach (ReceitaItem item in Receita.Items)
                {
                    estoqueItems.Add(item, Estoque.PegarEstoquePorItemQuantidade(item));
                }

                if (ChecarQuantidades(estoqueItems, Quantidade))
                {
                    FazerReceita(Receita, estoqueItems, Quantidade);
                    ChamarAvaliacao(Receita);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não existe itens suficientes em estoque para fazer essa receita.", "Estoque insuficiente.");
                    return;
                }
            }
        }

        private bool ChecarQuantidades(Dictionary<ReceitaItem, List<Estoque>> listagem, int xicaras)
        {
            foreach (KeyValuePair<ReceitaItem, List<Estoque>> etapa in listagem)
            {
                int quantidade = 0;

                foreach (Estoque est in etapa.Value)
                {
                    quantidade += est.Quantidade;
                }

                if (quantidade < (etapa.Key.Quantidade * xicaras))
                    return false;
            }
            return true;
        }

        private void FazerReceita(Receita receita, Dictionary<ReceitaItem, List<Estoque>> estoqueItens, int quantidade)
        {
            foreach (ReceitaItem item in receita.Items)
            {
                int faltante = item.Quantidade * quantidade;
                List<Estoque> lista = estoqueItens[item];
                foreach (Estoque itemEstoque in lista)
                {
                    faltante = itemEstoque.AbaixaEstoque(Math.Abs(faltante));
                    if (faltante == 0)
                        break;
                }
            }
        }

        public void ChamarAvaliacao(Receita receita)
        {
            FormAvaliacao form = new FormAvaliacao(receita);
            DialogResult retorno = form.ShowDialog();
        }

        private bool ValidarCampos()
        {
            if (Receita.ID < 0)
            {
                MessageBox.Show("Receita selecionada é inválida.", "Receita Inválida");
                return false;
            }

            if (Quantidade < 0 || Quantidade > 10)
            {
                MessageBox.Show("Receita selecionada é inválida.", "Receita Inválida");
                return false;
            }

            return true;
        }
        #endregion
    }
}
