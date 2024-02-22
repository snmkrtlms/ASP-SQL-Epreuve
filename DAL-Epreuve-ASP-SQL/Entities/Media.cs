using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve_ASP_SQL.Entities
{
    public class Media
    {
        public int Id_Media { get; set; }
        public string Url { get; set; }
        public int Id_Produit {  get; set; }
    }
}
