using CapsuleCorpCoffeeDAO.Interfaces;
using CapsuleCorpCoffeeDTO.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapsuleCorpCoffeeDAO.Classes
{
    public class EstoqueDAO : DBConexao, IDataAccessObject<Estoque>
    {
        #region Implementação da Interface
        public void Atualizar(Estoque obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.estoque SET \"Capsula\" = @capsula, \"Validade\" = @validade, \"Quantidade\" = @quantidade WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("capsula", obj.Capsula);
                Cmd.Parameters.AddWithValue("validade", obj.Validade);
                Cmd.Parameters.AddWithValue("quantidade", obj.Quantidade);
                Cmd.Parameters.AddWithValue("id", obj.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar no banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Deletar(Estoque obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.estoque WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", obj.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Inserir(Estoque obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.estoque(\"Capsula\", \"Validade\", \"Quantidade\") VALUES (@capsula, @validade, @quantidade)", Conn);
                Cmd.Parameters.AddWithValue("capsula", obj.Capsula);
                Cmd.Parameters.AddWithValue("validade", obj.Validade);
                Cmd.Parameters.AddWithValue("quantidade", obj.Quantidade);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir no banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Estoque> Listar()
        {
            List<Estoque> estoque = new List<Estoque>();
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.estoque", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        estoque.Add(new Estoque(row));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return estoque;
        }

        public Estoque SelecionarPorID(int id)
        {
            Estoque estoque = new Estoque();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.estoque WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    estoque = new Estoque(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return estoque;
        }
        #endregion

        #region Métodos

        public List<Estoque> ListarPorValidadeID(int capsula)
        {
            List<Estoque> estoque = new List<Estoque>();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.estoque WHERE \"Capsula\" = @capsula AND \"Validade\" >= @validade AND \"Quantidade\" > 0 ORDER BY \"Validade\"", Conn);
                Cmd.Parameters.AddWithValue("capsula", capsula);
                Cmd.Parameters.AddWithValue("validade", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                

                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        estoque.Add(new Estoque(row));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return estoque;
        }

        #endregion
    }
}
