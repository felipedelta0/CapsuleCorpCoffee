using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapsuleCorpCoffee.DAL.Persistencia;

namespace CapsuleCorpCoffee.DAL.Models
{
    public class TipoCapsula
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Forca { get; set; }

        private bool IsEditar
        {
            get
            {
                if (ID > 0)
                    return true;
                return false;
            }
        }

        public override string ToString()
        {
            return Descricao;
        }

        public TipoCapsula ()
        {
            ID = -1;
            Descricao = "";
            Forca = 0;
        }

        public TipoCapsula (DataRow row)
        {
            PreencherDados(row);
        }

        public TipoCapsula (int id, string descricao, int forca)
        {
            ID = id;
            Descricao = descricao;
            Forca = forca;
        }

        public void PreencherDados(DataRow row)
        {
            ID = Int32.Parse(row["ID"].ToString());
            Descricao = row["Descricao"].ToString();
            Forca = Int32.Parse(row["Forca"].ToString());
        }

        public bool Salvar()
        {
            try
            {
                TipoCapsulaDAL persistencia = new TipoCapsulaDAL();

                if (IsEditar)
                {
                    persistencia.Atualizar(this);
                }
                else
                {
                    persistencia.Inserir(this);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível salvar o Tipo de Cápsula. Erro: " + ex.Message);
            }
        }

        public static List<TipoCapsula> CarregarCapsulas()
        {
            try
            {
                TipoCapsulaDAL persistencia = new TipoCapsulaDAL();

                return persistencia.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar os registros cadastrados. Erro: " + ex.Message);
            }
        }

        public static TipoCapsula CarregarCapsulaPorID(int id)
        {
            try
            {
                TipoCapsulaDAL persistencia = new TipoCapsulaDAL();

                return persistencia.SelecionarPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar o tipo de cápsula. Erro: " + ex.Message);
            }
        }

        public static bool ExcluirCapsula(int id)
        {
            try
            {
                TipoCapsula capsula = CarregarCapsulaPorID(id);

                TipoCapsulaDAL persistencia = new TipoCapsulaDAL();

                persistencia.Deletar(capsula);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar o tipo de cápsula. Erro: " + ex.Message);
            }
        }
    }
}
