using CapsuleCorpCoffee.Controles;
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
            foreach (ItemParaReceita controle in flowControles.Controls)
            {
                var capsula = controle.CapsulaEscolhida;
                var quantidade = controle.QuantidadeEscolhida;

                // Terminar
            }
        }
    }
}
