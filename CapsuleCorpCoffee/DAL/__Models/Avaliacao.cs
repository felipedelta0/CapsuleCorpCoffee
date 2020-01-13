using CapsuleCorpCoffee.DAL.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CapsuleCorpCoffee.DAL.Models
{
    public class Avaliacao
    {
        #region Propriedades
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
        #endregion

        #region Construtores
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
        #endregion

        #region Métodos da Classe
        public void PreencherDados(DataRow row)
        {
            ID = Int32.Parse(row["ID"].ToString());
            Nota = Int32.Parse(row["Nota"].ToString());
            Receita = Int32.Parse(row["Receita_ID"].ToString());
            Usuario = row["Usuario"].ToString();
            Comentario = row["Comentario"].ToString();
        }

        public static double ObterMedia(int receita)
        {
            List<double> notas = PegarItensPorReceita(receita);
            return notas.Count > 0 ? (notas.Sum() / notas.Count) : -1;
        }
        #endregion

        #region Métodos da DAL
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

        private static List<double> PegarItensPorReceita(int receita)
        {
            try
            {
                AvaliacaoDAL persistencia = new AvaliacaoDAL();

                return persistencia.SelecionarPorReceitaID(receita).Select(aval => (double)aval.Nota).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível obter a avaliação. Erro: " + ex.Message);
            }
        }
        #endregion
    }
}
