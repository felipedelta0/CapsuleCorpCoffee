using CapsuleCorpCoffeeBUS.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using CapsuleCorpCoffeeBUS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormFazerReceita : Form
    {
        #region Propriedades, Váriaveis e Atributos

        private ReceitaBUS receitaBUS;
        private CapsulaReceitaBUS capsulaReceitaBUS;
        private EstoqueBUS estoqueBUS;

        #endregion

        #region Construtores
        public FormFazerReceita()
        {
            InitializeComponent();

            this.receitaBUS = FactoryBUS.CreateReceitaBUS();
            this.capsulaReceitaBUS = FactoryBUS.CreateCapsulaReceitaBUS();
            this.estoqueBUS = FactoryBUS.CreateEstoqueBUS();
        }
        #endregion

        #region Eventos
        private void FormFazerReceita_Load(object sender, EventArgs e)
        {
            List<Receita> receitas = this.receitaBUS.Listar();

            cmbQuantidade.SelectedIndex = 0;

            MontarComboBox(receitas);
        }

        private void btnFazer_Click(object sender, EventArgs e)
        {
            int quantidade;
            Int32.TryParse(cmbQuantidade.Text.ToString(), out quantidade);
            Receita receita = (Receita)cmbReceitas.SelectedItem;

            if (ValidarCampos(receita, quantidade))
            {
                List<CapsulaReceita> capsulas = this.capsulaReceitaBUS.ListarPorReceita(receita.ID);
                
                if (this.ChecarQuantidades(capsulas, quantidade))
                {
                    FazerReceita(capsulas, quantidade);

                    MessageBox.Show("Receita preparada com sucesso. Favor efetuar a avaliação da receita.", "Sucesso");

                    ChamarAvaliacao(receita);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não existem itens suficientes no estoque para fazer essa receita.", "Erro");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Receita inválida ou quantidade inválida. Cheque os campos e tente novamente.", "Erro");
                return;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos
        private void MontarComboBox(List<Receita> receitas)
        {
            cmbReceitas.Items.Clear();
            cmbReceitas.DataSource = receitas;
            cmbReceitas.DisplayMember = "Descricao";

            if (cmbReceitas.Items.Count > 0)
                cmbReceitas.SelectedIndex = 0;
        }

        private bool ChecarQuantidades(List<CapsulaReceita> capsulas, int xicaras)
        {
            if (capsulas.Count == 0)
                return false;

            foreach (CapsulaReceita capsula in capsulas)
            {
                int quantidade = 0;

                List<Estoque> estoque = estoqueBUS.PegarEstoquePorItemQuantidade(capsula.Capsula);

                foreach (Estoque item in estoque)
                    quantidade += item.Quantidade;

                if (quantidade < (capsula.Quantidade * xicaras))
                    return false;
            }

            return true;
        }

        private void FazerReceita(List<CapsulaReceita> capsulas, int xicaras)
        {
            foreach (CapsulaReceita capsula in capsulas)
            {
                int faltante = capsula.Quantidade * xicaras;

                List<Estoque> lista = this.estoqueBUS.PegarEstoquePorItemQuantidade(capsula.Capsula);

                foreach (Estoque item in lista)
                {
                    faltante = this.estoqueBUS.AbaixaEstoque(Math.Abs(faltante), item);

                    if (faltante == 0)
                        break;
                }
            }
        }

        public void ChamarAvaliacao(Receita receita)
        {
            AbrirFormAvaliacao(receita);
        }

        public void AbrirFormAvaliacao(Receita receita)
        {
            FormAvaliacao form = new FormAvaliacao(receita);
            form.ShowDialog();
        }

        private bool ValidarCampos(Receita receita, int quantidade)
        {
            if (receita == null)
                return false;

            if (receita.ID < 0)
                return false;

            if (quantidade < 1 || quantidade > 10)
                return false;

            return true;
        }
        #endregion
    }
}
