using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DAL;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            string a = "";
            using (var context = new db_Entities())
            {
                var customers = context.Customer.ToList();
                
                foreach (var cust in customers)
                {
                  a+= cust.id + " " + cust.customer + " " + cust.address;
                }

            }
            ViewData["Message"] = "Your application description page."+ a;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
