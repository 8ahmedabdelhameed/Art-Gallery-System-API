using Art_Gallery.Model.CategoryItems;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Art_Gallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _repo ;

        public CategoryController(ICategoryRepo repo)
        {
            this._repo = repo;
        }
        [HttpDelete]
        public IActionResult deletecategory(int id)
        {
            _repo.DeleteCategory(id);
            return NoContent();
        }
           [HttpPost]
        public IActionResult PostCat(CategoryPostDto ss)
        {
            if(ModelState.IsValid)
            { 
            _repo.postCategory(ss);
            return Created();
            }
            else
            {
                return BadRequest();
            }
        }
            [HttpPut]
        public IActionResult UpdateCat(CategoryPostDto ss,int id)
        {
            if(ModelState.IsValid)
            { 
            _repo.UpdateCategory(ss,id);
            return Created();
            }
            else
            {
                return BadRequest();
            }
        }
             [HttpGet]
        public IActionResult UpdateCat()
        {
          var x =  _repo.GetAll();
            return Ok(x);
        }
    }

}
