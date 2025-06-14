using Art_Gallery.Model.CustomerItems;

namespace Art_Gallery.Model
{
    public class LoyaltyCard
    { 
        public int LoyaltyCardId { get; set; }
        public string CardNumber { get; set; } 
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
    }
}
