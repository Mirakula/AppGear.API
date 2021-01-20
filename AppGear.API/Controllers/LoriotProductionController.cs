using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using AppGear.API.Models;
using AppGear.API.Repositories;
using AppGear.API.Services;
using Microsoft.AspNetCore.SignalR;

namespace AppGear.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class LoriotProductionController : ControllerBase
    {
        private readonly ILoriotProductionRepository _loriotProductionRepository;

        private readonly ILoriotDecoderRepository _decoder;
        private readonly IBusCapacaityCalculator _busCapacaity;


        public LoriotProductionController(ILoriotProductionRepository loriotRepository, 
                ILoriotDecoderRepository decoder, IBusCapacaityCalculator busCapacaity)
        {
            _loriotProductionRepository = loriotRepository;
            _decoder = decoder;
            _busCapacaity = busCapacaity;
        }

        //Read
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var loraWanList = _loriotProductionRepository.Get();
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
                var loraWan = _loriotProductionRepository.Get(id);
                if (loraWan == null)
                    return NotFound();

                return Ok(loraWan);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(LoriotProduction loriot)
        {
            try
            {
                _loriotProductionRepository.Post(loriot);

                return Ok();
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Delete
        [HttpDelete]
        public IActionResult Delete(LoriotProduction loriot)
        {
            try
            {
                _loriotProductionRepository.Delete(loriot);
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
