using Art_Gallery.Model.CategoryItems;
using System.ComponentModel.DataAnnotations;

namespace Art_Gallery.Model.ArtPieceItems
{
    public class ArtPieceDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string ArtPieceTitle { get; set; } = string.Empty;
            [StringLength(500, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string ? ArtPieceDescription { get; set; }
        [Range(0,double.MaxValue, ErrorMessage = "Price must be a non-negative number.")]
        public decimal ArtPiecePrice { get; set; }
        public List<CategoryDto> categories { get; set; } 
    }
     public class ArtPieceDtoPostWithCat
    {
        [Required]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string ArtPieceTitle { get; set; } = string.Empty;
            [StringLength(500, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string ? ArtPieceDescription { get; set; }
        [Range(0,double.MaxValue, ErrorMessage = "Price must be a non-negative number.")]
        public decimal ArtPiecePrice { get; set; }
    }
        public class ArtPiecePostDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string ArtPieceTitle { get; set; } = string.Empty;
            [StringLength(500, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string ? ArtPieceDescription { get; set; }
        [Range(0,double.MaxValue, ErrorMessage = "Price must be a non-negative number.")]
        public decimal ArtPiecePrice { get; set; }
        public List<CategoryDto> ? categories { get; set; } 
        [Required]
        public int CustomerId { get; set; } 
    }
}
