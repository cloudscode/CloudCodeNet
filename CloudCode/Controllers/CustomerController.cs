using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CloudCode.Service;
using CloudCode.Domain;

namespace CloudCode.Controllers
{
    public class CustomerController : Controller
    {
        public ICustomerService CustomerService { set; get; }
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllCustomers()
        {
            IList<CloudCode.Domain.Customer> list = this.CustomerService.GetAllCustomers();
            Response.Write(list);
           // Response.End();
            //return Json(list);
            return Json(list, JsonRequestBehavior.AllowGet); 
        }
        public ActionResult save()
        {
            CloudCode.Domain.Customer cus = new CloudCode.Domain.Customer();
           // cus.Id = "Cloud";
           string strCus = this.CustomerService.save(cus);
           return Json(strCus, JsonRequestBehavior.AllowGet);
        }
        public ActionResult get()
        {
            CloudCode.Domain.Customer cus = new CloudCode.Domain.Customer();
            cus = this.CustomerService.Get("ALFKI");
            return Json(cus, JsonRequestBehavior.AllowGet);
        }
    }
}
