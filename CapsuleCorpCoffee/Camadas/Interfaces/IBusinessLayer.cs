using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.Camadas.Interfaces
{
    interface IBusinessLayer<T>
    {
        bool ValidarCampos(T obj);

        bool Salvar(T obj);

        bool Excluir(T obj);

        List<T> Listar();

        T SelecionarPorID(int id);
    }
}
