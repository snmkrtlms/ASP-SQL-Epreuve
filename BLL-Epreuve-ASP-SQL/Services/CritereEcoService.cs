using BLL_Epreuve_ASP_SQL.Entities;
using DAL = DAL_Epreuve_ASP_SQL.Entities;
using Shared_Epreuve_ASP_SQL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BLL_Epreuve_ASP_SQL.Mappers;

namespace BLL_Epreuve_ASP_SQL.Services
{
    public class CritereEcoService : ICritereEcoRepository<CritereEco>
    {
        private readonly ICritereEcoRepository<DAL.CritereEco> _repository;
        public CritereEcoService(ICritereEcoRepository<DAL.CritereEco> repository)
        {
            _repository = repository;
        }
        public IEnumerable<CritereEco> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }
    }
}
