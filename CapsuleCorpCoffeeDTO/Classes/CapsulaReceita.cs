using System;
using System.Data;

namespace CapsuleCorpCoffeeDTO.Classes
{
    public class CapsulaReceita
    {
        #region Propriedades

        public int ID { get; set; }
        public int Receita { get; set; }
        public int Capsula { get; set; }
        public int Quantidade { get; set; }
        public bool IsEditar
        {
            get
            {
                if (this.ID > 0)
                    return true;
                return false;
            }
        }

        #endregion

        #region Construtores
        public CapsulaReceita()
        {
            ID = -1;
            Receita = -1;
            Capsula = -1;
            Quantidade = -1;
        }

        public CapsulaReceita(DataRow row)
        {
            ID = Int32.Parse(row["ID"].ToString());
            Receita = Int32.Parse(row["Receita_ID"].ToString());
            Capsula = Int32.Parse(row["Capsula_ID"].ToString());
            Quantidade = Int32.Parse(row["Quantidade"].ToString());
        }
        #endregion
    }
}
