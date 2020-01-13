using CapsuleCorpCoffeeBUS.Interfaces;
using CapsuleCorpCoffeeDAO;
using CapsuleCorpCoffeeDAO.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using System.Collections.Generic;
using System.Linq;

namespace CapsuleCorpCoffeeBUS.Classes
{
    public class AvaliacaoBUS : IBusinessObject<Avaliacao>
    {

        #region Atributos

        private AvaliacaoDAO avaliacaoDAO;

        #endregion

        #region Construtores

        public AvaliacaoBUS()
        {
            this.avaliacaoDAO = FactoryDAO.CreateAvaliacaoDAO();
        }

        #endregion

        #region Métodos da Interface
        public bool Excluir(Avaliacao obj)
        {
            try
            {
                this.avaliacaoDAO.Deletar(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Avaliacao> Listar()
        {
            try
            {
                return this.avaliacaoDAO.Listar();
            }
            catch
            {
                return new List<Avaliacao>();
            }
        }

        public bool Salvar(Avaliacao obj)
        {
            try
            {
                if (obj.IsEditar)
                    this.avaliacaoDAO.Atualizar(obj);
                else
                    this.avaliacaoDAO.Inserir(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Avaliacao SelecionarPorID(int id)
        {
            try
            {
                return this.avaliacaoDAO.SelecionarPorID(id);
            }
            catch
            {
                return new Avaliacao();
            }
        }

        public bool ValidarCampos(Avaliacao obj)
        {
            if (obj.Nota < 1 || obj.Nota > 5)
                return false;

            if (obj.Receita < 0)
                return false;

            return true;
        }
        #endregion

        #region Métodos

        public double ObterMedia(int receita)
        {
            List<Avaliacao> notas = avaliacaoDAO.SelecionarPorReceitaID(receita);

            return notas.Count > 0 ? (notas.Sum(nota => (double)nota.Nota) / notas.Count) : -1;
        }

        #endregion
    }
}
