using Art_Gallery.Model.ArtPieceItems;
using Art_Gallery.Model;
using System.ComponentModel.DataAnnotations;

namespace Art_Gallery.CustomerItems
{
    public class CustomerDto
    {
    }
    public class PostCustomerDto
    {
          [Required(ErrorMessage = "Customer name is required.")]
          public string CustomerName { get; set; } 
          [EmailAddress(ErrorMessage = "Invalid email address.")]
          public string CustomerEmail { get; set; }
          public LoyaltyCardDto ? LoyaltyCard { get; set; }
          public List<ArtPieceDto> ? ArtPieces { get; set; } 
    }
}
