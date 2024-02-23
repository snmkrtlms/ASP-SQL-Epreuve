using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_ASP_SQL.Entities
{
    public class Media
    {
        //Constructeur
        public Media(int id_Media, string url, int id_Produit)
        {
            Id_Media = id_Media;
            Url = url;
            Id_Produit = id_Produit;
        }

        public Media()
        {
        }

        public int Id_Media {  get; set; }
        public string Url { get; set; }
        public int Id_Produit { get; set; }
    }
}
