using CapsuleCorpCoffee.DAL.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.DAL.Models
{
    public class ReceitaItem
    {
        public int ID { get; set; }
        public int Receita { get; set; }
        public TipoCapsula Capsula { get; set; }
        public int Quantidade { get; set; }

        public ReceitaItem()
        {
            ID = -1;
            Receita = -1;
            Capsula = new TipoCapsula();
            Quantidade = -1;
        }

        public ReceitaItem(int id)
        {
            Carregar(id);
        }

        public ReceitaItem(DataRow row)
        {
            PreencherDados(row);
        }

        public void PreencherDados(DataRow row)
        {
            ID = Int32.Parse(row["ID"].ToString());
            Receita = Int32.Parse(row["Receita_ID"].ToString());
            Capsula = TipoCapsula.CarregarCapsulaPorID(Int32.Parse(row["Capsula_ID"].ToString()));
            Quantidade = Int32.Parse(row["Quantidade"].ToString());
        }

        public void Carregar(int id)
        {
            try
            {
                ReceitaItemDAL persistencia = new ReceitaItemDAL();

                persistencia.CarregarPorID(id, this);

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar o item. Erro: " + ex.Message);
            }
        }

        public static List<ReceitaItem> ListarPorReceita(int receita)
        {
            try
            {
                ReceitaItemDAL persistencia = new ReceitaItemDAL();

                return persistencia.SelecionarPorReceitaID(receita);

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar o item. Erro: " + ex.Message);
            }
        }

        public static void SalvarItems(List<ReceitaItem> itens)
        {
            try
            {
                ReceitaItemDAL persistencia = new ReceitaItemDAL();

                foreach (ReceitaItem item in itens)
                {
                    if (item.ID < 0)
                    {
                        persistencia.Inserir(item);
                    }
                    else
                    {
                        persistencia.Atualizar(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível salvar o item. Erro: " + ex.Message);
            }
        }

        public bool Excluir()
        {
            try
            {
                ReceitaItemDAL persistencia = new ReceitaItemDAL();

                persistencia.Deletar(this);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir esse item. Erro: " + ex.Message);
            }
        }

    }
}
