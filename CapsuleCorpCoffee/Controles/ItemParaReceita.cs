using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapsuleCorpCoffee.DAL_MUDAR.Models;

namespace CapsuleCorpCoffee.Controles
{
    internal partial class ItemParaReceita : UserControl
    {
        public ItemParaReceita()
        {
            InitializeComponent();
        }

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
    }
}
