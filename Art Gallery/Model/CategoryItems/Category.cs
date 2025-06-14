using Art_Gallery.Model.ArtPieceItems;

namespace Art_Gallery.Model.CategoryItems
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ArtPiece> artPieces { get; set; } = new List<ArtPiece>();

    }
}
