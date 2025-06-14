using Art_Gallery.Model.ArtPieceItems;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Art_Gallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtPieceController : ControllerBase
    {
        private readonly IArtPieceRepo _context ;

        public ArtPieceController(IArtPieceRepo context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult PostPiece(ArtPiecePostDto s)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.PostPieceOfArt(s);
            return Created();
        }
    }
}
