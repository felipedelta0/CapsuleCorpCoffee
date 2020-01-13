using CapsuleCorpCoffeeBUS.Interfaces;
using CapsuleCorpCoffeeDAO;
using CapsuleCorpCoffeeDAO.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using System.Collections.Generic;

namespace CapsuleCorpCoffeeBUS.Classes
{
    public class CapsulaBUS : IBusinessObject<Capsula>
    {
        #region Atributos

        private CapsulaDAO capsulaDAO;

        #endregion

        #region Construtores

        public CapsulaBUS()
        {
            this.capsulaDAO = FactoryDAO.CreateCapsulaDAO();
        }

        #endregion

        #region Métodos da Interface

        public Capsula SelecionarPorID(int id)
        {
            try
            {
                return this.capsulaDAO.SelecionarPorID(id);
            }
            catch
            {
                return new Capsula();
            }
        }

        public bool Excluir(Capsula obj)
        {
            try
            {
                this.capsulaDAO.Deletar(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Capsula> Listar()
        {
            try
            {
                return this.capsulaDAO.Listar();
            }
            catch
            {
                return new List<Capsula>();
            }
        }

        public bool Salvar(Capsula obj)
        {
            try
            {
                if (obj.IsEditar)
                    this.capsulaDAO.Atualizar(obj);
                else
                    this.capsulaDAO.Inserir(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ValidarCampos(Capsula obj)
        {
            if (obj.Descricao.Length == 0)
                return false;

            if (obj.Forca < 1 || obj.Forca > 10)
                return false;

            return true;
        }

        #endregion
    }
}
