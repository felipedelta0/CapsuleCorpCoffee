using CapsuleCorpCoffee.Camadas.DTO;
using CapsuleCorpCoffee.Camadas.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.Camadas.DAO
{
    public class AvaliacaoDAO : DBConexao, IDataAccessObject<Avaliacao>
    {
        #region Métodos da Interface

        public void Atualizar(Avaliacao obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.avaliacao SET \"Receita_ID\" = @receita, \"Nota\" = @nota, \"Usuario\" = @usuario, \"Comentario\" = @comentario WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("receita", obj.Receita);
                Cmd.Parameters.AddWithValue("nota", obj.Nota);
                Cmd.Parameters.AddWithValue("usuario", obj.Usuario);
                Cmd.Parameters.AddWithValue("comentario", obj.Comentario);
                Cmd.Parameters.AddWithValue("id", obj.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização no banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Deletar(Avaliacao obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.avaliacao WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", obj.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na exclusão do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Inserir(Avaliacao obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.avaliacao(\"Receita_ID\", \"Nota\", \"Usuario\", \"Comentario\") VALUES (@receita, @nota, @usuario, @comentario)", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("receita", obj.Receita));
                Cmd.Parameters.Add(new NpgsqlParameter("nota", obj.Nota));
                Cmd.Parameters.Add(new NpgsqlParameter("usuario", obj.Usuario));
                Cmd.Parameters.Add(new NpgsqlParameter("comentario", obj.Comentario));
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na inserção no banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Avaliacao> Listar()
        {
            List<Avaliacao> avaliacoes = new List<Avaliacao>();
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.avaliacao", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        avaliacoes.Add(new Avaliacao(row));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na listagem do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return avaliacoes;
        }

        public Avaliacao SelecionarPorID(int id)
        {
            Avaliacao avaliacao = new Avaliacao();

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
                    avaliacao = new Avaliacao(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return avaliacao;
        }

        #endregion

        #region Métodos

        public List<Avaliacao> SelecionarPorReceitaID(int id)
        {
            List<Avaliacao> avaliacoes = new List<Avaliacao>();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.avaliacao WHERE \"Receita_ID\" = @receita", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("receita", id));

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                

                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        avaliacoes.Add(new Avaliacao(row));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return avaliacoes;
        }

        #endregion
    }
}
