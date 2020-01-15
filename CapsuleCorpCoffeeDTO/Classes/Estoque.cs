using System;
using System.Data;

namespace CapsuleCorpCoffeeDTO.Classes
{
    public class Estoque
    {
        #region Propriedades
        public int ID { get; set; }
        public int Capsula { get; set; }
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
            Capsula = -1;
        }

        public Estoque(DataRow row)
        {
            this.ID = int.Parse(row["ID"].ToString());
            this.Validade = DateTime.Parse(row["Validade"].ToString());
            this.Quantidade = int.Parse(row["Quantidade"].ToString());
            this.Capsula = int.Parse(row["Capsula"].ToString());
        }
        #endregion 
    }
}
