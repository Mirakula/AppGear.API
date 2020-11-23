using System;
using System.Collections.Generic;
using System.Linq;
using AppGear.API.DTOs;
using AppGear.API.Models;

namespace AppGear.API.Repositories
{
    public class LoriotProductionRepository : ILoriotProductionRepository
    {

        private readonly LorawanContext _databaseContext;

        public LoriotProductionRepository(LorawanContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<LoriotProduction> Get()
        {
            return _databaseContext.LoriotsProduction.ToList();
        }

        public LoriotProduction Get(int id)
        {
            return _databaseContext.LoriotsProduction.FirstOrDefault(x => x.Id == id);
        }

        public void Post(LoriotProduction loriotProduction)
        {
            _databaseContext.Add(loriotProduction);
            _databaseContext.SaveChanges();
        }

        public void Put(LoriotProductionDTO loriotProductionDto, int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(LoriotProduction loriotProduction)
        {
            _databaseContext.Remove(loriotProduction);
            _databaseContext.SaveChanges();
        }
    }
}
