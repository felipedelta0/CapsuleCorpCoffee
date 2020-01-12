using System;
using System.Windows.Forms;
using System.Linq;
using CapsuleCorpCoffee.DAL.Models;

namespace CapsuleCorpCoffee.Controles
{
    internal partial class ItemParaReceita : UserControl
    {
        #region Propriedades, Váriaveis e Atributos
        public TipoCapsula CapsulaEscolhida
        {
            get
            {
                return (TipoCapsula)cmbCapsula.SelectedItem;
            }
        }

        public int QuantidadeEscolhida
        {
            get
            {
                int quantidade;
                Int32.TryParse(txtQuantidade.Text, out quantidade);
                return quantidade;
            }
        }
        #endregion

        #region Construtores
        public ItemParaReceita()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void ItemParaReceita_Load(object sender, EventArgs e)
        {
            MontarComboBox();
        }
        #endregion

        #region Métodos
        private void MontarComboBox()
        {
            cmbCapsula.Items.Clear();

            CarregarCapsulasNoCombo();

            cmbCapsula.DisplayMember = "Descricao";

            cmbCapsula.SelectedIndex = 0;
        }

        private void CarregarCapsulasNoCombo()
        {
            foreach (TipoCapsula capsula in TipoCapsula.CarregarCapsulas())
                cmbCapsula.Items.Add(capsula);
        }
        #endregion
    }
}
