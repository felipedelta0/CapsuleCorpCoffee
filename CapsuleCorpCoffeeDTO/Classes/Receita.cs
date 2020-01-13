using System;
using System.Collections.Generic;
using System.Data;

namespace CapsuleCorpCoffeeDTO.Classes
{
    public class Receita
    {
        #region Propriedades
        public int ID { get; set; }
        public string Descricao { get; set; }
        public List<CapsulaReceita> Items { get; set; }
        public bool IsEditar
        {
            get
            {
                return ID > 0 ? true : false;
            }
        }

        #endregion 

        #region Construtores
        public Receita()
        {
            ID = -1;
            Descricao = "";
            Items = new List<CapsulaReceita>();
        }

        public Receita(DataRow row)
        {
            ID = Int32.Parse(row["ID"].ToString());
            Descricao = row["Descricao"].ToString();
            Items = new List<CapsulaReceita>();
        }
        #endregion
    }
}
