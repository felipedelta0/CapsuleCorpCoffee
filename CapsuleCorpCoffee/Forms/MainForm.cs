using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapsuleCorpCoffee.DAL.Models;
using CapsuleCorpCoffee.DAL.Persistencia;
using CapsuleCorpCoffee.Forms;


namespace CapsuleCorpCoffee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Gerenciar os Tipos de Cápsulas de Café
        private void tiposDeCapsulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTiposCapsulas();
        }

        // Cadastrar Nova Receita
        private void cadastrarReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirReceitas();
        }

        // Gerenciar o Estoque
        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirEstoque();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirTiposCapsulas();
        }

        private void AbrirTiposCapsulas()
        {
            TiposCapsulas formTipoCapsulas = new TiposCapsulas();
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

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            AbrirReceitas();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirEstoque();
        }
    }
}
