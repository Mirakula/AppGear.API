using System.Collections.Generic;
using AppGear.API.DTOs;
using AppGear.API.Models;

namespace AppGear.API.Repositories
{
    public interface ILorawanRepository
    {
        List<Lorawan> Get();
        void Get(int id);
        void Post(Lorawan lorawan);
        void Put(LorawanDTO lorawan, int id);
        void Delete(int id);
    }
}