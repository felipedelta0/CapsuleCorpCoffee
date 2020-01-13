using CapsuleCorpCoffee.Camadas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.Camadas
{
    public static class FactoryDAO
    {
        public static CapsulaDAO CreateCapsulaDAO()
        {
            return new CapsulaDAO();
        }

        public static EstoqueDAO CreateEstoqueDAO()
        {
            return new EstoqueDAO();
        }

        public static ReceitaDAO CreateReceitaDAO()
        {
            return new ReceitaDAO();
        }

        public static CapsulaReceitaDAO CreateCapsulaReceitaDAO()
        {
            return new CapsulaReceitaDAO();
        }
    }
}
