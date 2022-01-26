using Customer.Infrastructure;

namespace Customer.Services
{
    public class CustomerService : ICustomerService
    {
        public Models.Customer GetCustomerById(string id)
        {
            return new Models.Customer
            {
                Id = id,
                FirstName = "Gina",
                LastName = "Linetti"
            };
        }
    }
}