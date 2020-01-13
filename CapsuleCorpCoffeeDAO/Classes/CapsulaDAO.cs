using CapsuleCorpCoffeeDAO.Interfaces;
using CapsuleCorpCoffeeDTO.Classes;
using Npgsql;
using System;
using System.Data;
using System.Collections.Generic;

namespace CapsuleCorpCoffeeDAO.Classes
{
    public class CapsulaDAO : DBConexao, IDataAccessObject<Capsula>
    {
        #region Implementação da Interface
        public void Atualizar(Capsula obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.capsulas SET \"Descricao\" = @descricao, \"Forca\" = @forca WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("descricao", obj.Descricao);
                Cmd.Parameters.AddWithValue("forca", obj.Forca);
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

        public void Deletar(Capsula obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.capsulas WHERE \"ID\" = @id", Conn);
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

        public void Inserir(Capsula obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.capsulas(\"Descricao\", \"Forca\") VALUES (@descricao, @forca)", Conn);
                Cmd.Parameters.AddWithValue("descricao", obj.Descricao);
                Cmd.Parameters.AddWithValue("forca", obj.Forca);
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

        public List<Capsula> Listar()
        {
            List<Capsula> capsulas = new List<Capsula>();
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.capsulas", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        capsulas.Add(new Capsula(row));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return capsulas;
        }

        public Capsula SelecionarPorID(int id)
        {
            Capsula capsula = new Capsula();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.capsulas WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    capsula = new Capsula(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter do banco: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return capsula;
        }
        #endregion
    }
}
