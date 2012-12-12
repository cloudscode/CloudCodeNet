using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using CloudCode.Domain;

namespace CloudCode.View
{
  
    /// <summary>
    /// Order Entry CustomerList View Model 
    /// </summary>
    public class CustomerViewModel : ViewInformation
    {

        public List<Customer> Customers;
        public Customer Customer;
        public int TotalCustomers { get; set; }
        
        public CustomerViewModel()
        {
            Customer = new Customer();
            Customers = new List<Customer>();
            ReturnMessage = new List<String>();
            ValidationErrors = new Hashtable();
            TotalCustomers = 0;
        }

    }
}
