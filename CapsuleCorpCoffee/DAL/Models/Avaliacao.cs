using CapsuleCorpCoffee.DAL.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.DAL.Models
{
    public class Avaliacao
    {
        public int ID { get; set; }
        public int Nota { get; set; }
        public int Receita { get; set; }
        public string Usuario { get; set; }
        public string Comentario { get; set; }
        public bool IsEditar
        {
            get
            {
                return ID > 0 ? true : false;
            }
        }

        public Avaliacao()
        {
            ID = -1;
            Nota = -1;
            Receita = -1;
            Usuario = "";
            Comentario = "";
        }

        public Avaliacao(int id)
        {
            Carregar(id);
        }

        public Avaliacao(DataRow row)
        {
            PreencherDados(row);
        }

        public void PreencherDados(DataRow row)
        {
            ID = Int32.Parse(row["ID"].ToString());
            Nota = Int32.Parse(row["Nota"].ToString());
            Receita = Int32.Parse(row["Receita_ID"].ToString());
            Usuario = row["Usuario"].ToString();
            Comentario = row["Comentario"].ToString();
        }

        public void Carregar(int id)
        {
            try
            {
                AvaliacaoDAL persistencia = new AvaliacaoDAL();

                persistencia.CarregarPorID(id, this);

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar a avaliação. Erro: " + ex.Message);
            }
        }

        public bool Salvar()
        {
            try
            {
                AvaliacaoDAL persistencia = new AvaliacaoDAL();

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
                throw new Exception("Não foi possível salvar a avaliação. Erro: " + ex.Message);
            }
        }
    }
}
