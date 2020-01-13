using CapsuleCorpCoffee.Camadas.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.Camadas
{
    public static class FactoryBUS
    {
        public static CapsulaBUS CreateCapsulaBUS()
        {
            return new CapsulaBUS();
        }

        public static EstoqueBUS CreateEstoqueBUS()
        {
            return new EstoqueBUS();
        }
    }
}
