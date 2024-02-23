using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Epreuve_ASP_SQL.Models
{
    public class ProduitEditForm
    {
        [HiddenInput]
        [Required]
        public int Id_Produit { get; set; }
        [DisplayName("Nom : ")]
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [MinLength(2, ErrorMessage = "Le nom doit être composé de minimum 2 caractères.")]
        [MaxLength(64, ErrorMessage = "Le nom doit être composé de maximum 64 caractères.")]
        public string Nom { get; set; }
        [DisplayName("Description : ")]
        [Required(ErrorMessage = "La description est obligatoire.")]
        public string Description { get; set; }
        [DisplayName("Prix : ")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Le prix est obligatoire.")]
        public decimal Prix { get; set; }
        [DisplayName("Critère écologique : ")]
        [Required(ErrorMessage = "Le choix du critère est obligatoire.")]
        public string CritereEco { get; set; }
        [DisplayName("Catégorie : ")]
        [Required(ErrorMessage = "La catégorie est obligatoire.")]
        public string Categorie { get; set; }
    }
}
