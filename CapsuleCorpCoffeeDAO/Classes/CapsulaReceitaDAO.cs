using CapsuleCorpCoffeeDAO.Interfaces;
using CapsuleCorpCoffeeDTO.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapsuleCorpCoffeeDAO.Classes
{
    public class CapsulaReceitaDAO : DBConexao, IDataAccessObject<CapsulaReceita>
    {
        #region Implementação da Interface

        public void Atualizar(CapsulaReceita obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.capsulareceita SET \"Receita_ID\" = @receita, \"Capsula_ID\" = @capsula, \"Quantidade\" = @quantidade WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("receita", obj.Receita);
                Cmd.Parameters.AddWithValue("capsula", obj.Capsula);
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

        public void Deletar(CapsulaReceita obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.capsulareceita WHERE \"ID\" = @id", Conn);
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

        public void Inserir(CapsulaReceita obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.capsulareceita(\"Receita_ID\", \"Capsula_ID\", \"Quantidade\") VALUES (@receita, @capsula, @quantidade)", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("receita", obj.Receita));
                Cmd.Parameters.Add(new NpgsqlParameter("capsula", obj.Capsula));
                Cmd.Parameters.Add(new NpgsqlParameter("quantidade", obj.Quantidade));
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

        public List<CapsulaReceita> Listar()
        {
            List<CapsulaReceita> capsulas = new List<CapsulaReceita>();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.capsulareceita", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                
                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        capsulas.Add(new CapsulaReceita(row));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return capsulas;
        }

        public CapsulaReceita SelecionarPorID(int id)
        {
            CapsulaReceita capsula = new CapsulaReceita();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.capsulareceita WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    capsula = new CapsulaReceita(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return capsula;
        }

        #endregion

        #region Métodos

        public List<CapsulaReceita> SelecionarPorReceitaID(int id)
        {
            List<CapsulaReceita> capsulas = new List<CapsulaReceita>();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.capsulareceita WHERE \"Receita_ID\" = @receita", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("receita", id));

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                

                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        capsulas.Add(new CapsulaReceita(row));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar itens do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return capsulas;
        }

        #endregion
    }
}
