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
    public class ReceitaDAO : DBConexao, IDataAccessObject<Receita>
    {
        #region Implementação da Interface
        public void Atualizar(Receita obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("UPDATE public.receita SET \"Descricao\" = @descricao WHERE \"ID\" = @id", Conn);
                Cmd.Parameters.AddWithValue("descricao", obj.Descricao);
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

        public void Deletar(Receita obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("DELETE FROM public.receita WHERE \"ID\" = @id", Conn);
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

        public void Inserir(Receita obj)
        {
            try
            {
                AbrirConexao();
                Cmd = new NpgsqlCommand("INSERT INTO public.receita(\"Descricao\") VALUES (@descricao)", Conn);
                Cmd.Parameters.Add(new NpgsqlParameter("descricao", obj.Descricao));
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

        public List<Receita> Listar()
        {
            List<Receita> receitas = new List<Receita>();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        receitas.Add(new Receita(row));
            }
            catch
            {
                receitas = new List<Receita>();
            }
            finally
            {
                FecharConexao();
            }

            return receitas;
        }

        public Receita SelecionarPorID(int id)
        {
            Receita receita = new Receita();

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
                    receita = new Receita(dt.Rows[0]);
            }
            catch
            {
                receita = new Receita();
            }
            finally
            {
                FecharConexao();
            }

            return receita;
        }
        #endregion

        #region Métodos

        public Receita SelecionarUltimoRegistro()
        {
            Receita receita = new Receita();

            try
            {
                AbrirConexao();

                Cmd = new NpgsqlCommand("SELECT * FROM public.receita ORDER BY \"ID\" DESC LIMIT 1", Conn);

                Adapter = new NpgsqlDataAdapter(Cmd);

                DataSet ds = new DataSet();
                Adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    receita = new Receita(dt.Rows[0]);
            }
            catch
            {
                receita = new Receita();
            }
            finally
            {
                FecharConexao();
            }

            return receita;
        }

        #endregion
    }
}
