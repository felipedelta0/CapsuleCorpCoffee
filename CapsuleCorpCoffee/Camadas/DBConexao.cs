using System;
using Npgsql;

namespace CapsuleCorpCoffee.Camadas
{
    public class DBConexao
    {
        #region Propriedades
        private string ConnString = "Host=localhost;Username=postgres;Password=postgres;Database=capsulecorpcoffeeDB";
        protected NpgsqlConnection Conn;
        protected NpgsqlCommand Cmd;
        protected NpgsqlDataAdapter Adapter;
        #endregion

        #region Abertura da Conexão
        protected void AbrirConexao()
        {
            try
            {
                this.Conn = new NpgsqlConnection(this.ConnString);
                this.Conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Fechamento da Conexão
        protected void FecharConexao()
        {
            try
            {
                this.Conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
