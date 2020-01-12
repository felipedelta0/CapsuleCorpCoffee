using CapsuleCorpCoffee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CapsuleCorpCoffee.DAL.Persistencia
{
    public class TipoCapsulaDAL : Conexao
    {
        // CRUD
        public void Inserir(TipoCapsula tipoCapsula)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.tipo_capsula(\"Descricao\", \"Forca\") VALUES (@descricao, @forca)", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("descricao", tipoCapsula.Descricao));
                Cmd.Parameters.AddWithValue("forca", tipoCapsula.Forca);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na inserção de Tipo de Cápsula: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public TipoCapsula SelecionarPorID(int id)
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.tipo_capsula WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", id);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                TipoCapsula tipoCapsula = null;

                if (dt.Rows.Count > 0)
                {
                    tipoCapsula = new TipoCapsula(dt.Rows[0]);
                }

                return tipoCapsula;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na seleção de Tipo de Cápsula: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<TipoCapsula> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.tipo_capsula", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                List<TipoCapsula> capsulas = new List<TipoCapsula>();

                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        capsulas.Add(new TipoCapsula(row));
                    }
                }

                return capsulas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na listagem de Tipo de Cápsula: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Atualizar(TipoCapsula tipoCapsula)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.tipo_capsula SET \"Descricao\" = '@descricao', \"Forca\" = @forca WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("descricao", tipoCapsula.Descricao);
                Cmd.Parameters.AddWithValue("forca", tipoCapsula.Forca);
                Cmd.Parameters.AddWithValue("id", tipoCapsula.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização de Tipo de Cápsula: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Deletar(TipoCapsula tipoCapsula)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.tipo_capsula WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("id", tipoCapsula.ID);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na exclusão de Tipo de Cápsula: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
