using CapsuleCorpCoffee.Camadas;
using CapsuleCorpCoffee.Camadas.Business;
using CapsuleCorpCoffee.Camadas.DTO;
using System;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormEditorCapsulas : Form
    {
        #region Propriedades, Váriaveis e Atributos
        private Capsula Capsula;
        private CapsulaBUS capsulaBUS;
        private bool IsEditar = false;
        #endregion

        #region Construtores
        public FormEditorCapsulas()
        {
            InitializeComponent();

            this.Capsula = new Capsula();

            DefinirTitulo();
            InicializarBUS();
        }

        public FormEditorCapsulas(Capsula capsula)
        {
            InitializeComponent();

            this.Capsula = capsula;
            this.IsEditar = true;
            this.txtDescricao.Text = this.Capsula.Descricao.ToString();
            this.cmbForca.Text = this.Capsula.Forca.ToString();

            DefinirTitulo();
            InicializarBUS();
        }
        #endregion

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int forca;
            this.Capsula.Descricao = txtDescricao.Text.Trim();
            Int32.TryParse(cmbForca.Text.ToString(), out forca);
            this.Capsula.Forca = forca;

            if (capsulaBUS.ValidarCampos(this.Capsula))
            {
                if (capsulaBUS.Salvar(this.Capsula))
                    MessageBox.Show("Registro salvo com sucesso!", "Sucesso");
                else
                    MessageBox.Show("Erro ao salvar o registro. Tente novamente", "Erro ao Salvar");

                this.Close();
            }
            else
            {
                MessageBox.Show("Registro inválido. Favor verificar todos os campos", "Erro ao Validar");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos
        private void InicializarBUS()
        {
            this.capsulaBUS = FactoryBUS.CreateCapsulaBUS();
        }

        private void DefinirTitulo()
        {
            if (this.IsEditar)
                this.Text = "Edição de Cápsula";
            else
                this.Text = "Nova Cápsula";
        }
        #endregion
    }
}
