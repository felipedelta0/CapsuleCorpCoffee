using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.DAL_MUDAR.Models
{
    class Estoque
    {
        private int ID { get; set; }
        public TipoCapsula Capsula { get; set; }
        public int Quantidade { get; set; }
        public DateTime Validade { get; set; }
    }
}
