using CapsuleCorpCoffee.DAL_MUDAR.Models;
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
    public partial class EditorTipoCapsulas : Form
    {
        private string Descricao;
        private int Forca;
        private TipoCapsula Capsula;

        public EditorTipoCapsulas()
        {
            InitializeComponent();

            this.Text = "Novo Tipo de Cápsula";
        }

        // Construtor de Edição
        public EditorTipoCapsulas(TipoCapsula tipoCapsula)
        {
            InitializeComponent();
            Capsula = tipoCapsula;
            txtDescricao.Text = Capsula.Descricao;
            cmbForca.Text = Capsula.Forca.ToString();

            this.Text = "Edição de Tipo de Cápsula";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Descricao = txtDescricao.Text.Trim();
            Int32.TryParse(cmbForca.SelectedItem.ToString(), out Forca);

            if (ValidarCampos())
            {
                // Salvar tudo certinho
            }
        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
