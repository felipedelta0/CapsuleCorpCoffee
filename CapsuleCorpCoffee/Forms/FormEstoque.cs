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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            AtualizarView();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int itemID = PegarItemID();

            if (itemID > 0)
            {
                FormEditorItemEstoque formEditor = new FormEditorItemEstoque(new Estoque(itemID));

                DialogResult res = formEditor.ShowDialog();

                AtualizarView();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormEditorItemEstoque formEditor = new FormEditorItemEstoque();

            DialogResult res = formEditor.ShowDialog();

            AtualizarView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int itemID = PegarItemID();

            if (itemID > 0)
            {
                Estoque item = new Estoque(itemID);

                if (MessageBox.Show($"Tem certeza que deseja apagar todos os {item.Quantidade.ToString()} itens dessa cápsula do estoque?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string capsula = item.Capsula.Descricao;

                    bool exclusao = item.Excluir();

                    if (exclusao)
                        MessageBox.Show($"Estoque {item.Capsula.Descricao} de excluída com sucesso!");

                    AtualizarView();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarView()
        {
            int index = PegarIndexDeSelecao();

            List<Estoque> estoque = new List<Estoque>();
            estoque = Estoque.ListarEstoque();

            MontarView(estoque);
            dgvEstoque.Rows[index].Selected = true;
        }

        private int PegarIndexDeSelecao()
        {
            return dgvEstoque.SelectedRows.Count > 0 ? (dgvEstoque.SelectedRows[0].Index > 0 ? dgvEstoque.SelectedRows[0].Index - 1 : 0) : 0;
        }

        private void MontarView(List<Estoque> estoque)
        {
            dgvEstoque.Rows.Clear();

            foreach (Estoque item in estoque)
            {
                dgvEstoque.Rows.Add(item.ID.ToString(), item.Capsula.Descricao, item.Validade.ToString("dd/MM/yyyy"), item.Quantidade.ToString());
            }
        }

        private int PegarItemID()
        {
            int itemID;
            Int32.TryParse(dgvEstoque.SelectedRows[0].Cells[0].Value.ToString(), out itemID);
            return itemID;
        }
    }
}
