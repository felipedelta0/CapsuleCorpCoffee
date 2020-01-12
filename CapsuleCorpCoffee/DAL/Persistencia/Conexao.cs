using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CapsuleCorpCoffee.DAL.Persistencia
{
    public class Conexao
    {
        private string ConnString = "Host=localhost;Username=postgres;Password=postgres;Database=capsulecorpcoffeeDB";
        protected NpgsqlConnection Conn;
        protected NpgsqlCommand Cmd;
        protected NpgsqlDataAdapter Adapter;

        protected void AbrirConexao()
        {
            try
            {
                Conn = new NpgsqlConnection(ConnString);
                Conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                Conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
