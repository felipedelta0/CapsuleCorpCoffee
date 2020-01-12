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
    public partial class FormEditorItemEstoque : Form
    {
        private Estoque ItemEstoque;
        public FormEditorItemEstoque()
        {
            ItemEstoque = new Estoque();
            this.Text = "Inserção de Item de Estoque";

            InitializeComponent();
        }

        public FormEditorItemEstoque(Estoque item)
        {
            ItemEstoque = item;
            this.Text = "Edição de Item de Estoque";

            InitializeComponent();
        }

        private void FormEditorItemEstoque_Load(object sender, EventArgs e)
        {
            CarregarCapsulas();

            if (ItemEstoque.IsEditar)
            {
                datePicker.Value = ItemEstoque.Validade;
                txtQuantidade.Text = ItemEstoque.Quantidade.ToString();
                VerificaCapsulaSelecionada();
            }

            this.cmbCapsula.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CarregarCapsulas()
        {
            List<TipoCapsula> capsulas = TipoCapsula.CarregarCapsulas();

            cmbCapsula.Items.Clear();

            foreach (TipoCapsula capsula in capsulas)
            {
                cmbCapsula.Items.Add(capsula);
            }

            cmbCapsula.SelectedIndex = 0;
        }

        private void VerificaCapsulaSelecionada()
        {
            if (ItemEstoque.IsEditar)
            {
                cmbCapsula.SelectedItem = ItemEstoque;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposEMontar())
            {
                ItemEstoque.Salvar();
                MessageBox.Show("Salvo com sucesso!", "Sucesso");
                this.Close();
            }
        }

        private bool ValidarCamposEMontar()
        {
            try
            {
                TipoCapsula capsula = (TipoCapsula)cmbCapsula.SelectedItem;
                int quantidade;
                Int32.TryParse(txtQuantidade.Text.ToString(), out quantidade);
                DateTime validade = datePicker.Value;

                if (capsula.ID <= 0)
                {
                    MessageBox.Show("Cápsula selecionada é inválida.", "Cápsula Inválida");
                    return false;
                }

                if (quantidade < 0)
                {
                    MessageBox.Show("Quantidade informada é inválida.", "Quantidade Inválida");
                    return false;
                }

                ItemEstoque.Capsula = capsula;
                ItemEstoque.Quantidade = quantidade;
                ItemEstoque.Validade = validade;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na validação: " + ex.Message);
            }
        }
    }
}
