using System.Collections.Generic;

namespace CapsuleCorpCoffeeBUS.Interfaces
{
    public interface IBusinessObject<T>
    {
        bool ValidarCampos(T obj);

        bool Salvar(T obj);

        bool Excluir(T obj);

        List<T> Listar();

        T SelecionarPorID(int id);
    }
}
