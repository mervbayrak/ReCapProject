using CarRentalSystem.Business.Abstract;
using CarRentalSystem.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }


        // GET api/carImages
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // GET api/carImages/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        // POST api/carImages
        [HttpPost]
        public IActionResult Post(CarImage carImage)
        {
            var result = _carImageService.Add(carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        // PUT api/carImages/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, CarImage carImage)
        {
            var result = _carImageService.Update(carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        // DELETE api/carImages/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = _carImageService.GetById(id).Data;

            var result = _carImageService.Delete(data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
