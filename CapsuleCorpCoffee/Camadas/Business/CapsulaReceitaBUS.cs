using CapsuleCorpCoffee.Camadas.DAO;
using CapsuleCorpCoffee.Camadas.DTO;
using CapsuleCorpCoffee.Camadas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.Camadas.Business
{
    public class CapsulaReceitaBUS : IBusinessLayer<CapsulaReceita>
    {
        #region Atributos

        private CapsulaReceitaDAO capsulaReceitaDAO;

        #endregion

        #region Construtores

        public CapsulaReceitaBUS()
        {
            this.capsulaReceitaDAO = FactoryDAO.CreateCapsulaReceitaDAO();
        }

        #endregion

        #region Métodos da Interface

        public bool Excluir(CapsulaReceita obj)
        {
            try
            {
                this.capsulaReceitaDAO.Deletar(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<CapsulaReceita> Listar()
        {
            try
            {
                return this.capsulaReceitaDAO.Listar();
            }
            catch
            {
                return new List<CapsulaReceita>();
            }
        }

        public bool Salvar(CapsulaReceita obj)
        {
            try
            {
                if (obj.IsEditar)
                    this.capsulaReceitaDAO.Atualizar(obj);
                else
                    this.capsulaReceitaDAO.Inserir(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public CapsulaReceita SelecionarPorID(int id)
        {
            try
            {
                return this.capsulaReceitaDAO.SelecionarPorID(id);
            }
            catch
            {
                return new CapsulaReceita();
            }
        }

        public bool ValidarCampos(CapsulaReceita obj)
        {
            if (obj.Capsula <= 0)
                return false;

            if (obj.Quantidade <= 0)
                return false;

            return true;
        }

        #endregion

        #region Métodos

        public List<CapsulaReceita> ListarPorReceita(int receita)
        {
            try
            {
                return this.capsulaReceitaDAO.SelecionarPorReceitaID(receita);
            }
            catch
            {
                return new List<CapsulaReceita>();
            }
        }

        #endregion
    }
}
