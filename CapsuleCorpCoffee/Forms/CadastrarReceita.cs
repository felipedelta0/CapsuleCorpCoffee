using CapsuleCorpCoffee.Controles;
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
    public partial class CadastrarReceita : Form
    {
        int Quantidade;
        Receita Receita;

        public CadastrarReceita()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            string quantidadeString = cmbQuantidadeItens.Text;
            
            Int32.TryParse(quantidadeString, out Quantidade);

            if (Quantidade > 0)
            {
                CarregarControles();

                BloqueiaDesbloqueiaTopo();
                BloqueiaDesbloqueiaRodape();
            }
        }

        private void CarregarControles()
        {
            for (int flag = 0; flag < Quantidade; flag++)
            {
                ItemParaReceita item = new ItemParaReceita();
                flowControles.Controls.Add(item);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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

        private void BloqueiaDesbloqueiaTopo()
        {
            cmbQuantidadeItens.Enabled = !cmbQuantidadeItens.Enabled;
            btnEscolher.Enabled = !btnEscolher.Enabled;
        }

        private void BloqueiaDesbloqueiaRodape()
        {
            btnAlterar.Enabled = !btnAlterar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                PrepararObjeto();
                Receita.Salvar();
                Receita.AtualizarItens();
                ReceitaItem.SalvarItems(Receita.Items);
            }
            MessageBox.Show("Receita cadastrada com sucesso!", "Sucesso");
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (txtNomeReceita.Text.ToString().Trim().Length <= 0)
            {
                MessageBox.Show("Favor verificar o nome da receita.", "Nome Vazio");
                return false;
            }

            foreach (ItemParaReceita controle in flowControles.Controls)
            {
                if (controle.QuantidadeEscolhida < 0)
                {
                    MessageBox.Show("Favor verificar a quantidade de todas as cápsulas informadas na receita.", "Quantidade Zerada");
                    return false;
                }

                if (controle.CapsulaEscolhida.ID <= 0)
                {
                    MessageBox.Show("Favor verificar todas as cápsulas informadas na receita.", "Cápsula Inválida");
                    return false;
                }
            }

            return true;
        }

        private void PrepararObjeto()
        {
            Receita = new Receita();
            Receita.Descricao = txtNomeReceita.Text.ToString().Trim();

            foreach (ItemParaReceita controle in flowControles.Controls)
            {
                ReceitaItem item = new ReceitaItem();
                item.Capsula = controle.CapsulaEscolhida;
                item.Quantidade = controle.QuantidadeEscolhida;
                Receita.Items.Add(item);
            }
        }
    }
}
