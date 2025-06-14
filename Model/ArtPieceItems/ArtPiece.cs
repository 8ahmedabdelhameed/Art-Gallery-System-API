using Art_Gallery.Model.CategoryItems;
using Art_Gallery.Model.CustomerItems;
using Microsoft.Extensions.Options;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Art_Gallery.Model.ArtPieceItems
{
    public class ArtPiece
    {
        public int ArtPieceId { get; set; }
        public string ArtPieceTitle { get; set; } = string.Empty;
        public string ? ArtPieceDescription { get; set; }
        public decimal ArtPiecePrice { get; set; }
        public int ? CustomerId { get; set; }
        public Customer ? customer { get; set; } 
        public List<Category> ? categories { get; set; } = new List<Category>();
    }
}
