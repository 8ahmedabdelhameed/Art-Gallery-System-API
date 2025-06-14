using Art_Gallery.Model;
using Art_Gallery.Model.CategoryItems;
using Art_Gallery.Model.CustomerItems;
using Microsoft.EntityFrameworkCore;

namespace Art_Gallery.CustomerItems
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public PostCustomerDto GetCustomer(int id)
        {
            var cus = _context.Customers.Include(x=>x.ArtPieces).ThenInclude(x=>x.categories).Include(x=>x.LoyaltyCard).FirstOrDefault(c => c.CustomerId == id);
            if(cus != null)
            {
                return new PostCustomerDto
                {
                    CustomerEmail = cus.CustomerEmail,
                    CustomerName = cus.CustomerName,
                    LoyaltyCard = cus.LoyaltyCard != null ? new LoyaltyCardDto
                    {
                        CardNumber = cus.LoyaltyCard.CardNumber,
                        Balance = cus.LoyaltyCard.Balance
                    } : null,
                    ArtPieces =  cus.ArtPieces == null ? null : cus.ArtPieces.Select(x=>new Model.ArtPieceItems.ArtPieceDto
                    {
                        ArtPieceDescription = x.ArtPieceDescription,
                        ArtPiecePrice = x.ArtPiecePrice,
                        ArtPieceTitle = x.ArtPieceTitle,
                        categories =x.categories.Select(x=> new CategoryDto 
                        {
                        CategoryName = x.CategoryName}).ToList()
                        }).ToList()
                    };
                }
            return null;
           }
        
        public void PostCustomer(PostCustomerDto customer)
        {
            LoyaltyCard c = new LoyaltyCard
            {
                CardNumber = customer.LoyaltyCard.CardNumber,
                Balance = customer.LoyaltyCard.Balance
            };
            var customers = new Customer
            {
                CustomerEmail = customer.CustomerEmail,
                CustomerName = customer.CustomerName,
                ArtPieces = customer.ArtPieces == null ? null : customer.ArtPieces.Select(x=>new Model.ArtPieceItems.ArtPiece
                {
                    ArtPiecePrice = x.ArtPiecePrice,
                    ArtPieceTitle = x.ArtPieceTitle,
                    ArtPieceDescription = x.ArtPieceDescription,
                    categories = x.categories.Select(x=> new Category
                    {
                        CategoryName = x.CategoryName
                    }).ToList(),
                }).ToList(),
                LoyaltyCard = c
            };
            _context.Customers.Add(customers);
            _context.SaveChanges();
        }
    }
}
