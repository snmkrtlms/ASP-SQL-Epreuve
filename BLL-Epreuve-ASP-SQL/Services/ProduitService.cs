using BLL_Epreuve_ASP_SQL.Entities;
using DAL = DAL_Epreuve_ASP_SQL.Entities;
using BLL_Epreuve_ASP_SQL.Mappers;
using Shared_Epreuve_ASP_SQL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL_Epreuve_ASP_SQL.Services
{
    public class ProduitService : IProduitRepository<Produit>
    {
        private readonly IProduitRepository<DAL.Produit> _repository;
        public ProduitService(IProduitRepository<DAL.Produit> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Produit> Get()
        {
            return _repository.Get().Select(d=>d.ToBLL());
        }

        public Produit Get(int id)
       {
            return _repository.Get(id).ToBLL();
        }

        public IEnumerable<Produit> GetByCategorie(string categorie)
        {
            return _repository.GetByCategorie(categorie).Select(d => d.ToBLL());
        }

        public IEnumerable<Produit> GetByCritereEco(string critereEco)
        {
            return _repository.GetByCritereEco(critereEco).Select(d => d.ToBLL());
        }

        public IEnumerable<Produit> GetByNom(string nomProduit)
        {
            return _repository.GetByNom(nomProduit).Select(d => d.ToBLL());
        }

        public IEnumerable<Produit> GetPopulaires()
        {
            return _repository.GetPopulaires().Select(d => d.ToBLL());
        }

        public int Insert(Produit entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public void Update(Produit entity)
        {
            _repository.Update(entity.ToDAL());
        }
    }
}
