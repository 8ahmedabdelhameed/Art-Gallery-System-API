namespace Art_Gallery.Model.CategoryItems
{
    public interface ICategoryRepo
    {
        void postCategory(CategoryPostDto dto);
        void UpdateCategory(CategoryPostDto dto,int id);
         List<CategoryPostDto> GetAll();
        void DeleteCategory(int id);
    }
}
