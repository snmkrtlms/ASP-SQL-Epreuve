using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve_ASP_SQL.Models
{
    public class ProduitListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Produit { get; set; }
        [DisplayName("Nom : ")]
        public string Nom { get; set; }
        [DisplayName("Description : ")]
        public string Description { get; set; }
        [DisplayName("Prix : ")]
        [DataType(DataType.Currency)]
        public decimal Prix { get; set; }
        [DisplayName("Critère écologique : ")]
        public string CritereEco { get; set; }
        [DisplayName("Catégorie : ")]
        public string Categorie { get; set; }
    }
}
