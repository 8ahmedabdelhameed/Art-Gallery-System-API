namespace Art_Gallery.CustomerItems
{
    public interface ICustomerRepo
    {
        void PostCustomer(PostCustomerDto customer);
        PostCustomerDto GetCustomer(int id);
    }
}
