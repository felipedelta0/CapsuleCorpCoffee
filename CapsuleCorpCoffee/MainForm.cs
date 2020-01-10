using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
