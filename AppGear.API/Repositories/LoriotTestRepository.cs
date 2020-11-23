using System.Collections.Generic;
using System.Linq;
using AppGear.API.DTOs;
using AppGear.API.Models;

namespace AppGear.API.Repositories
{
    public class LoriotTestRepository : ILoriotTestRepository
    {

        private readonly LorawanContext _databaseContext;

        public LoriotTestRepository(LorawanContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<LoriotTest> Get()
        {
           return _databaseContext.LoriotsTest.ToList();
        }

        public LoriotTest Get(int id)
        {
           return _databaseContext.LoriotsTest.FirstOrDefault(x => x.Id == id);
        }

        public void Post(LoriotTest loriot)
        {
            _databaseContext.LoriotsTest.Add(loriot);
            _databaseContext.SaveChanges();
        }

        public void Put(LoriotTestDTO loriot, int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(LoriotTest loriot)
        {
            _databaseContext.LoriotsTest.Remove(loriot);
            _databaseContext.SaveChanges();
        }
    }
}