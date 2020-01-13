using CapsuleCorpCoffee.Camadas.DAO;
using CapsuleCorpCoffee.Camadas.DTO;
using CapsuleCorpCoffee.Camadas.Interfaces;
using System.Collections.Generic;

namespace CapsuleCorpCoffee.Camadas.Business
{
    public class CapsulaBUS : IBusinessLayer<Capsula>
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
