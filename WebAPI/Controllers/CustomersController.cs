using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getallcustomers")]
        public ActionResult GetAllCustomer()
        {
            var result = _customerService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpGet("getbyid")]
        public ActionResult GetById(int customerId)
        {
            var result = _customerService.GetById(customerId);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost("addcustomer")]
        public ActionResult AddCustomer(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.IsSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost("deletecustomer")]
        public ActionResult DeleteCustomer(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.IsSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost("updatecustomer")]
        public ActionResult UpdateCustomer(Customer customer)
        {
            var result = _customerService.Update(customer);
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
