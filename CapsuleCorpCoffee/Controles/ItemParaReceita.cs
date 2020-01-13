using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CapsuleCorpCoffeeBUS.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using CapsuleCorpCoffeeBUS;

namespace CapsuleCorpCoffee.Controles
{
    internal partial class ItemParaReceita : UserControl
    {
        #region Propriedades, Váriaveis e Atributos
        private CapsulaBUS capsulaBUS;

        public Capsula CapsulaEscolhida
        {
            get
            {
                return (Capsula)cmbCapsula.SelectedItem;
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

            capsulaBUS = FactoryBUS.CreateCapsulaBUS();
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
            List<Capsula> capsulas = capsulaBUS.Listar();

            PopularComboBox(capsulas);

            cmbCapsula.DisplayMember = "Descricao";
        }

        private void PopularComboBox(List<Capsula> capsulas)
        {
            cmbCapsula.Items.Clear();

            foreach (Capsula capsula in capsulas)
                cmbCapsula.Items.Add(capsula);

            if (cmbCapsula.Items.Count > 0)
                cmbCapsula.SelectedIndex = 0;
        }
        #endregion
    }
}
