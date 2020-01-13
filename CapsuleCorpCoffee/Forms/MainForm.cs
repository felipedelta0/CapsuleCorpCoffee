using System;
using System.Windows.Forms;
using CapsuleCorpCoffeeBUS.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using CapsuleCorpCoffee.Forms;

namespace CapsuleCorpCoffee
{
    public partial class MainForm : Form
    {
        #region Construtores
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btnTiposCapsulas_Click(object sender, EventArgs e)
        {
            AbrirFormCapsulas();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            AbrirReceitas();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirEstoque();
        }
        #endregion

        #region Métodos
        private void AbrirFormCapsulas()
        {
            FormCapsulas formTipoCapsulas = new FormCapsulas();
            formTipoCapsulas.ShowDialog();
        }

        private void AbrirReceitas()
        {
            FormReceitas formReceitas = new FormReceitas();
            formReceitas.ShowDialog();
        }

        private void AbrirEstoque()
        {
            FormEstoque formEstoque = new FormEstoque();
            formEstoque.ShowDialog();
        }
        #endregion
    }
}
