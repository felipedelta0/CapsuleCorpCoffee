using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace CapsuleCorpCoffee.DAL.Persistencia
{
    class ReceitaDAL : Conexao
    {
        // CRUD
        public void Inserir(Receita receita)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.receita(\"Descricao\") VALUES (@descricao)", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("descricao", receita.Descricao));
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na inserção de item no estoque: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        
        public Receita SelecionarPorID(int id)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                Receita receita = null;

                if (dt.Rows.Count > 0)
                {
                    receita = new Receita(dt.Rows[0]);
                }

                return receita;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção da receita: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void CarregarPorID(int id, Receita obj)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita WHERE \"ID\" = @id", Conn);
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
                throw new Exception("Erro no carregamento da receita: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Receita> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                List<Receita> receitas = new List<Receita>();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        receitas.Add(new Receita(row));
                    }
                }

                return receitas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na listagem de receitas: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void CarregarUltimoCadastrado(Receita obj)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita ORDER BY \"ID\" DESC LIMIT 1", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    obj.ID = Int32.Parse(dt.Rows[0]["ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na listagem de receitas: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Atualizar(Receita receita)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.receita SET \"Descricao\" = @descricao WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("descricao", receita.Descricao);
                Cmd.Parameters.AddWithValue("id", receita.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização da receita: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Deletar(Receita receita)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.receita WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", receita.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na exclusão da receita: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
