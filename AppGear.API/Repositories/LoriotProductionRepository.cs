using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGear.API.DTOs;
using AppGear.API.Models;
using AppGear.API.Services;
using Microsoft.AspNetCore.SignalR;

namespace AppGear.API.Repositories
{
    public class LoriotProductionRepository : Hub, ILoriotProductionRepository
    {

        private readonly LorawanContext _databaseContext;
        private readonly ILoriotDecoderRepository _decoder;

        public LoriotProductionRepository(LorawanContext databaseContext, ILoriotDecoderRepository decoder)
        {
            _databaseContext = databaseContext;
            _decoder = decoder;
        }

        public List<LoriotProduction> Get()
        {
            return _databaseContext.LoriotsProduction.ToList();
        }

        public LoriotProduction Get(int id)
        {
            return _databaseContext.LoriotsProduction.FirstOrDefault(x => x.Id == id);
        }

        public async void Post(LoriotProduction loriotProduction)
        {
            if (loriotProduction.cmd == "rx")
            {
                var decoderModel = await _decoder.UnpackData(loriotProduction.data, loriotProduction.EUI);
                _decoder.Post(decoderModel);
            }

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
