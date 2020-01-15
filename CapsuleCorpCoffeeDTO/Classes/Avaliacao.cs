using System;
using System.Data;

namespace CapsuleCorpCoffeeDTO.Classes
{
    public class Avaliacao
    {
        #region Propriedades
        public int ID { get; set; }
        public int Nota { get; set; }
        public int Receita { get; set; }
        public string Usuario { get; set; }
        public string Comentario { get; set; }
        public bool IsEditar
        {
            get
            {
                return ID > 0 ? true : false;
            }
        }
        #endregion

        #region Construtores
        public Avaliacao()
        {
            ID = -1;
            Nota = -1;
            Receita = -1;
            Usuario = "";
            Comentario = "";
        }

        public Avaliacao(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            Nota = int.Parse(row["Nota"].ToString());
            Receita = int.Parse(row["Receita_ID"].ToString());
            Usuario = row["Usuario"].ToString();
            Comentario = row["Comentario"].ToString();
        }
        #endregion
    }
}
