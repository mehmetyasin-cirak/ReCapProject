using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

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

        [HttpGet("getallbrands")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getbybrandid")]
        public IActionResult GetAllByBrandId(int brandId)
        {
            var result = _brandService.GetById(brandId);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addbrand")]
        public IActionResult AddBrand(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("deletebrand")]
        public IActionResult DeleteBrand(Brand brand)
        {
            var result = _brandService.Remove(brand);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("updatebrand")]
        public IActionResult UpdateBrand(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
