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
    class EstoqueDAL : Conexao
    {
        // CRUD
        public void Inserir(Estoque itemEstoque)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.estoque(\"Capsula\", \"Validade\", \"Quantidade\") VALUES (@capsula, @validade, @quantidade)", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("capsula", itemEstoque.Capsula.ID));
                Cmd.Parameters.AddWithValue("validade", itemEstoque.Validade);
                Cmd.Parameters.AddWithValue("quantidade", itemEstoque.Quantidade);
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
        public Estoque SelecionarPorID(int id)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.estoque WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                Estoque estoque = null;

                if (dt.Rows.Count > 0)
                {
                    estoque = new Estoque(dt.Rows[0]);
                }

                return estoque;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção de item de estoque: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void CarregarPorID(int id, Estoque obj)
        {
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
                {
                    obj.PreencherDados(dt.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no carregamento de item de estoque: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Estoque> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.estoque", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                List<Estoque> estoque = new List<Estoque>();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        estoque.Add(new Estoque(row));
                    }
                }

                return estoque;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na listagem de estoque: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        
        public void Atualizar(Estoque itemEstoque)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.estoque SET \"Capsula\" = @capsula, \"Validade\" = @validade, \"Quantidade\" = @quantidade WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("capsula", itemEstoque.Capsula.ID);
                Cmd.Parameters.AddWithValue("validade", itemEstoque.Validade);
                Cmd.Parameters.AddWithValue("quantidade", itemEstoque.Quantidade);
                Cmd.Parameters.AddWithValue("id", itemEstoque.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização de item no estoque: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Deletar(Estoque itemEstoque)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.estoque WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", itemEstoque.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na exclusão de item do estoque: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Estoque> ListarPorItemValidade(int capsula)
        {
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
                List<Estoque> estoque = new List<Estoque>();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        estoque.Add(new Estoque(row));
                    }
                }

                return estoque;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na listagem de estoque: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
