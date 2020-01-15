using CapsuleCorpCoffeeBUS.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using CapsuleCorpCoffeeBUS;
using CapsuleCorpCoffee.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormEditorReceita : Form
    {
        #region Propriedades, Váriaveis e Atributos

        private ReceitaBUS receitaBUS;
        private CapsulaReceitaBUS capsulaReceitaBUS;
        private int Quantidade;

        #endregion

        #region Construtores
        public FormEditorReceita()
        {
            InitializeComponent();

            this.receitaBUS = FactoryBUS.CreateReceitaBUS();
            this.capsulaReceitaBUS = FactoryBUS.CreateCapsulaReceitaBUS();
        }
        #endregion

        #region Eventos
        private void btnEscolher_Click(object sender, EventArgs e)
        {
            int.TryParse(cmbQuantidadeItens.Text, out Quantidade);

            if (Quantidade > 0)
            {
                CarregarControles();

                BloqueiaDesbloqueiaTopo();
                BloqueiaDesbloqueiaRodape();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            flowControles.Controls.Clear();
            txtNomeReceita.Text = "";

            BloqueiaDesbloqueiaTopo();
            BloqueiaDesbloqueiaRodape();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<CapsulaReceita> itemsReceita = MontarItensReceita();

            if (itemsReceita.Count > 0)
            {
                Receita receita = MontarReceita();

                if (this.receitaBUS.ValidarCampos(receita))
                {
                    this.receitaBUS.Salvar(receita);

                    SalvarItemsReceita(itemsReceita);

                    MessageBox.Show("Receita cadastrada com sucesso!", "Sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Favor verificar os itens e quantidades informados e tentar novamente.", "Erro");
            }
        }
        #endregion

        #region Métodos
        private void SalvarItemsReceita(List<CapsulaReceita> items)
        {
            Receita receita = receitaBUS.SelecionarUltimaInserida();

            foreach (CapsulaReceita capsula in items)
            {
                capsula.Receita = receita.ID;

                this.capsulaReceitaBUS.Salvar(capsula);
            }
        }

        private Receita MontarReceita()
        {
            Receita receita = new Receita();
            receita.Descricao = txtNomeReceita.Text.ToString().Trim();

            return receita;
        }

        private List<CapsulaReceita> MontarItensReceita()
        {
            List<CapsulaReceita> capsulas = new List<CapsulaReceita>();

            if (flowControles.Controls.Count > 0)
            {
                foreach (ItemParaReceita controle in flowControles.Controls)
                {
                    Capsula capsula = controle.CapsulaEscolhida;

                    CapsulaReceita capsulaReceita = new CapsulaReceita();

                    capsulaReceita.Capsula = capsula.ID;
                    capsulaReceita.Quantidade = controle.QuantidadeEscolhida;

                    if (capsulaReceitaBUS.ValidarCampos(capsulaReceita))
                        capsulas.Add(capsulaReceita);
                    else
                        return new List<CapsulaReceita>();
                }
            }

            return capsulas;
        }

        private void CarregarControles()
        {
            for (int flag = 0; flag < Quantidade; flag++)
            {
                ItemParaReceita item = new ItemParaReceita();
                flowControles.Controls.Add(item);
            }
        }

        private void BloqueiaDesbloqueiaTopo()
        {
            cmbQuantidadeItens.Enabled = !cmbQuantidadeItens.Enabled;
            btnEscolher.Enabled = !btnEscolher.Enabled;
        }

        private void BloqueiaDesbloqueiaRodape()
        {
            btnLimpar.Enabled = !btnLimpar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
        }

        #endregion
    }
}
