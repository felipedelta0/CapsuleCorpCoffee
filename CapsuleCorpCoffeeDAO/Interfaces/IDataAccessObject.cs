using System.Collections.Generic;

namespace CapsuleCorpCoffeeDAO.Interfaces
{
    public interface IDataAccessObject<T>
    {
        #region CREATE

        void Inserir(T obj);

        #endregion

        #region READ

        List<T> Listar();
        T SelecionarPorID(int id);

        #endregion

        #region UPDATE

        void Atualizar(T obj);

        #endregion

        #region DELETE

        void Deletar(T obj);

        #endregion
    }
}
