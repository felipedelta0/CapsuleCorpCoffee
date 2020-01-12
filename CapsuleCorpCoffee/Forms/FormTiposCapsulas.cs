using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormTiposCapsulas : Form
    {
        #region Construtores
        public FormTiposCapsulas()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
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
            FormEditorTipoCapsulas formEditor = new FormEditorTipoCapsulas();

            DialogResult res = formEditor.ShowDialog();

            AtualizarView();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int capsulaID = PegarIDCapsula();

            if (capsulaID > 0)
            {
                FormEditorTipoCapsulas formEditor = new FormEditorTipoCapsulas(TipoCapsula.CarregarCapsulaPorID(capsulaID));

                DialogResult res = formEditor.ShowDialog();

                AtualizarView();
            }
        }
        #endregion

        #region Métodos
        private void AtualizarView()
        {
            int index = PegarIndexDeSelecao();

            List<TipoCapsula> capsulas = new List<TipoCapsula>();
            capsulas = TipoCapsula.CarregarCapsulas();

            foreach (TipoCapsula capsula in capsulas)
            {
                dgvTipoCapsulas.Rows.Add(capsula.ID, capsula.Descricao, capsula.Forca);
            }

            dgvTipoCapsulas.Rows[index].Selected = true;
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
        #endregion
    }
}
