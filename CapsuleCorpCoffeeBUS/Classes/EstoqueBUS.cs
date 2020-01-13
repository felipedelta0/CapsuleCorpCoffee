using CapsuleCorpCoffeeBUS.Interfaces;
using CapsuleCorpCoffeeDAO;
using CapsuleCorpCoffeeDAO.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using System;
using System.Collections.Generic;

namespace CapsuleCorpCoffeeBUS.Classes
{
    public class EstoqueBUS : IBusinessObject<Estoque>
    {
        #region Atributos

        private EstoqueDAO estoqueDAO;

        #endregion

        #region Construtores

        public EstoqueBUS()
        {
            this.estoqueDAO = FactoryDAO.CreateEstoqueDAO();
        }

        #endregion

        #region Métodos da Interface
        public bool Excluir(Estoque obj)
        {
            try
            {
                this.estoqueDAO.Deletar(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Estoque> Listar()
        {
            try
            {
                return this.estoqueDAO.Listar();
            }
            catch
            {
                return new List<Estoque>();
            }
        }

        public bool Salvar(Estoque obj)
        {
            try
            {
                if (obj.IsEditar)
                    this.estoqueDAO.Atualizar(obj);
                else
                    this.estoqueDAO.Inserir(obj);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Estoque SelecionarPorID(int id)
        {
            try
            {
                return this.estoqueDAO.SelecionarPorID(id);
            }
            catch
            {
                return new Estoque();
            }
        }

        public bool ValidarCampos(Estoque obj)
        {
            if (obj.Validade < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))
                return false;

            if (obj.Quantidade < 0)
                return false;

            return true;
        }
        #endregion

        #region Métodos

        public List<Estoque> PegarEstoquePorItemQuantidade(int itemID)
        {
            try
            {
                return this.estoqueDAO.ListarPorValidadeID(itemID);
            }
            catch
            {
                return new List<Estoque>();
            }
        }

        public int AbaixaEstoque(int quantidade, Estoque obj)
        {
            int faltante;
            faltante = obj.Quantidade - quantidade;

            if (faltante < 0)
            {
                obj.Quantidade = 0;
            }
            else if (faltante >= 0)
            {
                obj.Quantidade -= quantidade;
                if (faltante >= 0)
                    faltante = 0;
                else
                    faltante = Math.Abs(faltante);
            }

            this.Salvar(obj);

            return faltante;
        }
    }

    #endregion
}
