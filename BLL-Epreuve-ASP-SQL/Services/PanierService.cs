using Shared_Epreuve_ASP_SQL.Repositories;
using DAL = DAL_Epreuve_ASP_SQL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using BLL_Epreuve_ASP_SQL.Entities;
using System.Linq;
using BLL_Epreuve_ASP_SQL.Mappers;

namespace BLL_Epreuve_ASP_SQL.Services
{
    public class PanierService : IPanierRepository<Panier>
    {
        private readonly IPanierRepository<DAL.Panier> _repository;
        public PanierService(IPanierRepository<DAL.Panier> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Panier> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }
    }
}
