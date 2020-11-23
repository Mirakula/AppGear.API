using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGear.API.DTOs;
using AppGear.API.Models;

namespace AppGear.API.Repositories
{
    public interface ILoriotProductionRepository
    {
        List<LoriotProduction> Get();
        LoriotProduction Get(int id);
        void Post(LoriotProduction loriotProduction);
        void Put(LoriotProductionDTO loriotProductionDto, int id);
        void Delete(LoriotProduction loriotProduction);
    }
}
