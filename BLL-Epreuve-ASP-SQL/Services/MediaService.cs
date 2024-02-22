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
    public class MediaService : IMediaRepository<Media>
    {
        private readonly IMediaRepository<DAL.Media> _repository;
        public MediaService(IMediaRepository<DAL.Media> repository)
        {
            _repository = repository;
        }
 
        public void Delete(int id)
            {
                throw new NotImplementedException();
            }

        public IEnumerable<Media> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public Media Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Media entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public void Update(Media entity)
        {
            throw new NotImplementedException();
        }
    }
}
