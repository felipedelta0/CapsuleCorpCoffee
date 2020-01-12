using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormEditorTipoCapsulas : Form
    {
        #region Propriedades, Váriaveis e Atributos
        private string Descricao;
        private int Forca;
        private TipoCapsula Capsula;
        private bool IsEditar;
        #endregion

        #region Construtores
        public FormEditorTipoCapsulas()
        {
            InitializeComponent();

            this.Text = "Novo Tipo de Cápsula";
            IsEditar = false;
        }

        public FormEditorTipoCapsulas(TipoCapsula tipoCapsula)
        {
            InitializeComponent();
            Capsula = tipoCapsula;
            txtDescricao.Text = Capsula.Descricao;
            cmbForca.Text = Capsula.Forca.ToString();
            IsEditar = true;

            this.Text = "Edição de Tipo de Cápsula";
        }
        #endregion

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Descricao = txtDescricao.Text.Trim();
            Int32.TryParse(cmbForca.Text.ToString(), out Forca);

            if (ValidarCampos())
            {
                if (!IsEditar)
                    Capsula = new TipoCapsula();

                Capsula.Descricao = Descricao;
                Capsula.Forca = Forca;
                if (Capsula.Salvar())
                    MessageBox.Show("Registro salvo com sucesso!", "Sucesso");

                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos
        private bool ValidarCampos()
        {
            if (Descricao.Length == 0)
            {
                MessageBox.Show("Descrição não pode ser vazia.", "Descrição Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Forca < 1 || Forca > 10)
            {
                MessageBox.Show("Selecione um nível de força de café válido (1 a 10)", "Força de Café Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion
    }
}
