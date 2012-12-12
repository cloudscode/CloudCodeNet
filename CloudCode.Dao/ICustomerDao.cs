using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CloudCode.Domain;

namespace CloudCode.Dao
{
   public interface ICustomerDao
    {
        IQueryable<Customer> GetAllCustomers();
        string save(Customer customer);
        Customer Get(string id);
    }
}
