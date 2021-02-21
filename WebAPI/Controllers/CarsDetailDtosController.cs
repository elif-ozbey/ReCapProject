using Business.Abstarct;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsDetailDtosController : ControllerBase
    {
        ICarService _carDetailDto;
        public CarsDetailDtosController(ICarService carDetailDto)
        {
            _carDetailDto = carDetailDto;
        }

        [HttpGet("getcardetail")]
        
        public IActionResult GetCarDetail( )
        {
            var result = _carDetailDto.GetCarDetailDtos();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


}
}
