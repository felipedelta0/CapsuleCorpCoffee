using CapsuleCorpCoffee.DAL.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapsuleCorpCoffee.DAL.Models
{
    public class Estoque
    {
        #region Propriedades
        public int ID { get; set; }
        public TipoCapsula Capsula { get; set; }
        public int Quantidade { get; set; }
        public DateTime Validade { get; set; }
        public bool IsEditar
        {
            get
            {
                if (ID > 0)
                    return true;
                return false;
            }
        }
        #endregion 

        #region Construtores
        public Estoque()
        {
            ID = -1;
            Validade = new DateTime();
            Quantidade = -1;
            Capsula = new TipoCapsula();
        }

        public Estoque(int id)
        {
            Carregar(id);
        }

        public Estoque(DataRow row)
        {
            PreencherDados(row);
        }
        #endregion 

        #region Métodos da Classe
        public void PreencherDados(DataRow row)
        {
            ID = Int32.Parse(row["ID"].ToString());
            Validade = DateTime.Parse(row["Validade"].ToString());
            Quantidade = Int32.Parse(row["Quantidade"].ToString());
            Capsula = TipoCapsula.CarregarCapsulaPorID(Int32.Parse(row["Capsula"].ToString()));
        }


        // --------------------------------------------------------------------------- //
        public int AbaixaEstoque(int quantidade)
        {
            try
            {
                int faltante;
                faltante = this.Quantidade - quantidade;

                if (faltante < 0)
                {
                    this.Quantidade = 0;
                }
                else if (faltante >= 0)
                {
                    this.Quantidade -= quantidade;
                    if (faltante >= 0)
                        faltante = 0;
                    else
                        faltante = Math.Abs(faltante);
                }
                this.Salvar();
                return faltante;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível reduzir a quantidade do estoque. Erro: " + ex.Message);
            }
        }
        // --------------------------------------------------------------------------- //

        #endregion 

        #region Métodos da DAL
        public bool Salvar()
        {
            try
            {
                EstoqueDAL persistencia = new EstoqueDAL();

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
                throw new Exception("Não foi possível salvar o item de estoque. Erro: " + ex.Message);
            }
        }

        public void Carregar(int id)
        {
            try
            {
                EstoqueDAL persistencia = new EstoqueDAL();

                persistencia.CarregarPorID(id, this);

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar o item de estoque. Erro: " + ex.Message);
            }
        }

        public static List<Estoque> ListarEstoque()
        {
            try
            {
                EstoqueDAL persistencia = new EstoqueDAL();

                return persistencia.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar os registros cadastrados. Erro: " + ex.Message);
            }
        }

        public bool Excluir()
        {
            try
            {
                EstoqueDAL persistencia = new EstoqueDAL();

                persistencia.Deletar(this);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir o item selecionado. Erro: " + ex.Message);
            }
        }

        // --------------------------------------------------------------------------- //
        public static List<Estoque> PegarEstoquePorItemQuantidade(ReceitaItem item)
        {
            try
            {
                EstoqueDAL persistencia = new EstoqueDAL();

                return persistencia.ListarPorItemValidade(item.Capsula.ID);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar os registros cadastrados. Erro: " + ex.Message);
            }
        }
        // --------------------------------------------------------------------------- //


        #endregion 
    }
}
