using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getallcolor")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addcolor")]
        public IActionResult AddColor(Color color)
        {
            var result = _colorService.Add(color);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(result.Message);
        }
        [HttpPost("deletecolor")]
        public IActionResult DeleteColor(Color color)
        {
            var result = _colorService.Remove(color);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(result.Message);
        }
        [HttpPost("updatecolor")]
        public IActionResult UpdateColor(Color color)
        {
            var result = _colorService.Update(color);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(result.Message);
        }
    }
}
