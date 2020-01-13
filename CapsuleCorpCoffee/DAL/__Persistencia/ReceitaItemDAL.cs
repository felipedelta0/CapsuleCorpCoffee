using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace CapsuleCorpCoffee.DAL.Persistencia
{
    public class ReceitaItemDAL : Conexao
    {
        #region CREATE
        public void Inserir(ReceitaItem item)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.receita_items(\"Receita_ID\", \"Capsula_ID\", \"Quantidade\") VALUES (@receita, @capsula, @quantidade)", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("receita", item.Receita));
                Cmd.Parameters.Add(new NpgsqlParameter("capsula", item.Capsula.ID));
                Cmd.Parameters.Add(new NpgsqlParameter("quantidade", item.Quantidade));
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na inserção de item: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion

        #region READ
        public ReceitaItem SelecionarPorID(int id)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita_items WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                ReceitaItem item = null;

                if (dt.Rows.Count > 0)
                {
                    item = new ReceitaItem(dt.Rows[0]);
                }

                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção do item: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<ReceitaItem> SelecionarPorReceitaID(int id)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita_items WHERE \"Receita_ID\" = @receita", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("receita", id));

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                List<ReceitaItem> items = new List<ReceitaItem>();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        items.Add(new ReceitaItem(row));
                    }
                }

                return items;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção do item: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void CarregarPorID(int id, ReceitaItem obj)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita_items WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    obj.PreencherDados(dt.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no carregamento do item: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<ReceitaItem> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita_item", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                List<ReceitaItem> items = new List<ReceitaItem>();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        items.Add(new ReceitaItem(row));
                    }
                }

                return items;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na listagem de items: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion

        #region UPDATE
        public void Atualizar(ReceitaItem item)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.receita_items SET \"Receita_ID\" = @receita, \"Capsula_ID\" = @capsula, \"Quantidade\" = @quantidade WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("receita", item.Receita);
                Cmd.Parameters.AddWithValue("capsula", item.Capsula.ID);
                Cmd.Parameters.AddWithValue("quantidade", item.Quantidade);
                Cmd.Parameters.AddWithValue("id", item.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização do item: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion

        #region DELETE
        public void Deletar(ReceitaItem item)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.receita_items WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", item.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na exclusão do item: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion
    }
}
