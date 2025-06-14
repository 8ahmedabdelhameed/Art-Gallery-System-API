namespace Art_Gallery.Model.ArtPieceItems
{
    public class ArtPieceRepo : IArtPieceRepo
    {
        private readonly AppDbContext _context ;

        public ArtPieceRepo(AppDbContext context)
        {
            _context = context;
        }
        public void PostPieceOfArt(ArtPiecePostDto s)
        {
            ArtPiece artPiece = new ArtPiece
            {
                ArtPiecePrice = s.ArtPiecePrice,
                ArtPieceTitle = s.ArtPieceTitle,
                ArtPieceDescription =s.ArtPieceDescription,
                categories = s.categories.Select(x=> new CategoryItems.Category
                {
                    CategoryName = x.CategoryName
                }).ToList(),
                customer = _context.Customers.FirstOrDefault(x=>x.CustomerId == s.CustomerId) == null ? null : _context.Customers.FirstOrDefault(x=>x.CustomerId == s.CustomerId)
            };
            _context.Add(artPiece);
            _context.SaveChanges();
    }
    }
}
