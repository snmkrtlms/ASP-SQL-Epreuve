using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve_ASP_SQL.Models
{
    public class PanierListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Panier { get; set; }
        [DisplayName("Quantité : ")]
        public int Quantite { get; set; }
        [DisplayName("Identifiant de la commande : ")]
        public int Id_Commande { get; set; }
        [DisplayName("Identifiant du produit : ")]
        public int Id_Produit { get; set; }
    }
}
