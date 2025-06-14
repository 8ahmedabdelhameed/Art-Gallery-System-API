using System.ComponentModel.DataAnnotations;

namespace Art_Gallery.Model
{
    public class LoyaltyCardDto
    { 
        [Required(ErrorMessage = "Card Number is required")]
        [StringLength(16, ErrorMessage = "Card Number must be 16 characters long")]
        public string CardNumber { get; set; } 
        [Required(ErrorMessage = "Balance is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Balance must be a non-negative number")]
        public decimal Balance { get; set; }
    }
}
