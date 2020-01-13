using CapsuleCorpCoffee.Camadas;
using CapsuleCorpCoffee.Camadas.Business;
using CapsuleCorpCoffee.Camadas.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormCapsulas : Form
    {
        #region Propriedades, Variáveis e Atributos

        private CapsulaBUS capsulaBUS;

        #endregion

        #region Construtores
        public FormCapsulas()
        {
            InitializeComponent();

            capsulaBUS = FactoryBUS.CreateCapsulaBUS();
        }
        #endregion

        #region Eventos

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCapsulas_Load(object sender, EventArgs e)
        {
            AtualizarView();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AbrirFormEditor();

            AtualizarView();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int capsulaID = PegarIDCapsula();

            if (capsulaID > 0)
            {
                Capsula capsula = capsulaBUS.SelecionarPorID(capsulaID);

                AbrirFormEditor(capsula);

                AtualizarView();
            }
        }
        #endregion

        #region Métodos

        private void AbrirFormEditor(Capsula capsula = null)
        {
            FormEditorCapsulas formEditor;

            if (capsula == null)
                formEditor = new FormEditorCapsulas();
            else
                formEditor = new FormEditorCapsulas(capsula);

            formEditor.ShowDialog();
        }

        private void AtualizarView()
        {
            int index = PegarIndexDeSelecao();

            List<Capsula> capsulas = new List<Capsula>();
            capsulas = capsulaBUS.Listar();

            MontarView(capsulas);

            if (capsulas.Count > 0)
                dgvCapsulas.Rows[index].Selected = true;
        }

        private void MontarView(List<Capsula> capsulas)
        {
            dgvCapsulas.Rows.Clear();

            foreach (Capsula capsula in capsulas)
                dgvCapsulas.Rows.Add(capsula.ID, capsula.Descricao, capsula.Forca);
        }

        private int PegarIDCapsula()
        {
            int capsulaID;
            Int32.TryParse(dgvCapsulas.SelectedRows[0].Cells[0].Value.ToString(), out capsulaID);
            return capsulaID;
        }

        private int PegarIndexDeSelecao()
        {
            return dgvCapsulas.SelectedRows.Count > 0 ? (dgvCapsulas.SelectedRows[0].Index > 0 ? dgvCapsulas.SelectedRows[0].Index  - 1 : 0) : 0;
        }
        #endregion
    }
}
