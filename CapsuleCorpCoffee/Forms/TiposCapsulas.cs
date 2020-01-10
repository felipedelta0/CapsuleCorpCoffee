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
    public partial class TiposCapsulas : Form
    {
        public TiposCapsulas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TiposCapsulas_Load(object sender, EventArgs e)
        {
            // Popular Grid View
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Criar novo tipo de capsula
            EditorTipoCapsulas formEditor = new EditorTipoCapsulas();
            formEditor.ShowDialog();
            this.Close();
        }
    }
}
