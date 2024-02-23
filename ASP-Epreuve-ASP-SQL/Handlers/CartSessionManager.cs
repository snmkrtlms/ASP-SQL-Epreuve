using BLL_Epreuve_ASP_SQL.Entities;
using System.Text.Json;


namespace ASP_Epreuve_ASP_SQL.Handlers
{
    public class CartSessionManager : SessionManager
    {
        public CartSessionManager(IHttpContextAccessor httpContext) : base(httpContext)
        {
        }

        public List<Produit> Panier {  get; set; }
        //{
        //    get 
        //    {
        //        if(_session.GetString(nameof(Panier)) is null) 
        //            Panier = new List<Produit>();
        //        return JsonSerializer.Deserialize<Produit[]>(_session.GetString(nameof(Panier)));
        //    }
        //    private set
        //    {
        //        _session.SetString(nameof(Panier), JsonSerializer.Serialize(value));
        //    }
        //}

        public void AddProduit(Produit prod)
        {
            List<Produit> produits = new List<Produit>(Panier);
            produits.Add(prod);
            Panier = produits;
        }

    }
}
