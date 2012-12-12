using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudCode.Dao;
using CloudCode.Domain;
namespace CloudCode.Service
{
    [Spring.Stereotype.Service]
    [Spring.Transaction.Interceptor.Transaction(ReadOnly=true)]
    public class CustomerService:ICustomerService
    {
        public ICustomerDao CustomerDao { set; get; }
        public IList<Customer> GetAllCustomers()
        {
            IQueryable<Customer> query = this.CustomerDao.GetAllCustomers();
            return query.ToList<Customer>();

        }
        public string save(Customer customer)
        {
            return this.CustomerDao.save(customer);
        }
        public Customer Get(string id)
        {
            return this.CustomerDao.Get(id);
        }
    }
}
