using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.DAL_MUDAR.Models
{
    class Receita
    {
        private int ID { get; set; }
        public string Descricao { get; set; }
        //public Dictionary<Capsula, int> CapsulasUsadas { get; set; } // Capsula : Quantidade
    }
}
