using CapsuleCorpCoffee.DAL.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.DAL.Models
{
    public class Receita
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public List<ReceitaItem> Items { get; set; }
        public bool IsEditar
        {
            get
            {
                return ID > 0 ? true : false;
            }
        }

        public string MostrarCapsulas
        {
            get
            {
                string retorno = "";
                for(int i = 0; i < Items.Count; i++)
                {
                    if (i > 0)
                        retorno += ", ";
                    retorno += Items[i].Capsula.Descricao;
                }
                return retorno;
            }
        }

        public int QuantidadeTotalCapsulas
        {
            get
            {
                return Items.Sum(item => item.Quantidade);
            }
        }

        public Receita()
        {
            ID = -1;
            Descricao = "";
            Items = new List<ReceitaItem>();
        }

        public Receita(int id)
        {
            Carregar(id);
        }

        public Receita(DataRow row)
        {
            PreencherDados(row);
        }

        public void PreencherDados(DataRow row)
        {
            ID = Int32.Parse(row["ID"].ToString());
            Descricao = row["Descricao"].ToString();
            CarregarItems();
        }

        public void Carregar(int id)
        {
            try
            {
                ReceitaDAL persistencia = new ReceitaDAL();

                persistencia.CarregarPorID(id, this);

                CarregarItems();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar a receita. Erro: " + ex.Message);
            }
        }

        private void CarregarItems()
        {
            if (ID > 0)
            {
                Items = ReceitaItem.ListarPorReceita(ID);
            }
        }

        public bool Salvar()
        {
            try
            {
                ReceitaDAL persistencia = new ReceitaDAL();

                if (IsEditar)
                {
                    persistencia.Atualizar(this);
                }
                else
                {
                    persistencia.Inserir(this);
                }

                CarregarUltimoIDDescricao();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível salvar a receita. Erro: " + ex.Message);
            }
        }

        public bool Excluir()
        {
            try
            {
                ReceitaDAL persistencia = new ReceitaDAL();

                persistencia.Deletar(this);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir essa receita. Erro: " + ex.Message);
            }
        }

        public static List<Receita> ListarReceitas()
        {
            try
            {
                ReceitaDAL persistencia = new ReceitaDAL();

                return persistencia.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar os registros cadastrados. Erro: " + ex.Message);
            }
        }

        public void CarregarUltimoIDDescricao()
        {
            try
            {
                ReceitaDAL persistencia = new ReceitaDAL();

                persistencia.CarregarUltimoCadastrado(this);

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar a receita. Erro: " + ex.Message);
            }
        }

        public void AtualizarItens()
        {
            if (ID > 0)
            {
                foreach (ReceitaItem item in Items)
                {
                    item.Receita = ID;
                }
            }
        }
    }
}
