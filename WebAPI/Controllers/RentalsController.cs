using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.IsSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpGet("getbyid")]
        public ActionResult GetById(int rentalId)
        {
            var result = _rentalService.GetById(rentalId);
            if (result.IsSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost("add")]
        public ActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.IsSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost("delete")]
        public ActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.IsSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost("update")]
        public ActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.IsSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}
