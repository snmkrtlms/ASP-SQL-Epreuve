﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Epreuve_ASP_SQL.Models
{
    public class ProduitDetailsViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Produit { get; set; }
        [DisplayName("Nom : ")]
        public string Nom { get; set; }
        [DisplayName("Description : ")]
        public string Description { get; set; }
        [DisplayName("Prix : ")]
        public decimal Prix { get; set; }
        [DisplayName("Critère écologique : ")]
        public string CritereEco { get; set; }
        [DisplayName("Catégorie : ")]
        public string Categorie { get; set; }
        [DisplayName("Médias :")]
        [DataType(DataType.ImageUrl)]
        public List<string> UrlImages { get; set; }

        public ProduitDetailsViewModel()
        {
            UrlImages = new List<string>();
        }
    }
}