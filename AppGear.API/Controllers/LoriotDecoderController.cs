using System;
using System.Threading.Tasks;
using AppGear.API.Models;
using AppGear.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AppGear.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoriotDecoderController : ControllerBase
    {
        private readonly ILoriotDecoderRepository _decoder;
        
        public LoriotDecoderController(ILoriotDecoderRepository decoder)
        {
            _decoder = decoder;
        }
        
        [HttpPost]
        public async Task<IActionResult> DecodeData(LoriotTest loriotTest)
        {
            var decodeModel = await _decoder.UnpackData(loriotTest.data);

            try
            {
                _decoder.Post(decodeModel);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}