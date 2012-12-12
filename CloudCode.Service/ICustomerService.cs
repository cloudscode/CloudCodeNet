using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CloudCode.Dao;
using CloudCode.Domain;

namespace CloudCode.Service
{
    public interface ICustomerService
    {
        ICustomerDao CustomerDao { set; get; }
        IList<Customer> GetAllCustomers();
        string save(Customer customer);
        Customer Get(string id);
    }
}
