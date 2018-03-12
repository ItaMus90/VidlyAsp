using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        /// <summary>
        /// This Method return all customers
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var customers = GetCustomer();

            return View(customers);
        }

        /// <summary>
        /// This Method take from the request the id number
        /// And return the customer with this id 
        /// </summary>
        /// <param name="id">Id of customer</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        /// <summary>
        /// This method return IEnumerable of customers
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer {Id=1,Name="John Smith" },
                new Customer {Id=2,Name="Mary Williams" }
            };
        }
    }
}