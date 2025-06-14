using Art_Gallery.Model.ArtPieceItems;
using System.ComponentModel.DataAnnotations;

namespace Art_Gallery.Model.CategoryItems
{
    public class CategoryDto
    {
         [Required]
     public string CategoryName { get; set; }
    }
    public class CategoryPostDto
    {
        [Required]
        public string CategoryName { get; set; }
        public List<ArtPieceDtoPostWithCat> ? artPieces { get; set; }
    }

}
