namespace Customer.Infrastructure
{
    public interface ICustomerService
    {
        public Models.Customer GetCustomerById(string id);
    }
}