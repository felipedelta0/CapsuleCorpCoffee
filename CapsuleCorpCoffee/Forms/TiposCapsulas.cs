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
            AtualizarView();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EditorTipoCapsulas formEditor = new EditorTipoCapsulas();

            DialogResult res = formEditor.ShowDialog();

            AtualizarView();
        }

        private void AtualizarView()
        {
            int index = PegarIndexDeSelecao();

            List<TipoCapsula> capsulas = new List<TipoCapsula>();
            capsulas = TipoCapsula.CarregarCapsulas();

            dgvTipoCapsulas.DataSource = capsulas;
            dgvTipoCapsulas.Rows[index].Selected = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int capsulaID = PegarIDCapsula();

            if (capsulaID > 0)
            {
                EditorTipoCapsulas formEditor = new EditorTipoCapsulas(TipoCapsula.CarregarCapsulaPorID(capsulaID));

                DialogResult res = formEditor.ShowDialog();

                AtualizarView();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int capsulaID = PegarIDCapsula();

            if (capsulaID > 0)
            {
                bool exclusao = TipoCapsula.ExcluirCapsula(capsulaID);

                if (exclusao)
                    MessageBox.Show("Tipo de Cápsula excluída com sucesso!");

                AtualizarView();
            }
        }

        private int PegarIDCapsula()
        {
            int capsulaID;
            Int32.TryParse(dgvTipoCapsulas.SelectedRows[0].Cells[0].Value.ToString(), out capsulaID);
            return capsulaID;
        }

        private int PegarIndexDeSelecao()
        {
            return dgvTipoCapsulas.SelectedRows.Count > 0 ? (dgvTipoCapsulas.SelectedRows[0].Index > 0 ? dgvTipoCapsulas.SelectedRows[0].Index  - 1 : 0) : 0;
        }
    }
}
