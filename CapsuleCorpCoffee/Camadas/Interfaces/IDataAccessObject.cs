using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.Camadas.Interfaces
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
