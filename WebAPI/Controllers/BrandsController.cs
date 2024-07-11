using ConsoleApp1.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using RecapProjectCar.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("getallbrand")]
        public IActionResult Get()
        {
            var result =_brandService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
        [HttpPost("addbrand")]
        public IActionResult Post(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest();
        }
        [HttpGet("getbyidbrand")]
        public IActionResult Get(int id)
        {
            var resultt =_brandService.GetById(id);
            if (resultt.Success)
            {
                return Ok(resultt.Data);

            }
            return BadRequest();
        }
       


    }
}
