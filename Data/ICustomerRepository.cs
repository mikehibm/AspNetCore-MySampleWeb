using System.Collections.Generic;
using MySampleWeb.Models;

namespace MySampleWeb.Data
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll(int offset, int limit);
        Customer Find(string CustomerID);
        void Add(Customer Customer);
        void Update(Customer Customer);
        void Remove(string CustomerID);
    }
}