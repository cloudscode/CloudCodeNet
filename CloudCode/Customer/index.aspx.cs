using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudCode.Customer
{
    public partial class index : System.Web.UI.Page
    {
        public CloudCode.Service.ICustomerService CustomerService { set; get; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                IList<CloudCode.Domain.Customer> list = this.CustomerService.GetAllCustomers();
                this.gvCustomer.DataSource = list;
                this.gvCustomer.DataBind();
            }
        }
    }
}