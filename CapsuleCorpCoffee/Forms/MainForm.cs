using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapsuleCorpCoffee.Forms;
using Npgsql;

namespace CapsuleCorpCoffee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            var connString = "Host=localhost;Username=postgres;Password=postgres;Database=capsulecorpcoffeeDB";

            try
            {
                var conn = new NpgsqlConnection(connString);

                conn.Open();

                MessageBox.Show(conn.State.ToString(), "Status da Conexão");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
            
        }

        // Gerenciar os Tipos de Cápsulas de Café
        private void tiposDeCapsulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposCapsulas formTipoCapsulas = new TiposCapsulas();
            formTipoCapsulas.ShowDialog();
        }

        // Fazer uma receita já existente
        private void fazerReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Cadastrar Nova Receita
        private void cadastrarReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarReceita formCadastrarReceira = new CadastrarReceita();
            formCadastrarReceira.ShowDialog();
        }

        // Gerenciar o Estoque
        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
