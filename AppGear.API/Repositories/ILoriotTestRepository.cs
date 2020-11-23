using System.Collections.Generic;
using System.Reflection.Metadata;
using AppGear.API.DTOs;
using AppGear.API.Models;

namespace AppGear.API.Repositories
{
    public interface ILoriotTestRepository
    {
        // Interface C.R.U.D

        //Read
        List<LoriotTest> Get();
        //Read
        LoriotTest Get (int id);
        //Create
        void Post(LoriotTest loriot);
        //Update
        void Put(LoriotTestDTO loriot, int id);
        //Delete
        void Delete(LoriotTest loriot);
    }
}