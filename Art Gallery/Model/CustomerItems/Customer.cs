using Art_Gallery.Model.ArtPieceItems;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Art_Gallery.Model.CustomerItems
{
    public class Customer
    {  
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } 
        public string CustomerEmail { get; set; }
        public LoyaltyCard ? LoyaltyCard { get; set; }
        public List<ArtPiece> ? ArtPieces { get; set; } 
    }
}
