namespace Art_Gallery.Model.CategoryItems
{
    public class CategoryRepo : ICategoryRepo
    { 
        private readonly AppDbContext _context;

        public CategoryRepo(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }
        public void DeleteCategory(int id)
        {
           var cat = _context.Categories.Find(id);
            if(cat != null)
            {
                _context.Categories.Remove(cat);
                _context.SaveChanges();
            }
           throw new Exception("Non Found category");

        }
        public List<CategoryPostDto> GetAll()
        {
            return _context.Categories.Select(x=>new CategoryPostDto
            {
                CategoryName = x.CategoryName,
                artPieces = x.artPieces == null ? null : x.artPieces.Select(x=> new ArtPieceItems.ArtPieceDtoPostWithCat
                {
                    ArtPiecePrice = x.ArtPiecePrice,
                    ArtPieceDescription =x.ArtPieceDescription,
                    ArtPieceTitle = x.ArtPieceTitle
                }).ToList()
            }).ToList();
        }

        public void postCategory(CategoryPostDto dto)
        {
            Category category = new Category
            {
                CategoryName = dto.CategoryName,
                artPieces = dto.artPieces == null ? null : dto.artPieces.Select(x=> new ArtPieceItems.ArtPiece
                {
                    ArtPieceDescription = x.ArtPieceDescription,
                    ArtPieceTitle = x.ArtPieceTitle,
                    ArtPiecePrice = x.ArtPiecePrice,
                }).ToList()
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public void UpdateCategory(CategoryPostDto dto,int id)
        {
            var context = _context.Categories.Find(id);
            if(context != null)
            { 
                context.CategoryName = dto.CategoryName;
                context.artPieces = dto.artPieces == null ? null : dto.artPieces.Select(x=> new ArtPieceItems.ArtPiece
                {
                    ArtPieceDescription = x.ArtPieceDescription,
                    ArtPieceTitle = x.ArtPieceTitle,
                    ArtPiecePrice = x.ArtPiecePrice
                }).ToList();
            _context.Categories.Update(context);
            _context.SaveChanges();
            }
            else {
            throw new Exception("category not found ");
            }
        }
    }
}
