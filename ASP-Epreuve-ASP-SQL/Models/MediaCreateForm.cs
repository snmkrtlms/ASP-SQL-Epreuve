using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve_ASP_SQL.Models
{
    public class MediaCreateForm
    {
        [DisplayName("Charger l'image : ")]
        [Required]
        public IFormFile Url { get; set; }
        [DisplayName("L'identifiant du produit : ")]
        [Required]
        public int Id_Produit { get; set; }
    }
}
