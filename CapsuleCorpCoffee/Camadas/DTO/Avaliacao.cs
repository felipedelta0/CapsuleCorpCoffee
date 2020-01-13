using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCorpCoffee.Camadas.DTO
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
            ID = Int32.Parse(row["ID"].ToString());
            Nota = Int32.Parse(row["Nota"].ToString());
            Receita = Int32.Parse(row["Receita_ID"].ToString());
            Usuario = row["Usuario"].ToString();
            Comentario = row["Comentario"].ToString();
        }
        #endregion
    }
}
