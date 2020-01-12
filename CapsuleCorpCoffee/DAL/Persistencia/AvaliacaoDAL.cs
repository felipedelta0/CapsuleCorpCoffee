using CapsuleCorpCoffee.DAL.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.DAL.Persistencia
{
    class AvaliacaoDAL : Conexao
    {
        // CRUD
        public void Inserir(Avaliacao avaliacao)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.avaliacao(\"Receita_ID\", \"Nota\", \"Usuario\", \"Comentario\") VALUES (@receita, @nota, @usuario, @comentario)", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("receita", avaliacao.Receita));
                Cmd.Parameters.Add(new NpgsqlParameter("nota", avaliacao.Nota));
                Cmd.Parameters.Add(new NpgsqlParameter("usuario", avaliacao.Usuario));
                Cmd.Parameters.Add(new NpgsqlParameter("comentario", avaliacao.Comentario));
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na inserção de avaliação: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Avaliacao SelecionarPorID(int id)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.avaliacao WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                Avaliacao avaliacao = null;

                if (dt.Rows.Count > 0)
                {
                    avaliacao = new Avaliacao(dt.Rows[0]);
                }

                return avaliacao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção da avaliação: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Avaliacao> SelecionarPorReceitaID(int id)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.avaliacao WHERE \"Receita_ID\" = @receita", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("receita", id));

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                List<Avaliacao> items = new List<Avaliacao>();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        items.Add(new Avaliacao(row));
                    }
                }

                return items;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção da avaliação: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void CarregarPorID(int id, Avaliacao obj)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.avaliacao WHERE \"ID\" = @id", Conn);
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

        public List<Avaliacao> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.avaliacao", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                List<Avaliacao> items = new List<Avaliacao>();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        items.Add(new Avaliacao(row));
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

        public void Atualizar(Avaliacao item)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.avaliacao SET \"Receita_ID\" = @receita, \"Nota\" = @nota, \"Usuario\" = @usuario, \"Comentario\" = @comentario WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("receita", item.Receita);
                Cmd.Parameters.AddWithValue("nota", item.Nota);
                Cmd.Parameters.AddWithValue("usuario", item.Usuario);
                Cmd.Parameters.AddWithValue("comentario", item.Comentario);
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

        public void Deletar(Avaliacao item)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.avaliacao WHERE \"ID\" = @id", Conn);
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
    }
}
