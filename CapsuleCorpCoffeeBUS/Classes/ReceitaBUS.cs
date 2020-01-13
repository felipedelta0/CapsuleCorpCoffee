using CapsuleCorpCoffeeBUS.Interfaces;
using CapsuleCorpCoffeeDAO;
using CapsuleCorpCoffeeDAO.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using System.Collections.Generic;

namespace CapsuleCorpCoffeeBUS.Classes
{
    public class ReceitaBUS : IBusinessObject<Receita>
    {
        #region Atributos

        private ReceitaDAO receitaDAO;

        #endregion

        #region Construtores

        public ReceitaBUS()
        {
            this.receitaDAO = FactoryDAO.CreateReceitaDAO();
        }

        #endregion

        #region Métodos da Interface
        public bool Excluir(Receita obj)
        {
            try
            {
                this.receitaDAO.Deletar(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Receita> Listar()
        {
            try
            {
                return this.receitaDAO.Listar();
            }
            catch
            {
                return new List<Receita>();
            }
        }

        public bool Salvar(Receita obj)
        {
            try
            {
                if (obj.IsEditar)
                    this.receitaDAO.Atualizar(obj);
                else
                    this.receitaDAO.Inserir(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Receita SelecionarPorID(int id)
        {
            try
            {
                return this.receitaDAO.SelecionarPorID(id);
            }
            catch
            {
                return new Receita();
            }
        }

        public bool ValidarCampos(Receita obj)
        {
            if (obj.Descricao.Length <= 0)
                return false;

            return true;
        }

        #endregion

        #region Métodos

        public Receita SelecionarUltimaInserida()
        {
            try
            {
                return this.receitaDAO.SelecionarUltimoRegistro();
            }
            catch
            {
                return new Receita();
            }
        }

        #endregion
    }
}
