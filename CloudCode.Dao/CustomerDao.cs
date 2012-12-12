using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate.Linq;
using CloudCode.Domain;

namespace CloudCode.Dao
{
    [Spring.Stereotype.Repository]
    // [Spring.Transaction.Interceptor.Transaction(ReadOnly = false)]
    public class CustomerDao : ICustomerDao, INHibernateSessionFactory
    {
        public NHibernate.ISessionFactory SessionFactory { set; get; }
        public IQueryable<Customer> GetAllCustomers()
        {
            NHibernate.ISession session = this.SessionFactory.GetCurrentSession();
            var query = session.Query<Customer>();
            var result = from customer in query
                         select customer;
            return result;
        }
        public string save(Customer customer)
        {
            return this.SessionFactory.GetCurrentSession().Save(customer).ToString();
        }
        public Customer Get(string id)
        {
            return this.SessionFactory.GetCurrentSession().Get<Customer>(id);
        }
    }
}
