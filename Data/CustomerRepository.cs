using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MySampleWeb.Models;

namespace MySampleWeb.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private NorthWindContext _context;

        public CustomerRepository(NorthWindContext context)
        {
            _context = context;
        }

        public void Add(Customer Customer)
        {
            throw new NotImplementedException();
        }

        public Customer Find(string CustomerID)
        {
            return _context
                .Customers
                .Find(CustomerID);
        }

        public IEnumerable<Customer> GetAll(int offset, int limit)
        {
            return _context
                .Customers
                .OrderBy(c => c.CompanyName)
                .Skip(offset)
                .Take(limit)
                .AsNoTracking()
                .ToList();
        }

        public void Remove(string CustomerID)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer Customer)
        {
            throw new NotImplementedException();
        }
    }
}