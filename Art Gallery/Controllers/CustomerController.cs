using Art_Gallery.CustomerItems;
using Art_Gallery.Model.ArtPieceItems;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Art_Gallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _repo;

        public CustomerController(ICustomerRepo repo)
        {
            _repo = repo;
        }
          [HttpPost]
        public IActionResult PostCustomer(PostCustomerDto s)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            _repo.PostCustomer(s);
            return Created();
        }
              [HttpGet]
        public IActionResult GetCustomer(int id)
        {
          var x =  _repo.GetCustomer(id);
            return Ok(x);
        }
    }
}
