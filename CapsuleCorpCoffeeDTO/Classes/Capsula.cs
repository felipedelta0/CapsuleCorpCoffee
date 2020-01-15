using System;
using System.Data;

namespace CapsuleCorpCoffeeDTO.Classes
{
    public class Capsula
    {
        #region Propriedades
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Forca { get; set; }
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
        public Capsula()
        {
            this.ID = -1;
            this.Descricao = "";
            this.Forca = 0;
        }

        public Capsula(DataRow row)
        {
            this.ID = int.Parse(row["ID"].ToString());
            this.Descricao = row["Descricao"].ToString();
            this.Forca = int.Parse(row["Forca"].ToString());
        }
        #endregion
    }
}
