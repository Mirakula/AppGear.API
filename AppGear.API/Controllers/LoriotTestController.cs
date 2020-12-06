using System;
using AppGear.API.Models;
using AppGear.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AppGear.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoriotTestController : Controller
    {
        private readonly ILoriotTestRepository _loriotTestRepository;
        
        //Dependency injection
        public LoriotTestController(ILoriotTestRepository loriotRepository)
        {
            _loriotTestRepository = loriotRepository;
        }

        //CRUD
        //Read
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var loraWanList = _loriotTestRepository.Get();
                if (loraWanList == null)
                    NotFound();
                
                return Ok(loraWanList);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);                
            }
        }
        
        //Get By Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var loraWan = _loriotTestRepository.Get(id);
                if (loraWan == null)
                    return NotFound();
                
                return Ok(loraWan);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Create
        [HttpPost]
        public IActionResult Post(LoriotTest loriot)
        {
            try
            {
                _loriotTestRepository.Post(loriot);
                return Ok();
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        //Delete
        [HttpDelete]
        public IActionResult Delete(LoriotTest loriot)
        {
            try
            {
                _loriotTestRepository.Delete(loriot);
                return Ok();
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        //Put
        [HttpPut]
        public IActionResult Put()
        {
            throw new NotImplementedException();
        }
    }
}